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
                // Create the day (days at current index) which will create weather for the day
                days[currentDay] = new Day(rand);
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
                bool madeLemonade = player.CanMakeLemonade(numberOfPitchers);
                // Display the current ACTUAL WEATHER
                days[currentDay].weather.DisplayActualWeather();
                // Determine today's customers
                // Determine total sales
                // Add sales to wallet
                // Increment day
                currentDay++;
            }
            
        
        }

        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the lemonade stand!\nYou will have 7 days to try to make as much money as you can!\n\nGOOD LUCK!!");
        }
    }
}
