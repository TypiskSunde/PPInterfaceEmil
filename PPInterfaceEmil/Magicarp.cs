using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPInterfaceEmil
{
    class Magicarp : Ipokemon
    {
        public string IsUseless;

        public int Health { get; set; }

        public Magicarp(int health)
        {
            Health = health;
        }

        public void Splash(Ipokemon snorlaxPokemon)
        {
            snorlaxPokemon.LooseHealth();
        }

        public void LooseHealth()
        {
            Health-= 5;
        }
    }
}
