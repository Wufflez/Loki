using System.Collections.Generic;
using System.Linq;

namespace Loki
{
    public class Inventory
    {
        public Inventory(int width, int height)
        {
            Slots = Enumerable.Range(0, width * height)
                .Select(x => new Vector2i(x % width, x / width))
                .Select(pos => new InventorySlot(pos))
                .ToList();
        }

        public List<InventorySlot> Slots { get; }

        public InventorySlot GetSlotAt(Vector2i position)
        {
            return Slots.FirstOrDefault(slot => slot.Position == position);
        }
    }
}
