using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Weather
    {
        public string condition;
        public int temperature;
        private List<string> weatherChoices;
        private Random rand;
        public string predictedForecast;

        public Weather(Random rand)
        {
            this.rand = rand;
            weatherChoices = new List<string> { "mostly sunny", "party cloudy", "cold & rainy" };
            PredictWeather();
        }

        public void PredictWeather()
        {
            // Randomly generate a number between 0 and 10
            int randomNumber = rand.Next(11);
            // Based on that number, we will fall into 3 categories, similar to weatherChoices above
            if (randomNumber >= 8)
            {
                // Sunny weather
                temperature = 80;
                condition = weatherChoices[0];
                predictedForecast = "Bright & sunny skies ahead!";
            }
            else if (randomNumber >= 4)
            {
                // Mild weather
                temperature = 70;
                condition = weatherChoices[1];
                predictedForecast = "A mild day, with pleasant temperatures!";
            }
            else
            {
                // Gross weather
                temperature = 50;
                condition = weatherChoices[2];
                predictedForecast = "Rain ahead, looks like a good day to stay inside!";

            }
            // Prediction will indicate actual forecast
            // Then, assign temperature, condition, and predictedForecast based on category
        }

        public void DisplayWeatherForecast()
        {
            Console.WriteLine($"Today's weather forecast is: {predictedForecast}");
        }

        public void DisplayActualWeather()
        {
            Console.WriteLine($"Today was {temperature} degrees F, and {condition}!");
        }

    }
}
