using System.Globalization;
using System.IO;
using System.Linq;

namespace Loki
{
    public class CharacterFile
    {
        public string Name { get; set; }
        public string FilePath { get; set; }

        public static CharacterFile[] LoadCharacterFiles()
        {
            string localLowPath = Shell32.GetKnownFolderPath(Shell32.LocalLowId);
            string charactersPath = Path.Join(localLowPath, @"IronGate\Valheim\characters");
            return Directory.EnumerateFiles(charactersPath, "*.fch").Select(FromPath).ToArray();
        }

        public static CharacterFile FromPath(string characterFilePath)
        {
            string name = Path.GetFileNameWithoutExtension(characterFilePath);
            name = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(name.ToLower());
            return new CharacterFile
                {FilePath = characterFilePath, Name = name};
        }

        public override string ToString() => $"{Name} [{FilePath}]";
    }
}
