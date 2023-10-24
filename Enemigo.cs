namespace TerminalRpgEncounter
{


    public class Enemigo
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Dexterity { get; set; }
        public int Health { get; set; }



        public Enemigo(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 70;
        }

        // Build Attack method
        public virtual int Attack(Human target)
        {
            if (target == null)
            {
                Console.WriteLine("Fallo el ataque");
                return 0;
            }
            else
            {
                int dmg = Strength * 3;
                target.Health -= dmg;
                Console.WriteLine($"{Name} ataco a {target.Name} causando {dmg} de daño!");
                return target.Health;
            }

        }
    }
}