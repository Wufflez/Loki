using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

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
                // drop from item picker
                if (this.DataContext is InventorySlot slot)
                {
                    var customData = new List<(string, string)>();
                    slot.Item = new Item(itemData.ItemName, itemData.MaxStack, (float)itemData.MaxDurability, slot.Position,
                        false, 1, 0, MainWindow.selectedPlayerProfile.PlayerId, MainWindow.selectedPlayerProfile.PlayerName, customData);
                }
            }
            else if (e.Data.GetData(typeof(InventorySlot)) is InventorySlot sourceSlot)
            {
                // drop from inventory slot
                if (this.DataContext is InventorySlot slot && sourceSlot != slot)
                {
                    slot.Item = sourceSlot.Item;
                    sourceSlot.Item = null;
                }
            }
        }

        private void BorderMouseMove(object sender, MouseEventArgs e)
        {
            if (sender is FrameworkElement element && e.LeftButton == MouseButtonState.Pressed)
            {
                if (element.DataContext is InventorySlot slot)
                {
                    var data = new DataObject(slot);
                    DragDrop.DoDragDrop(element, data, DragDropEffects.Move);
                }
            }
        }

        private void StackEditPreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is TextBox {IsKeyboardFocusWithin: false} txtStack) 
            {  
                txtStack.SelectAll();
                txtStack.Focus();
                e.Handled = true;
            }
        }

        private void StackEditKeyUp(object sender, KeyEventArgs e)
        {
            if (sender is TextBox textBox && (e.Key == Key.Enter || e.Key == Key.Return))
            {
                DependencyProperty prop = TextBox.TextProperty;
                BindingExpression binding = BindingOperations.GetBindingExpression(textBox, prop);
                binding?.UpdateSource();
                Keyboard.ClearFocus();
            }
        }
    }
}
