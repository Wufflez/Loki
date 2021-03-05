using System.Linq;

namespace Loki
{
    public readonly struct Beard
    {
        public static Beard[] AvailableBeards =
        {
            new Beard("No beard", "BeardNone"),
            new Beard("Braided 1", "Beard5"),
            new Beard("Braided 2", "Beard6"),
            new Beard("Braided 3", "Beard9"),
            new Beard("Braided 4", "Beard10"),
            new Beard("Long 1", "Beard1"),
            new Beard("Long 2", "Beard2"),
            new Beard("Short 1", "Beard3"),
            new Beard("Short 2", "Beard4"),
            new Beard("Short 3", "Beard7"),
            new Beard("Thick 1", "Beard8"),
            new Beard("Deer Lord", "TrophyDeer"),
            new Beard("Troll Master", "TrophyForestTroll"),
            new Beard("Deathsquito", "TrophyDeathsquito"),
        };

        public string DisplayName { get; }
        public string Code { get; }

        public static Beard Default = new Beard("No beard", "BeardNone");

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
