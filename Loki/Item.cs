using System;

namespace Loki
{
    public class Item
    {
        public string Name { get; }
        public int Stack { get; }
        public float Durability { get; }
        public Vector2i Pos { get; }
        public bool Equiped { get; }
        public int Quality { get; }
        public int Variant { get; }
        public long CrafterId { get; }
        public string CrafterName { get; }

        public double MaxDurability =>
            SharedData.MaxDurability + Math.Max(0, Quality - 1) * SharedData.DurabilityPerLevel;

        public Item(string name, int stack, float durability, Vector2i pos, bool equiped, int quality, int variant, long crafterId, string crafterName)
        {
            Name = name;
            Stack = stack;
            Durability = durability;
            Pos = pos;
            Equiped = equiped;
            Quality = quality;
            Variant = variant;
            CrafterId = crafterId;
            CrafterName = crafterName;
            SharedData = ItemDb.TryFindSharedData(name);

            if (SharedData == null)
            {
                Unrecognised = true;
            }

        }
        
        public SharedItemData SharedData { get; }

        public bool HasQualityLevels => SharedData?.MaxQuality > 1;

        public bool Unrecognised { get; }

        public string StackText => $"{Stack} / {SharedData.MaxStack}";

        public bool CanStack => SharedData.MaxStack > 1;

        public override string ToString() => $"{Name} [{Stack}]";
    }
}
