using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
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

        private async void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            Debug.Assert(version != null, nameof(version) + " != null");
            Title = $"{Title} v{version.Major}.{version.Minor}";

            try
            {
                CharacterFiles = await Task.Run(CharacterFile.LoadCharacterFiles);
                SelectedCharacterFile = CharacterFiles.FirstOrDefault();
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
                    if (makeBackup) 
                        Backup.BackupCharacter(character);

                    using var fileStream = File.Create(character.FilePath);
                    profile.Write(fileStream);
                });
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
            }
        }

        public CharacterFile SelectedCharacterFile
        {
            get => (CharacterFile) GetValue(SelectedCharacterFileProperty);
            set => SetValue(SelectedCharacterFileProperty, value);
        }

        private void CanSaveOrRevertExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = SelectedCharacterFile != null;
        }

        private void RevertExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            LoadProfile(SelectedCharacterFile);
        }

        private void SaveExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            SaveProfile(SelectedCharacterFile);
        }

        private void ItemPickerItemMouseMove(object sender, MouseEventArgs e)
        {
            if(sender is TextBlock txt && e.LeftButton == MouseButtonState.Pressed)
            {
                if (txt.DataContext is InventoryListItem item)
                {
                    var data = new DataObject(item.ItemData);
                    DragDrop.DoDragDrop(txt, data, DragDropEffects.Copy);
                }
            }
        }
    }
}
