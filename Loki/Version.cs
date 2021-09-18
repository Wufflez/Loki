﻿using System.Linq;

namespace Loki
{
    internal static class Version
    {
        /// <summary>
        /// Version of PlayerProfile .fch data.
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
            version == ProfileVersion || CompatibleProfileVersions.Contains(version);

    }
}
