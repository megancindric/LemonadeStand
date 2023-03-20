using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Customer
    {
        string name;
        public Customer() {
            name = "John Doe";
        }

        public bool BuyLemonade(Random rand, int weatherBonus)
        {
            // Randomly select a number
            int roll = rand.Next(1, 5);
            roll += weatherBonus;
            if (roll >=4)
            {
                return true;
            }
            else
            {
                return false;
            }
            // Add weatherBonus to it
            // Based on that number, return TRUE if they buy a cup, FALSE otherwise
        }
    }
}
