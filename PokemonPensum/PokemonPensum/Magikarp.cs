using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPensum
{
    internal class Magikarp : IPokemon
    {
        public string IsUseless { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public string PokemonName { get; set; }
        public string AttackName { get; set; }

        public Magikarp()
        {
            IsUseless = "Is useless";
            Health = 6000;
        }

        public void Splash()
        {
            AttackName = "Splash";
            Damage = 0;
            //oponent.LooseHealth();
        }

        public void LooseHealth(IPokemon oponent)
        {
            oponent.Health -= Damage;
        }

        public void Attack(IPokemon oponent)
        {
            Splash();
            LooseHealth(oponent);
        }
    }
}

