using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Day
    {
        public Weather weather;
        public List<Customer> customers;
        public int weatherBoost;
        public Random rand;
        public Day(Random rand)
        {
            this.rand = rand;
            weather = new Weather(rand);
            customers = new List<Customer>();
            weatherBoost = 0; 
        }
        public void CalculateCustomers()
        {
            // Based on current weather, we will determine the number of customers
            //"mostly sunny", "party cloudy", "cold & rainy"
            int numberOfCustomers = 0;
            if (weather.condition == "mostly sunny")
            {
                weatherBoost = 2;
                numberOfCustomers = 20;
            }
            else if (weather.condition == "partly cloudy")
            {
                weatherBoost = 1;
                numberOfCustomers = 15;
            }
            else
            {
                numberOfCustomers = 8;
            }
            // Then, append that number of customers to customers list
            for (int i = 0; i < numberOfCustomers; i++) { 
                Customer newCustomer = new Customer();
                customers.Add(newCustomer);
            }
        }
        public double CalculateSales(int cupsMade, double cupPrice)
        {
            double totalSales = 0;
            int numberOfSales = 0;
            // Each customer will randomly choose to buy a cup
            foreach(Customer customer in customers)
            {
                Console.WriteLine("A customer approaches!\n");
                bool didBuyCup = customer.BuyLemonade(rand, weatherBoost);
                if (didBuyCup)
                {
                    Console.WriteLine("They decided to buy a cup of lemonade!\n");
                    if (cupsMade > 0)
                    {
                        numberOfSales++;
                        totalSales += cupPrice;
                        cupsMade--;
                        Console.WriteLine("And they bought a refreshing cup of lemonade! :)");
                    }
                    else
                    {
                        Console.WriteLine("...but there was no lemonade left to buy :(");
                    }
                    
                }
                else
                {
                    Console.WriteLine("And they decided not to buy any!");
                }
            }
            // Confirm there is still cups available, then...
            // If they buy a cup, increment numberOfSales by 1
            // And increment dailySales by the price

            // Finally, print out information about the total number of customers, how many bought a cup, and overall total income
            return totalSales;
        }
    }

    
}
