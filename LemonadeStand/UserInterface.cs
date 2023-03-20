using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    static class UserInterface
    {
        public static int GetNumberOfItems(string itemName)
        {
            bool userInputIsInt = false;
            int quantityOfItem = -1;
            while(!userInputIsInt ||  quantityOfItem < 0) {
                Console.WriteLine($"How many {itemName} would you like to purchase?");
                Console.WriteLine("Please enter a positive number, or press 0 to cancel.");
                userInputIsInt = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
            }
            return quantityOfItem;
        }

        public static int GetNumberOfPitchers()
        {
            bool userInputIsInt = false;
            int quantityOfItem = -1;
            while (!userInputIsInt || quantityOfItem < 0)
            {
                Console.WriteLine($"How many pitchers of lemonade would you like to make? (1 pitcher = 8 cups)");
                Console.WriteLine("Please enter a positive number, or press 0 to cancel purchase");
                userInputIsInt = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
            }
            return quantityOfItem;
        }
    }
}
