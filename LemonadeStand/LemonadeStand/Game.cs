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
            
        }

        //member methods(Can Do)
        public void RunGame()
        {
            DisplayRules();
            player.EnterNameOfPlayer();
            player.ChangeRecipe();
            if(player.response == "yes") {
                player.ChangeNumberOfIceCubesInRecipe();
                player.ChangeNumberOfLemonsInRecipe();
                player.ChangeNumberOfSugarCubesInRecipe();
            }
            
            
        }
        public void DisplayRules()
        {
            Console.WriteLine("You have 7 days to try to make as much money as you can selling lemonade. You will want to check the weather" +
                "everyday to determine how much lemonade you think you might sell on a given day so that you know how many of your supplies" +
                "you will need to purchase.");
        }
    }
}
