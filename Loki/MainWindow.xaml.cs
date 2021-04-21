using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Media.Media3D;

namespace Loki
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static PlayerProfile selectedPlayerProfile = null;

        private async void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            Debug.Assert(version != null, nameof(version) + " != null");
            Title = $"{Title} v{version.Major}.{version.Minor}";

            try
            {
                CharacterFiles = await Task.Run(CharacterFile.LoadCharacterFiles);
                SelectedCharacterFile = CharacterFiles.FirstOrDefault();
                CommandManager.InvalidateRequerySuggested();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public static readonly DependencyProperty ProfileProperty = DependencyProperty.Register(
            "Profile", typeof(PlayerProfile), typeof(MainWindow), new PropertyMetadata(default(PlayerProfile)));

        public PlayerProfile Profile
        {
            get => (PlayerProfile) GetValue(ProfileProperty);
            set => SetValue(ProfileProperty, value);
        }

        public static readonly DependencyProperty CharacterFilesProperty = DependencyProperty.Register(
            "CharacterFiles", typeof(CharacterFile[]), typeof(MainWindow), new PropertyMetadata(default(CharacterFile[])));

        public CharacterFile[] CharacterFiles
        {
            get => (CharacterFile[]) GetValue(CharacterFilesProperty);
            set => SetValue(CharacterFilesProperty, value);
        }

        public static readonly DependencyProperty SelectedCharacterFileProperty = DependencyProperty.Register(
            "SelectedCharacterFile", typeof(CharacterFile), typeof(MainWindow), new PropertyMetadata(default(CharacterFile), SelectedCharacterChanged));

        public static readonly DependencyProperty CreateBackupProperty = DependencyProperty.Register(
            "CreateBackup", typeof(bool), typeof(MainWindow), new PropertyMetadata(true));

        public bool CreateBackup
        {
            get => (bool) GetValue(CreateBackupProperty);
            set => SetValue(CreateBackupProperty, value);
        }

        public static readonly DependencyProperty SaveInProgressProperty = DependencyProperty.Register(
            "SaveInProgress", typeof(bool), typeof(MainWindow), new PropertyMetadata(default(bool)));

        /// <summary>
        /// Gets or sets a value that indicates whether or not a Save is currently in progress.
        /// </summary>
        public bool SaveInProgress
        {
            get => (bool) GetValue(SaveInProgressProperty);
            set => SetValue(SaveInProgressProperty, value);
        }


        private static void SelectedCharacterChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var window = (MainWindow) d;
            var characterFile = (CharacterFile) e.NewValue;
            if (characterFile != null)
            {
                window.LoadProfile(characterFile);
            }
            else
            {
                window.Profile = null;
            }
        }

        public async void LoadProfile(CharacterFile character)
        {
            try
            {
                Profile = await Task.Run(() => PlayerProfile.Read(File.OpenRead(character.FilePath)));
                character.PlayerName = Profile.PlayerName;
                selectedPlayerProfile = Profile;
            }
            catch (Exception ex)
            {
                Profile = null;
                MessageBox.Show("Error loading from character file: " + ex.Message, "Error", MessageBoxButton.OK,
                    MessageBoxImage.Error);
                // TODO Log
            }
        }

        public async void SaveProfile(CharacterFile character)
        {
            try
            {
                if (Profile == null) throw new InvalidOperationException("No profile loaded, cannot save");

                // Capture values of dependency properties for background thread.
                var profile = Profile;
                bool makeBackup = CreateBackup;

                SaveInProgress = true;
                Cursor = Cursors.Wait;

                await Task.Run(() =>
                {
                    
                    // Re-Tag any items with new character name if needed.
                    foreach (var slot in profile.Player.Inventory.Slots)
                    {
                        if (slot.Item != null && slot.Item.CrafterId == profile.PlayerId)
                        {
                            slot.Item.CrafterName = profile.PlayerName;
                        }
                    }
                    
                    if (makeBackup) 
                        Backup.BackupCharacter(character);

                    using var fileStream = File.Create(character.FilePath);

                    profile.Write(fileStream);
                });

                character.PlayerName = Profile.PlayerName;
                ShowNotification("Character Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving to character file: " + ex.Message, "Error", MessageBoxButton.OK,
                    MessageBoxImage.Error);
                // TODO log error
            }
            finally
            {
                SaveInProgress = false;
                Cursor = null;
                CommandManager.InvalidateRequerySuggested();
            }
        }

        public CharacterFile SelectedCharacterFile
        {
            get => (CharacterFile) GetValue(SelectedCharacterFileProperty);
            set => SetValue(SelectedCharacterFileProperty, value);
        }

        private void CanSaveOrRevertExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = SelectedCharacterFile != null && !SelectedCharacterFile.Invalid && !SaveInProgress;
        }

        private void RevertExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            LoadProfile(SelectedCharacterFile);
            ShowNotification("Character Reverted");
        }

        private void SaveExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            SaveProfile(SelectedCharacterFile);
        }

        private void ItemPickerItemMouseMove(object sender, MouseEventArgs e)
        {
            if(sender is FrameworkElement element && e.LeftButton == MouseButtonState.Pressed)
            {
                if (element.DataContext is InventoryListItem item)
                {
                    var data = new DataObject(item.ItemData);
                    DragDrop.DoDragDrop(element, data, DragDropEffects.Copy);
                }
            }
        }

        private void CanRestoreExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = SelectedCharacterFile != null;
        }

        private void RestoreExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            // Select backup to restore from.
            var restoreWindow = new Backups(SelectedCharacterFile) {Owner = this};
            restoreWindow.ShowDialog();

            if (restoreWindow.DialogResult == true)
            {
                // Reload profile, as user has restored it from another file.
                LoadProfile(SelectedCharacterFile);
            }
        }

        private async Task ShowNotification(string notifyText)
        {
            NotifyText.Text = notifyText;
            NotificationBorder.Opacity = 1;
            NotificationBorder.Visibility = Visibility.Visible;
            
            await Task.Delay(2000);
            var opacityAnim = new DoubleAnimation(1.0, 0.0, new Duration(TimeSpan.FromSeconds(0.3)));
            opacityAnim.FillBehavior = FillBehavior.Stop;
            opacityAnim.Completed += (sender, args) => NotificationBorder.Visibility = Visibility.Hidden;
            NotificationBorder.BeginAnimation(OpacityProperty, opacityAnim);
            
        }
    }
}
