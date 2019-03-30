using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Sekiro_Save_Manager.Properties;

namespace Sekiro_Save_Manager.Forms
{
    public partial class MainForm : Form
    {
        private const string BackupIndexName = "profiles.xml";
        private readonly SaveBackupIndex _saveBackupIndex = new SaveBackupIndex();
        private bool _loadingSettings;


        public MainForm()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            TrayIcon.Icon = Icon;

            LoadSettings();
            CheckProfiles();
            LoadBackups();
        }

        private void LoadBackups()
        {
            if (!File.Exists(BackupIndexName))
            {
                return;
            }

            _saveBackupIndex.Load(BackupIndexName);

            lvBackups.Items.Clear();

            foreach (var backup in _saveBackupIndex)
            {
                DisplayBackup(backup);
            }

            var count = _saveBackupIndex.Count();

            if (count > 0)
            {
                Log($"Loaded {count} backup(s) from {BackupIndexName}");
            }
        }

        private void DisplayBackup(SaveBackup backup)
        {
            var lvi = new ListViewItem {Text = backup.Comment};
            lvi.SubItems.Add(backup.Saved.ToString());
            lvi.SubItems.Add(backup.BackupLocation);
            lvi.SubItems.Add(backup.SourceLocation);
            lvi.Tag = backup;
            lvBackups.Items.Add(lvi);
        }

        private string GetCurrentProfilePath()
        {
            if (Sekiro.IsProfilePathValid(Settings.Default.SaveFileLocation))
            {
                return Settings.Default.SaveFileLocation;
            }

            return null;
        }

        private void CheckProfiles()
        {
            var profileDirectoryMissing = true;

            if (Sekiro.IsProfilePathValid(Settings.Default.SaveFileLocation))
            {
                profileDirectoryMissing = false;
                Log($"Found profile directory at {Settings.Default.SaveFileLocation}");
            }

            else
            {
                Log("Game profile directory is invalid or not set");
            }

            if (profileDirectoryMissing)
            {
                Log("Automatically searching for profile directories at known locations...");

                var dirs = Sekiro.GetProfileDirectories();

                foreach (var dir in dirs)
                {
                    Log($"Found profile directory: {dir.FullName}");
                }

                Log("To select on of the above profile directories, navigate to the 'Options' tab");
            }
        }

        private void LoadSettings()
        {
            _loadingSettings = true;

            txtSaveLocation.Text = Settings.Default.SaveFileLocation;
            numBackupInterval.Value = Settings.Default.BackupInterval;
            BackupTimer.Interval = (int) (numBackupInterval.Value * 60000);
            chkAutoBackup.Checked = Settings.Default.AutomaticBackup;
            txtAutoBackupLocation.Text = Settings.Default.AutomaticBackupDirectory;
            chkHideRestoreWarning.Checked = Settings.Default.HideRestoreWarning;
            chkTrayMinimize.Checked = Settings.Default.TrayMinimize;

            if (Settings.Default.AutomaticBackup)
            {
                BackupTimer.Enabled = true;
                BackupTimer.Start();

                Log($"Starting automatic backups every {Settings.Default.BackupInterval} minutes");
            }

            btnBackup.Enabled = Sekiro.IsProfilePathValid(Settings.Default.SaveFileLocation);

            _loadingSettings = false;
        }

        private void SaveSettings()
        {
            if (_loadingSettings)
            {
                return;
            }

            Settings.Default.SaveFileLocation = txtSaveLocation.Text;
            Settings.Default.BackupInterval = (int) numBackupInterval.Value;
            Settings.Default.AutomaticBackup = chkAutoBackup.Checked;
            Settings.Default.AutomaticBackupDirectory = txtAutoBackupLocation.Text;
            Settings.Default.HideRestoreWarning = chkHideRestoreWarning.Checked;
            Settings.Default.TrayMinimize = chkTrayMinimize.Checked;
            Settings.Default.Save();
        }


