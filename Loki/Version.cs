using System.Linq;

namespace Loki
{
    internal static class Version
    {

        /// <summary>
        /// Version of PlayerProfile .fch data. This is the version of the saved file.
        /// </summary>
        public const int ProfileVersion = 36;

        /// <summary>
        /// These legacy versions are also considered compatible, in addition to <see cref="ProfileVersion"/>
        /// </summary>
        private static readonly int[] CompatibleProfileVersions =
        {
            35,
            34,
            33,
            32,
            31,
            30,
            29,
            28,
            27,
        };

        public static bool IsProfileCompatible(int version) =>
            version == ProfileVersion || CompatibleProfileVersions.Contains(version);

    }
}
