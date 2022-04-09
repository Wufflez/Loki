using System.Collections.Generic;
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
        private static readonly Dictionary<string, SharedItemData> ItemData = new Dictionary<string, SharedItemData>
        {
            ["Abomination_attack1"] = new SharedItemData
            {
                ItemName = "Abomination_attack1", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Swing attack",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Abomination_attack2"] = new SharedItemData
            {
                ItemName = "Abomination_attack2", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Slam attack",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Abomination_attack3"] = new SharedItemData
            {
                ItemName = "Abomination_attack3", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Stub to the ground",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Acorn"] = new SharedItemData
            {
                ItemName = "Acorn", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "Acorns",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Amber"] = new SharedItemData
            {
                ItemName = "Amber", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Amber",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["AmberPearl"] = new SharedItemData
            {
                ItemName = "AmberPearl", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Amber pearl",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["AncientSeed"] = new SharedItemData
            {
                ItemName = "AncientSeed", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Ancient seed",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["ArmorBronzeChest"] = new SharedItemData
            {
                ItemName = "ArmorBronzeChest", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "Bronze plate cuirass",
                MaxQuality = 4, ItemType = (ItemType)7,
            },
            ["ArmorBronzeLegs"] = new SharedItemData
            {
                ItemName = "ArmorBronzeLegs", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "Bronze plate leggings",
                MaxQuality = 4, ItemType = (ItemType)11,
            },
            ["ArmorFenringChest"] = new SharedItemData
            {
                ItemName = "ArmorFenringChest", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "Fenris coat",
                MaxQuality = 4, ItemType = (ItemType)7,
            },
            ["ArmorFenringLegs"] = new SharedItemData
            {
                ItemName = "ArmorFenringLegs", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "Fenris leggings",
                MaxQuality = 4, ItemType = (ItemType)11,
            },
            ["ArmorIronChest"] = new SharedItemData
            {
                ItemName = "ArmorIronChest", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "Iron scale mail",
                MaxQuality = 4, ItemType = (ItemType)7,
            },
            ["ArmorIronLegs"] = new SharedItemData
            {
                ItemName = "ArmorIronLegs", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "Iron greaves",
                MaxQuality = 4, ItemType = (ItemType)11,
            },
            ["ArmorLeatherChest"] = new SharedItemData
            {
                ItemName = "ArmorLeatherChest", IsTeleportable = true, UsesDurability = true, MaxDurability = 400,
                DurabilityPerLevel = 100, MaxStack = 1, DisplayName = "Leather tunic",
                MaxQuality = 4, ItemType = (ItemType)7,
            },
            ["ArmorLeatherLegs"] = new SharedItemData
            {
                ItemName = "ArmorLeatherLegs", IsTeleportable = true, UsesDurability = true, MaxDurability = 400,
                DurabilityPerLevel = 100, MaxStack = 1, DisplayName = "Leather pants",
                MaxQuality = 4, ItemType = (ItemType)11,
            },
            ["ArmorPaddedCuirass"] = new SharedItemData
            {
                ItemName = "ArmorPaddedCuirass", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "Padded cuirass",
                MaxQuality = 4, ItemType = (ItemType)7,
            },
            ["ArmorPaddedGreaves"] = new SharedItemData
            {
                ItemName = "ArmorPaddedGreaves", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "Padded greaves",
                MaxQuality = 4, ItemType = (ItemType)11,
            },
            ["ArmorRagsChest"] = new SharedItemData
            {
                ItemName = "ArmorRagsChest", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Rag tunic",
                MaxQuality = 2, ItemType = (ItemType)7,
            },
            ["ArmorRagsLegs"] = new SharedItemData
            {
                ItemName = "ArmorRagsLegs", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Rag pants",
                MaxQuality = 2, ItemType = (ItemType)11,
            },
            ["ArmorRootChest"] = new SharedItemData
            {
                ItemName = "ArmorRootChest", IsTeleportable = true, UsesDurability = true, MaxDurability = 800,
                DurabilityPerLevel = 100, MaxStack = 1, DisplayName = "Root harnesk",
                MaxQuality = 4, ItemType = (ItemType)7,
            },
            ["ArmorRootLegs"] = new SharedItemData
            {
                ItemName = "ArmorRootLegs", IsTeleportable = true, UsesDurability = true, MaxDurability = 800,
                DurabilityPerLevel = 100, MaxStack = 1, DisplayName = "Root leggings",
                MaxQuality = 4, ItemType = (ItemType)11,
            },
            ["ArmorTrollLeatherChest"] = new SharedItemData
            {
                ItemName = "ArmorTrollLeatherChest", IsTeleportable = true, UsesDurability = true, MaxDurability = 500,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "Troll leather tunic",
                MaxQuality = 4, ItemType = (ItemType)7,
            },
            ["ArmorTrollLeatherLegs"] = new SharedItemData
            {
                ItemName = "ArmorTrollLeatherLegs", IsTeleportable = true, UsesDurability = true, MaxDurability = 500,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "Troll leather pants",
                MaxQuality = 4, ItemType = (ItemType)11,
            },
            ["ArmorWolfChest"] = new SharedItemData
            {
                ItemName = "ArmorWolfChest", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "Wolf armor chest",
                MaxQuality = 4, ItemType = (ItemType)7,
            },
            ["ArmorWolfLegs"] = new SharedItemData
            {
                ItemName = "ArmorWolfLegs", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "Wolf armor legs",
                MaxQuality = 4, ItemType = (ItemType)11,
            },
            ["ArrowBronze"] = new SharedItemData
            {
                ItemName = "ArrowBronze", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "Bronzehead arrow",
                MaxQuality = 1, ItemType = (ItemType)9,
            },
            ["ArrowFire"] = new SharedItemData
            {
                ItemName = "ArrowFire", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "Fire arrow",
                MaxQuality = 1, ItemType = (ItemType)9,
            },
            ["ArrowFlint"] = new SharedItemData
            {
                ItemName = "ArrowFlint", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "Flinthead arrow",
                MaxQuality = 1, ItemType = (ItemType)9,
            },
            ["ArrowFrost"] = new SharedItemData
            {
                ItemName = "ArrowFrost", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "Frost arrow",
                MaxQuality = 1, ItemType = (ItemType)9,
            },
            ["ArrowIron"] = new SharedItemData
            {
                ItemName = "ArrowIron", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "Ironhead arrow",
                MaxQuality = 1, ItemType = (ItemType)9,
            },
            ["ArrowNeedle"] = new SharedItemData
            {
                ItemName = "ArrowNeedle", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "Needle arrow",
                MaxQuality = 1, ItemType = (ItemType)9,
            },
            ["ArrowObsidian"] = new SharedItemData
            {
                ItemName = "ArrowObsidian", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "Obsidian arrow",
                MaxQuality = 1, ItemType = (ItemType)9,
            },
            ["ArrowPoison"] = new SharedItemData
            {
                ItemName = "ArrowPoison", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "Poison arrow",
                MaxQuality = 1, ItemType = (ItemType)9,
            },
            ["ArrowSilver"] = new SharedItemData
            {
                ItemName = "ArrowSilver", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "Silver arrow",
                MaxQuality = 1, ItemType = (ItemType)9,
            },
            ["ArrowWood"] = new SharedItemData
            {
                ItemName = "ArrowWood", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "Wood arrow",
                MaxQuality = 1, ItemType = (ItemType)9,
            },
            ["AtgeirBlackmetal"] = new SharedItemData
            {
                ItemName = "AtgeirBlackmetal", IsTeleportable = true, UsesDurability = true, MaxDurability = 175,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Blackmetal atgeir",
                MaxQuality = 4, ItemType = (ItemType)14,
            },
            ["AtgeirBronze"] = new SharedItemData
            {
                ItemName = "AtgeirBronze", IsTeleportable = true, UsesDurability = true, MaxDurability = 125,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Bronze atgeir",
                MaxQuality = 4, ItemType = (ItemType)14,
            },
            ["AtgeirIron"] = new SharedItemData
            {
                ItemName = "AtgeirIron", IsTeleportable = true, UsesDurability = true, MaxDurability = 175,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Iron atgeir",
                MaxQuality = 4, ItemType = (ItemType)14,
            },
            ["AxeBlackMetal"] = new SharedItemData
            {
                ItemName = "AxeBlackMetal", IsTeleportable = true, UsesDurability = true, MaxDurability = 175,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Blackmetal axe",
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["AxeBronze"] = new SharedItemData
            {
                ItemName = "AxeBronze", IsTeleportable = true, UsesDurability = true, MaxDurability = 125,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Bronze axe",
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["AxeFlint"] = new SharedItemData
            {
                ItemName = "AxeFlint", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 30, MaxStack = 1, DisplayName = "Flint axe",
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["AxeIron"] = new SharedItemData
            {
                ItemName = "AxeIron", IsTeleportable = true, UsesDurability = true, MaxDurability = 175,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Iron axe",
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["AxeStone"] = new SharedItemData
            {
                ItemName = "AxeStone", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 30, MaxStack = 1, DisplayName = "Stone axe",
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["Barley"] = new SharedItemData
            {
                ItemName = "Barley", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "Barley",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["BarleyFlour"] = new SharedItemData
            {
                ItemName = "BarleyFlour", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Barley flour",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["BarleyWine"] = new SharedItemData
            {
                ItemName = "BarleyWine", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "Fire resistance barley wine",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["BarleyWineBase"] = new SharedItemData
            {
                ItemName = "BarleyWineBase", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Barley wine base: Fire resistance",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Battleaxe"] = new SharedItemData
            {
                ItemName = "Battleaxe", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Battleaxe",
                MaxQuality = 4, ItemType = (ItemType)14,
            },
            ["BattleaxeCrystal"] = new SharedItemData
            {
                ItemName = "BattleaxeCrystal", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Crystal battleaxe",
                MaxQuality = 4, ItemType = (ItemType)14,
            },
            ["bat_melee"] = new SharedItemData
            {
                ItemName = "bat_melee", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Bat melee",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Beard1"] = new SharedItemData
            {
                ItemName = "Beard1", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Long 1",
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Beard10"] = new SharedItemData
            {
                ItemName = "Beard10", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Braided 4",
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Beard2"] = new SharedItemData
            {
                ItemName = "Beard2", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Long 2",
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Beard3"] = new SharedItemData
            {
                ItemName = "Beard3", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Short 1",
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Beard4"] = new SharedItemData
            {
                ItemName = "Beard4", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Short 2",
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Beard5"] = new SharedItemData
            {
                ItemName = "Beard5", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Braided 1",
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Beard6"] = new SharedItemData
            {
                ItemName = "Beard6", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Braided 2",
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Beard7"] = new SharedItemData
            {
                ItemName = "Beard7", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Short 3",
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Beard8"] = new SharedItemData
            {
                ItemName = "Beard8", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Thick 1",
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Beard9"] = new SharedItemData
            {
                ItemName = "Beard9", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Braided 3",
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["BeardNone"] = new SharedItemData
            {
                ItemName = "BeardNone", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "No beard",
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["BeechSeeds"] = new SharedItemData
            {
                ItemName = "BeechSeeds", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "Beech seeds",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["BeltStrength"] = new SharedItemData
            {
                ItemName = "BeltStrength", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Megingjord",
                MaxQuality = 1, ItemType = (ItemType)18,
            },
            ["BirchSeeds"] = new SharedItemData
            {
                ItemName = "BirchSeeds", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "Birch seeds",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["BlackMetal"] = new SharedItemData
            {
                ItemName = "BlackMetal", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "Black metal",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["BlackMetalScrap"] = new SharedItemData
            {
                ItemName = "BlackMetalScrap", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "Black metal scrap",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["BlackSoup"] = new SharedItemData
            {
                ItemName = "BlackSoup", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "Black soup",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["blobelite_attack_aoe"] = new SharedItemData
            {
                ItemName = "blobelite_attack_aoe", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "fart",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["blobtar_attack"] = new SharedItemData
            {
                ItemName = "blobtar_attack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "fireballattack",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["blob_attack_aoe"] = new SharedItemData
            {
                ItemName = "blob_attack_aoe", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "fart",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Bloodbag"] = new SharedItemData
            {
                ItemName = "Bloodbag", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Bloodbag",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["BloodPudding"] = new SharedItemData
            {
                ItemName = "BloodPudding", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "Blood pudding",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["Blueberries"] = new SharedItemData
            {
                ItemName = "Blueberries", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Blueberries",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["BoarJerky"] = new SharedItemData
            {
                ItemName = "BoarJerky", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Boar jerky",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["boar_base_attack"] = new SharedItemData
            {
                ItemName = "boar_base_attack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "boar attack1",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["BombOoze"] = new SharedItemData
            {
                ItemName = "BombOoze", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Ooze bomb",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["BoneFragments"] = new SharedItemData
            {
                ItemName = "BoneFragments", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Bone fragments",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["bonemass_attack_aoe"] = new SharedItemData
            {
                ItemName = "bonemass_attack_aoe", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "heal",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["bonemass_attack_punch"] = new SharedItemData
            {
                ItemName = "bonemass_attack_punch", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "slap",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["bonemass_attack_spawn"] = new SharedItemData
            {
                ItemName = "bonemass_attack_spawn", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "heal",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["bonemass_attack_throw"] = new SharedItemData
            {
                ItemName = "bonemass_attack_throw", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "slime throw",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Bow"] = new SharedItemData
            {
                ItemName = "Bow", IsTeleportable = true, UsesDurability = true, MaxDurability = 50,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Crude bow",
                MaxQuality = 4, ItemType = (ItemType)4,
            },
            ["BowDraugrFang"] = new SharedItemData
            {
                ItemName = "BowDraugrFang", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Draugr fang",
                MaxQuality = 4, ItemType = (ItemType)4,
            },
            ["BowFineWood"] = new SharedItemData
            {
                ItemName = "BowFineWood", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Finewood bow",
                MaxQuality = 4, ItemType = (ItemType)4,
            },
            ["BowHuntsman"] = new SharedItemData
            {
                ItemName = "BowHuntsman", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Huntsman bow",
                MaxQuality = 4, ItemType = (ItemType)4,
            },
            ["Bread"] = new SharedItemData
            {
                ItemName = "Bread", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Bread",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["BreadDough"] = new SharedItemData
            {
                ItemName = "BreadDough", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Bread dough",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Bronze"] = new SharedItemData
            {
                ItemName = "Bronze", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "Bronze",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["BronzeNails"] = new SharedItemData
            {
                ItemName = "BronzeNails", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "Bronze nails",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["CapeDeerHide"] = new SharedItemData
            {
                ItemName = "CapeDeerHide", IsTeleportable = true, UsesDurability = true, MaxDurability = 400,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Deer hide cape",
                MaxQuality = 4, ItemType = (ItemType)17,
            },
            ["CapeLinen"] = new SharedItemData
            {
                ItemName = "CapeLinen", IsTeleportable = true, UsesDurability = true, MaxDurability = 1500,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Linen cape",
                MaxQuality = 4, ItemType = (ItemType)17,
            },
            ["CapeLox"] = new SharedItemData
            {
                ItemName = "CapeLox", IsTeleportable = true, UsesDurability = true, MaxDurability = 1200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Lox cape",
                MaxQuality = 4, ItemType = (ItemType)17,
            },
            ["CapeOdin"] = new SharedItemData
            {
                ItemName = "CapeOdin", IsTeleportable = true, UsesDurability = true, MaxDurability = 1500,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Cape of Odin",
                MaxQuality = 4, ItemType = (ItemType)17,
            },
            ["CapeTest"] = new SharedItemData
            {
                ItemName = "CapeTest", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "CAPE TEST",
                MaxQuality = 4, ItemType = (ItemType)17,
            },
            ["CapeTrollHide"] = new SharedItemData
            {
                ItemName = "CapeTrollHide", IsTeleportable = true, UsesDurability = true, MaxDurability = 500,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Troll hide cape",
                MaxQuality = 4, ItemType = (ItemType)17,
            },
            ["CapeWolf"] = new SharedItemData
            {
                ItemName = "CapeWolf", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Wolf fur cape",
                MaxQuality = 4, ItemType = (ItemType)17,
            },
            ["Carrot"] = new SharedItemData
            {
                ItemName = "Carrot", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Carrot",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["CarrotSeeds"] = new SharedItemData
            {
                ItemName = "CarrotSeeds", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "Carrot seeds",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["CarrotSoup"] = new SharedItemData
            {
                ItemName = "CarrotSoup", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "Carrot soup",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["Chain"] = new SharedItemData
            {
                ItemName = "Chain", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Chain",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Chitin"] = new SharedItemData
            {
                ItemName = "Chitin", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Chitin",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Cloudberry"] = new SharedItemData
            {
                ItemName = "Cloudberry", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Cloudberries",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["Club"] = new SharedItemData
            {
                ItemName = "Club", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Club",
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["Coal"] = new SharedItemData
            {
                ItemName = "Coal", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Coal",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Coins"] = new SharedItemData
            {
                ItemName = "Coins", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 999, DisplayName = "Coins",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["CookedDeerMeat"] = new SharedItemData
            {
                ItemName = "CookedDeerMeat", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Cooked deer meat",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["CookedLoxMeat"] = new SharedItemData
            {
                ItemName = "CookedLoxMeat", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Cooked lox meat",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["CookedMeat"] = new SharedItemData
            {
                ItemName = "CookedMeat", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Cooked boar meat",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["CookedWolfMeat"] = new SharedItemData
            {
                ItemName = "CookedWolfMeat", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Cooked wolf meat",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["Copper"] = new SharedItemData
            {
                ItemName = "Copper", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "Copper",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["CopperOre"] = new SharedItemData
            {
                ItemName = "CopperOre", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "Copper ore",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["CryptKey"] = new SharedItemData
            {
                ItemName = "CryptKey", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Swamp key",
                MaxQuality = 1, ItemType = (ItemType)16,
            },
            ["Crystal"] = new SharedItemData
            {
                ItemName = "Crystal", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Crystal",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Cultivator"] = new SharedItemData
            {
                ItemName = "Cultivator", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "Cultivator",
                MaxQuality = 3, ItemType = (ItemType)19,
            },
            ["Dandelion"] = new SharedItemData
            {
                ItemName = "Dandelion", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Dandelion",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Deathsquito_sting"] = new SharedItemData
            {
                ItemName = "Deathsquito_sting", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Wraith melee",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["DeerHide"] = new SharedItemData
            {
                ItemName = "DeerHide", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Deer hide",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["DeerMeat"] = new SharedItemData
            {
                ItemName = "DeerMeat", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Deer meat",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["DeerStew"] = new SharedItemData
            {
                ItemName = "DeerStew", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "Deer stew",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["DragonEgg"] = new SharedItemData
            {
                ItemName = "DragonEgg", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Dragon egg",
                MaxQuality = 1, ItemType = (ItemType)16,
            },
            ["DragonTear"] = new SharedItemData
            {
                ItemName = "DragonTear", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Dragon tear",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["dragon_bite"] = new SharedItemData
            {
                ItemName = "dragon_bite", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Dragon claw left",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["dragon_claw_left"] = new SharedItemData
            {
                ItemName = "dragon_claw_left", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Dragon claw left",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["dragon_claw_right"] = new SharedItemData
            {
                ItemName = "dragon_claw_right", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Dragon claw left",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["dragon_coldbreath"] = new SharedItemData
            {
                ItemName = "dragon_coldbreath", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "dragon breath",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["dragon_coldbreath_OLD"] = new SharedItemData
            {
                ItemName = "dragon_coldbreath_OLD", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "dragon breath",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["dragon_spit_shotgun"] = new SharedItemData
            {
                ItemName = "dragon_spit_shotgun", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "cold ball",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["dragon_taunt"] = new SharedItemData
            {
                ItemName = "dragon_taunt", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "scream",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["draugr_arrow"] = new SharedItemData
            {
                ItemName = "draugr_arrow", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Ironhead arrow",
                MaxQuality = 1, ItemType = (ItemType)9,
            },
            ["draugr_axe"] = new SharedItemData
            {
                ItemName = "draugr_axe", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Dragur axe",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["draugr_bow"] = new SharedItemData
            {
                ItemName = "draugr_bow", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Bow",
                MaxQuality = 1, ItemType = (ItemType)4,
            },
            ["draugr_sword"] = new SharedItemData
            {
                ItemName = "draugr_sword", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Dragur axe",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Eikthyr_antler"] = new SharedItemData
            {
                ItemName = "Eikthyr_antler", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "StagAttack1",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Eikthyr_charge"] = new SharedItemData
            {
                ItemName = "Eikthyr_charge", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "StagAttack2",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Eikthyr_flegs_OLD"] = new SharedItemData
            {
                ItemName = "Eikthyr_flegs_OLD", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "StagAttack1",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Eikthyr_stomp"] = new SharedItemData
            {
                ItemName = "Eikthyr_stomp", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "slap",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["ElderBark"] = new SharedItemData
            {
                ItemName = "ElderBark", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Ancient bark",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Entrails"] = new SharedItemData
            {
                ItemName = "Entrails", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Entrails",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Eyescream"] = new SharedItemData
            {
                ItemName = "Eyescream", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "Eyescream",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["Feathers"] = new SharedItemData
            {
                ItemName = "Feathers", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Feathers",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Fenring_attack_claw"] = new SharedItemData
            {
                ItemName = "Fenring_attack_claw", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "claw",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Fenring_attack_fireclaw"] = new SharedItemData
            {
                ItemName = "Fenring_attack_fireclaw", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "claw",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Fenring_attack_fireclaw_double"] = new SharedItemData
            {
                ItemName = "Fenring_attack_fireclaw_double", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "claw",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Fenring_attack_flames"] = new SharedItemData
            {
                ItemName = "Fenring_attack_flames", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Fenring cultist flames",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Fenring_attack_jump"] = new SharedItemData
            {
                ItemName = "Fenring_attack_jump", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "claw",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Fenring_taunt"] = new SharedItemData
            {
                ItemName = "Fenring_taunt", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "scream",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["FineWood"] = new SharedItemData
            {
                ItemName = "FineWood", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Fine wood",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["FirCone"] = new SharedItemData
            {
                ItemName = "FirCone", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "Fir cone",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["FishCooked"] = new SharedItemData
            {
                ItemName = "FishCooked", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Cooked fish",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["FishingBait"] = new SharedItemData
            {
                ItemName = "FishingBait", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "Fishing bait",
                MaxQuality = 1, ItemType = (ItemType)9,
            },
            ["FishingRod"] = new SharedItemData
            {
                ItemName = "FishingRod", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Fishing rod",
                MaxQuality = 1, ItemType = (ItemType)14,
            },
            ["FishRaw"] = new SharedItemData
            {
                ItemName = "FishRaw", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Raw fish",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["FishWraps"] = new SharedItemData
            {
                ItemName = "FishWraps", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "Fish wraps",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["FistFenrirClaw"] = new SharedItemData
            {
                ItemName = "FistFenrirClaw", IsTeleportable = true, UsesDurability = true, MaxDurability = 300,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Flesh rippers",
                MaxQuality = 4, ItemType = (ItemType)14,
            },
            ["Flametal"] = new SharedItemData
            {
                ItemName = "Flametal", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "Flametal",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["FlametalOre"] = new SharedItemData
            {
                ItemName = "FlametalOre", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "Flametal ore",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Flax"] = new SharedItemData
            {
                ItemName = "Flax", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "Flax",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Flint"] = new SharedItemData
            {
                ItemName = "Flint", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "Flint",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["FreezeGland"] = new SharedItemData
            {
                ItemName = "FreezeGland", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Freeze gland",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["gd_king_punch"] = new SharedItemData
            {
                ItemName = "gd_king_punch", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "jaws",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["gd_king_rootspawn"] = new SharedItemData
            {
                ItemName = "gd_king_rootspawn", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "spawn",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["gd_king_scream"] = new SharedItemData
            {
                ItemName = "gd_king_scream", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "scream",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["gd_king_shoot"] = new SharedItemData
            {
                ItemName = "gd_king_shoot", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "shaman attack",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["gd_king_stomp"] = new SharedItemData
            {
                ItemName = "gd_king_stomp", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "jaws",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Ghost_attack"] = new SharedItemData
            {
                ItemName = "Ghost_attack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "jaws",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["GoblinArmband"] = new SharedItemData
            {
                ItemName = "GoblinArmband", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Iron plate armor",
                MaxQuality = 4, ItemType = (ItemType)7,
            },
            ["GoblinBrute_ArmGuard"] = new SharedItemData
            {
                ItemName = "GoblinBrute_ArmGuard", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Iron plate armor",
                MaxQuality = 4, ItemType = (ItemType)7,
            },
            ["GoblinBrute_Attack"] = new SharedItemData
            {
                ItemName = "GoblinBrute_Attack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Brute sword",
                MaxQuality = 7, ItemType = (ItemType)3,
            },
            ["GoblinBrute_Backbones"] = new SharedItemData
            {
                ItemName = "GoblinBrute_Backbones", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Iron plate armor",
                MaxQuality = 4, ItemType = (ItemType)6,
            },
            ["GoblinBrute_ExecutionerCap"] = new SharedItemData
            {
                ItemName = "GoblinBrute_ExecutionerCap", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Iron plate armor",
                MaxQuality = 4, ItemType = (ItemType)6,
            },
            ["GoblinBrute_HipCloth"] = new SharedItemData
            {
                ItemName = "GoblinBrute_HipCloth", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Iron plate armor",
                MaxQuality = 4, ItemType = (ItemType)11,
            },
            ["GoblinBrute_LegBones"] = new SharedItemData
            {
                ItemName = "GoblinBrute_LegBones", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Iron plate armor",
                MaxQuality = 4, ItemType = (ItemType)18,
            },
            ["GoblinBrute_RageAttack"] = new SharedItemData
            {
                ItemName = "GoblinBrute_RageAttack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Brute sword",
                MaxQuality = 7, ItemType = (ItemType)3,
            },
            ["GoblinBrute_ShoulderGuard"] = new SharedItemData
            {
                ItemName = "GoblinBrute_ShoulderGuard", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Iron plate armor",
                MaxQuality = 4, ItemType = (ItemType)17,
            },
            ["GoblinBrute_Taunt"] = new SharedItemData
            {
                ItemName = "GoblinBrute_Taunt", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Brute taunt",
                MaxQuality = 7, ItemType = (ItemType)3,
            },
            ["GoblinClub"] = new SharedItemData
            {
                ItemName = "GoblinClub", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Club",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["GoblinHelmet"] = new SharedItemData
            {
                ItemName = "GoblinHelmet", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Iron plate armor",
                MaxQuality = 4, ItemType = (ItemType)7,
            },
            ["GoblinKing_Beam"] = new SharedItemData
            {
                ItemName = "GoblinKing_Beam", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "dragon breath",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["GoblinKing_Meteors"] = new SharedItemData
            {
                ItemName = "GoblinKing_Meteors", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "spawn",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["GoblinKing_Nova"] = new SharedItemData
            {
                ItemName = "GoblinKing_Nova", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "slap",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["GoblinKing_Taunt"] = new SharedItemData
            {
                ItemName = "GoblinKing_Taunt", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "scream",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["GoblinLegband"] = new SharedItemData
            {
                ItemName = "GoblinLegband", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Iron plate armor",
                MaxQuality = 4, ItemType = (ItemType)7,
            },
            ["GoblinLoin"] = new SharedItemData
            {
                ItemName = "GoblinLoin", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Iron plate armor",
                MaxQuality = 4, ItemType = (ItemType)11,
            },
            ["GoblinShaman_attack_fireball"] = new SharedItemData
            {
                ItemName = "GoblinShaman_attack_fireball", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "fireballattack",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["GoblinShaman_attack_poke"] = new SharedItemData
            {
                ItemName = "GoblinShaman_attack_poke", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Club",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["GoblinShaman_attack_protect"] = new SharedItemData
            {
                ItemName = "GoblinShaman_attack_protect", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "heal",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["GoblinShaman_Headdress_antlers"] = new SharedItemData
            {
                ItemName = "GoblinShaman_Headdress_antlers", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Club",
                MaxQuality = 1, ItemType = (ItemType)6,
            },
            ["GoblinShaman_Headdress_feathers"] = new SharedItemData
            {
                ItemName = "GoblinShaman_Headdress_feathers", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Club",
                MaxQuality = 1, ItemType = (ItemType)6,
            },
            ["GoblinShaman_Staff_Bones"] = new SharedItemData
            {
                ItemName = "GoblinShaman_Staff_Bones", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Club",
                MaxQuality = 1, ItemType = (ItemType)18,
            },
            ["GoblinShaman_Staff_Feathers"] = new SharedItemData
            {
                ItemName = "GoblinShaman_Staff_Feathers", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Club",
                MaxQuality = 1, ItemType = (ItemType)18,
            },
            ["GoblinShoulders"] = new SharedItemData
            {
                ItemName = "GoblinShoulders", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Iron plate armor",
                MaxQuality = 4, ItemType = (ItemType)7,
            },
            ["GoblinSpear"] = new SharedItemData
            {
                ItemName = "GoblinSpear", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "Flint spear",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["GoblinSword"] = new SharedItemData
            {
                ItemName = "GoblinSword", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Bronze sword",
                MaxQuality = 7, ItemType = (ItemType)3,
            },
            ["GoblinTorch"] = new SharedItemData
            {
                ItemName = "GoblinTorch", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Torch",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["GoblinTotem"] = new SharedItemData
            {
                ItemName = "GoblinTotem", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "Fuling totem",
                MaxQuality = 1, ItemType = (ItemType)16,
            },
            ["GreydwarfEye"] = new SharedItemData
            {
                ItemName = "GreydwarfEye", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Greydwarf eye",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Greydwarf_attack"] = new SharedItemData
            {
                ItemName = "Greydwarf_attack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "jaws",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Greydwarf_elite_attack"] = new SharedItemData
            {
                ItemName = "Greydwarf_elite_attack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "jaws",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Greydwarf_shaman_attack"] = new SharedItemData
            {
                ItemName = "Greydwarf_shaman_attack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "shaman attack",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Greydwarf_shaman_heal"] = new SharedItemData
            {
                ItemName = "Greydwarf_shaman_heal", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "heal",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Greydwarf_throw"] = new SharedItemData
            {
                ItemName = "Greydwarf_throw", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "throw stone",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Greyling_attack"] = new SharedItemData
            {
                ItemName = "Greyling_attack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "jaws",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Guck"] = new SharedItemData
            {
                ItemName = "Guck", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Guck",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Hair1"] = new SharedItemData
            {
                ItemName = "Hair1", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Ponytail 1",
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Hair10"] = new SharedItemData
            {
                ItemName = "Hair10", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Side Swept 2",
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Hair11"] = new SharedItemData
            {
                ItemName = "Hair11", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Braided 2",
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Hair12"] = new SharedItemData
            {
                ItemName = "Hair12", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Braided 3",
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Hair13"] = new SharedItemData
            {
                ItemName = "Hair13", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Braided 4",
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Hair14"] = new SharedItemData
            {
                ItemName = "Hair14", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Side Swept 3",
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Hair2"] = new SharedItemData
            {
                ItemName = "Hair2", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Ponytail 2",
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Hair3"] = new SharedItemData
            {
                ItemName = "Hair3", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Braided 1",
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Hair4"] = new SharedItemData
            {
                ItemName = "Hair4", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Ponytail 3",
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Hair5"] = new SharedItemData
            {
                ItemName = "Hair5", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Short 1",
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Hair6"] = new SharedItemData
            {
                ItemName = "Hair6", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Long 1",
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Hair7"] = new SharedItemData
            {
                ItemName = "Hair7", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Ponytail 4",
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Hair8"] = new SharedItemData
            {
                ItemName = "Hair8", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Short 2",
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Hair9"] = new SharedItemData
            {
                ItemName = "Hair9", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Side Swept 1",
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["HairNone"] = new SharedItemData
            {
                ItemName = "HairNone", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "No hair",
                MaxQuality = 1, ItemType = (ItemType)10,
            },
            ["Hammer"] = new SharedItemData
            {
                ItemName = "Hammer", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 100, MaxStack = 1, DisplayName = "Hammer",
                MaxQuality = 3, ItemType = (ItemType)19,
            },
            ["HardAntler"] = new SharedItemData
            {
                ItemName = "HardAntler", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Hard antler",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["hatchling_spit_cold"] = new SharedItemData
            {
                ItemName = "hatchling_spit_cold", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "cold ball",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["HealthUpgrade_Bonemass"] = new SharedItemData
            {
                ItemName = "HealthUpgrade_Bonemass", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Bonemass heart",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["HealthUpgrade_GDKing"] = new SharedItemData
            {
                ItemName = "HealthUpgrade_GDKing", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Elder heart",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["HelmetBronze"] = new SharedItemData
            {
                ItemName = "HelmetBronze", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "Bronze helmet",
                MaxQuality = 4, ItemType = (ItemType)6,
            },
            ["HelmetDrake"] = new SharedItemData
            {
                ItemName = "HelmetDrake", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "Drake helmet",
                MaxQuality = 4, ItemType = (ItemType)6,
            },
            ["HelmetDverger"] = new SharedItemData
            {
                ItemName = "HelmetDverger", IsTeleportable = true, UsesDurability = false, MaxDurability = 1000,
                DurabilityPerLevel = 100, MaxStack = 1, DisplayName = "Dverger circlet",
                MaxQuality = 1, ItemType = (ItemType)6,
            },
            ["HelmetFenring"] = new SharedItemData
            {
                ItemName = "HelmetFenring", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "Fenris hood",
                MaxQuality = 4, ItemType = (ItemType)6,
            },
            ["HelmetIron"] = new SharedItemData
            {
                ItemName = "HelmetIron", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "Iron helmet",
                MaxQuality = 4, ItemType = (ItemType)6,
            },
            ["HelmetLeather"] = new SharedItemData
            {
                ItemName = "HelmetLeather", IsTeleportable = true, UsesDurability = true, MaxDurability = 400,
                DurabilityPerLevel = 100, MaxStack = 1, DisplayName = "Leather helmet",
                MaxQuality = 4, ItemType = (ItemType)6,
            },
            ["HelmetOdin"] = new SharedItemData
            {
                ItemName = "HelmetOdin", IsTeleportable = true, UsesDurability = true, MaxDurability = 300,
                DurabilityPerLevel = 100, MaxStack = 1, DisplayName = "Hood of Odin",
                MaxQuality = 4, ItemType = (ItemType)6,
            },
            ["HelmetPadded"] = new SharedItemData
            {
                ItemName = "HelmetPadded", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "Padded helmet",
                MaxQuality = 4, ItemType = (ItemType)6,
            },
            ["HelmetRoot"] = new SharedItemData
            {
                ItemName = "HelmetRoot", IsTeleportable = true, UsesDurability = true, MaxDurability = 800,
                DurabilityPerLevel = 100, MaxStack = 1, DisplayName = "Root mask",
                MaxQuality = 4, ItemType = (ItemType)6,
            },
            ["HelmetTrollLeather"] = new SharedItemData
            {
                ItemName = "HelmetTrollLeather", IsTeleportable = true, UsesDurability = true, MaxDurability = 500,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "Troll leather helmet",
                MaxQuality = 4, ItemType = (ItemType)6,
            },
            ["HelmetYule"] = new SharedItemData
            {
                ItemName = "HelmetYule", IsTeleportable = true, UsesDurability = false, MaxDurability = 1000,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Yule hat",
                MaxQuality = 1, ItemType = (ItemType)6,
            },
            ["Hoe"] = new SharedItemData
            {
                ItemName = "Hoe", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "Hoe",
                MaxQuality = 3, ItemType = (ItemType)19,
            },
            ["Honey"] = new SharedItemData
            {
                ItemName = "Honey", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Honey",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["imp_fireball_attack"] = new SharedItemData
            {
                ItemName = "imp_fireball_attack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "fireballattack",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Iron"] = new SharedItemData
            {
                ItemName = "Iron", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "Iron",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["IronNails"] = new SharedItemData
            {
                ItemName = "IronNails", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "Iron nails",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["IronOre"] = new SharedItemData
            {
                ItemName = "IronOre", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "Iron ore",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["IronScrap"] = new SharedItemData
            {
                ItemName = "IronScrap", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "Scrap iron",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["JuteRed"] = new SharedItemData
            {
                ItemName = "JuteRed", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Red jute",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["KnifeBlackMetal"] = new SharedItemData
            {
                ItemName = "KnifeBlackMetal", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Blackmetal knife",
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["KnifeButcher"] = new SharedItemData
            {
                ItemName = "KnifeButcher", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Butcher knife",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["KnifeChitin"] = new SharedItemData
            {
                ItemName = "KnifeChitin", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Abyssal razor",
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["KnifeCopper"] = new SharedItemData
            {
                ItemName = "KnifeCopper", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Copper knife",
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["KnifeFlint"] = new SharedItemData
            {
                ItemName = "KnifeFlint", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Flint knife",
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["KnifeSilver"] = new SharedItemData
            {
                ItemName = "KnifeSilver", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Silver knife",
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["LeatherScraps"] = new SharedItemData
            {
                ItemName = "LeatherScraps", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Leather scraps",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Leech_BiteAttack"] = new SharedItemData
            {
                ItemName = "Leech_BiteAttack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "jaws",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["LinenThread"] = new SharedItemData
            {
                ItemName = "LinenThread", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Linen thread",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["LoxMeat"] = new SharedItemData
            {
                ItemName = "LoxMeat", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Lox meat",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["LoxPelt"] = new SharedItemData
            {
                ItemName = "LoxPelt", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Lox pelt",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["LoxPie"] = new SharedItemData
            {
                ItemName = "LoxPie", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "Lox meat pie",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["LoxPieUncooked"] = new SharedItemData
            {
                ItemName = "LoxPieUncooked", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "Unbaked lox pie",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["lox_bite"] = new SharedItemData
            {
                ItemName = "lox_bite", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "lox bite",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["lox_stomp"] = new SharedItemData
            {
                ItemName = "lox_stomp", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "slap",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["MaceBronze"] = new SharedItemData
            {
                ItemName = "MaceBronze", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Bronze mace",
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["MaceIron"] = new SharedItemData
            {
                ItemName = "MaceIron", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Iron mace",
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["MaceNeedle"] = new SharedItemData
            {
                ItemName = "MaceNeedle", IsTeleportable = true, UsesDurability = true, MaxDurability = 150,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Porcupine",
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["MaceSilver"] = new SharedItemData
            {
                ItemName = "MaceSilver", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Frostner",
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["MeadBaseFrostResist"] = new SharedItemData
            {
                ItemName = "MeadBaseFrostResist", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Mead base: Frost resistance",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["MeadBaseHealthMedium"] = new SharedItemData
            {
                ItemName = "MeadBaseHealthMedium", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Mead base: Medium healing",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["MeadBaseHealthMinor"] = new SharedItemData
            {
                ItemName = "MeadBaseHealthMinor", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Mead base: Minor healing",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["MeadBasePoisonResist"] = new SharedItemData
            {
                ItemName = "MeadBasePoisonResist", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Mead base: Poison resistance",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["MeadBaseStaminaMedium"] = new SharedItemData
            {
                ItemName = "MeadBaseStaminaMedium", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Mead base: Medium stamina",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["MeadBaseStaminaMinor"] = new SharedItemData
            {
                ItemName = "MeadBaseStaminaMinor", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Mead base: Minor stamina",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["MeadBaseTasty"] = new SharedItemData
            {
                ItemName = "MeadBaseTasty", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Mead base: Tasty",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["MeadFrostResist"] = new SharedItemData
            {
                ItemName = "MeadFrostResist", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "Frost resistance mead",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["MeadHealthMedium"] = new SharedItemData
            {
                ItemName = "MeadHealthMedium", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "Medium healing mead",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["MeadHealthMinor"] = new SharedItemData
            {
                ItemName = "MeadHealthMinor", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "Minor healing mead",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["MeadPoisonResist"] = new SharedItemData
            {
                ItemName = "MeadPoisonResist", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "Poison resistance mead",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["MeadStaminaMedium"] = new SharedItemData
            {
                ItemName = "MeadStaminaMedium", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "Medium stamina mead",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["MeadStaminaMinor"] = new SharedItemData
            {
                ItemName = "MeadStaminaMinor", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "Minor stamina mead",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["MeadTasty"] = new SharedItemData
            {
                ItemName = "MeadTasty", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "Tasty mead",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["MinceMeatSauce"] = new SharedItemData
            {
                ItemName = "MinceMeatSauce", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "Minced Meat Sauce",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["Mushroom"] = new SharedItemData
            {
                ItemName = "Mushroom", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Mushroom",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["MushroomBlue"] = new SharedItemData
            {
                ItemName = "MushroomBlue", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Blue mushroom",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["MushroomYellow"] = new SharedItemData
            {
                ItemName = "MushroomYellow", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Yellow mushroom",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["NeckTail"] = new SharedItemData
            {
                ItemName = "NeckTail", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Neck tail",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["NeckTailGrilled"] = new SharedItemData
            {
                ItemName = "NeckTailGrilled", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Grilled Neck tail",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["Neck_BiteAttack"] = new SharedItemData
            {
                ItemName = "Neck_BiteAttack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "jaws",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Needle"] = new SharedItemData
            {
                ItemName = "Needle", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Needle",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Obsidian"] = new SharedItemData
            {
                ItemName = "Obsidian", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Obsidian",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Onion"] = new SharedItemData
            {
                ItemName = "Onion", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Onion",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["OnionSeeds"] = new SharedItemData
            {
                ItemName = "OnionSeeds", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "Onion seeds",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["OnionSoup"] = new SharedItemData
            {
                ItemName = "OnionSoup", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "Onion soup",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["Ooze"] = new SharedItemData
            {
                ItemName = "Ooze", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Ooze",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["PickaxeAntler"] = new SharedItemData
            {
                ItemName = "PickaxeAntler", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Antler pickaxe",
                MaxQuality = 1, ItemType = (ItemType)14,
            },
            ["PickaxeBronze"] = new SharedItemData
            {
                ItemName = "PickaxeBronze", IsTeleportable = true, UsesDurability = true, MaxDurability = 120,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Bronze pickaxe",
                MaxQuality = 4, ItemType = (ItemType)14,
            },
            ["PickaxeIron"] = new SharedItemData
            {
                ItemName = "PickaxeIron", IsTeleportable = true, UsesDurability = true, MaxDurability = 150,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Iron pickaxe",
                MaxQuality = 4, ItemType = (ItemType)14,
            },
            ["PickaxeStone"] = new SharedItemData
            {
                ItemName = "PickaxeStone", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Stone pickaxe",
                MaxQuality = 1, ItemType = (ItemType)14,
            },
            ["PineCone"] = new SharedItemData
            {
                ItemName = "PineCone", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "Pine cone",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["PlayerUnarmed"] = new SharedItemData
            {
                ItemName = "PlayerUnarmed", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Unarmed",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Pukeberries"] = new SharedItemData
            {
                ItemName = "Pukeberries", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Bukeperries",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["QueenBee"] = new SharedItemData
            {
                ItemName = "QueenBee", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Queen bee",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["QueensJam"] = new SharedItemData
            {
                ItemName = "QueensJam", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "Queens jam",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["Raspberry"] = new SharedItemData
            {
                ItemName = "Raspberry", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Raspberries",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["RawMeat"] = new SharedItemData
            {
                ItemName = "RawMeat", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Boar meat",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Resin"] = new SharedItemData
            {
                ItemName = "Resin", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Resin",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Root"] = new SharedItemData
            {
                ItemName = "Root", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Root",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["RottenMeat"] = new SharedItemData
            {
                ItemName = "RottenMeat", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Rotten meat",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["RoundLog"] = new SharedItemData
            {
                ItemName = "RoundLog", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Core wood",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Ruby"] = new SharedItemData
            {
                ItemName = "Ruby", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Ruby",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["SaddleLox"] = new SharedItemData
            {
                ItemName = "SaddleLox", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Lox saddle",
                MaxQuality = 1, ItemType = (ItemType)16,
            },
            ["Sausages"] = new SharedItemData
            {
                ItemName = "Sausages", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Sausages",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["SerpentMeat"] = new SharedItemData
            {
                ItemName = "SerpentMeat", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Serpent meat",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["SerpentMeatCooked"] = new SharedItemData
            {
                ItemName = "SerpentMeatCooked", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Cooked serpent meat",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["SerpentScale"] = new SharedItemData
            {
                ItemName = "SerpentScale", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Serpent scale",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["SerpentStew"] = new SharedItemData
            {
                ItemName = "SerpentStew", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "Serpent stew",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["Serpent_attack"] = new SharedItemData
            {
                ItemName = "Serpent_attack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Serpent bite",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Serpent_taunt"] = new SharedItemData
            {
                ItemName = "Serpent_taunt", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Serpent Taunt",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["SharpeningStone"] = new SharedItemData
            {
                ItemName = "SharpeningStone", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Sharpening stone",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["ShieldBanded"] = new SharedItemData
            {
                ItemName = "ShieldBanded", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Banded shield",
                MaxQuality = 3, ItemType = (ItemType)5,
            },
            ["ShieldBlackmetal"] = new SharedItemData
            {
                ItemName = "ShieldBlackmetal", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Black metal shield",
                MaxQuality = 3, ItemType = (ItemType)5,
            },
            ["ShieldBlackmetalTower"] = new SharedItemData
            {
                ItemName = "ShieldBlackmetalTower", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Black metal tower shield",
                MaxQuality = 3, ItemType = (ItemType)5,
            },
            ["ShieldBoneTower"] = new SharedItemData
            {
                ItemName = "ShieldBoneTower", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Bone tower shield",
                MaxQuality = 3, ItemType = (ItemType)5,
            },
            ["ShieldBronzeBuckler"] = new SharedItemData
            {
                ItemName = "ShieldBronzeBuckler", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Bronze buckler",
                MaxQuality = 3, ItemType = (ItemType)5,
            },
            ["ShieldIronBuckler"] = new SharedItemData
            {
                ItemName = "ShieldIronBuckler", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Iron buckler",
                MaxQuality = 3, ItemType = (ItemType)5,
            },
            ["ShieldIronSquare"] = new SharedItemData
            {
                ItemName = "ShieldIronSquare", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Iron shield",
                MaxQuality = 3, ItemType = (ItemType)5,
            },
            ["ShieldIronTower"] = new SharedItemData
            {
                ItemName = "ShieldIronTower", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Iron tower shield",
                MaxQuality = 3, ItemType = (ItemType)5,
            },
            ["ShieldKnight"] = new SharedItemData
            {
                ItemName = "ShieldKnight", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Knight shield",
                MaxQuality = 1, ItemType = (ItemType)5,
            },
            ["ShieldSerpentscale"] = new SharedItemData
            {
                ItemName = "ShieldSerpentscale", IsTeleportable = true, UsesDurability = true, MaxDurability = 250,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Serpent scale shield",
                MaxQuality = 3, ItemType = (ItemType)5,
            },
            ["ShieldSilver"] = new SharedItemData
            {
                ItemName = "ShieldSilver", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Silver shield",
                MaxQuality = 3, ItemType = (ItemType)5,
            },
            ["ShieldWood"] = new SharedItemData
            {
                ItemName = "ShieldWood", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Wood shield",
                MaxQuality = 3, ItemType = (ItemType)5,
            },
            ["ShieldWoodTower"] = new SharedItemData
            {
                ItemName = "ShieldWoodTower", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Wood tower shield",
                MaxQuality = 3, ItemType = (ItemType)5,
            },
            ["ShocklateSmoothie"] = new SharedItemData
            {
                ItemName = "ShocklateSmoothie", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "Muckshake",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["Silver"] = new SharedItemData
            {
                ItemName = "Silver", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "Silver",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["SilverNecklace"] = new SharedItemData
            {
                ItemName = "SilverNecklace", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Silver Necklace",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["SilverOre"] = new SharedItemData
            {
                ItemName = "SilverOre", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "Silver ore",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["skeleton_bow"] = new SharedItemData
            {
                ItemName = "skeleton_bow", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Bow",
                MaxQuality = 1, ItemType = (ItemType)4,
            },
            ["skeleton_mace"] = new SharedItemData
            {
                ItemName = "skeleton_mace", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Dragur axe",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["skeleton_sword"] = new SharedItemData
            {
                ItemName = "skeleton_sword", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Dragur axe",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["SledgeCheat"] = new SharedItemData
            {
                ItemName = "SledgeCheat", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Cheat sledge",
                MaxQuality = 4, ItemType = (ItemType)14,
            },
            ["SledgeIron"] = new SharedItemData
            {
                ItemName = "SledgeIron", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Iron sledge",
                MaxQuality = 4, ItemType = (ItemType)14,
            },
            ["SledgeStagbreaker"] = new SharedItemData
            {
                ItemName = "SledgeStagbreaker", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Stagbreaker",
                MaxQuality = 4, ItemType = (ItemType)14,
            },
            ["SpearBronze"] = new SharedItemData
            {
                ItemName = "SpearBronze", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Bronze spear",
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["SpearChitin"] = new SharedItemData
            {
                ItemName = "SpearChitin", IsTeleportable = true, UsesDurability = true, MaxDurability = 50,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Abyssal harpoon",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["SpearElderbark"] = new SharedItemData
            {
                ItemName = "SpearElderbark", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Ancient bark spear",
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["SpearFlint"] = new SharedItemData
            {
                ItemName = "SpearFlint", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Flint spear",
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["SpearWolfFang"] = new SharedItemData
            {
                ItemName = "SpearWolfFang", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Fang spear",
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["StaminaUpgrade_Greydwarf"] = new SharedItemData
            {
                ItemName = "StaminaUpgrade_Greydwarf", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Stamina Greydwarf",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["StaminaUpgrade_Troll"] = new SharedItemData
            {
                ItemName = "StaminaUpgrade_Troll", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Stamina Troll",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["StaminaUpgrade_Wraith"] = new SharedItemData
            {
                ItemName = "StaminaUpgrade_Wraith", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Stamina Wraith",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["Stone"] = new SharedItemData
            {
                ItemName = "Stone", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Stone",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["stonegolem_attack1_spike"] = new SharedItemData
            {
                ItemName = "stonegolem_attack1_spike", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Spike attack",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["stonegolem_attack2_left_groundslam"] = new SharedItemData
            {
                ItemName = "stonegolem_attack2_left_groundslam", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "One hand ground slam",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["stonegolem_attack3_spikesweep"] = new SharedItemData
            {
                ItemName = "stonegolem_attack3_spikesweep", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Spike sweep",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["stonegolem_attack_doublesmash"] = new SharedItemData
            {
                ItemName = "stonegolem_attack_doublesmash", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "slap",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["stonegolem_attack_sonicboom_NOTUSED"] = new SharedItemData
            {
                ItemName = "stonegolem_attack_sonicboom_NOTUSED", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "slap",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["StoneGolem_clubs"] = new SharedItemData
            {
                ItemName = "StoneGolem_clubs", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "",
                MaxQuality = 1, ItemType = (ItemType)7,
            },
            ["StoneGolem_hat"] = new SharedItemData
            {
                ItemName = "StoneGolem_hat", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "",
                MaxQuality = 1, ItemType = (ItemType)6,
            },
            ["StoneGolem_spikes"] = new SharedItemData
            {
                ItemName = "StoneGolem_spikes", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "",
                MaxQuality = 1, ItemType = (ItemType)7,
            },
            ["SurtlingCore"] = new SharedItemData
            {
                ItemName = "SurtlingCore", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "Surtling core",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["SwordBlackmetal"] = new SharedItemData
            {
                ItemName = "SwordBlackmetal", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Blackmetal sword",
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["SwordBronze"] = new SharedItemData
            {
                ItemName = "SwordBronze", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Bronze sword",
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["SwordCheat"] = new SharedItemData
            {
                ItemName = "SwordCheat", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Cheat sword",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["SwordIron"] = new SharedItemData
            {
                ItemName = "SwordIron", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Iron sword",
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["SwordIronFire"] = new SharedItemData
            {
                ItemName = "SwordIronFire", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Dyrnwyn",
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["SwordSilver"] = new SharedItemData
            {
                ItemName = "SwordSilver", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Silver sword",
                MaxQuality = 4, ItemType = (ItemType)3,
            },
            ["Tankard"] = new SharedItemData
            {
                ItemName = "Tankard", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Tankard",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["TankardAnniversary"] = new SharedItemData
            {
                ItemName = "TankardAnniversary", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Anniversary Tankard",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["TankardOdin"] = new SharedItemData
            {
                ItemName = "TankardOdin", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Mead horn of Odin",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Tar"] = new SharedItemData
            {
                ItemName = "Tar", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Tar",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["tentaroot_attack"] = new SharedItemData
            {
                ItemName = "tentaroot_attack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Dragur axe",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Thistle"] = new SharedItemData
            {
                ItemName = "Thistle", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Thistle",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Thunderstone"] = new SharedItemData
            {
                ItemName = "Thunderstone", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Thunder stone",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Tin"] = new SharedItemData
            {
                ItemName = "Tin", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "Tin",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["TinOre"] = new SharedItemData
            {
                ItemName = "TinOre", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "Tin ore",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Torch"] = new SharedItemData
            {
                ItemName = "Torch", IsTeleportable = true, UsesDurability = true, MaxDurability = 20,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Torch",
                MaxQuality = 1, ItemType = (ItemType)15,
            },
            ["TrollHide"] = new SharedItemData
            {
                ItemName = "TrollHide", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Troll hide",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["troll_groundslam"] = new SharedItemData
            {
                ItemName = "troll_groundslam", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "slap",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["troll_log_swing_h"] = new SharedItemData
            {
                ItemName = "troll_log_swing_h", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "LOG",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["troll_log_swing_v"] = new SharedItemData
            {
                ItemName = "troll_log_swing_v", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "LOG",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["troll_punch"] = new SharedItemData
            {
                ItemName = "troll_punch", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "slap",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["troll_throw"] = new SharedItemData
            {
                ItemName = "troll_throw", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "fireballattack",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["TrophyAbomination"] = new SharedItemData
            {
                ItemName = "TrophyAbomination", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Abomination trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyBlob"] = new SharedItemData
            {
                ItemName = "TrophyBlob", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Blob trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyBoar"] = new SharedItemData
            {
                ItemName = "TrophyBoar", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Boar trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyBonemass"] = new SharedItemData
            {
                ItemName = "TrophyBonemass", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Bonemass trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyCultist"] = new SharedItemData
            {
                ItemName = "TrophyCultist", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Cultist trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyDeathsquito"] = new SharedItemData
            {
                ItemName = "TrophyDeathsquito", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Deathsquito trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyDeer"] = new SharedItemData
            {
                ItemName = "TrophyDeer", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Deer trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyDragonQueen"] = new SharedItemData
            {
                ItemName = "TrophyDragonQueen", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Moder trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyDraugr"] = new SharedItemData
            {
                ItemName = "TrophyDraugr", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Draugr trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyDraugrElite"] = new SharedItemData
            {
                ItemName = "TrophyDraugrElite", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Draugr Elite trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyDraugrFem"] = new SharedItemData
            {
                ItemName = "TrophyDraugrFem", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Draugr trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyEikthyr"] = new SharedItemData
            {
                ItemName = "TrophyEikthyr", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Eikthyr trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyFenring"] = new SharedItemData
            {
                ItemName = "TrophyFenring", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Fenring trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyForestTroll"] = new SharedItemData
            {
                ItemName = "TrophyForestTroll", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Troll trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyFrostTroll"] = new SharedItemData
            {
                ItemName = "TrophyFrostTroll", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Troll trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyGoblin"] = new SharedItemData
            {
                ItemName = "TrophyGoblin", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Fuling trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyGoblinBrute"] = new SharedItemData
            {
                ItemName = "TrophyGoblinBrute", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Fuling berserker trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyGoblinKing"] = new SharedItemData
            {
                ItemName = "TrophyGoblinKing", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Yagluth trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyGoblinShaman"] = new SharedItemData
            {
                ItemName = "TrophyGoblinShaman", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Fuling shaman trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyGreydwarf"] = new SharedItemData
            {
                ItemName = "TrophyGreydwarf", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Greydwarf trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyGreydwarfBrute"] = new SharedItemData
            {
                ItemName = "TrophyGreydwarfBrute", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Greydwarf Brute trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyGreydwarfShaman"] = new SharedItemData
            {
                ItemName = "TrophyGreydwarfShaman", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Greydwarf Shaman trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyGrowth"] = new SharedItemData
            {
                ItemName = "TrophyGrowth", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Growth trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyHatchling"] = new SharedItemData
            {
                ItemName = "TrophyHatchling", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Drake trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyLeech"] = new SharedItemData
            {
                ItemName = "TrophyLeech", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Leech trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyLox"] = new SharedItemData
            {
                ItemName = "TrophyLox", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Lox trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyNeck"] = new SharedItemData
            {
                ItemName = "TrophyNeck", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Neck trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophySerpent"] = new SharedItemData
            {
                ItemName = "TrophySerpent", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Serpent trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophySGolem"] = new SharedItemData
            {
                ItemName = "TrophySGolem", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Stone Golem trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophySkeleton"] = new SharedItemData
            {
                ItemName = "TrophySkeleton", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Skeleton trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophySkeletonPoison"] = new SharedItemData
            {
                ItemName = "TrophySkeletonPoison", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Rancid remains trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophySurtling"] = new SharedItemData
            {
                ItemName = "TrophySurtling", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Surtling trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyTheElder"] = new SharedItemData
            {
                ItemName = "TrophyTheElder", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "The Elder trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyUlv"] = new SharedItemData
            {
                ItemName = "TrophyUlv", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Ulv trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyWolf"] = new SharedItemData
            {
                ItemName = "TrophyWolf", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Wolf trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["TrophyWraith"] = new SharedItemData
            {
                ItemName = "TrophyWraith", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Wraith trophy",
                MaxQuality = 1, ItemType = (ItemType)13,
            },
            ["Turnip"] = new SharedItemData
            {
                ItemName = "Turnip", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Turnip",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["TurnipSeeds"] = new SharedItemData
            {
                ItemName = "TurnipSeeds", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "Turnip seeds",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["TurnipStew"] = new SharedItemData
            {
                ItemName = "TurnipStew", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "Turnip stew",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["Ulv_attack1_bite"] = new SharedItemData
            {
                ItemName = "Ulv_attack1_bite", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Bite Attack",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Ulv_attack2_slash"] = new SharedItemData
            {
                ItemName = "Ulv_attack2_slash", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Slash Attack",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["VegvisirShard_Bonemass"] = new SharedItemData
            {
                ItemName = "VegvisirShard_Bonemass", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "Yagluth thing",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Wishbone"] = new SharedItemData
            {
                ItemName = "Wishbone", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Wishbone",
                MaxQuality = 1, ItemType = (ItemType)18,
            },
            ["WitheredBone"] = new SharedItemData
            {
                ItemName = "WitheredBone", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "Withered bone",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["WolfClaw"] = new SharedItemData
            {
                ItemName = "WolfClaw", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Fenris claw",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["WolfFang"] = new SharedItemData
            {
                ItemName = "WolfFang", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Wolf fang",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["WolfHairBundle"] = new SharedItemData
            {
                ItemName = "WolfHairBundle", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Fenris hair",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["WolfJerky"] = new SharedItemData
            {
                ItemName = "WolfJerky", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Wolf jerky",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["WolfMeat"] = new SharedItemData
            {
                ItemName = "WolfMeat", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Wolf meat",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["WolfMeatSkewer"] = new SharedItemData
            {
                ItemName = "WolfMeatSkewer", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Wolf skewer",
                MaxQuality = 1, ItemType = (ItemType)2,
            },
            ["WolfPelt"] = new SharedItemData
            {
                ItemName = "WolfPelt", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Wolf pelt",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["Wolf_Attack1"] = new SharedItemData
            {
                ItemName = "Wolf_Attack1", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "WolfAttack1",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Wolf_Attack2"] = new SharedItemData
            {
                ItemName = "Wolf_Attack2", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "WolfAttack2",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Wolf_Attack3"] = new SharedItemData
            {
                ItemName = "Wolf_Attack3", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "WolfAttack3",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["Wood"] = new SharedItemData
            {
                ItemName = "Wood", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Wood",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["wraith_melee"] = new SharedItemData
            {
                ItemName = "wraith_melee", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Wraith melee",
                MaxQuality = 1, ItemType = (ItemType)3,
            },
            ["YagluthDrop"] = new SharedItemData
            {
                ItemName = "YagluthDrop", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "Yagluth thing",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
            ["YmirRemains"] = new SharedItemData
            {
                ItemName = "YmirRemains", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "Ymir flesh",
                MaxQuality = 1, ItemType = (ItemType)1,
            },
        };

        public static SharedItemData TryFindSharedData(string itemName) => 
            ItemData.TryGetValue(itemName, out SharedItemData sharedData) ? sharedData : null;

        public static IEnumerable<SharedItemData> AllItems => ItemData.Values;
    }
}

