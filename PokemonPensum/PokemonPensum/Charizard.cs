using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPensum
{
    internal class Charizard : IPokemon
    {
     
        public int Health { get; set; }
        public int Damage { get; set; }
        public string PokemonName { get; set; }
        public string AttackName { get; set; }

        public Charizard()
        {
            PokemonName = "Charizard";
            Health = 270;
        }

        public void FireBlast()
        {
            AttackName = "Fireblast";
            Damage = 300;
        }

        public void FireBall()
        {
            AttackName = "Fireball";
            Damage = 250;
        }

        public void Attack(IPokemon oponent)
        {
            var index = Program.rand.Next(0, 2);
            if (index == 0) FireBlast();
            else if (index == 1) FireBall();
            LooseHealth(oponent);
        }

        public void LooseHealth(IPokemon oponent)
        {
            oponent.Health -= Damage;
        }
    }
}
