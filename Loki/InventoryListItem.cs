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

        public static string ItemsFilter { get; set; }

        public static List<InventoryListItem> AllItems = ItemDb.AllItems
            .Select(CreateListItem).ToList();

        private static InventoryListItem CreateListItem(SharedItemData itemData)
        {

            string displayName = itemData.DisplayName;

            if (string.IsNullOrWhiteSpace(displayName))
                displayName = $"<{itemData.ItemName}>";

            string category = itemData.ItemType switch
            {
                ItemType.None => Loki.Properties.Resources.Unknown,
                ItemType.Material => Loki.Properties.Resources.Material,
                ItemType.Consumable => Loki.Properties.Resources.Consumable,
                ItemType.OneHandedWeapon => Loki.Properties.Resources.One_Handed_Weapon,
                ItemType.Bow => Loki.Properties.Resources.Bow,
                ItemType.Shield => Loki.Properties.Resources.Shield,
                ItemType.Helmet => Loki.Properties.Resources.Helmet,
                ItemType.Chest => Loki.Properties.Resources.Chest,
                ItemType.Ammo => Loki.Properties.Resources.Ammo,
                ItemType.Customization => Loki.Properties.Resources.Customisation,
                ItemType.Legs => Loki.Properties.Resources.Legs,
                ItemType.Hands => Loki.Properties.Resources.Hands,
                ItemType.Trophy => Loki.Properties.Resources.Trophy,
                ItemType.TwoHandedWeapon => Loki.Properties.Resources.Trophy,
                ItemType.Torch => Loki.Properties.Resources.Torch,
                ItemType.Misc => Loki.Properties.Resources.Miscellaneous,
                ItemType.Shoulder => Loki.Properties.Resources.Shoulder,
                ItemType.Utility => Loki.Properties.Resources.Utility,
                ItemType.Tool => Loki.Properties.Resources.Tool,
                ItemType.AttachAtgeir => Loki.Properties.Resources.Attach_Atgeir,
                _ => Loki.Properties.Resources.Unknown,
            };
            return new InventoryListItem(displayName, category, itemData);
        }

        public static bool FilterListItem(InventoryListItem item)
        {
            if (string.IsNullOrWhiteSpace(ItemsFilter))
            {
                return true;
            }
            else
            {
                string[] filterItems = ItemsFilter.ToLower().Split(new char[] { ',' });

                foreach(string filterItem in filterItems)
                {
                    if(item.Name.ToLower().Contains(filterItem))
                    {
                        return true;
                    }
                }

                return false;
            }
        }

        public static bool FilterListItemObject(object itemObject)
        {
            return FilterListItem(itemObject as InventoryListItem);
        }
    }
}
