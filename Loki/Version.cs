using System.Linq;

namespace Loki
{
    internal static class Version
    {
        /// <summary>
        /// Version of PlayerProfile .fch data. This is what's checked when loading the file.
        /// </summary>
        public const int MinProfileVersion = 33;

        /// <summary>
        /// Version of PlayerProfile .fch data. This is the version of the saved file.
        /// </summary>
        public const int ProfileVersion = 36;

        private static readonly int[] CompatibleProfileVersions =
        {
            36,
            32,
            31,
            30,
            29,
            28,
            27,
        };

        public static bool IsProfileCompatible(int version) =>
            version == MinProfileVersion || CompatibleProfileVersions.Contains(version);

    }
}
