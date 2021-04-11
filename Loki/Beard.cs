using System.Collections.Generic;
using System.Linq;

namespace Loki
{
    public readonly struct Beard
    {
        private static readonly Beard[] SensibleBeards = 
        {
            new Beard(Loki.Properties.Resources.B_No_beard, "BeardNone"),
            new Beard(Loki.Properties.Resources.B_Braided_2, "Beard5"),
            new Beard(Loki.Properties.Resources.B_Braided_2, "Beard6"),
            new Beard(Loki.Properties.Resources.B_Braided_3, "Beard9"),
            new Beard(Loki.Properties.Resources.B_Braided_4, "Beard10"),
            new Beard(Loki.Properties.Resources.B_Long_1, "Beard1"),
            new Beard(Loki.Properties.Resources.B_Long_2, "Beard2"),
            new Beard(Loki.Properties.Resources.B_Short_1, "Beard3"),
            new Beard(Loki.Properties.Resources.B_Short_2, "Beard4"),
            new Beard(Loki.Properties.Resources.B_Short_3, "Beard7"),
            new Beard(Loki.Properties.Resources.B_Thick_1, "Beard8"),
        };

        private static readonly IEnumerable<Beard> SillyBeards = 
            ItemDb.AllItems.Where(i => i.ItemType == ItemType.Trophy)
            .Select(i => new Beard(i.DisplayName, i.ItemName));

        public static Beard[] AvailableBeards = SensibleBeards.Concat(SillyBeards).ToArray();

        public string DisplayName { get; }
        public string Code { get; }

        public static Beard Default = new Beard(Loki.Properties.Resources.B_No_beard, "BeardNone");

        public Beard(string name, string code)
        {
            DisplayName = name;
            Code = code;
        }

        public static Beard FromCode(string beardCode)
        {
            Beard beard = AvailableBeards.FirstOrDefault(b => b.Code == beardCode);
            if (string.IsNullOrEmpty(beard.Code)) 
                beard = Default;
            return beard;
        }
    }
}
