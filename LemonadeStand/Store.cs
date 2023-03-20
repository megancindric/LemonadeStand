using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Store
    {
        private double lemonPrice;
        private double sugarCubePrice;
        private double iceCubePrice;
        private double cupPrice;

        public Store()
        {
            lemonPrice = .5;
            sugarCubePrice = .15;
            iceCubePrice = 0.01;
            cupPrice = .25;
        }
        public void ShowMenu()
        {
            // Show welcome message, show price of each item
            Console.WriteLine();

        }
        
        //TODO: Add success/thank you message after purchase, show item number and total cost
        public void SellLemons(Player player)
        {
            int lemonQuantity = UserInterface.GetNumberOfItems("lemons");
            double transactionAmount = CalculateTransactionAmount(lemonQuantity, lemonPrice);
            if(player.wallet.Money >= transactionAmount)
            {
                PerformTransaction(player.wallet, transactionAmount);
                player.inventory.AddLemons(lemonQuantity);
            }
        }

        public void SellSugarCubes(Player player)
        {
            int sugarCubeQuantity = UserInterface.GetNumberOfItems("sugar cubes");
            double transactionAmount = CalculateTransactionAmount(sugarCubeQuantity, sugarCubePrice);
            if (player.wallet.Money >= transactionAmount)
            {
                PerformTransaction(player.wallet, transactionAmount);
                player.inventory.AddSugarCubes(sugarCubeQuantity);
            }
        }

        public void SellIceCubes(Player player)
        {
            int iceCubeQuantity = UserInterface.GetNumberOfItems("ice cubes");
            double transactionAmount = CalculateTransactionAmount(iceCubeQuantity, iceCubePrice);
            if (player.wallet.Money >= transactionAmount)
            {
                PerformTransaction(player.wallet, transactionAmount);
                player.inventory.AddIceCubes(iceCubeQuantity);
            }
        }

        public void SellCups(Player player)
        {
            int cupQuantity = UserInterface.GetNumberOfItems("cups");
            double transactionAmount = CalculateTransactionAmount(cupQuantity, cupPrice);
            if (player.wallet.Money >= transactionAmount)
            {
                PerformTransaction(player.wallet,transactionAmount);
                player.inventory.AddCups(cupQuantity);
            }
        }

        public double CalculateTransactionAmount(int quantity, double pricePerItem)
        {
            return quantity * pricePerItem;
        }

        private void PerformTransaction(Wallet wallet, double totalAmount)
        {
            wallet.PayForItems(totalAmount);
        }
    }

    
}
