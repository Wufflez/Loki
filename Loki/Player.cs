using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Media;
using JetBrains.Annotations;

namespace Loki
{
    public class Player: INotifyPropertyChanged
    {
        private const int Version = 25;
        private const int InventoryVersion = 103;
        private const int SkillVersion = 2;

        private float _maxHealth;
        private float _curHealth;
        private float _maxStamina;
        private bool _firstSpawn;
        private float _timeSinceDeath;
        private string _guardianPower;
        private float _guardianPowerCooldown;
        private List<Item> _inventory = new List<Item>();
        private readonly List<string> _knownRecipes = new List<string>();
        private readonly List<(string, int)> _knownStations = new List<(string, int)>();
        private readonly List<string> _knownMaterials = new List<string>();
        private List<string> _shownTutorials = new List<string>();
        private readonly List<string> _uniques = new List<string>();
        private readonly List<string> _trophies = new List<string>();
        private readonly List<Biome> _knownBiomes = new List<Biome>();
        private readonly List<(string, string)> _knownTexts = new List<(string, string)>();
        private string _beard;
        private string _hair;
        private Vector3 _skinColour;
        private Vector3 _hairColour;

        private int _modelIndex;
        private readonly List<Food> _food = new List<Food>();
        public ObservableCollection<Skill> Skills { get; } = new ObservableCollection<Skill>();

        public Inventory Inventory { get; } = new Inventory(8, 4);

        public Beard Beard
        {
            get => Beard.FromCode(_beard);
            set => _beard = value.Code;
        }

        public Hair Hair
        {
            get => Hair.FromCode(_hair);
            set => _hair = value.Code;
        }

        public Model Model
        {
            get => Model.FromIndex(_modelIndex);
            set => _modelIndex = value.Index;
        }

        public Color HairColour
        {
            get => Color.FromScRgb(1.0f, _hairColour.X, _hairColour.Y, _hairColour.Z);
            set
            {
                if (value.Equals(HairColour)) return;
                _hairColour = new Vector3(value.ScR, value.ScG, value.ScB);
                OnPropertyChanged();
                OnPropertyChanged(nameof(RawHairRgb));
            }
        }

        public Color SkinColour
        {
            get => Color.FromScRgb(1.0f, _skinColour.X, _skinColour.Y, _skinColour.Z);
            set
            {
                if (value.Equals(SkinColour)) return;
                _skinColour = new Vector3(value.ScR, value.ScG, value.ScB);
                OnPropertyChanged();
                OnPropertyChanged(nameof(SkinGlow));
                OnPropertyChanged(nameof(RawSkinRgb));
            }
        }

        public float SkinGlow
        {
            get => _skinColour.Length();
            set
            {
                if (value.Equals(SkinGlow)) return;
                _skinColour.Normalise(value);
                OnPropertyChanged();
                OnPropertyChanged(nameof(SkinColour));
                OnPropertyChanged(nameof(RawSkinRgb));
            }
        }

        public string RawSkinRgb => $"RGB ( {_skinColour.X:F3}, {_skinColour.Y:F3}, {_skinColour.Z:F3})";
        public string RawHairRgb => $"RGB ( {_hairColour.X:F3}, {_hairColour.Y:F3}, {_hairColour.Z:F3})";

        private Player()
        {
        }

        public static Player Read(Stream input, bool leaveOpen = false)
        {
            using var reader = new BinaryReader(input, Encoding.UTF8, leaveOpen);

            int expectedPlayerDataLength = reader.ReadInt32();
            var playerDataStartPos = input.Position;

            var version = reader.ReadInt32();

            var player = new Player
            {
                _maxHealth = version >= 7 ? reader.ReadSingle() : 25f,
                _curHealth = reader.ReadSingle(),
                _maxStamina = version >= 10 ? reader.ReadSingle() : 100f,
                _firstSpawn = version < 8 || reader.ReadBoolean(),
                _timeSinceDeath = version >= 20 ? reader.ReadSingle() : 999999f,
                _guardianPower = version >= 23 ? reader.ReadString() : string.Empty,
                _guardianPowerCooldown = version >= 24 ? reader.ReadSingle() : default,
                _shownTutorials = new List<string>(),
            };

            if (version == 2)
                input.Position += 12; // Skip over 'ZDOID', long + uint 

            player._inventory = ReadInventory(input, true);
            player.UpdateInventorySlots();

            player._knownRecipes.AddRange(reader.ReadStrings(reader.ReadInt32()));

            if (version < 15)
            {
                int count = reader.ReadInt32();
                while (count-- > 0) reader.ReadString();
            }
            else
            {
                int count = reader.ReadInt32();
                while (count-- > 0)
                    player._knownStations.Add((reader.ReadString(), reader.ReadInt32()));
            }

            player._knownMaterials.AddRange(reader.ReadStrings(reader.ReadInt32()));

            if (version < 19 || version >= 21)
                player._shownTutorials.AddRange(reader.ReadStrings(reader.ReadInt32()));

            if (version >= 6)
                player._uniques.AddRange(reader.ReadStrings(reader.ReadInt32()));

            if (version >= 9)
                player._trophies.AddRange(reader.ReadStrings(reader.ReadInt32()));

            if (version >= 18) 
                player._knownBiomes.AddRange(reader.ReadInt32s(reader.ReadInt32()).Cast<Biome>());

            if (version >= 22)
            {
                int count = reader.ReadInt32();
                while(count -- >0)
                    player._knownTexts.Add((reader.ReadString(), reader.ReadString()));
            }

            if (version >= 4)
            {
                player._beard = reader.ReadString();
                player._hair = reader.ReadString();
            }

            if (version >= 5)
            {
                player._skinColour = reader.ReadVector3();
                player._hairColour = reader.ReadVector3();
            }

            player._modelIndex = version >= 11 ? reader.ReadInt32() : default;

            if (version >= 12)
            {
                int foodCount = reader.ReadInt32();
                while (foodCount-- > 0)
                {
                    if (version >= 14)
                    {
                        string name = reader.ReadString();
                        float time = default;
                        float health = default;
                        float stamina = default;
                        if(version >= 25)
                        {
                            time = reader.ReadSingle();
                        }
                        else
                        {
                            health = reader.ReadSingle();
                            stamina = version >= 16 ? reader.ReadSingle() : default;
                        }
                        player._food.Add(new Food(name, time, health, stamina));
                    }
                    else
                    {
                        // Skip legacy data.
                        reader.ReadString();
                        input.Position += version >= 13 ? 24 : 28;
                    }
                }
            }

            if (version >= 17)
            {
                int skillVersion = reader.ReadInt32();
                int skillCount = reader.ReadInt32();
                while (skillCount-- > 0)
                {
                    SkillType type = (SkillType) reader.ReadInt32();
                    float level = reader.ReadSingle();
                    float accumulator = skillVersion >= 2 ? reader.ReadSingle() : default;
                    player.Skills.Add(new Skill(type, level, accumulator));
                }
            }

            // Sanity check - compare with player data length provided.
            long amountRead = input.Position - playerDataStartPos;
            if (amountRead != expectedPlayerDataLength)
            {
                var message =
                    "Amount of data read for player field did not match length header. " +
                    $"Data read = {amountRead}B, Length in header = {expectedPlayerDataLength}B";

                var result = MessageBox.Show(
                    $"{message}" + Environment.NewLine + Environment.NewLine +
                    "Do you want to continue loading? (Not Recommended)",
                    $"Error reading {nameof(Player)}",
                    MessageBoxButton.YesNo, MessageBoxImage.Warning);

                if (result == MessageBoxResult.No)
                {
                    throw new InvalidDataException(message);
                }
            }

            return player;
        }

