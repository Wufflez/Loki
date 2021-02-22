using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Loki
{
    /// <summary>
    /// Player profile as stored in a '.fch' file.
    /// </summary>
    public class PlayerProfile
    {
        public long PlayerId { get; set; }
        public string PlayerName { get; set; }
        public string StartSeed { get; set; }
        public PlayerStats Stats { get; private set; }
        public Player Player { get; private set; }
        private List<(long, WorldPlayerData)> _worldData;
        private PlayerProfile() { }

        public static PlayerProfile Read(Stream input, bool leaveOpen = false)
        {
            using var reader = new BinaryReader(input, Encoding.UTF8, leaveOpen);
            var totalExpectedSize = reader.ReadInt32();

            var startPosition = input.Position;

            var version = reader.ReadInt32();

            if (!Version.IsProfileCompatible(version))
                throw new InvalidDataException("Character version is not compatible");

            var playerStats = new PlayerStats();
            if (version >= 28)
            {
                playerStats.Kills = reader.ReadInt32();
                playerStats.Deaths = reader.ReadInt32();
                playerStats.Crafts = reader.ReadInt32();
                playerStats.Builds = reader.ReadInt32();
            }

            int worldCount = reader.ReadInt32();
            var worldData = new List<(long, WorldPlayerData)>();
            for (var i = 0; i < worldCount; i++)
                worldData.Add((
                    reader.ReadInt64(),
                    new WorldPlayerData
                    {
                        HaveCustomSpawn = reader.ReadBoolean(),
                        SpawnPoint = reader.ReadVector3(),
                        HaveLogoutPoint = reader.ReadBoolean(),
                        LogoutPoint = reader.ReadVector3(),
                        HaveDeathPoint = version >= 30 && reader.ReadBoolean(),
                        DeathPoint = version >= 30 ? reader.ReadVector3() : default,
                        HomePoint = reader.ReadVector3(),
                        MapData = version >= 29 && reader.ReadBoolean() ? reader.ReadByteArray() : default,
                    }));

            string playerName = reader.ReadString();
            long playerId = reader.ReadInt64();
            string startSeed = reader.ReadString();

            var player = reader.ReadBoolean() ? Player.Read(input, true) : default;

            // Verify we read all the data and haven't skipped anything.
            var dataRead = input.Position - startPosition;
            if (dataRead != totalExpectedSize)
            {
                throw new InvalidDataException(
                    "Amount of data read did not match the length header. " +
                    $"Data read = {dataRead}B, Length in header = {totalExpectedSize}B");
            }

            return new PlayerProfile
            {
                Stats = playerStats,
                PlayerId = playerId,
                PlayerName = playerName,
                StartSeed = startSeed,
                _worldData = worldData,
                Player = player,
            };
        }

        public void Write(Stream output, bool leaveOpen = false)
        {
            if (!output.CanSeek)
                throw new ArgumentException("Output stream must support seek");

            const int profileOffset = 4;
            output.Position = profileOffset;

            using var writer = new BinaryWriter(output, Encoding.UTF8, leaveOpen);

            writer.Write(Version.ProfileVersion);
            writer.Write(Stats.Kills);
            writer.Write(Stats.Deaths);
            writer.Write(Stats.Crafts);
            writer.Write(Stats.Builds);

            writer.Write(_worldData.Count);
            foreach (var (key, worldData) in _worldData)
            {
                writer.Write(key);
                writer.Write(worldData.HaveCustomSpawn);
                writer.Write(worldData.SpawnPoint);
                writer.Write(worldData.HaveLogoutPoint);
                writer.Write(worldData.LogoutPoint);
                writer.Write(worldData.HaveDeathPoint);
                writer.Write(worldData.DeathPoint);
                writer.Write(worldData.HomePoint);
                writer.Write(worldData.MapData != null);
                if (worldData.MapData != null) writer.WriteByteArray(worldData.MapData);
            }

            writer.Write(PlayerName);
            writer.Write(PlayerId);
            writer.Write(StartSeed);

            writer.Write(Player != null);
            if (Player != null)
            {
                output.Position += 4;
                var playerOffset = output.Position;
                Player.Write(output, true);

                // Write size of player data before it.
                int playerDataSize = (int)(output.Position - playerOffset);
                output.Position = playerOffset - 4;
                writer.Write(playerDataSize);
                output.Position += playerDataSize;
            }

            // Length of entire profile is written to very start.
            int profileLength = (int)(output.Position - profileOffset);
            output.Position = 0;
            writer.Write(profileLength);

            // Write tail of file (SHA512 hash, length prefixed)
            output.Position = profileOffset;
            var hash = SHA512.Create().ComputeHash(output);
            writer.WriteByteArray(hash);
        }
    }
}
