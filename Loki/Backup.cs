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
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string backupDirPath = Path.Join(localAppData, "TwoThreeSix", "Loki", "CharacterBackup");
            Directory.CreateDirectory(backupDirPath);

            int latestBackupNumber =
                Directory.EnumerateFiles(backupDirPath)
                    .Select(Path.GetFileName)
                    .Select(fileName => Regex.Match(fileName, @"^.*-backup-(\d+)\.fch$"))
                    .Where(match => match.Success)
                    .Select(match =>
                        int.Parse(match.Groups[1].Value))
                    .DefaultIfEmpty().Max();

            string charFilename = Path.GetFileNameWithoutExtension(source.FilePath);
            string backupFilename = $"{charFilename}-backup-{latestBackupNumber + 1}.fch";

            string backupFilePath = Path.Join(backupDirPath, backupFilename);

            File.Copy(source.FilePath, backupFilePath);
        }
    }
}
