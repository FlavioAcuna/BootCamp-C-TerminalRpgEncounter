namespace TerminalRpgEncounter
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Human> party = new List<Human>();
            Ninja ninja = new Ninja("Fujibayashi Nagato");
            Samurai samurai = new Samurai("Miyamoto Musashi");
            Mago mago = new Mago("Merlin");
            party.Add(ninja);
            party.Add(samurai);
            party.Add(mago);
            List<Enemigo> enemyParty = new List<Enemigo>();
            Zombie zombie1 = new Zombie("ZombieBoy");
            Zombie zombie2 = new Zombie("ZombieGirl");
            Spider spider1 = new Spider("SpiderMan");
            enemyParty.Add(zombie1);
            enemyParty.Add(zombie2);
            enemyParty.Add(spider1);
            List<object> campoBatalla = new List<object>();
            campoBatalla.Add(ninja);
            campoBatalla.Add(zombie1);
            campoBatalla.Add(samurai);
            campoBatalla.Add(zombie2);
            campoBatalla.Add(mago);
            campoBatalla.Add(spider1);
            Console.WriteLine($"Equipo I: {ninja.Name} , {samurai.Name} , {mago.Name} VS Equipo II: {zombie1.Name} , {zombie2.Name} , {spider1.Name} ");
            while (campoBatalla.Count > 3)
            {
                for (int i = 0; i < party.Count; i++)
                {
                    Random rand = new Random();
                    var Jugador = party[i];
                    if (Jugador is Ninja)
                    {
                        Console.WriteLine($"{ninja.Name} Selecciona un ataque");
                        ninja.Ataques();
                        string InputLine = Console.ReadLine();
                        Enemigo atacarEnemigo = enemyParty[rand.Next(0, enemyParty.Count)];
                        if (InputLine == "1")
                        {
                            ninja.Attack(atacarEnemigo);
                            Console.WriteLine($"HP: {ninja.Health} EnemigoHP: {atacarEnemigo.Health}");
                        }
                        else
                        {
                            ninja.Steal(atacarEnemigo);
                            Console.WriteLine($"HP: {ninja.Health} EnemigoHP: {atacarEnemigo.Health}");
                        }
                        if (atacarEnemigo.Health <= 0)
                        {
                            Console.WriteLine($"{atacarEnemigo.Name} Ha sido asesinado");
                            enemyParty.Remove(atacarEnemigo);
                            campoBatalla.Remove(atacarEnemigo);
                        }
                    }
                    else if (Jugador is Mago)
                    {
                        Console.WriteLine($"{mago.Name} Selecciona un ataque");
                        mago.Ataques();
                        string InputLine = Console.ReadLine();
                        Enemigo atacarEnemigo = enemyParty[rand.Next(0, enemyParty.Count)];
                        if (InputLine == "1")
                        {
                            mago.Attack(atacarEnemigo);
                            Console.WriteLine($"HP: {mago.Health} EnemigoHP: {atacarEnemigo.Health}");
                        }
                        else
                        {
                            mago.Curar(mago);
                            Console.WriteLine($"HP: {mago.Health} EnemigoHP: {atacarEnemigo.Health}");
                        }
                        if (atacarEnemigo.Health <= 0)
                        {
                            Console.WriteLine($"{atacarEnemigo.Name} Ha sido asesinado");
                            enemyParty.Remove(atacarEnemigo);
                            campoBatalla.Remove(atacarEnemigo);
                        }

                    }
                    else if (Jugador is Samurai)
                    {
                        Console.WriteLine($"{samurai.Name} Selecciona un ataque");
                        samurai.Ataques();
                        string InputLine = Console.ReadLine();
                        Enemigo atacarEnemigo = enemyParty[rand.Next(0, enemyParty.Count)];
                        if (InputLine == "1")
                        {
                            samurai.Attack(atacarEnemigo);
                            Console.WriteLine($"HP: {samurai.Health} EnemigoHP: {atacarEnemigo.Health}");
                        }
                        else
                        {
                            samurai.meditar();
                            Console.WriteLine($"HP: {samurai.Health} EnemigoHP: {atacarEnemigo.Health}");
                        }
                        if (atacarEnemigo.Health <= 0)
                        {
                            Console.WriteLine($"{atacarEnemigo.Name} Ha sido asesinado");
                            enemyParty.Remove(atacarEnemigo);
                            campoBatalla.Remove(atacarEnemigo);
                        }
                    }
                    else
                    {
                        Human atacarJugador = party[rand.Next(0, party.Count)];
                        Enemigo randomEnemy = enemyParty[rand.Next(0, enemyParty.Count)];
                        randomEnemy.Attack(atacarJugador);
                        if (atacarJugador.Health <= 0)
                        {
                            Console.WriteLine($"{atacarJugador.Name} Ha muerto");
                            party.Remove(atacarJugador);
                            campoBatalla.Remove(atacarJugador);
                        }
                    }
                }

            }
            Console.WriteLine("Se Termino el juego");
            if (party.Count > enemyParty.Count)
            {
                Console.WriteLine("Gano el equipo I");
            }
            else
            {
                Console.WriteLine("Gano el equipo II , Suerte la proxima");
            }



        }
    }
}