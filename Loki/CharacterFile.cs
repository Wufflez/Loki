using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace Loki
{
    public class CharacterFile: INotifyPropertyChanged
    {
        private string _playerName;
        private string _filePath;

        /// <summary>
        /// Name of player as read from the character profile inside the file.
        /// </summary>
        public string PlayerName
        {
            get => _playerName;
            set
            {
                if (value == _playerName) return;
                _playerName = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// ID for the player as extracted from within the file.
        /// </summary>
        public long PlayerId { get; set; }

        public string FilePath
        {
            get => _filePath;
            set
            {
                if (value == _filePath) return;
                _filePath = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Set if failed to load from disk e.g. incompatible format etc.
        /// </summary>
        public bool Invalid { get; set; }

        public static CharacterFile[] LoadCharacterFiles()
        {
            string localLowPath = Shell32.GetKnownFolderPath(Shell32.LocalLowId);
            string charactersPath = Path.Join(localLowPath, @"IronGate\Valheim\characters_local");
            return Directory.EnumerateFiles(charactersPath, "*.fch").Select(FromPath).ToArray();
        }

        public static CharacterFile FromPath(string characterFilePath)
        {
            string name = Path.GetFileNameWithoutExtension(characterFilePath);

            try
            {
                using var fileStream = File.OpenRead(characterFilePath);
                PlayerProfile p = PlayerProfile.Read(fileStream);

                return new CharacterFile
                    {FilePath = characterFilePath, PlayerName = p.PlayerName, PlayerId = p.PlayerId};
            }
            catch (Exception ex)
            {
                // TODO: Log error.
                return new CharacterFile
                {
                    FilePath = characterFilePath, PlayerName = "<unknown>", Invalid = true,
                };
            }
        }

        public override string ToString() => $"{PlayerName} [{FilePath}]";
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
