using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Player
    {

        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;

        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
        }

        public bool CanMakeLemonade(int numberOfPitchers)
        {
            // Try to make target number of pitchers
            int requiredLemons = numberOfPitchers * recipe.NumberOfLemons;
            int requiredSugarCubes = numberOfPitchers * recipe.NumberOfSugarCubes;
            int requiredIceCubes = numberOfPitchers*recipe.NumberOfIceCubes;
            int requiredCups = numberOfPitchers * 8;
            // Calculate necessary ingredient #
            if (requiredLemons > inventory.lemons.Count)
            {
                Console.WriteLine($"\nInsufficient lemons in inventory.  Please purchase {requiredLemons - inventory.lemons.Count} more!");
                return false;
            }
            if (requiredSugarCubes > inventory.sugarCubes.Count)
            {
                Console.WriteLine($"\nInsufficient sugar cubes in inventory.  Please purchase {requiredSugarCubes - inventory.sugarCubes.Count} more!");
                return false;
            }
            if (requiredIceCubes > inventory.iceCubes.Count)
            {
                Console.WriteLine($"\nInsufficient ice cubes in inventory.  Please purchase {requiredIceCubes - inventory.iceCubes.Count} more!");
                return false;
            }
            if (requiredCups > inventory.cups.Count)
            {
                Console.WriteLine($"\nInsufficient cups in inventory.  Please purchase {requiredCups - inventory.cups.Count} more!");
                return false;
            }
            // Determine if inventory is sufficient
            // If ingredient is insufficient, inform player, return false (will need to go to store)
            // If all ingredients sufficient, remove that number from inventory
            // use RemoveRange(index, numberToRemove)
            inventory.lemons.RemoveRange(0, requiredLemons);
            inventory.sugarCubes.RemoveRange(0, requiredSugarCubes);
            inventory.iceCubes.RemoveRange(0, requiredIceCubes);
            inventory.cups.RemoveRange(0, requiredCups);
            Console.WriteLine($"\nYou successfully made {numberOfPitchers} pitchers of lemonade! ({numberOfPitchers * 8} cups)\n");
            return true;
        }


        public void DisplayStatus()
        {
            DisplayMoney();
            DisplayInventory();
            DisplayRecipe();
        }

        public void DisplayInventory()
        {
            Console.WriteLine($"\n\tCurrent Inventory:\n\n\tLemons: {inventory.lemons.Count}\n\tSugar Cubes: {inventory.sugarCubes.Count}\n\tIce Cubes: {inventory.iceCubes.Count}\n\tCups: {inventory.cups.Count}");

        }
        public void DisplayRecipe()
        {
            Console.WriteLine("\n\tCurrent Recipe:\n");
            recipe.DisplayRecipe();
        }
        public void DisplayMoney()
        {
            Console.WriteLine($"\n\tCurrent Money: ${wallet.Money}\n");

        }
    }
}
