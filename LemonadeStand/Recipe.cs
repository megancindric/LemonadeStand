using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Recipe
    {
        private int numberOfLemons;
        private int numberOfSugarCubes;
        private int numberOfIceCubes;
        private double price;

        public Recipe()
        {
            numberOfLemons = 2;
            numberOfSugarCubes = 4;
            numberOfIceCubes = 10;
            price = 1;
        }

        public void DisplayRecipe()
        {
            Console.WriteLine($"Your current recipe for lemonade is as follows:\n\n1 Pitcher Lemonade\n{numberOfLemons} lemons\n{numberOfSugarCubes} sugar cubes\n{numberOfIceCubes} ice cubes\n\n${price} per cup");
        }
    }
}
