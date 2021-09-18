namespace Loki
{
    public class Food
    {
        public string Name { get; }
        public float Time { get; }
        public float Health { get; }
        public float Stamina { get; }

        public Food(string name, float time, float health, float stamina)
        {
            Name = name;
            Time = time;
            Health = health;
            Stamina = stamina;
        }
    }
}
