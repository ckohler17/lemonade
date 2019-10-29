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
        Day day;
        List<Day> days;
        int currentDay;

        //constructor(Builder)
        public Game()
        {
            player = new Player();
            day = new Day(0);
           
                                   
        }

        //member methods(Can Do)
        public void RunGame()
        {
            DisplayRules();
            DetermineNumberOfDays();          
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
        public void DetermineNumberOfDays()
        {
            days = new List<Day>();
            for (int i = 0; i < 7; i++)
            {
                days.Add(new Day(i));
            }
        }
        public void WeatherPerDay()
        {
            Random random = new Random();
            foreach (Day day in days)
            {
                day.weather.DetermineTemperature(random);
                day.weather.DetermineWeatherConditions(random);
            }
        }
        public void Forecast()
        {
            Console.WriteLine("Here is your forcast for the week. On " + days[0].name + " it will be " + days[0].weather.temperature + " and " + days[0].weather.condition + ".");
            Console.WriteLine("On " + days[1].name + " it will be " + days[1].weather.temperature + " and " + days[1].weather.condition + ".");
            Console.WriteLine("On " + days[2].name + " it will be " + days[2].weather.temperature + " and " + days[2].weather.condition + ".");
            Console.WriteLine("On " + days[3].name + " it will be " + days[3].weather.temperature + " and " + days[3].weather.condition + ".");
            Console.WriteLine("On " + days[4].name + " it will be " + days[4].weather.temperature + " and " + days[4].weather.condition + ".");
            Console.WriteLine("On " + days[5].name + " it will be " + days[5].weather.temperature + " and " + days[5].weather.condition + ".");
            Console.WriteLine("On " + days[6].name + " it will be " + days[6].weather.temperature + " and " + days[6].weather.condition + ".");
        }

    }
}
