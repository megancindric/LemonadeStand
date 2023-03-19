using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Inventory
    {
        internal List<Lemon> lemons;
        internal List<SugarCube> sugarCubes;
        internal List<IceCube> iceCubes;
        internal List<Cup> cups;

        public Inventory() { 
            lemons = new List<Lemon>();
            sugarCubes = new List<SugarCube> ();
            iceCubes = new List<IceCube> ();
            cups = new List<Cup> ();
        }
    }
}
