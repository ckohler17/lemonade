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
        public List<Day> days;
        double totalProfit;
        int currentDay;
        Store store;
        public string playagain;

        //constructor(Builder)
        public Game()
        {
            player = new Player();          
            store = new Store();    
                                                                    
        }

        //member methods(Can Do)
        public void RunGame()
        {
            DisplayRules();
            player.EnterNameOfPlayer();
            DetermineNumberOfDays();
            WeatherPerDay();
            Forecast();            
            foreach(Day day in days)
            {
                day.RunDay(store, player, player.recipe);                
            }
            DisplayProfitLossTotal();
            PlayAgain();
            if(playagain == "yes")
            {
                RunGame();
            }         
                            
                  
            
        }
        public void DisplayRules()
        {
            Console.WriteLine("You have 7 days to try to make as much money as you can selling lemonade. You will want to check the weather " +
                "everyday to determine how much lemonade you think you might sell on a given day so that you know how many of your supplies " +
                "you will need to purchase.");
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
        public void PlayAgain()
        {
            Console.WriteLine("Game over. Would you like to play again? Please enter 'yes' or 'no'.");
            playagain = Console.ReadLine().ToLower();
            if(playagain != "yes" && playagain != "no")
            {
                Console.WriteLine("Sorry, I did not recognize your answer. Please respond with 'yes' or 'no'.");
            }
        }
        public void DisplayProfitLossTotal()
        {
            if(store.lossTotal > player.profitTotal)
            {
                double gameLoss = (store.lossTotal - player.profitTotal);
                Console.WriteLine(player.name + " your total loss is " + gameLoss + ".");
            }else if(player.profitTotal > store.lossTotal)
            {
                double gameProfit = (player.profitTotal - store.lossTotal);
                Console.WriteLine(player.name + " your total profit is " + gameProfit + ".");
            }else
            {
                Console.WriteLine(player.name + " you broke even.");
            }

        }


    }
}
