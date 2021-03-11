using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Loki
{
    public static class Backup
    {
        public static void BackupCharacter(CharacterFile source)
        {
            CharacterBackupDir.Create();
            int latestBackupNumber =
                CharacterBackupDir.EnumerateFiles()
                    .Select(f=>f.Name)
                    .Select(fileName => Regex.Match(fileName, @"^.*-backup-(\d+)\.fch$"))
                    .Where(match => match.Success)
                    .Select(match =>
                        int.Parse(match.Groups[1].Value))
                    .DefaultIfEmpty().Max();

            string charFilename = Path.GetFileNameWithoutExtension(source.FilePath);
            string backupFilename = $"{charFilename}-backup-{latestBackupNumber + 1}.fch";

            string backupFilePath = Path.Join(CharacterBackupDir.FullName, backupFilename);

            File.Copy(source.FilePath, backupFilePath);
        }

        public static DirectoryInfo CharacterBackupDir { get; } = GetBackupDir();

        private static DirectoryInfo GetBackupDir()
        {
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string backupDirPath = Path.Join(localAppData, "TwoThreeSix", "Loki", "CharacterBackup");
            return new DirectoryInfo(backupDirPath);
        }

        public static FileInfo[] GetBackupsFor(CharacterFile file)
        {
            var characterName = Path.GetFileNameWithoutExtension(file.FilePath);

            return CharacterBackupDir.EnumerateFiles("*.fch")
                .Select(f => (file: f, regex: Regex.Match(f.Name, @"^(.*)-backup-\d+\.fch")))
                .Where(pair => pair.regex.Success && pair.regex.Groups[1].Value == characterName)
                .Select(pair => pair.file)
                .ToArray();
        }
    }
}
