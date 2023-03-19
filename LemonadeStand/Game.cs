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

        public Game()
        {
            player = new Player();
            store = new Store();
            days = new List<Day>();
            currentDay = 1;

        }
        public void RunGame()
        {
            DisplayWelcome();
            while (currentDay < 8)
            {
                // Run this loop 7 times (1 week)
                // For each day:
                // Display the current day
                // Display the current weather FORECAST
                // Display the current inventory
                // Display the current recipe
                // Allow user to alter recipe & price
                // Get desired number of pitchers
                // Make number of pitchers
                // If they are short on items, go to the store
                // Display the current ACTUAL WEATHER
                // Determine today's customers
                // Determine total sales
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
