using System.Collections.Generic;
using Loki;

namespace Loki
{
    class SharedItemData
    {
        public string ItemName { get; set; }
        public bool IsTeleportable { get; set; }
        public bool UsesDurability { get; set; }
        public double MaxDurability { get; set; }
        public double DurabilityPerLevel { get; set; }
        public int MaxStack { get; set; }
        public string DisplayName { get; set; }
    }

    public static class ItemDb
    {
        private static readonly Dictionary<string, SharedItemData> ItemData = new Dictionary<string, SharedItemData>
        {
            ["Amber"] = new SharedItemData
            {
                ItemName = "Amber", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_amber",
            },
            ["AmberPearl"] = new SharedItemData
            {
                ItemName = "AmberPearl", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_amberpearl",
            },
            ["AncientSeed"] = new SharedItemData
            {
                ItemName = "AncientSeed", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_ancientseed",
            },
            ["ArmorBronzeChest"] = new SharedItemData
            {
                ItemName = "ArmorBronzeChest", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "$item_chest_bronze",
            },
            ["ArmorBronzeLegs"] = new SharedItemData
            {
                ItemName = "ArmorBronzeLegs", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "$item_legs_bronze",
            },
            ["ArmorIronChest"] = new SharedItemData
            {
                ItemName = "ArmorIronChest", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "$item_chest_iron",
            },
            ["ArmorIronLegs"] = new SharedItemData
            {
                ItemName = "ArmorIronLegs", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "$item_legs_iron",
            },
            ["ArmorLeatherChest"] = new SharedItemData
            {
                ItemName = "ArmorLeatherChest", IsTeleportable = true, UsesDurability = true, MaxDurability = 400,
                DurabilityPerLevel = 100, MaxStack = 1, DisplayName = "$item_chest_leather",
            },
            ["ArmorLeatherLegs"] = new SharedItemData
            {
                ItemName = "ArmorLeatherLegs", IsTeleportable = true, UsesDurability = true, MaxDurability = 400,
                DurabilityPerLevel = 100, MaxStack = 1, DisplayName = "$item_legs_leather",
            },
            ["ArmorPaddedCuirass"] = new SharedItemData
            {
                ItemName = "ArmorPaddedCuirass", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "$item_chest_pcuirass",
            },
            ["ArmorPaddedGreaves"] = new SharedItemData
            {
                ItemName = "ArmorPaddedGreaves", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "$item_legs_pgreaves",
            },
            ["ArmorRagsChest"] = new SharedItemData
            {
                ItemName = "ArmorRagsChest", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_chest_rags",
            },
            ["ArmorRagsLegs"] = new SharedItemData
            {
                ItemName = "ArmorRagsLegs", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_legs_rags",
            },
            ["ArmorTrollLeatherChest"] = new SharedItemData
            {
                ItemName = "ArmorTrollLeatherChest", IsTeleportable = true, UsesDurability = true, MaxDurability = 500,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "$item_chest_trollleather",
            },
            ["ArmorTrollLeatherLegs"] = new SharedItemData
            {
                ItemName = "ArmorTrollLeatherLegs", IsTeleportable = true, UsesDurability = true, MaxDurability = 500,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "$item_legs_trollleather",
            },
            ["ArmorWolfChest"] = new SharedItemData
            {
                ItemName = "ArmorWolfChest", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "$item_chest_wolf",
            },
            ["ArmorWolfLegs"] = new SharedItemData
            {
                ItemName = "ArmorWolfLegs", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "$item_legs_wolf",
            },
            ["ArrowBronze"] = new SharedItemData
            {
                ItemName = "ArrowBronze", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "$item_arrow_bronze",
            },
            ["ArrowFire"] = new SharedItemData
            {
                ItemName = "ArrowFire", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "$item_arrow_fire",
            },
            ["ArrowFlint"] = new SharedItemData
            {
                ItemName = "ArrowFlint", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "$item_arrow_flint",
            },
            ["ArrowFrost"] = new SharedItemData
            {
                ItemName = "ArrowFrost", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "$item_arrow_frost",
            },
            ["ArrowIron"] = new SharedItemData
            {
                ItemName = "ArrowIron", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "$item_arrow_iron",
            },
            ["ArrowNeedle"] = new SharedItemData
            {
                ItemName = "ArrowNeedle", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "$item_arrow_needle",
            },
            ["ArrowObsidian"] = new SharedItemData
            {
                ItemName = "ArrowObsidian", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "$item_arrow_obsidian",
            },
            ["ArrowPoison"] = new SharedItemData
            {
                ItemName = "ArrowPoison", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "$item_arrow_poison",
            },
            ["ArrowSilver"] = new SharedItemData
            {
                ItemName = "ArrowSilver", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "$item_arrow_silver",
            },
            ["ArrowWood"] = new SharedItemData
            {
                ItemName = "ArrowWood", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "$item_arrow_wood",
            },
            ["AtgeirBlackmetal"] = new SharedItemData
            {
                ItemName = "AtgeirBlackmetal", IsTeleportable = true, UsesDurability = true, MaxDurability = 175,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_atgeir_blackmetal",
            },
            ["AtgeirBronze"] = new SharedItemData
            {
                ItemName = "AtgeirBronze", IsTeleportable = true, UsesDurability = true, MaxDurability = 125,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_atgeir_bronze",
            },
            ["AtgeirIron"] = new SharedItemData
            {
                ItemName = "AtgeirIron", IsTeleportable = true, UsesDurability = true, MaxDurability = 175,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_atgeir_iron",
            },
            ["AxeBlackMetal"] = new SharedItemData
            {
                ItemName = "AxeBlackMetal", IsTeleportable = true, UsesDurability = true, MaxDurability = 175,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_axe_blackmetal",
            },
            ["AxeBronze"] = new SharedItemData
            {
                ItemName = "AxeBronze", IsTeleportable = true, UsesDurability = true, MaxDurability = 125,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_axe_bronze",
            },
            ["AxeFlint"] = new SharedItemData
            {
                ItemName = "AxeFlint", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 30, MaxStack = 1, DisplayName = "$item_axe_flint",
            },
            ["AxeIron"] = new SharedItemData
            {
                ItemName = "AxeIron", IsTeleportable = true, UsesDurability = true, MaxDurability = 175,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_axe_iron",
            },
            ["AxeStone"] = new SharedItemData
            {
                ItemName = "AxeStone", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 30, MaxStack = 1, DisplayName = "$item_axe_stone",
            },
            ["Barley"] = new SharedItemData
            {
                ItemName = "Barley", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "$item_barley",
            },
            ["BarleyFlour"] = new SharedItemData
            {
                ItemName = "BarleyFlour", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_barleyflour",
            },
            ["BarleyWine"] = new SharedItemData
            {
                ItemName = "BarleyWine", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "$item_barleywine",
            },
            ["BarleyWineBase"] = new SharedItemData
            {
                ItemName = "BarleyWineBase", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_barleywinebase",
            },
            ["Battleaxe"] = new SharedItemData
            {
                ItemName = "Battleaxe", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_battleaxe",
            },
            ["Beard1"] = new SharedItemData
            {
                ItemName = "Beard1", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$customization_beard01",
            },
            ["Beard10"] = new SharedItemData
            {
                ItemName = "Beard10", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$customization_beard10",
            },
            ["Beard2"] = new SharedItemData
            {
                ItemName = "Beard2", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$customization_beard02",
            },
            ["Beard3"] = new SharedItemData
            {
                ItemName = "Beard3", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$customization_beard03",
            },
            ["Beard4"] = new SharedItemData
            {
                ItemName = "Beard4", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$customization_beard04",
            },
            ["Beard5"] = new SharedItemData
            {
                ItemName = "Beard5", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$customization_beard05",
            },
            ["Beard6"] = new SharedItemData
            {
                ItemName = "Beard6", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$customization_beard06",
            },
            ["Beard7"] = new SharedItemData
            {
                ItemName = "Beard7", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$customization_beard07",
            },
            ["Beard8"] = new SharedItemData
            {
                ItemName = "Beard8", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$customization_beard08",
            },
            ["Beard9"] = new SharedItemData
            {
                ItemName = "Beard9", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$customization_beard09",
            },
            ["BeardNone"] = new SharedItemData
            {
                ItemName = "BeardNone", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$customization_nobeard",
            },
            ["BeechSeeds"] = new SharedItemData
            {
                ItemName = "BeechSeeds", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "$item_beechseeds",
            },
            ["BeltStrength"] = new SharedItemData
            {
                ItemName = "BeltStrength", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_beltstrength",
            },
            ["BlackMetal"] = new SharedItemData
            {
                ItemName = "BlackMetal", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "$item_blackmetal",
            },
            ["BlackMetalScrap"] = new SharedItemData
            {
                ItemName = "BlackMetalScrap", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "$item_blackmetalscrap",
            },
            ["blobelite_attack_aoe"] = new SharedItemData
            {
                ItemName = "blobelite_attack_aoe", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "fart",
            },
            ["blob_attack_aoe"] = new SharedItemData
            {
                ItemName = "blob_attack_aoe", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "fart",
            },
            ["Bloodbag"] = new SharedItemData
            {
                ItemName = "Bloodbag", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_bloodbag",
            },
            ["BloodPudding"] = new SharedItemData
            {
                ItemName = "BloodPudding", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "$item_bloodpudding",
            },
            ["Blueberries"] = new SharedItemData
            {
                ItemName = "Blueberries", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_blueberries",
            },
            ["boar_base_attack"] = new SharedItemData
            {
                ItemName = "boar_base_attack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "boar attack1",
            },
            ["BombOoze"] = new SharedItemData
            {
                ItemName = "BombOoze", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_oozebomb",
            },
            ["BoneFragments"] = new SharedItemData
            {
                ItemName = "BoneFragments", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_bonefragments",
            },
            ["bonemass_attack_aoe"] = new SharedItemData
            {
                ItemName = "bonemass_attack_aoe", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "heal",
            },
            ["bonemass_attack_punch"] = new SharedItemData
            {
                ItemName = "bonemass_attack_punch", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "slap",
            },
            ["bonemass_attack_spawn"] = new SharedItemData
            {
                ItemName = "bonemass_attack_spawn", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "heal",
            },
            ["bonemass_attack_throw"] = new SharedItemData
            {
                ItemName = "bonemass_attack_throw", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "slime throw",
            },
            ["Bow"] = new SharedItemData
            {
                ItemName = "Bow", IsTeleportable = true, UsesDurability = true, MaxDurability = 50,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_bow",
            },
            ["BowDraugrFang"] = new SharedItemData
            {
                ItemName = "BowDraugrFang", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_bow_draugrfang",
            },
            ["BowFineWood"] = new SharedItemData
            {
                ItemName = "BowFineWood", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_bow_finewood",
            },
            ["BowHuntsman"] = new SharedItemData
            {
                ItemName = "BowHuntsman", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_bow_huntsman",
            },
            ["Bread"] = new SharedItemData
            {
                ItemName = "Bread", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_bread",
            },
            ["Bronze"] = new SharedItemData
            {
                ItemName = "Bronze", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "$item_bronze",
            },
            ["BronzeNails"] = new SharedItemData
            {
                ItemName = "BronzeNails", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "$item_bronzenails",
            },
            ["CapeDeerHide"] = new SharedItemData
            {
                ItemName = "CapeDeerHide", IsTeleportable = true, UsesDurability = true, MaxDurability = 400,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_cape_deerhide",
            },
            ["CapeLinen"] = new SharedItemData
            {
                ItemName = "CapeLinen", IsTeleportable = true, UsesDurability = true, MaxDurability = 1500,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_cape_linen",
            },
            ["CapeLox"] = new SharedItemData
            {
                ItemName = "CapeLox", IsTeleportable = true, UsesDurability = true, MaxDurability = 1200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_cape_lox",
            },
            ["CapeOdin"] = new SharedItemData
            {
                ItemName = "CapeOdin", IsTeleportable = true, UsesDurability = true, MaxDurability = 1500,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_cape_odin",
            },
            ["CapeTest"] = new SharedItemData
            {
                ItemName = "CapeTest", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "CAPE TEST",
            },
            ["CapeTrollHide"] = new SharedItemData
            {
                ItemName = "CapeTrollHide", IsTeleportable = true, UsesDurability = true, MaxDurability = 500,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_cape_trollhide",
            },
            ["CapeWolf"] = new SharedItemData
            {
                ItemName = "CapeWolf", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "$item_cape_wolf",
            },
            ["Carrot"] = new SharedItemData
            {
                ItemName = "Carrot", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_carrot",
            },
            ["CarrotSeeds"] = new SharedItemData
            {
                ItemName = "CarrotSeeds", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "$item_carrotseeds",
            },
            ["CarrotSoup"] = new SharedItemData
            {
                ItemName = "CarrotSoup", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "$item_carrotsoup",
            },
            ["Chain"] = new SharedItemData
            {
                ItemName = "Chain", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_chain",
            },
            ["Chitin"] = new SharedItemData
            {
                ItemName = "Chitin", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_chitin",
            },
            ["Cloudberry"] = new SharedItemData
            {
                ItemName = "Cloudberry", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_cloudberries",
            },
            ["Club"] = new SharedItemData
            {
                ItemName = "Club", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_club",
            },
            ["Coal"] = new SharedItemData
            {
                ItemName = "Coal", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_coal",
            },
            ["Coins"] = new SharedItemData
            {
                ItemName = "Coins", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 999, DisplayName = "$item_coins",
            },
            ["CookedLoxMeat"] = new SharedItemData
            {
                ItemName = "CookedLoxMeat", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_loxmeat_cooked",
            },
            ["CookedMeat"] = new SharedItemData
            {
                ItemName = "CookedMeat", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_meat_cooked",
            },
            ["Copper"] = new SharedItemData
            {
                ItemName = "Copper", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "$item_copper",
            },
            ["CopperOre"] = new SharedItemData
            {
                ItemName = "CopperOre", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "$item_copperore",
            },
            ["CryptKey"] = new SharedItemData
            {
                ItemName = "CryptKey", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_cryptkey",
            },
            ["Crystal"] = new SharedItemData
            {
                ItemName = "Crystal", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_crystal",
            },
            ["Cultivator"] = new SharedItemData
            {
                ItemName = "Cultivator", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "$item_cultivator",
            },
            ["Dandelion"] = new SharedItemData
            {
                ItemName = "Dandelion", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_dandelion",
            },
            ["Deathsquito_sting"] = new SharedItemData
            {
                ItemName = "Deathsquito_sting", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Wraith melee",
            },
            ["DeerHide"] = new SharedItemData
            {
                ItemName = "DeerHide", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_deerhide",
            },
            ["DragonEgg"] = new SharedItemData
            {
                ItemName = "DragonEgg", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_dragonegg",
            },
            ["DragonTear"] = new SharedItemData
            {
                ItemName = "DragonTear", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_dragontear",
            },
            ["dragon_bite"] = new SharedItemData
            {
                ItemName = "dragon_bite", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Dragon claw left",
            },
            ["dragon_claw_left"] = new SharedItemData
            {
                ItemName = "dragon_claw_left", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Dragon claw left",
            },
            ["dragon_claw_right"] = new SharedItemData
            {
                ItemName = "dragon_claw_right", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Dragon claw left",
            },
            ["dragon_coldbreath"] = new SharedItemData
            {
                ItemName = "dragon_coldbreath", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "dragon breath",
            },
            ["dragon_coldbreath_OLD"] = new SharedItemData
            {
                ItemName = "dragon_coldbreath_OLD", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "dragon breath",
            },
            ["dragon_spit_shotgun"] = new SharedItemData
            {
                ItemName = "dragon_spit_shotgun", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "cold ball",
            },
            ["dragon_taunt"] = new SharedItemData
            {
                ItemName = "dragon_taunt", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "scream",
            },
            ["draugr_arrow"] = new SharedItemData
            {
                ItemName = "draugr_arrow", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "Ironhead arrow",
            },
            ["draugr_axe"] = new SharedItemData
            {
                ItemName = "draugr_axe", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Dragur axe",
            },
            ["draugr_bow"] = new SharedItemData
            {
                ItemName = "draugr_bow", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Bow",
            },
            ["draugr_sword"] = new SharedItemData
            {
                ItemName = "draugr_sword", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Dragur axe",
            },
            ["Eikthyr_antler"] = new SharedItemData
            {
                ItemName = "Eikthyr_antler", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "StagAttack1",
            },
            ["Eikthyr_charge"] = new SharedItemData
            {
                ItemName = "Eikthyr_charge", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "StagAttack2",
            },
            ["Eikthyr_flegs_OLD"] = new SharedItemData
            {
                ItemName = "Eikthyr_flegs_OLD", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "StagAttack1",
            },
            ["Eikthyr_stomp"] = new SharedItemData
            {
                ItemName = "Eikthyr_stomp", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "slap",
            },
            ["ElderBark"] = new SharedItemData
            {
                ItemName = "ElderBark", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_elderbark",
            },
            ["Entrails"] = new SharedItemData
            {
                ItemName = "Entrails", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_entrails",
            },
            ["Feathers"] = new SharedItemData
            {
                ItemName = "Feathers", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_feathers",
            },
            ["Fenring_attack_claw"] = new SharedItemData
            {
                ItemName = "Fenring_attack_claw", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "claw",
            },
            ["Fenring_attack_jump"] = new SharedItemData
            {
                ItemName = "Fenring_attack_jump", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "claw",
            },
            ["Fenring_taunt"] = new SharedItemData
            {
                ItemName = "Fenring_taunt", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "scream",
            },
            ["FineWood"] = new SharedItemData
            {
                ItemName = "FineWood", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_finewood",
            },
            ["FirCone"] = new SharedItemData
            {
                ItemName = "FirCone", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "$item_fircone",
            },
            ["FishCooked"] = new SharedItemData
            {
                ItemName = "FishCooked", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_fish_cooked",
            },
            ["FishingBait"] = new SharedItemData
            {
                ItemName = "FishingBait", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "$item_fishingbait",
            },
            ["FishingRod"] = new SharedItemData
            {
                ItemName = "FishingRod", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_fishingrod",
            },
            ["FishRaw"] = new SharedItemData
            {
                ItemName = "FishRaw", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_fish_raw",
            },
            ["FishWraps"] = new SharedItemData
            {
                ItemName = "FishWraps", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "$item_fishwraps",
            },
            ["Flametal"] = new SharedItemData
            {
                ItemName = "Flametal", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "$item_flametal",
            },
            ["FlametalOre"] = new SharedItemData
            {
                ItemName = "FlametalOre", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "$item_flametalore",
            },
            ["Flax"] = new SharedItemData
            {
                ItemName = "Flax", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "$item_flax",
            },
            ["Flint"] = new SharedItemData
            {
                ItemName = "Flint", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "$item_flint",
            },
            ["FreezeGland"] = new SharedItemData
            {
                ItemName = "FreezeGland", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_freezegland",
            },
            ["gd_king_punch"] = new SharedItemData
            {
                ItemName = "gd_king_punch", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "jaws",
            },
            ["gd_king_rootspawn"] = new SharedItemData
            {
                ItemName = "gd_king_rootspawn", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "spawn",
            },
            ["gd_king_scream"] = new SharedItemData
            {
                ItemName = "gd_king_scream", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "scream",
            },
            ["gd_king_shoot"] = new SharedItemData
            {
                ItemName = "gd_king_shoot", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "shaman attack",
            },
            ["gd_king_stomp"] = new SharedItemData
            {
                ItemName = "gd_king_stomp", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "jaws",
            },
            ["Ghost_attack"] = new SharedItemData
            {
                ItemName = "Ghost_attack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "jaws",
            },
            ["GoblinArmband"] = new SharedItemData
            {
                ItemName = "GoblinArmband", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Iron plate armor",
            },
            ["GoblinBrute_ArmGuard"] = new SharedItemData
            {
                ItemName = "GoblinBrute_ArmGuard", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Iron plate armor",
            },
            ["GoblinBrute_Attack"] = new SharedItemData
            {
                ItemName = "GoblinBrute_Attack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Brute sword",
            },
            ["GoblinBrute_Backbones"] = new SharedItemData
            {
                ItemName = "GoblinBrute_Backbones", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Iron plate armor",
            },
            ["GoblinBrute_ExecutionerCap"] = new SharedItemData
            {
                ItemName = "GoblinBrute_ExecutionerCap", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Iron plate armor",
            },
            ["GoblinBrute_HipCloth"] = new SharedItemData
            {
                ItemName = "GoblinBrute_HipCloth", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Iron plate armor",
            },
            ["GoblinBrute_LegBones"] = new SharedItemData
            {
                ItemName = "GoblinBrute_LegBones", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Iron plate armor",
            },
            ["GoblinBrute_RageAttack"] = new SharedItemData
            {
                ItemName = "GoblinBrute_RageAttack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Brute sword",
            },
            ["GoblinBrute_ShoulderGuard"] = new SharedItemData
            {
                ItemName = "GoblinBrute_ShoulderGuard", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Iron plate armor",
            },
            ["GoblinBrute_Taunt"] = new SharedItemData
            {
                ItemName = "GoblinBrute_Taunt", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Brute taunt",
            },
            ["GoblinClub"] = new SharedItemData
            {
                ItemName = "GoblinClub", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Club",
            },
            ["GoblinHelmet"] = new SharedItemData
            {
                ItemName = "GoblinHelmet", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Iron plate armor",
            },
            ["GoblinKing_Beam"] = new SharedItemData
            {
                ItemName = "GoblinKing_Beam", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "dragon breath",
            },
            ["GoblinKing_Meteors"] = new SharedItemData
            {
                ItemName = "GoblinKing_Meteors", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "spawn",
            },
            ["GoblinKing_Nova"] = new SharedItemData
            {
                ItemName = "GoblinKing_Nova", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "slap",
            },
            ["GoblinKing_Taunt"] = new SharedItemData
            {
                ItemName = "GoblinKing_Taunt", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "scream",
            },
            ["GoblinLegband"] = new SharedItemData
            {
                ItemName = "GoblinLegband", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Iron plate armor",
            },
            ["GoblinLoin"] = new SharedItemData
            {
                ItemName = "GoblinLoin", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Iron plate armor",
            },
            ["GoblinShaman_attack_fireball"] = new SharedItemData
            {
                ItemName = "GoblinShaman_attack_fireball", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "fireballattack",
            },
            ["GoblinShaman_attack_poke"] = new SharedItemData
            {
                ItemName = "GoblinShaman_attack_poke", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Club",
            },
            ["GoblinShaman_attack_protect"] = new SharedItemData
            {
                ItemName = "GoblinShaman_attack_protect", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "heal",
            },
            ["GoblinShaman_Headdress_antlers"] = new SharedItemData
            {
                ItemName = "GoblinShaman_Headdress_antlers", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Club",
            },
            ["GoblinShaman_Headdress_feathers"] = new SharedItemData
            {
                ItemName = "GoblinShaman_Headdress_feathers", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Club",
            },
            ["GoblinShaman_Staff_Bones"] = new SharedItemData
            {
                ItemName = "GoblinShaman_Staff_Bones", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Club",
            },
            ["GoblinShaman_Staff_Feathers"] = new SharedItemData
            {
                ItemName = "GoblinShaman_Staff_Feathers", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Club",
            },
            ["GoblinShoulders"] = new SharedItemData
            {
                ItemName = "GoblinShoulders", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Iron plate armor",
            },
            ["GoblinSpear"] = new SharedItemData
            {
                ItemName = "GoblinSpear", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "Flint spear",
            },
            ["GoblinSword"] = new SharedItemData
            {
                ItemName = "GoblinSword", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Bronze sword",
            },
            ["GoblinTorch"] = new SharedItemData
            {
                ItemName = "GoblinTorch", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Torch",
            },
            ["GoblinTotem"] = new SharedItemData
            {
                ItemName = "GoblinTotem", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "$item_goblintotem",
            },
            ["GreydwarfEye"] = new SharedItemData
            {
                ItemName = "GreydwarfEye", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_greydwarfeye",
            },
            ["Greydwarf_attack"] = new SharedItemData
            {
                ItemName = "Greydwarf_attack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "jaws",
            },
            ["Greydwarf_elite_attack"] = new SharedItemData
            {
                ItemName = "Greydwarf_elite_attack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "jaws",
            },
            ["Greydwarf_shaman_attack"] = new SharedItemData
            {
                ItemName = "Greydwarf_shaman_attack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "shaman attack",
            },
            ["Greydwarf_shaman_heal"] = new SharedItemData
            {
                ItemName = "Greydwarf_shaman_heal", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "heal",
            },
            ["Greydwarf_throw"] = new SharedItemData
            {
                ItemName = "Greydwarf_throw", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "throw stone",
            },
            ["Greyling_attack"] = new SharedItemData
            {
                ItemName = "Greyling_attack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "jaws",
            },
            ["Guck"] = new SharedItemData
            {
                ItemName = "Guck", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_guck",
            },
            ["Hair1"] = new SharedItemData
            {
                ItemName = "Hair1", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$customization_hair01",
            },
            ["Hair10"] = new SharedItemData
            {
                ItemName = "Hair10", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$customization_hair10",
            },
            ["Hair11"] = new SharedItemData
            {
                ItemName = "Hair11", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$customization_hair11",
            },
            ["Hair12"] = new SharedItemData
            {
                ItemName = "Hair12", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$customization_hair12",
            },
            ["Hair13"] = new SharedItemData
            {
                ItemName = "Hair13", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$customization_hair13",
            },
            ["Hair14"] = new SharedItemData
            {
                ItemName = "Hair14", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$customization_hair14",
            },
            ["Hair2"] = new SharedItemData
            {
                ItemName = "Hair2", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$customization_hair02",
            },
            ["Hair3"] = new SharedItemData
            {
                ItemName = "Hair3", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$customization_hair03",
            },
            ["Hair4"] = new SharedItemData
            {
                ItemName = "Hair4", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$customization_hair04",
            },
            ["Hair5"] = new SharedItemData
            {
                ItemName = "Hair5", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$customization_hair05",
            },
            ["Hair6"] = new SharedItemData
            {
                ItemName = "Hair6", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$customization_hair06",
            },
            ["Hair7"] = new SharedItemData
            {
                ItemName = "Hair7", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$customization_hair07",
            },
            ["Hair8"] = new SharedItemData
            {
                ItemName = "Hair8", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$customization_hair08",
            },
            ["Hair9"] = new SharedItemData
            {
                ItemName = "Hair9", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$customization_hair09",
            },
            ["HairNone"] = new SharedItemData
            {
                ItemName = "HairNone", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$customization_nohair",
            },
            ["Hammer"] = new SharedItemData
            {
                ItemName = "Hammer", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 100, MaxStack = 1, DisplayName = "$item_hammer",
            },
            ["HardAntler"] = new SharedItemData
            {
                ItemName = "HardAntler", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_hardantler",
            },
            ["hatchling_spit_cold"] = new SharedItemData
            {
                ItemName = "hatchling_spit_cold", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "cold ball",
            },
            ["HealthUpgrade_Bonemass"] = new SharedItemData
            {
                ItemName = "HealthUpgrade_Bonemass", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Bonemass heart",
            },
            ["HealthUpgrade_GDKing"] = new SharedItemData
            {
                ItemName = "HealthUpgrade_GDKing", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Elder heart",
            },
            ["HelmetBronze"] = new SharedItemData
            {
                ItemName = "HelmetBronze", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "$item_helmet_bronze",
            },
            ["HelmetDrake"] = new SharedItemData
            {
                ItemName = "HelmetDrake", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "$item_helmet_drake",
            },
            ["HelmetDverger"] = new SharedItemData
            {
                ItemName = "HelmetDverger", IsTeleportable = true, UsesDurability = false, MaxDurability = 1000,
                DurabilityPerLevel = 100, MaxStack = 1, DisplayName = "$item_helmet_dverger",
            },
            ["HelmetIron"] = new SharedItemData
            {
                ItemName = "HelmetIron", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "$item_helmet_iron",
            },
            ["HelmetLeather"] = new SharedItemData
            {
                ItemName = "HelmetLeather", IsTeleportable = true, UsesDurability = true, MaxDurability = 400,
                DurabilityPerLevel = 100, MaxStack = 1, DisplayName = "$item_helmet_leather",
            },
            ["HelmetOdin"] = new SharedItemData
            {
                ItemName = "HelmetOdin", IsTeleportable = true, UsesDurability = true, MaxDurability = 300,
                DurabilityPerLevel = 100, MaxStack = 1, DisplayName = "$item_helmet_odin",
            },
            ["HelmetPadded"] = new SharedItemData
            {
                ItemName = "HelmetPadded", IsTeleportable = true, UsesDurability = true, MaxDurability = 1000,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "$item_helmet_padded",
            },
            ["HelmetTrollLeather"] = new SharedItemData
            {
                ItemName = "HelmetTrollLeather", IsTeleportable = true, UsesDurability = true, MaxDurability = 500,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "$item_helmet_trollleather",
            },
            ["HelmetYule"] = new SharedItemData
            {
                ItemName = "HelmetYule", IsTeleportable = true, UsesDurability = false, MaxDurability = 1000,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_helmet_yule",
            },
            ["Hoe"] = new SharedItemData
            {
                ItemName = "Hoe", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 200, MaxStack = 1, DisplayName = "$item_hoe",
            },
            ["Honey"] = new SharedItemData
            {
                ItemName = "Honey", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_honey",
            },
            ["imp_fireball_attack"] = new SharedItemData
            {
                ItemName = "imp_fireball_attack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "fireballattack",
            },
            ["Iron"] = new SharedItemData
            {
                ItemName = "Iron", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "$item_iron",
            },
            ["IronNails"] = new SharedItemData
            {
                ItemName = "IronNails", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "$item_ironnails",
            },
            ["IronOre"] = new SharedItemData
            {
                ItemName = "IronOre", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "$item_ironore",
            },
            ["IronScrap"] = new SharedItemData
            {
                ItemName = "IronScrap", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "$item_ironscrap",
            },
            ["KnifeBlackMetal"] = new SharedItemData
            {
                ItemName = "KnifeBlackMetal", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_knife_blackmetal",
            },
            ["KnifeChitin"] = new SharedItemData
            {
                ItemName = "KnifeChitin", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_knife_chitin",
            },
            ["KnifeCopper"] = new SharedItemData
            {
                ItemName = "KnifeCopper", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_knife_copper",
            },
            ["KnifeFlint"] = new SharedItemData
            {
                ItemName = "KnifeFlint", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_knife_flint",
            },
            ["LeatherScraps"] = new SharedItemData
            {
                ItemName = "LeatherScraps", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_leatherscraps",
            },
            ["Leech_BiteAttack"] = new SharedItemData
            {
                ItemName = "Leech_BiteAttack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "jaws",
            },
            ["LinenThread"] = new SharedItemData
            {
                ItemName = "LinenThread", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_linenthread",
            },
            ["LoxMeat"] = new SharedItemData
            {
                ItemName = "LoxMeat", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_loxmeat",
            },
            ["LoxPelt"] = new SharedItemData
            {
                ItemName = "LoxPelt", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_loxpelt",
            },
            ["LoxPie"] = new SharedItemData
            {
                ItemName = "LoxPie", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "$item_loxpie",
            },
            ["lox_bite"] = new SharedItemData
            {
                ItemName = "lox_bite", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "lox bite",
            },
            ["lox_stomp"] = new SharedItemData
            {
                ItemName = "lox_stomp", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "slap",
            },
            ["MaceBronze"] = new SharedItemData
            {
                ItemName = "MaceBronze", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_mace_bronze",
            },
            ["MaceIron"] = new SharedItemData
            {
                ItemName = "MaceIron", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_mace_iron",
            },
            ["MaceNeedle"] = new SharedItemData
            {
                ItemName = "MaceNeedle", IsTeleportable = true, UsesDurability = true, MaxDurability = 150,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_mace_needle",
            },
            ["MaceSilver"] = new SharedItemData
            {
                ItemName = "MaceSilver", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_mace_silver",
            },
            ["MeadBaseFrostResist"] = new SharedItemData
            {
                ItemName = "MeadBaseFrostResist", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_meadbasefrostresist",
            },
            ["MeadBaseHealthMedium"] = new SharedItemData
            {
                ItemName = "MeadBaseHealthMedium", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_meadbasehealth_medium",
            },
            ["MeadBaseHealthMinor"] = new SharedItemData
            {
                ItemName = "MeadBaseHealthMinor", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_meadbasehealth",
            },
            ["MeadBasePoisonResist"] = new SharedItemData
            {
                ItemName = "MeadBasePoisonResist", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_meadbasepoisonresist",
            },
            ["MeadBaseStaminaMedium"] = new SharedItemData
            {
                ItemName = "MeadBaseStaminaMedium", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_meadbasestamina_medium",
            },
            ["MeadBaseStaminaMinor"] = new SharedItemData
            {
                ItemName = "MeadBaseStaminaMinor", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_meadbasestamina",
            },
            ["MeadBaseTasty"] = new SharedItemData
            {
                ItemName = "MeadBaseTasty", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_meadbasetasty",
            },
            ["MeadFrostResist"] = new SharedItemData
            {
                ItemName = "MeadFrostResist", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "$item_mead_frostres",
            },
            ["MeadHealthMedium"] = new SharedItemData
            {
                ItemName = "MeadHealthMedium", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "$item_mead_hp_medium",
            },
            ["MeadHealthMinor"] = new SharedItemData
            {
                ItemName = "MeadHealthMinor", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "$item_mead_hp_minor",
            },
            ["MeadPoisonResist"] = new SharedItemData
            {
                ItemName = "MeadPoisonResist", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "$item_mead_poisonres",
            },
            ["MeadStaminaMedium"] = new SharedItemData
            {
                ItemName = "MeadStaminaMedium", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "$item_mead_stamina_medium",
            },
            ["MeadStaminaMinor"] = new SharedItemData
            {
                ItemName = "MeadStaminaMinor", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "$item_mead_stamina_minor",
            },
            ["MeadTasty"] = new SharedItemData
            {
                ItemName = "MeadTasty", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "$item_mead_tasty",
            },
            ["Mushroom"] = new SharedItemData
            {
                ItemName = "Mushroom", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_mushroomcommon",
            },
            ["MushroomBlue"] = new SharedItemData
            {
                ItemName = "MushroomBlue", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_mushroomblue",
            },
            ["MushroomYellow"] = new SharedItemData
            {
                ItemName = "MushroomYellow", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_mushroomyellow",
            },
            ["NeckTail"] = new SharedItemData
            {
                ItemName = "NeckTail", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_necktail",
            },
            ["NeckTailGrilled"] = new SharedItemData
            {
                ItemName = "NeckTailGrilled", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_necktailgrilled",
            },
            ["Neck_BiteAttack"] = new SharedItemData
            {
                ItemName = "Neck_BiteAttack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "jaws",
            },
            ["Needle"] = new SharedItemData
            {
                ItemName = "Needle", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_needle",
            },
            ["Obsidian"] = new SharedItemData
            {
                ItemName = "Obsidian", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_obsidian",
            },
            ["Ooze"] = new SharedItemData
            {
                ItemName = "Ooze", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_ooze",
            },
            ["PickaxeAntler"] = new SharedItemData
            {
                ItemName = "PickaxeAntler", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_pickaxe_antler",
            },
            ["PickaxeBronze"] = new SharedItemData
            {
                ItemName = "PickaxeBronze", IsTeleportable = true, UsesDurability = true, MaxDurability = 120,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_pickaxe_bronze",
            },
            ["PickaxeIron"] = new SharedItemData
            {
                ItemName = "PickaxeIron", IsTeleportable = true, UsesDurability = true, MaxDurability = 150,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_pickaxe_iron",
            },
            ["PickaxeStone"] = new SharedItemData
            {
                ItemName = "PickaxeStone", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_pickaxe_stone",
            },
            ["PineCone"] = new SharedItemData
            {
                ItemName = "PineCone", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "$item_pinecone",
            },
            ["PlayerUnarmed"] = new SharedItemData
            {
                ItemName = "PlayerUnarmed", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Unarmed",
            },
            ["QueenBee"] = new SharedItemData
            {
                ItemName = "QueenBee", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_queenbee",
            },
            ["QueensJam"] = new SharedItemData
            {
                ItemName = "QueensJam", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "$item_queensjam",
            },
            ["Raspberry"] = new SharedItemData
            {
                ItemName = "Raspberry", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_raspberries",
            },
            ["RawMeat"] = new SharedItemData
            {
                ItemName = "RawMeat", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_meat_raw",
            },
            ["Resin"] = new SharedItemData
            {
                ItemName = "Resin", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_resin",
            },
            ["RoundLog"] = new SharedItemData
            {
                ItemName = "RoundLog", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_roundlog",
            },
            ["Ruby"] = new SharedItemData
            {
                ItemName = "Ruby", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_ruby",
            },
            ["Sausages"] = new SharedItemData
            {
                ItemName = "Sausages", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_sausages",
            },
            ["SerpentMeat"] = new SharedItemData
            {
                ItemName = "SerpentMeat", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_serpentmeat",
            },
            ["SerpentMeatCooked"] = new SharedItemData
            {
                ItemName = "SerpentMeatCooked", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_serpentmeatcooked",
            },
            ["SerpentScale"] = new SharedItemData
            {
                ItemName = "SerpentScale", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_serpentscale",
            },
            ["SerpentStew"] = new SharedItemData
            {
                ItemName = "SerpentStew", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "$item_serpentstew",
            },
            ["Serpent_attack"] = new SharedItemData
            {
                ItemName = "Serpent_attack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Serpent bite",
            },
            ["Serpent_taunt"] = new SharedItemData
            {
                ItemName = "Serpent_taunt", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Serpent Taunt",
            },
            ["SharpeningStone"] = new SharedItemData
            {
                ItemName = "SharpeningStone", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_sharpeningstone",
            },
            ["ShieldBanded"] = new SharedItemData
            {
                ItemName = "ShieldBanded", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_shield_banded",
            },
            ["ShieldBlackmetal"] = new SharedItemData
            {
                ItemName = "ShieldBlackmetal", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_shield_blackmetal",
            },
            ["ShieldBlackmetalTower"] = new SharedItemData
            {
                ItemName = "ShieldBlackmetalTower", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_shield_blackmetal_tower",
            },
            ["ShieldBronzeBuckler"] = new SharedItemData
            {
                ItemName = "ShieldBronzeBuckler", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_shield_bronzebuckler",
            },
            ["ShieldIronSquare"] = new SharedItemData
            {
                ItemName = "ShieldIronSquare", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_shield_iron_square",
            },
            ["ShieldIronTower"] = new SharedItemData
            {
                ItemName = "ShieldIronTower", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_shield_iron_tower",
            },
            ["ShieldKnight"] = new SharedItemData
            {
                ItemName = "ShieldKnight", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Knight shield",
            },
            ["ShieldSerpentscale"] = new SharedItemData
            {
                ItemName = "ShieldSerpentscale", IsTeleportable = true, UsesDurability = true, MaxDurability = 250,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_shield_serpentscale",
            },
            ["ShieldSilver"] = new SharedItemData
            {
                ItemName = "ShieldSilver", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_shield_silver",
            },
            ["ShieldWood"] = new SharedItemData
            {
                ItemName = "ShieldWood", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_shield_wood",
            },
            ["ShieldWoodTower"] = new SharedItemData
            {
                ItemName = "ShieldWoodTower", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_shield_woodtower",
            },
            ["Silver"] = new SharedItemData
            {
                ItemName = "Silver", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "$item_silver",
            },
            ["SilverNecklace"] = new SharedItemData
            {
                ItemName = "SilverNecklace", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_silvernecklace",
            },
            ["SilverOre"] = new SharedItemData
            {
                ItemName = "SilverOre", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "$item_silverore",
            },
            ["skeleton_bow"] = new SharedItemData
            {
                ItemName = "skeleton_bow", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Bow",
            },
            ["skeleton_mace"] = new SharedItemData
            {
                ItemName = "skeleton_mace", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Dragur axe",
            },
            ["skeleton_sword"] = new SharedItemData
            {
                ItemName = "skeleton_sword", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Dragur axe",
            },
            ["SledgeIron"] = new SharedItemData
            {
                ItemName = "SledgeIron", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_sledge_iron",
            },
            ["SledgeStagbreaker"] = new SharedItemData
            {
                ItemName = "SledgeStagbreaker", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_stagbreaker",
            },
            ["SpearBronze"] = new SharedItemData
            {
                ItemName = "SpearBronze", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_spear_bronze",
            },
            ["SpearChitin"] = new SharedItemData
            {
                ItemName = "SpearChitin", IsTeleportable = true, UsesDurability = true, MaxDurability = 50,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_spear_chitin",
            },
            ["SpearElderbark"] = new SharedItemData
            {
                ItemName = "SpearElderbark", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_spear_ancientbark",
            },
            ["SpearFlint"] = new SharedItemData
            {
                ItemName = "SpearFlint", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_spear_flint",
            },
            ["SpearWolfFang"] = new SharedItemData
            {
                ItemName = "SpearWolfFang", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_spear_wolffang",
            },
            ["StaminaUpgrade_Greydwarf"] = new SharedItemData
            {
                ItemName = "StaminaUpgrade_Greydwarf", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Stamina Greydwarf",
            },
            ["StaminaUpgrade_Troll"] = new SharedItemData
            {
                ItemName = "StaminaUpgrade_Troll", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Stamina Troll",
            },
            ["StaminaUpgrade_Wraith"] = new SharedItemData
            {
                ItemName = "StaminaUpgrade_Wraith", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Stamina Wraith",
            },
            ["Stone"] = new SharedItemData
            {
                ItemName = "Stone", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_stone",
            },
            ["stonegolem_attack1_spike"] = new SharedItemData
            {
                ItemName = "stonegolem_attack1_spike", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Spike attack",
            },
            ["stonegolem_attack2_left_groundslam"] = new SharedItemData
            {
                ItemName = "stonegolem_attack2_left_groundslam", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "One hand ground slam",
            },
            ["stonegolem_attack3_spikesweep"] = new SharedItemData
            {
                ItemName = "stonegolem_attack3_spikesweep", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Spike sweep",
            },
            ["stonegolem_attack_doublesmash"] = new SharedItemData
            {
                ItemName = "stonegolem_attack_doublesmash", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "slap",
            },
            ["stonegolem_attack_sonicboom_NOTUSED"] = new SharedItemData
            {
                ItemName = "stonegolem_attack_sonicboom_NOTUSED", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "slap",
            },
            ["StoneGolem_clubs"] = new SharedItemData
            {
                ItemName = "StoneGolem_clubs", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "",
            },
            ["StoneGolem_hat"] = new SharedItemData
            {
                ItemName = "StoneGolem_hat", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "",
            },
            ["StoneGolem_spikes"] = new SharedItemData
            {
                ItemName = "StoneGolem_spikes", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "",
            },
            ["SurtlingCore"] = new SharedItemData
            {
                ItemName = "SurtlingCore", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "$item_surtlingcore",
            },
            ["SwordBlackmetal"] = new SharedItemData
            {
                ItemName = "SwordBlackmetal", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_sword_blackmetal",
            },
            ["SwordBronze"] = new SharedItemData
            {
                ItemName = "SwordBronze", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_sword_bronze",
            },
            ["SwordCheat"] = new SharedItemData
            {
                ItemName = "SwordCheat", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Cheat sword",
            },
            ["SwordIron"] = new SharedItemData
            {
                ItemName = "SwordIron", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_sword_iron",
            },
            ["SwordIronFire"] = new SharedItemData
            {
                ItemName = "SwordIronFire", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_sword_fire",
            },
            ["SwordSilver"] = new SharedItemData
            {
                ItemName = "SwordSilver", IsTeleportable = true, UsesDurability = true, MaxDurability = 200,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_sword_silver",
            },
            ["Tankard"] = new SharedItemData
            {
                ItemName = "Tankard", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_tankard",
            },
            ["TankardOdin"] = new SharedItemData
            {
                ItemName = "TankardOdin", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_tankard_odin",
            },
            ["tentaroot_attack"] = new SharedItemData
            {
                ItemName = "tentaroot_attack", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Dragur axe",
            },
            ["Thistle"] = new SharedItemData
            {
                ItemName = "Thistle", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_thistle",
            },
            ["Tin"] = new SharedItemData
            {
                ItemName = "Tin", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "$item_tin",
            },
            ["TinOre"] = new SharedItemData
            {
                ItemName = "TinOre", IsTeleportable = false, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "$item_tinore",
            },
            ["Torch"] = new SharedItemData
            {
                ItemName = "Torch", IsTeleportable = true, UsesDurability = true, MaxDurability = 20,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_torch",
            },
            ["TrollHide"] = new SharedItemData
            {
                ItemName = "TrollHide", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_trollhide",
            },
            ["troll_groundslam"] = new SharedItemData
            {
                ItemName = "troll_groundslam", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "slap",
            },
            ["troll_log_swing_h"] = new SharedItemData
            {
                ItemName = "troll_log_swing_h", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "LOG",
            },
            ["troll_log_swing_v"] = new SharedItemData
            {
                ItemName = "troll_log_swing_v", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "LOG",
            },
            ["troll_punch"] = new SharedItemData
            {
                ItemName = "troll_punch", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "slap",
            },
            ["troll_throw"] = new SharedItemData
            {
                ItemName = "troll_throw", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "fireballattack",
            },
            ["TrophyBlob"] = new SharedItemData
            {
                ItemName = "TrophyBlob", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_trophy_blob",
            },
            ["TrophyBoar"] = new SharedItemData
            {
                ItemName = "TrophyBoar", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_trophy_boar",
            },
            ["TrophyBonemass"] = new SharedItemData
            {
                ItemName = "TrophyBonemass", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_trophy_bonemass",
            },
            ["TrophyDeathsquito"] = new SharedItemData
            {
                ItemName = "TrophyDeathsquito", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_trophy_deathsquito",
            },
            ["TrophyDeer"] = new SharedItemData
            {
                ItemName = "TrophyDeer", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_trophy_deer",
            },
            ["TrophyDragonQueen"] = new SharedItemData
            {
                ItemName = "TrophyDragonQueen", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_trophy_dragonqueen",
            },
            ["TrophyDraugr"] = new SharedItemData
            {
                ItemName = "TrophyDraugr", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_trophy_draugr",
            },
            ["TrophyDraugrElite"] = new SharedItemData
            {
                ItemName = "TrophyDraugrElite", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_trophy_draugrelite",
            },
            ["TrophyDraugrFem"] = new SharedItemData
            {
                ItemName = "TrophyDraugrFem", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_trophy_draugr",
            },
            ["TrophyEikthyr"] = new SharedItemData
            {
                ItemName = "TrophyEikthyr", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_trophy_eikthyr",
            },
            ["TrophyFenring"] = new SharedItemData
            {
                ItemName = "TrophyFenring", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_trophy_fenring",
            },
            ["TrophyForestTroll"] = new SharedItemData
            {
                ItemName = "TrophyForestTroll", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_trophy_troll",
            },
            ["TrophyFrostTroll"] = new SharedItemData
            {
                ItemName = "TrophyFrostTroll", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_trophy_troll",
            },
            ["TrophyGoblin"] = new SharedItemData
            {
                ItemName = "TrophyGoblin", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_trophy_goblin",
            },
            ["TrophyGoblinBrute"] = new SharedItemData
            {
                ItemName = "TrophyGoblinBrute", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_trophy_goblinbrute",
            },
            ["TrophyGoblinKing"] = new SharedItemData
            {
                ItemName = "TrophyGoblinKing", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_trophy_goblinking",
            },
            ["TrophyGoblinShaman"] = new SharedItemData
            {
                ItemName = "TrophyGoblinShaman", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_trophy_goblinshaman",
            },
            ["TrophyGreydwarf"] = new SharedItemData
            {
                ItemName = "TrophyGreydwarf", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_trophy_greydwarf",
            },
            ["TrophyGreydwarfBrute"] = new SharedItemData
            {
                ItemName = "TrophyGreydwarfBrute", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_trophy_greydwarfbrute",
            },
            ["TrophyGreydwarfShaman"] = new SharedItemData
            {
                ItemName = "TrophyGreydwarfShaman", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_trophy_greydwarfshaman",
            },
            ["TrophyHatchling"] = new SharedItemData
            {
                ItemName = "TrophyHatchling", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_trophy_hatchling",
            },
            ["TrophyLeech"] = new SharedItemData
            {
                ItemName = "TrophyLeech", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_trophy_leech",
            },
            ["TrophyLox"] = new SharedItemData
            {
                ItemName = "TrophyLox", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_trophy_lox",
            },
            ["TrophyNeck"] = new SharedItemData
            {
                ItemName = "TrophyNeck", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_trophy_neck",
            },
            ["TrophySerpent"] = new SharedItemData
            {
                ItemName = "TrophySerpent", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 0, DisplayName = "$item_trophy_serpent",
            },
            ["TrophySGolem"] = new SharedItemData
            {
                ItemName = "TrophySGolem", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_trophy_sgolem",
            },
            ["TrophySkeleton"] = new SharedItemData
            {
                ItemName = "TrophySkeleton", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_trophy_skeleton",
            },
            ["TrophySkeletonPoison"] = new SharedItemData
            {
                ItemName = "TrophySkeletonPoison", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_trophy_skeletonpoison",
            },
            ["TrophySurtling"] = new SharedItemData
            {
                ItemName = "TrophySurtling", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_trophy_surtling",
            },
            ["TrophyTheElder"] = new SharedItemData
            {
                ItemName = "TrophyTheElder", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_trophy_elder",
            },
            ["TrophyWolf"] = new SharedItemData
            {
                ItemName = "TrophyWolf", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_trophy_wolf",
            },
            ["TrophyWraith"] = new SharedItemData
            {
                ItemName = "TrophyWraith", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 20, DisplayName = "$item_trophy_wraith",
            },
            ["Turnip"] = new SharedItemData
            {
                ItemName = "Turnip", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_turnip",
            },
            ["TurnipSeeds"] = new SharedItemData
            {
                ItemName = "TurnipSeeds", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 100, DisplayName = "$item_turnipseeds",
            },
            ["TurnipStew"] = new SharedItemData
            {
                ItemName = "TurnipStew", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 10, DisplayName = "$item_turnipstew",
            },
            ["VegvisirShard_Bonemass"] = new SharedItemData
            {
                ItemName = "VegvisirShard_Bonemass", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "Yagluth thing",
            },
            ["Wishbone"] = new SharedItemData
            {
                ItemName = "Wishbone", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "$item_wishbone",
            },
            ["WitheredBone"] = new SharedItemData
            {
                ItemName = "WitheredBone", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "$item_witheredbone",
            },
            ["WolfFang"] = new SharedItemData
            {
                ItemName = "WolfFang", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_wolffang",
            },
            ["WolfPelt"] = new SharedItemData
            {
                ItemName = "WolfPelt", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_wolfpelt",
            },
            ["Wolf_Attack1"] = new SharedItemData
            {
                ItemName = "Wolf_Attack1", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "WolfAttack1",
            },
            ["Wolf_Attack2"] = new SharedItemData
            {
                ItemName = "Wolf_Attack2", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "WolfAttack2",
            },
            ["Wolf_Attack3"] = new SharedItemData
            {
                ItemName = "Wolf_Attack3", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "WolfAttack3",
            },
            ["Wood"] = new SharedItemData
            {
                ItemName = "Wood", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_wood",
            },
            ["wraith_melee"] = new SharedItemData
            {
                ItemName = "wraith_melee", IsTeleportable = true, UsesDurability = true, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 1, DisplayName = "Wraith melee",
            },
            ["YagluthDrop"] = new SharedItemData
            {
                ItemName = "YagluthDrop", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 30, DisplayName = "Yagluth thing",
            },
            ["YmirRemains"] = new SharedItemData
            {
                ItemName = "YmirRemains", IsTeleportable = true, UsesDurability = false, MaxDurability = 100,
                DurabilityPerLevel = 50, MaxStack = 50, DisplayName = "$item_ymirremains",
            },
        };

        private static SharedItemData TryFindSharedData(string itemName) => 
            ItemData.TryGetValue(itemName, out SharedItemData sharedData) ? sharedData : null;
    }
}

