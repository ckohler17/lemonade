using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        //member variables(Has A)
        public string condition;
        public int temperature;
        List<string> weatherConditions;

        //constructor(Builder)
        public Weather()
        {
            weatherConditions = new List<string>() { "cloudy", "rainy", "sunny", "muggy" };           
            
        }

        //member methods(Can Do)
        public void DetermineWeatherConditions(Random random)
        {
            int index = random.Next(weatherConditions.Count);
            condition = weatherConditions[index];            
        }
        public void DetermineTemperature(Random random)
        {
            temperature = random.Next(50,100);        
        }
        public void DisplayTemperature()
        {
            Console.WriteLine("The temperature is " + temperature + "degrees.");
        }
        public void DisplayWeatherConditions()
        {
            Console.WriteLine("The weather condition is " + condition + ".");
        }

    }
}
