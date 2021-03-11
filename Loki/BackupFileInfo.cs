using System;
using System.IO;
using JetBrains.Annotations;

namespace Loki
{
    public class BackupFileInfo
    {
        public string BackupDate { get; }
        public string BackupTimeOfDay { get; }
        public FileInfo File { get; }
        public string Name { get; }

        public BackupFileInfo([NotNull] FileInfo backupFile)
        {
            File = backupFile ?? throw new ArgumentNullException(nameof(backupFile));
            Name = backupFile.Name;
            BackupDate = "Sometime";
            BackupTimeOfDay = File.CreationTime.ToString("HH:mm");
            if (File.CreationTime.Date == DateTime.Now.Date)
            {
                BackupDate = "Today";
            }
            else if((DateTime.Now.Date - File.CreationTime.Date).Days <=7)
            {
                BackupDate = File.CreationTime.Date.ToString("dddd");
            }
            else
            {
                BackupDate = File.CreationTime.Date.ToString("d");
            }
        }
    }
}
