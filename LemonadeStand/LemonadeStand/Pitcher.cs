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
        

        //constructor(Builder)
        public Pitcher()
        {
                    
        }

        //member methods(Can Do)
        public void MakeAPitcherOfLemonade(Inventory inventory, Recipe recipe)
        {
            if(inventory.lemons.Count >= recipe.amountOfLemons && inventory.iceCubes.Count >= recipe.amountOfIceCubes && inventory.sugarCubes.Count >= recipe.amountOfSugarCubes)
            {
                cupsLeftInPitcher = 2;
                
            } else
            {
                Console.WriteLine("You do not have enough ingredients to make a new pitcher of lemonade.");
            }

        }
    }
}
