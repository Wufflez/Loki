using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using Loki;

namespace Loki
{
    public enum ItemType
    {
        None = 0,
        Material = 1,
        Consumable = 2,
        OneHandedWeapon = 3,
        Bow = 4,
        Shield = 5,
        Helmet = 6,
        Chest = 7,
        Ammo = 9,
        Customization = 10,
        Legs = 11,
        Hands = 12,
        Trophy = 13,
        TwoHandedWeapon = 14,
        Torch = 15,
        Misc = 16,
        Shoulder = 17,
        Utility = 18,
        Tool = 19,
        AttachAtgeir = 20,
    }

    public class SharedItemData
    {
        public string ItemName { get; set; }
        public bool IsTeleportable { get; set; }
        public bool UsesDurability { get; set; }
        public double MaxDurability { get; set; }
        public double DurabilityPerLevel { get; set; }
        public int MaxStack { get; set; }
        public string DisplayName { get; set; }
        public int MaxQuality { get; set; }
        public ItemType ItemType {get;set;}
    }

    public static class ItemDb
    {
        private static readonly Dictionary<string, SharedItemData> ItemData = ReadItemDataFromCsvFile("SharedItemData.csv");

        public static SharedItemData TryFindSharedData(string itemName) => 
            ItemData.TryGetValue(itemName, out SharedItemData sharedData) ? sharedData : null;

        public static IEnumerable<SharedItemData> AllItems => ItemData.Values;

        private static Dictionary<string, SharedItemData> ReadItemDataFromCsvFile(string fileName)
        {
            try
            {
                using var reader = new StreamReader(fileName);
                using var csv = new CsvHelper.CsvReader(reader, CultureInfo.InvariantCulture);
                var items = csv.GetRecords<SharedItemData>().ToDictionary(item => item.ItemName);
                Debug.WriteLine($"Loaded {items.Count} items to shared item data");
                return items;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Failed to load shared item data. Details: {ex.Message}");
                return new Dictionary<string, SharedItemData>();
            }
        }
    }
}

