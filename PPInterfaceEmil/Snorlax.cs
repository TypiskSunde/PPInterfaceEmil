using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPInterfaceEmil
{
    class Snorlax : Ipokemon

    {

        public int Health { get; set; }
        public Snorlax(int health)
        {
            Health = health;
        }
        public void LooseHealth()
        {
            Health--;
        }
       

        

        public void MegaFart(Ipokemon snorlaxPokemon)
        {
            snorlaxPokemon.LooseHealth();
        }

        
    }
}
