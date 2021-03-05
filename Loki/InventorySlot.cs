using System.ComponentModel;
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
            if (position.Y == 0) QuickSlotNumber = position.X + 1;
        }

        public Vector2i Position { get; }
        public int? QuickSlotNumber { get; }
        public bool IsEmpty => Item == null;

        public ICommand DeleteItem => new RelayCommand(_ => Item = null);

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
