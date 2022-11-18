using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPensum
{
    internal class Gengar : IPokemon
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public string PokemonName { get; set; }
        public string AttackName { get; set; }

        public Gengar()
        {
            PokemonName = "Gengar";
            Health = 250;

        }

        void ShadowBall()
        {
            AttackName = "ShadowBall";
            Damage = 250;
        }
        void ShadowPunch()
        {
            AttackName = "Shadow Punch";
            Damage = 300;
        }

        public void Attack(IPokemon oponent)
        {
            //ShadowBall();
            //LooseHealth(oponent);
            var index = Program.rand.Next(0, 2);
            if (index == 0) ShadowBall();
            else if (index == 1) ShadowPunch();
            LooseHealth(oponent);
        }

        public void LooseHealth(IPokemon oponent)
        {
            oponent.Health -= Damage;
        }
    }
}
