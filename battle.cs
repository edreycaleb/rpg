namespace rpg
{
    public class battle
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Power { get; set; }
        public int Sanity { get; set; }
        public int Speed { get; set; }
        public int Bow { get; set; }
        public int Magic { get; set; }

        public int Mana { get; set; }

    

    public battle(string name, int health, int power, int sanity, int speed, int bow, int magic, int mana)
        {
            Health = health;
            Power = power;
            Sanity = sanity;
            Speed = speed;
            Bow = bow;
            Magic = magic;
            Mana = mana;
            Name = name;
        }

    }

}
