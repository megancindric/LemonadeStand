using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Game
    {
        public Player player;
        public List<Day> days;
        int currentDay;
        public Store store;
        public Random rand;

        public Game()
        {
            player = new Player();
            store = new Store();
            days = new List<Day>();
            currentDay = 0;
            rand = new Random();

        }
        public void RunGame()
        {
            //3 pitchers is a good idea
            DisplayWelcome();
            while (this.currentDay < 7)
            {
                // Run this loop 7 times (1 week)
                // For each day:
                // Create the day, which will create weather for the day, add to days list
                days.Add(new Day(rand));
                // Display the current day
                Console.WriteLine($"\n\nWelcome to day {this.currentDay + 1}!\n\n");
                // Display the current weather FORECAST
                days[currentDay].weather.DisplayWeatherForecast();
                // Display the current inventory
                // Display the current money
                // Display the current recipe
                player.DisplayStatus();

                // Allow user to alter recipe & price

                // Get desired number of pitchers
                int numberOfPitchers = UserInterface.GetNumberOfPitchers();
                // Make number of pitchers
                // Number of pitchers * 8 will be total available cups
                // If they are short on items, go to the store

                bool canMakeLemonade = player.CanMakeLemonade(numberOfPitchers);

                while (!canMakeLemonade)
                {
                    GoToStore();
                    canMakeLemonade = player.CanMakeLemonade(numberOfPitchers);
                }
                // Display the current ACTUAL WEATHER
                days[currentDay].weather.DisplayActualWeather();
                // Determine today's customers
                // Determine total sales
                days[currentDay].CalculateCustomers();
                double totalSales = days[currentDay].CalculateSales((numberOfPitchers * 8), player.recipe.Price);
                // Add sales to wallet
                player.wallet.ReceiveMoney(totalSales);
                // Increment day
                currentDay++;
            }
            DisplayFinalScore();
        }


        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the lemonade stand!\nYou will have 7 days to try to make as much money as you can!\n\nGOOD LUCK!!");
        }

        public void GoToStore()
        {
            player.DisplayInventory();
            player.DisplayMoney();
            store.SellLemons(player);
            store.SellSugarCubes(player);
            store.SellIceCubes(player);
            store.SellCups(player);

        }

        public void DisplayFinalScore()
        {
            Console.WriteLine("\n\n=============== WEEK COMPLETED!! ===============\n\n");
            Console.WriteLine($"You ended the week with ${player.wallet.Money}!");
            Console.ReadLine();
        }
    }
}
