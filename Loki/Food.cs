namespace Loki
{
    public class Food
    {
        public string Name { get; }
        public float Health { get; }
        public float Stamina { get; }

        public Food(string name, float health, float stamina)
        {
            Name = name;
            Health = health;
            Stamina = stamina;
        }
    }
}
