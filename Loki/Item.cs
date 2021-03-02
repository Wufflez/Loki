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
        }

        public override string ToString() => $"{Name} [{Stack}]";
    }
}
