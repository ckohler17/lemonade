using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
        class Player
        {
            //member variables(Has A)
            public string name;
            public string response;
            public Recipe recipe;
            public Inventory inventory;
            public Wallet wallet;
            public Pitcher pitcher;

            //constructor(Builder)
            public Player()
            {
                recipe = new Recipe();
                inventory = new Inventory();
                wallet = new Wallet();
                pitcher = new Pitcher();
            }

            //member methods(Can Do)
            public void EnterNameOfPlayer()
            {
                Console.WriteLine("Please type in your name.");
                name = Console.ReadLine();
            }

            //buy items at the store



            //change recipe
            public void DoYouWantToChangeRecipe()
            {
            Console.WriteLine("There are currently " + recipe.amountOfIceCubes + " ice cubes, " + recipe.amountOfSugarCubes + " sugar cubes and " + recipe.amountOfLemons+ " lemons in your recipe. Do you want to change these values? Please enter 'yes' to change or 'no' to continue.");
                 response = Console.ReadLine();
            }
            public void ChangeNumberOfIceCubesInRecipe()
            {
                Console.WriteLine("There are currently " + recipe.amountOfIceCubes + " ice cubes in the recipe. How many ice cubes would you like?");
                recipe.amountOfIceCubes = int.Parse(Console.ReadLine());
            }
            public void ChangeNumberOfSugarCubesInRecipe()
            {
                Console.WriteLine("There are currently " + recipe.amountOfSugarCubes + " sugar cubes in the recipe. How many sugar cubes would you like?");
                recipe.amountOfSugarCubes = int.Parse(Console.ReadLine());
            }
            public void ChangeNumberOfLemonsInRecipe()
            {
                Console.WriteLine("There are currently " + recipe.amountOfLemons + " lemons in the recipe. How many lemons would you like?");
                recipe.amountOfLemons = int.Parse(Console.ReadLine());
            }
            public void DeterminePricePerCup()
            {
                Console.WriteLine("Currently, the price per cup is " + recipe.pricePerCup + ". How much would you like it to be?");
                recipe.pricePerCup = int.Parse(Console.ReadLine());
            }
    
    }
}

