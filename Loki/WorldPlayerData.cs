namespace Loki
{
    public class WorldPlayerData
    {
        public bool HaveCustomSpawn { get; set; }
        public Vector3 SpawnPoint { get; set; }
        public bool HaveLogoutPoint { get; set; }
        public Vector3 LogoutPoint { get; set; }
        public bool HaveDeathPoint { get; set; }
        public Vector3 DeathPoint { get; set; }
        public Vector3 HomePoint { get; set; }
        public byte[] MapData { get; set; }
    }
}
