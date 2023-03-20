using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Recipe
    {
        private int _numberOfLemons;
        private int _numberOfSugarCubes;
        private int _numberOfIceCubes;
        private double _price;
        public int NumberOfLemons { get { return _numberOfLemons; } set { _numberOfLemons = value; } }
        public int NumberOfSugarCubes { get { return _numberOfSugarCubes; } set { _numberOfSugarCubes = value; } }
        public int NumberOfIceCubes { get { return _numberOfIceCubes; } set { _numberOfIceCubes = value; } }
        public double Price { get { return _price; } set { _price = value; } }
        public Recipe()
        {
            NumberOfLemons = 2;
            NumberOfSugarCubes = 4;
            NumberOfIceCubes = 10;
            Price = 1;
        }

        public void DisplayRecipe()
        {
            Console.WriteLine($"\t1 Pitcher of Lemonade:\n\t{NumberOfLemons} lemons\n\t{NumberOfSugarCubes} sugar cubes\n\t{NumberOfIceCubes} ice cubes\n\n\t${Price} per cup\n\n");
        }
    }
}