        private void Log(string message)
        {
            var now = DateTime.Now;
            txtLog.AppendText($"[{now:T}] {message}{Environment.NewLine}");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void numBackupInterval_ValueChanged(object sender, EventArgs e)
        {
            BackupTimer.Interval = (int) (numBackupInterval.Value * 60000);
            SaveSettings();
        }

        private void btnProfileLocation_Click(object sender, EventArgs e)
        {
            var defaultPath = Sekiro.GetDefaultBaseDirectory();
            var selectedPath = Sekiro.IsProfilePathValid(Settings.Default.SaveFileLocation)
                ? Settings.Default.SaveFileLocation
                : defaultPath;

            using (var dialog = new FolderBrowserDialog
            {
                Description = "Select a game profile directory",
                SelectedPath = selectedPath
            })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtSaveLocation.Text = dialog.SelectedPath;
                    SaveSettings();
                    btnBackup.Enabled = Sekiro.IsProfilePathValid(dialog.SelectedPath);
                }
            }
        }

        private void chkAutoBackup_CheckedChanged(object sender, EventArgs e)
        {
            SaveSettings();
            BackupTimer.Enabled = chkAutoBackup.Checked;

            if (chkAutoBackup.Checked)
            {
                BackupTimer.Start();
            }
            else
            {
                BackupTimer.Stop();
            }
        }

        private void lvBackups_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRestore.Enabled = lvBackups.SelectedItems.Count > 0;
            btnEdit.Enabled = lvBackups.SelectedItems.Count > 0;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog
            {
                Title = "Select a location to save the backup",
                DefaultExt = Sekiro.SaveFileExtension,
                Filter = $"Sekiro Save File ({Sekiro.SaveFileExtension})|*{Sekiro.SaveFileExtension}"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    BackupSave(Path.Combine(GetCurrentProfilePath(), Sekiro.SaveFileName), sfd.FileName);
                }
            }
        }

        private void BackupSave(string source, string destination)
        {
            try
            {
                File.Copy(source, destination);
                Log($"Backed up {source} to {destination}");
            }

            catch (Exception ex)
            {
                Log(ex.Message);
            }

            var saveBackup = new SaveBackup(destination, source, "", DateTime.Now);
            _saveBackupIndex.Add(saveBackup);
            _saveBackupIndex.Save(BackupIndexName);
        }

        private void RestoreBackup(string source, string destination)
        {
            try
            {
                File.Copy(source, destination, true);
                Log($"Restored {source} to {destination}");
            }

            catch (Exception ex)
            {
                Log(ex.Message);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new AboutDialog())
            {
                dialog.ShowDialog();
            }
        }

        private void btnAutoBackupLocation_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog
            {
                Description = "Select a backup directory"
            })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtAutoBackupLocation.Text = dialog.SelectedPath;
                    SaveSettings();
                }
            }
        }

        private void BackupTimer_Tick(object sender, EventArgs e)
        {
            var validDirectory = Directory.Exists(Settings.Default.AutomaticBackupDirectory);

            if (!validDirectory)
            {
                Log("Invalid auto-backup directory setting");
                return;
            }

            var now = DateTime.Now;
            var gameSavePath = Path.Combine(GetCurrentProfilePath(), Sekiro.SaveFileName);
            var path = Path.Combine(Settings.Default.AutomaticBackupDirectory, $"Backup {now:yyyy-dd-M--HH-mm-ss}");

            BackupSave(gameSavePath, path);
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (!Settings.Default.HideRestoreWarning)
            {
                var result = MessageBox.Show("Make sure you are restoring a save to the same Steam profile as it was backed up from or corruption may occur.",
                    "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                if (result == DialogResult.Cancel)
                {
                    return;
                }
            }

            var selectedBackup = (SaveBackup) lvBackups.SelectedItems[0].Tag;
            var gameSavePath = Path.Combine(GetCurrentProfilePath(), Sekiro.SaveFileName);
            RestoreBackup(selectedBackup.BackupLocation, gameSavePath);
        }

        private void chkHideRestoreWarning_CheckedChanged(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                TrayIcon.Visible = true;
                Hide();
            }

            else if (FormWindowState.Normal == WindowState)
            {
                TrayIcon.Visible = false;
            }
        }

        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
            TrayIcon.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var selectedItem = lvBackups.SelectedItems[0];
            var selectedBackup = (SaveBackup) selectedItem.Tag;

            using (var dialog = new EditDialog(selectedBackup.Comment))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    selectedBackup.Comment = dialog.Value;
                    _saveBackupIndex.Save(BackupIndexName);
                    selectedItem.SubItems[colComment.Index].Text = dialog.Value;
                }
            }
        }
    }
}