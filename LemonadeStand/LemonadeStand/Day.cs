using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        //member variables(Has A)
        public Weather weather;
        public List<Customer> customers;
        public string name;
      
        //constructor(Builder)
        public Day(int i)
        {
            weather = new Weather();
            DetermineDayOfWeek(i);
                                
        }

        //member methods(Can Do)
        public void RunDay(Store store, Player player, Recipe recipe)
        {

            player.DoYouWantToChangeRecipe();
            if (player.response == "yes")
            {
                player.ChangeNumberOfIceCubesInRecipe();
                player.ChangeNumberOfLemonsInRecipe();
                player.ChangeNumberOfSugarCubesInRecipe();
            }
            player.DeterminePricePerCup();
            store.DisplayPriceOfAllItems();
            player.wallet.DisplayWallet();
            store.SellCups(player);
            store.SellIceCubes(player);
            store.SellLemons(player);
            store.SellSugarCubes(player);
            player.inventory.DisplayInventory();
            player.pitcher.MakeAPitcherOfLemonade(player.inventory, player.recipe);
            player.inventory.SubtractIceCubesInventory(recipe);
            player.inventory.SubtractLemonInventory(recipe);
            player.inventory.SubtractSugarCubeInventory(recipe);
            DetermineNumberOfCustomers();
            foreach(Customer customer in customers)
            {   if (player.pitcher.cupsLeftInPitcher > 0)
                {
                    customer.OddsCustomerIsWillingToBuyBasedOnRecipe(player.recipe);
                    customer.OddsCustomerIsWillingToBuyBasedOnTemperature(weather);
                    customer.OddsCustomerIsWillingToBuyBasedOnWeather(weather);
                    customer.ChanceCustomerBuys(player.pitcher, player, recipe);
                    if (player.pitcher.cupsLeftInPitcher < 1)
                    {
                        player.pitcher.MakeAPitcherOfLemonade(player.inventory, recipe);
                        if (player.pitcher.cupsLeftInPitcher > 0)
                        {
                            player.inventory.SubtractIceCubesInventory(recipe);
                            player.inventory.SubtractLemonInventory(recipe);
                            player.inventory.SubtractSugarCubeInventory(recipe);
                        }

                    }
                }
            }
            player.wallet.DisplayWallet();
            Console.WriteLine("Done");

        }

        public void DetermineDayOfWeek(int i)
        {
           
                switch (i)
            {
                case 0:
                    name = "Sunday";
                    break;
                case 1:
                    name = "Monday";
                    break;
                case 2:
                    name = "Tuesday";
                    break;
                case 3:
                    name = "Wednesday";
                    break;
                case 4:
                    name = "Thursday";
                    break;
                case 5:
                    name = "Friday";
                    break;
                case 6:
                    name = "Saturday";
                    break;                  

            }

        }


        public void DetermineNumberOfCustomers()
        {
            Random random = new Random();
            int potentialCustomers = random.Next(2, 10); 
            customers = new List<Customer>();
            for (int i = 0; i < potentialCustomers; i++)
            {
                customers.Add(new Customer());
            }
        }

    }
}
