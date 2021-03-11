using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using JetBrains.Annotations;

namespace Loki
{
    /// <summary>
    /// Interaction logic for Backups.xaml
    /// </summary>
    public partial class Backups
    {
        private readonly CharacterFile _currentFile;

        public Backups([NotNull] CharacterFile currentFile)
        {
            _currentFile = currentFile ?? throw new ArgumentNullException(nameof(currentFile));
            InitializeComponent();
        }

        private async void Backups_OnLoaded(object sender, RoutedEventArgs e)
        {
            try
            {
                Debug.Assert(_currentFile != null);

                var backupFiles = await Task.Run(() => Backup.GetBackupsFor(_currentFile));

                BackupFileList.ItemsSource = backupFiles.OrderByDescending(file => file.CreationTime)
                    .Select(file => new BackupFileInfo(file)).ToArray();
;
                if (backupFiles.Length > 0)
                {
                    StatusIndicator.Visibility = Visibility.Hidden;
                }
                else
                {
                    StatusIndicator.Content = "No backups";
                }
            }
            catch (Exception)
            {
                // TODO: Log exception
                StatusIndicator.Foreground = Brushes.Firebrick;
                StatusIndicator.Content = "Failed to load backups";
            }
        }

        private void RestoreCanExecute(object sender, CanExecuteRoutedEventArgs e) => e.CanExecute = BackupFileList?.SelectedItem != null;

        private void RestoreExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            try
            {

                if (!(BackupFileList.SelectedItem is BackupFileInfo backupInfo))
                    throw new InvalidOperationException("Cannot perform backup without selected backup info");

                // Create a backup first unless the user opted not to do so.
                if (BackupCheckbox.IsChecked == true) 
                    Backup.BackupCharacter(_currentFile);

                backupInfo.File.CopyTo(_currentFile.FilePath, true);

                MessageBox.Show("Character restored successfully!", "Restore complete", MessageBoxButton.OK,
                    MessageBoxImage.Information);
                DialogResult = true;
            }
            catch (Exception ex)
            {
                // TODO: Log errors from restoring.
                MessageBox.Show("Failed to restore backup!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            Close();
        }

        private void CloseExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
