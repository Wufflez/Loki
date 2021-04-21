using System;
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
                if (this.DataContext is InventorySlot slot)
                {
                    slot.Item = new Item(itemData.ItemName, itemData.MaxStack, (float)itemData.MaxDurability, slot.Position,
                        false, 1, 0, 0, ""); ;
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
