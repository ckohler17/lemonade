using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Pitcher
    {
        //member variables(Has A)
        public int cupsLeftInPitcher;
        public Recipe recipe;

        //constructor(Builder)
        public Pitcher()
        {
            recipe = new Recipe();           
        }

        //member methods(Can Do)
        public void MakeAPitcherOfLemonade(Inventory inventory)
        {
            if(inventory.lemons.Count >= recipe.amountOfLemons && inventory.iceCubes.Count >= recipe.amountOfIceCubes && inventory.sugarCubes.Count >= recipe.amountOfSugarCubes)
            {
                cupsLeftInPitcher = 12;
                
            } else
            {
                Console.WriteLine("You do not have enough ingredients to make a new pitcher of lemonade.");
            }

        }
    }
}
