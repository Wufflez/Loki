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
            if (position.Y == 0) QuickSlotNumber = position.X + 1;
        }

        public Vector2i Position { get; }
        public int? QuickSlotNumber { get; }
        public bool IsEmpty => Item == null;

        public RelayCommand DeleteItem { get; }

        public RelayCommand RepairItem { get; }

        private bool RepairCanExecute(object _)
        {
            return Item != null && Item.Durability < Item.MaxDurability;
        }

        private void RepairExecuted(object _)
        {
            Item.Durability = (float) Item.MaxDurability;
            RepairItem.OnCanExecuteChanged();
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
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
