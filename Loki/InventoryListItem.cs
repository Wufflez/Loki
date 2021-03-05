using System;
using System.Collections.Generic;
using System.Linq;

namespace Loki
{
    public class InventoryListItem
    {
        public string Name { get; }
        public string Category { get; }
        public SharedItemData ItemData { get; }

        public InventoryListItem(string name, string category, SharedItemData itemData)
        {
            Name = name;
            Category = category;
            ItemData = itemData;
        }

        public static List<InventoryListItem> AllItems = ItemDb.AllItems
            .Select(CreateListItem).ToList();

        private static InventoryListItem CreateListItem(SharedItemData itemData)
        {

            string displayName = itemData.DisplayName;

            if (string.IsNullOrWhiteSpace(displayName))
                displayName = $"<{itemData.ItemName}>";

            string category = itemData.ItemType switch
            {
                ItemType.None => "Unknown",
                ItemType.Material => "Material",
                ItemType.Consumable => "Consumable",
                ItemType.OneHandedWeapon => "One Handed Weapon",
                ItemType.Bow => "Bow",
                ItemType.Shield => "Shield",
                ItemType.Helmet => "Helmet",
                ItemType.Chest => "Chest",
                ItemType.Ammo => "Ammo",
                ItemType.Customization => "Customisation",
                ItemType.Legs => "Legs",
                ItemType.Hands => "Hands",
                ItemType.Trophy => "Trophy",
                ItemType.TwoHandedWeapon => "Two Handed Weapon",
                ItemType.Torch => "Torch",
                ItemType.Misc => "Miscellaneous",
                ItemType.Shoulder => "Shoulder",
                ItemType.Utility => "Utility",
                ItemType.Tool => "Tool",
                ItemType.AttachAtgeir => "Attach Atgeir",
                _ => "Unknown",
            };
            return new InventoryListItem(displayName, category, itemData);
        }
    }
}
