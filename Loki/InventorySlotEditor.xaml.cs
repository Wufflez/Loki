using System;
using System.Diagnostics;
using System.Windows;

namespace Loki
{
    /// <summary>
    /// Interaction logic for InventorySlotEditor.xaml
    /// </summary>
    public partial class InventorySlotEditor
    {
        public InventorySlotEditor()
        {
            InitializeComponent();
        }

        private void BorderDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(typeof(SharedItemData)) is SharedItemData itemData)
            {
                if (this.DataContext is InventorySlot slot)
                {
                    slot.Item = new Item(itemData.ItemName, itemData.MaxStack, (float)itemData.MaxDurability, slot.Position,
                        false, 1, 0, 0, "Loki");
                }
            }
        }
    }
}
