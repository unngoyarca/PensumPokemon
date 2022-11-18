using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPensum
{
    internal class Gyarados : IPokemon
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public string PokemonName { get; set; }
        public string AttackName { get; set; }

        public Gyarados()
        {
            PokemonName = "Gyarados";
            Health = 300;
        }

        void Hydropump()
        {
            AttackName = "Hydropump";
            Damage = 250;
        }
        void DragonRage()
        {
            AttackName = "Dragon Rage";
            Damage = 250;
        }

        public void Attack(IPokemon oponent)
        {
            //Hydropump();
            //LooseHealth(oponent);
            var index = Program.rand.Next(0, 2);
            if (index == 0) Hydropump();
            else if (index == 1) DragonRage();
            LooseHealth(oponent);
        }

        public void LooseHealth(IPokemon oponent)
        {
            oponent.Health -= Damage;
        }
    }
}
