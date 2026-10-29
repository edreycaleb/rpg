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

    public static class Datag 
    {
        public static battle ha { get; set; }  
        public static battle va { get; set; }
        public static string name { get; set; }
        public static int clas { get; set; }
        public static int s = 0, p = 0, m = 0, b = 0, ma = 0, sa = 0, attks = 0;

        public static List<battle> hero = new List<battle>
        {
            new battle("Warrior", 120, 60, 100, 30, 0, 0, 0),
            new battle("Mage", 100, 10, 60, 45, 0, 60, 100),
            new battle("Archer", 70, 35, 100, 60, 70, 0, 0)
        };

        public static List<battle> villain = new List<battle>
        {
            new battle("Bandit", 120, 30, 50, 20, 0, 0, 0),
            new battle("Ciclope", 500, 300, 40, 15, 0, 0, 0),
            new battle("Lich", 40, 0, 0, 10, 0, 800, 1001),
            new battle("Knight", 250, 150, 70, 75, 0, 0, 0),
            new battle("Dragon", 1001, 1001, 1001, 1001, 0, 1001, 1001),
            new battle("WarriorLH",200, 120, 100, 50, 0, 0, 0),
            new battle("QueenEl",300, 30, 60, 70, 100, 200 , 1001),
            new battle("Imperator",1000, 0, 1000, 0, 0, 0 , 0),
            new battle("Chef bandits",240, 60, 100, 40, 0, 0 , 0),
            new battle("Chef of Guard",280, 180, 100, 100, 0, 0 , 0),

        };
    }

}
