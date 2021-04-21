using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using JetBrains.Annotations;

namespace Loki
{
    public class InventorySlot: INotifyPropertyChanged
    {
        private Item _item;

        public InventorySlot(Vector2i position)
        {
            Position = position;
            RepairItem = new RelayCommand(RepairExecuted, RepairCanExecute);
            DeleteItem = new RelayCommand(_ => Item = null);
            QualityUp = new RelayCommand(QualityUpExecuted, QualityUpCanExecute);
            QualityDown = new RelayCommand(QualityDownExecuted, QualityDownCanExecute);
            ToggleCrafter = new RelayCommand(ToggleCrafterExecuted);
            if (position.Y == 0) QuickSlotNumber = position.X + 1;
        }

        public Vector2i Position { get; }
        public int? QuickSlotNumber { get; }
        public bool IsEmpty => Item == null;

        public RelayCommand DeleteItem { get; }

        public RelayCommand RepairItem { get; }

        public RelayCommand QualityUp { get; }

        public RelayCommand QualityDown { get; }

        public RelayCommand ToggleCrafter { get; }

        private bool QualityUpCanExecute(object _)
        {
            return Item != null && Item.HasQualityLevels && Item.Quality < Item.SharedData.MaxQuality;
        }

        private void QualityUpExecuted(object _)
        {
            Item.Quality = Item.Quality + 1;
            Item.MaxDurability = 1; // Force-recalculating max durability
            RepairExecuted(this);
            QualityUp.OnCanExecuteChanged();
            QualityDown.OnCanExecuteChanged();
        }

        private bool QualityDownCanExecute(object _)
        {
            return Item != null && Item.HasQualityLevels && Item.Quality > 1;
        }

        private void QualityDownExecuted(object _)
        {
            Item.Quality = Item.Quality - 1;
            Item.MaxDurability = 1; // Force-recalculating max durability
            RepairExecuted(this);
            QualityUp.OnCanExecuteChanged();
            QualityDown.OnCanExecuteChanged();
        }

        private bool RepairCanExecute(object _)
        {
            return Item != null && Item.Durability < Item.MaxDurability;
        }

        private void RepairExecuted(object _)
        {
            Item.Durability = (float) Item.MaxDurability;
            RepairItem.OnCanExecuteChanged();
        }

        private void ToggleCrafterExecuted(object _)
        {
            Item.CrafterName = Item.CrafterId == 0 ? MainWindow.selectedPlayerProfile.PlayerName : "";
            Item.CrafterId = Item.CrafterId == 0 ? MainWindow.selectedPlayerProfile.PlayerId : 0;
        }

        public Item Item
        {
            get => _item;
            set
            {
                if (Equals(value, _item)) return;
                _item = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(IsEmpty));
                QualityUp.OnCanExecuteChanged();
                QualityDown.OnCanExecuteChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
