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
            AddLemons(20);
            AddSugarCubes(20);
            AddIceCubes(100);
            AddCups(30);
        }

        public void AddLemons(int numberOfLemons)
        {
            for(int i = 0; i < numberOfLemons; i++)
            {
                Lemon lemon = new Lemon();
                lemons.Add(lemon);
            }
        }

        public void AddSugarCubes(int numberOfSugarCubes)
        {
            for(int i = 0;i < numberOfSugarCubes; i++)
            {
                SugarCube sugarCube = new SugarCube();
                sugarCubes.Add(sugarCube);
            }
        }

        public void AddIceCubes(int numberOfIceCubes)
        {
            for (int i = 0; i < numberOfIceCubes; i++)
            {
                IceCube iceCube = new IceCube();
                iceCubes.Add(iceCube);
            }
        }

        public void AddCups(int numberOfCups)
        {
            for ( int i = 0; i < numberOfCups; i++)
            {
                Cup cup = new Cup();
                cups.Add(cup);
            }
        }
    }
}
