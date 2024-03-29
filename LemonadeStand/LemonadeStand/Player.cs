﻿using System;
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
        public double profitTotal;
        public double lossTotal;


        //constructor(Builder)
        public Player()
        {
            recipe = new Recipe();
            inventory = new Inventory();
            wallet = new Wallet();
            pitcher = new Pitcher();
            profitTotal = 0;
            lossTotal = 0;

        }

        //member methods(Can Do)
        public void EnterNameOfPlayer()
        {
            Console.WriteLine("Please type in your name.");
            name = Console.ReadLine();
        }


        public void DoYouWantToChangeRecipe()
        {
            Console.WriteLine("There are currently " + recipe.amountOfIceCubes + " ice cubes, " + recipe.amountOfSugarCubes + " sugar cubes and " + recipe.amountOfLemons + " lemons in your recipe. Do you want to change these values? Please enter 'yes' to change or 'no' to continue.");
            response = Console.ReadLine().ToLower();
            if(response != "yes" && response != "no")
            {
                Console.WriteLine("Sorry, I did not recognize your response. Please enter either 'yes' or 'no'.");
                DoYouWantToChangeRecipe();
            }
        }
        public void ChangeNumberOfIceCubesInRecipe()
        {
            Console.WriteLine("There are currently " + recipe.amountOfIceCubes + " ice cubes in the recipe. How many ice cubes would you like?");
            try 
            {
                recipe.amountOfIceCubes = Convert.ToInt32(Console.ReadLine()); 
            } catch
            {
                Console.WriteLine("Sorry, I did not recognize that. Please enter a number.");
            }
            

        }
        public void ChangeNumberOfSugarCubesInRecipe()
        {
            Console.WriteLine("There are currently " + recipe.amountOfSugarCubes + " sugar cubes in the recipe. How many sugar cubes would you like?");
            try
            {
                recipe.amountOfSugarCubes = int.Parse(Console.ReadLine());
            } catch
            {
                Console.WriteLine("Sorry, I do not recognize that. Please enter a number.");
            }
            
        }
        public void ChangeNumberOfLemonsInRecipe()
        {
            Console.WriteLine("There are currently " + recipe.amountOfLemons + " lemons in the recipe. How many lemons would you like?");
            try
            {
                recipe.amountOfLemons = int.Parse(Console.ReadLine());
            } catch
            {
                Console.WriteLine("Sorry, I do not recognize that. Please enter a number.");
            }
        }
        public void DeterminePricePerCup()
        {
            Console.WriteLine("Currently, the price per cup of lemonade is " + recipe.pricePerCup + ". How much would you like it to be?");
            try
            {
                recipe.pricePerCup = double.Parse(Console.ReadLine());
            } catch
            {
                Console.WriteLine("Sorry, I didn't recognize that. Please enter a number.");
                DeterminePricePerCup();
            }
            
        }
        public void DisplayTotalProfit()
        {
            Console.WriteLine(name + " your total profit is " + profitTotal + ".");
        }
    }
}

