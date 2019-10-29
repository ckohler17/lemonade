using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        //member variables(Has A)
        Player player;        
        List<Day> days;
        int currentDay;

        //constructor(Builder)
        public Game()
        {
            player = new Player();
            days = new List<Day>();
            for (int i = 0; i < 7; i++)
            {
                days.Add(new Day(i));
            }
                        
        }

        //member methods(Can Do)
        public void RunGame()
        {
            DisplayRules();
            //player.EnterNameOfPlayer();
            //player.ChangeRecipe();
            //if(player.response == "yes") {
            //    player.ChangeNumberOfIceCubesInRecipe();
            //    player.ChangeNumberOfLemonsInRecipe();
            //    player.ChangeNumberOfSugarCubesInRecipe();
            //}
            WeatherPerDay();
            Forecast();
            
            
        }
        public void DisplayRules()
        {
            Console.WriteLine("You have 7 days to try to make as much money as you can selling lemonade. You will want to check the weather" +
                "everyday to determine how much lemonade you think you might sell on a given day so that you know how many of your supplies" +
                " you will need to purchase.");
        }
        public void WeatherPerDay()
        {
            foreach (Day day in days)
            {
                day.weather.DetermineTemperature();
                day.weather.DetermineWeatherConditions();
            }
        }
        public void Forecast()
        {
            Console.WriteLine("The weather on " + day.name[0] + "will be " + day.weather.temperature[0] + " and" + day.weather.condition[0] + ". The weather on " + day[1] + "will be " + day.weather.temperature[1] + " and" + day.weather.condition[1] + "." );
        }

    }
}
