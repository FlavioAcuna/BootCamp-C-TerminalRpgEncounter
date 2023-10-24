namespace TerminalRpgEncounter
{
    public class Zombie : Enemigo
    {
        public Zombie(string name) : base(name)
        {
            Name = name;
            Intelligence = 1;
            Strength = 3;
            Dexterity = 1;
            Health = 60;
        }

    }
}