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
            // Calculate necessary ingredient #
            // Determine if inventory is sufficient
            // If ingredient is insufficient, inform player, return false (will need to go to store)
            // If all ingredients sufficient, remove that number from inventory
            // 
            return false;
        }

        public void DisplayStatus()
        {
            DisplayMoney();
            DisplayInventory();
            DisplayRecipe();
        }

        public void DisplayInventory()
        {
            Console.WriteLine($"\n\nCurrent Inventory:\n\nLemons: {inventory.lemons}\nSugar Cubes: {inventory.sugarCubes}\nIce Cubes: {inventory.iceCubes}\nCups: {inventory.cups}");

        }
        public void DisplayRecipe()
        {
            Console.WriteLine("\n\nCurrent Recipe:\n\n");
            recipe.DisplayRecipe();
        }
        public void DisplayMoney()
        {
            Console.WriteLine($"\n\nCurrent Money: ${wallet.Money}");

        }
    }
}
