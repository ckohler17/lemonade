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
        public  double dailyProfit;
        public double dailyLoss;
      
        //constructor(Builder)
        public Day(int i)
        {
            weather = new Weather();
            DetermineDayOfWeek(i);        
                                
        }

        //member methods(Can Do)
        public void RunDay(Store store, Player player, Recipe recipe)
        {
            NewDayMessage(player);
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
            player.inventory.DisplayInventory();
            store.SellCups(player);
            store.SellIceCubes(player);
            while (player.inventory.iceCubes.Count < recipe.amountOfIceCubes)
            {
                Console.WriteLine("You do not have enough ice cubes to make a pitcher, please purchase more.");
                store.SellIceCubes(player);                
            }           
            store.SellLemons(player);
            while (player.inventory.lemons.Count < recipe.amountOfLemons)
            {
                Console.WriteLine("You do not have enough lemons to make a pitcher, please purchase more.");
                store.SellLemons(player);
            }
            store.SellSugarCubes(player); 
            while(player.inventory.sugarCubes.Count < recipe.amountOfSugarCubes)
            {
                Console.WriteLine("You do not have enough sugar cubes to make a pitcher, please purchase more.");
                store.SellSugarCubes(player);
            }
            player.pitcher.MakeAPitcherOfLemonade(player.inventory, player.recipe);
            DetermineNumberOfCustomers();
            foreach(Customer customer in customers)
            {   if (player.pitcher.cupsLeftInPitcher > 0)
                {
                    bool decision = customer.ChanceCustomerBuys(player.pitcher, player, recipe, weather);
                    if (decision == true)
                    {
                        player.wallet.Money += recipe.pricePerCup;
                        dailyProfit += recipe.pricePerCup;
                        player.profitTotal += recipe.pricePerCup;
                        player.inventory.SubtractCupsInventory();                        
                    }
                    if (player.pitcher.cupsLeftInPitcher < 1)
                    {
                        player.pitcher.MakeAPitcherOfLemonade(player.inventory, recipe);
                    }                    
                }                
            }
            DisplayDailyProfit();
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
        public void NewDayMessage(Player player)
        {
            Console.WriteLine("Hi " + player.name + "! Today is " + name + ". The weather will be " + weather.temperature + " and " + weather.condition + ".");
        }
        public void DisplayDailyProfit()
        {
            Console.WriteLine("Your daily profit was " + dailyProfit + ".");
        }
        public void DisplanyDailyLoss()
        {
            dailyLoss = 
        }

        

    }
}
