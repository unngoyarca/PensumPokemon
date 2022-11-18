using System.Linq.Expressions;

namespace PokemonPensum
{
    public class Program
    {
        public static Random rand = new Random();
        static List<IPokemon> WildPokemon = new List<IPokemon>();
        static void Main(string[] args)
        {

           
            var Charizard = new Charizard();
            var Gengar = new Gengar();
            var Gyarados = new Gyarados();
            var Magikarp = new Magikarp();

            WildPokemon.Add(Charizard);
            WildPokemon.Add(Gengar);
            WildPokemon.Add(Gyarados);
            //WildPokemon.Add(Magikarp);

            var selectedPokemon = GetWildPokemon();
            
            while (Magikarp.Health > 0)
            {

                Console.WriteLine(selectedPokemon.PokemonName);
                //Console.WriteLine(selectedPokemon.PokemonName + " Use " + selectedPokemon.AttackName + "!!");
                
                selectedPokemon.Attack(Magikarp);
                Console.WriteLine(selectedPokemon.PokemonName + " use " + selectedPokemon.AttackName);
            }

            Console.WriteLine("Magikarp is dead");
            
        }
        static IPokemon GetWildPokemon()
        {
            var index = rand.Next(0, WildPokemon.Count);
            var Pokemon = WildPokemon[index];
            return Pokemon; // pokemon
        }

    }
}