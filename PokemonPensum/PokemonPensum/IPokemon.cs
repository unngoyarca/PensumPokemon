using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPensum
{
    internal interface IPokemon
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public string PokemonName { get; set; }
        public string AttackName { get; set; }


        public void LooseHealth(IPokemon opponent); 
        public void Attack(IPokemon oponent);

    }
}
