using System;

namespace Sekiro_Save_Manager
{
    internal class SaveBackup
    {
        public SaveBackup(string backupLocation, string sourceLocation, string comment, DateTime saved)
        {
            BackupLocation = backupLocation;
            SourceLocation = sourceLocation;
            Comment = comment;
            Saved = saved;
        }

        public string BackupLocation { get; }

        public string SourceLocation { get; }

        public string Comment { get; set; }
        public DateTime Saved { get; }
    }
}