        private void UpdateInventorySlots()
        {
            foreach (var item in _inventory)
            {
                var slot = Inventory.GetSlotAt(item.Pos);
                if (slot != null)
                    slot.Item = item;
            }
        }

        public void Write(Stream output, bool leaveOpen = false)
        {
            using var writer = new BinaryWriter(output, Encoding.UTF8, leaveOpen);
            
            writer.Write(Version);
            writer.Write(_maxHealth);
            writer.Write(_curHealth);
            writer.Write(_maxStamina);
            writer.Write(_firstSpawn);
            writer.Write(_timeSinceDeath);
            writer.Write(_guardianPower);
            writer.Write(_guardianPowerCooldown);

            writer.Write(InventoryVersion);
            // Rebuild Inventory (TODO: Review)
            _inventory = Inventory.Slots.Select(slot => slot.Item).Where(item => item != null).ToList();
            writer.Write(_inventory.Count);
            foreach (var item in _inventory)
            {
                writer.Write(item.Name);
                writer.Write(item.Stack);
                writer.Write(item.Durability);
                writer.Write(item.Pos);
                writer.Write(item.Equiped);
                writer.Write(item.Quality);
                writer.Write(item.Variant);
                writer.Write(item.CrafterId);
                writer.Write(item.CrafterName);
            }

            writer.WriteCountItems(_knownRecipes);
            writer.Write(_knownStations.Count);
            foreach ((string name, int num) in _knownStations)
            {
                writer.Write(name);
                writer.Write(num);
            }
            writer.WriteCountItems(_knownMaterials);
            writer.WriteCountItems(_shownTutorials);
            writer.WriteCountItems(_uniques);
            writer.WriteCountItems(_trophies);
            writer.WriteCountItems(_knownBiomes.Cast<int>().ToList());
            writer.Write(_knownTexts.Count);
            foreach ((string key, string value) in _knownTexts)
            {
                writer.Write(key);
                writer.Write(value);
            }

            writer.Write(_beard);
            writer.Write(_hair);
            writer.Write(_skinColour);
            writer.Write(_hairColour);
            writer.Write(_modelIndex);
            writer.Write(_food.Count);
            foreach (var food in _food)
            {
                writer.Write(food.Name);
                writer.Write(food.Time);
            }

            writer.Write(SkillVersion);
            writer.Write(Skills.Count);
            foreach (var skill in Skills)
            {
                writer.Write((int)skill.Type);
                writer.Write(skill.Level);
                writer.Write(skill.Accumulator);
            }
        }

        private static List<Item> ReadInventory(Stream input, bool leaveOpen = false)
        {
            using var reader = new BinaryReader(input, Encoding.UTF8, leaveOpen);
            var version = reader.ReadInt32();
            var itemCount = reader.ReadInt32();
            var items = new List<Item>(itemCount);
            for (int i = 0; i < itemCount; i++)
            {
                string name = reader.ReadString();
                int stack = reader.ReadInt32();
                float durability = reader.ReadSingle();
                Vector2i pos = reader.ReadVector2i();
                bool equiped = reader.ReadBoolean();
                int quality = version >= 101 ? reader.ReadInt32() : 1;
                int variant = version >= 102 ? reader.ReadInt32() : 0;
                (long crafterId, string crafterName) =
                    version >= 103 ? (reader.ReadInt64(), reader.ReadString()) : (0, string.Empty);
                Debug.WriteLine($"ReadInv: Item={name}, Position={pos}");
                if(name != "") items.Add(new Item(name, stack, durability, pos, equiped, quality, variant, crafterId, crafterName));
            }
            return items;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) => 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
