using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        //member variables(Has A)
        List<string> names;
        public int oddsOnWeather;
        public int oddsOnTemperature;
        public int oddsOnRecipe;
        public int oddsOnPrice;             


        //constructor(Builder)
        public Customer()
        {
            names = new List<string>() { "First Person", "Candy Cane", "Carolynn Kohler", "Fourth Person", "Minnie Mouse", "Mickey Mouse",
            "Lolli Pop", "Tootsie Roll"};
            
        }

        //member methods(Can Do)

        public void OddsCustomerIsWillingToBuyBasedOnWeather(Weather weather)  
        {
            Random random = new Random();
            if(weather.condition == "cloudy")
            {
                oddsOnWeather = random.Next(40, 90);
            }
            if(weather.condition == "rainy")
            {
                oddsOnWeather = random.Next(35, 70);
            }
            if(weather.condition == "sunny")
            {
                oddsOnWeather = random.Next(60, 100);
            }
            if(weather.condition == "muggy")
            {
                oddsOnWeather = random.Next(40, 90);
            }
        }
        public void OddsCustomerIsWillingToBuyBasedOnTemperature(Weather weather)
        {
            Random random = new Random();
            if(weather.temperature > 70)
            {
                oddsOnTemperature = random.Next(60, 100);
            } else
            {
                oddsOnTemperature = random.Next(30, 70);
            }
        }
        public void OddsCustomerIsWillingToBuyBasedOnRecipe(Recipe recipe)
        {
            Random random = new Random();
            if(recipe.amountOfIceCubes.ToString() != "8" && recipe.amountOfLemons.ToString() != "4" && recipe.amountOfSugarCubes.ToString() != "4")
            {
                oddsOnRecipe = random.Next(30, 70);
            } else
            {
                oddsOnRecipe = random.Next(60, 100);
            }
        }
        public void OddsCustomerIsWillingToBuyBasedOnPrice(Recipe recipe)
        {
            Random random = new Random();
            if(recipe.pricePerCup > 1.25)
            {
                oddsOnPrice = random.Next(30, 65);
            } else if(recipe.pricePerCup < 1.26 && recipe.pricePerCup > .74)
            {
                oddsOnPrice = random.Next(40, 85);
            } else
            {
                oddsOnPrice = random.Next(35, 90);
            }
        }
        public bool ChanceCustomerBuys(Pitcher pitcher, Player player, Recipe recipe, Weather weather)
        {
            OddsCustomerIsWillingToBuyBasedOnPrice(recipe);
            OddsCustomerIsWillingToBuyBasedOnRecipe(recipe);
            OddsCustomerIsWillingToBuyBasedOnTemperature(weather);
            OddsCustomerIsWillingToBuyBasedOnWeather(weather);
            if(oddsOnRecipe > 50 && oddsOnTemperature > 50 && oddsOnWeather > 50 && oddsOnPrice > 50)
            {
                Console.WriteLine("Bought a cup!");
                pitcher.cupsLeftInPitcher -= 1;
                return true;

            } else
            {
                
                Console.WriteLine("Didn't buy a cup. :(");
                return false;
            }
        }


    }
}
