using System.Linq;

namespace Loki
{
    public readonly struct Hair
    {
        public static Hair[] AvailableHairs =
        {
            new Hair("No hair", "HairNone"),
            new Hair("Braided 1", "Hair3"),
            new Hair("Braided 2", "Hair11"),
            new Hair("Braided 3", "Hair12"),
            new Hair("Braided 4", "Hair6"),
            new Hair("Long 1", "Hair1"),
            new Hair("Ponytail 1", "Hair2"),
            new Hair("Ponytail 2", "Hair4"),
            new Hair("Ponytail 3", "Hair7"),
            new Hair("Ponytail 4", "Hair5"),
            new Hair("Short 1", "Hair8"),
            new Hair("Short 2", "Hair13"),
            new Hair("Side Swept 1", "Hair9"),
            new Hair("Side Swept 2", "Hair10"),
            new Hair("Side Swept 3", "Hair14"),
            new Hair("Blob hair", "TrophyBlob"),
        };

        public string DisplayName { get; }
        public string Code { get; }

        public static Hair Default = new Hair("No hair", "HairNone");

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
