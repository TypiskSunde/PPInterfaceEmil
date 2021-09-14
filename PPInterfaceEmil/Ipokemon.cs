using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPInterfaceEmil
{
    interface Ipokemon
    {
        public int Health { get;  }

        void LooseHealth();
    }
}
