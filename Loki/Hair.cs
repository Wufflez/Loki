using System.Collections.Generic;
using System.Linq;

namespace Loki
{
    public readonly struct Hair
    {
        private static readonly Hair[] SensibleHairs =
        {
            new Hair(Loki.Properties.Resources.No_hair, "HairNone"),
            new Hair(Loki.Properties.Resources.Braided_1, "Hair3"),
            new Hair(Loki.Properties.Resources.Braided_2, "Hair11"),
            new Hair(Loki.Properties.Resources.Braided_3, "Hair12"),
            new Hair(Loki.Properties.Resources.Braided_4, "Hair6"),
            new Hair(Loki.Properties.Resources.Long_1, "Hair1"),
            new Hair(Loki.Properties.Resources.Ponytail_1, "Hair2"),
            new Hair(Loki.Properties.Resources.Ponytail_2, "Hair4"),
            new Hair(Loki.Properties.Resources.Ponytail_3, "Hair7"),
            new Hair(Loki.Properties.Resources.Ponytail_4, "Hair5"),
            new Hair(Loki.Properties.Resources.Short_1, "Hair8"),
            new Hair(Loki.Properties.Resources.Short_2, "Hair13"),
            new Hair(Loki.Properties.Resources.Side_Swept_1, "Hair9"),
            new Hair(Loki.Properties.Resources.Side_Swept_2, "Hair10"),
            new Hair(Loki.Properties.Resources.Side_Swept_3, "Hair14"),
            new Hair(Loki.Properties.Resources.Blob_hair, "TrophyBlob"),
        };

        private static readonly IEnumerable<Hair> SillyHairs =
            ItemDb.AllItems.Where(i => i.ItemType == ItemType.Trophy)
                .Select(i => new Hair(i.DisplayName, i.ItemName));

        public static readonly Hair[] AvailableHairs = SensibleHairs.Concat(SillyHairs).ToArray();

        public string DisplayName { get; }
        public string Code { get; }

        public static Hair Default = new Hair(Loki.Properties.Resources.No_hair, "HairNone");

        public Hair(string name, string code)
        {
            DisplayName = name;
            Code = code;
        }

        public static Hair FromCode(string hairCode)
        {
            Hair hair = AvailableHairs.FirstOrDefault(b => b.Code == hairCode);
            if (string.IsNullOrEmpty(hair.Code))
                hair = Default;
            return hair;
        }
    }
}
