using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace Loki
{
    public class Item: INotifyPropertyChanged
    {
        private int _stack;
        private float _durability;
        public string Name { get; }

        public int Stack
        {
            get => _stack;
            set
            {
                if (value == _stack) return;
                if (SharedData != null)
                {
                    if (value > SharedData.MaxStack)
                        value = SharedData.MaxStack;
                }
                if (value < 0) value = 0;
                _stack = value;
                OnPropertyChanged();
            }
        }

        public float Durability
        {
            get => _durability;
            set
            {
                if (value.Equals(_durability)) return;
                _durability = value;
                OnPropertyChanged();
            }
        }

        public Vector2i Pos { get; }
        public bool Equiped { get; }
        public int Quality { get; }
        public int Variant { get; }
        public long CrafterId { get; }
        public string CrafterName { get; }

        public bool HasCrafterTag => CrafterId != 0;

        public double MaxDurability =>
            SharedData.MaxDurability + Math.Max(0, Quality - 1) * SharedData.DurabilityPerLevel;

        public Item(string name, int stack, float durability, Vector2i pos, bool equiped, int quality, int variant, long crafterId, string crafterName)
        {
            Name = name;
            Stack = stack;
            Durability = durability;
            Pos = pos;
            Equiped = equiped;
            Quality = quality;
            Variant = variant;
            CrafterId = crafterId;
            CrafterName = crafterName;
            SharedData = ItemDb.TryFindSharedData(name);

            if (SharedData == null)
            {
                Unrecognised = true;
            }

        }
        
        public SharedItemData SharedData { get; }

        public bool HasQualityLevels => SharedData?.MaxQuality > 1;

        public bool Unrecognised { get; }

        public string StackText => $"{Stack} / {SharedData.MaxStack}";

        public bool CanStack => SharedData.MaxStack > 1;

        public override string ToString() => $"{Name} [{Stack}]";
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
