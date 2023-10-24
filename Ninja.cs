namespace TerminalRpgEncounter
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Name = name;
            Dexterity = 75;
        }
        public override int Attack(Enemigo enemigo)
        {
            Random rand = new Random();
            int critico = rand.Next(0, 100);
            int dmg = 0;
            if (critico <= 20)
            {
                dmg = 10 + Dexterity;
            }
            else
            {
                dmg = Dexterity;
            }
            enemigo.Health -= dmg;
            Console.WriteLine($"{Name} Ataco a {enemigo.Name} causando {dmg} de daño");
            return enemigo.Health;
        }

        public int Steal(Enemigo enemigo)
        {
            enemigo.Health -= 5;
            Health += 5;
            Console.WriteLine($"{Name} Ha robado a {enemigo.Name} 5 hp de vida");
            return enemigo.Health;
        }
        public void Ataques()
        {
            Console.WriteLine("Selecciona un ataque 1)Atacar 2)Robar HP");
        }
    }
}