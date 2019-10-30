using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        //member variables(Has A)
        public List<Lemon> lemons;
        public List<Cup> cups;
        public List<SugarCubes> sugarCubes;
        public List<IceCube> iceCubes;

        //constructor(Builder)
        public Inventory()
        {
       
         
        }

        //member methods(Can Do)
       public void DisplayInventory()
        {
            Console.WriteLine("Currently this is what your inventory looks like:");
            Console.WriteLine("Lemons: " + lemons.Count);
            Console.WriteLine("Cups: " + cups.Count);
            Console.WriteLine("Sugar cubes: " + sugarCubes.Count);
            Console.WriteLine("Ice cubes: " + iceCubes.Count);
        }
        public void AddLemonInventory(int lemonsBought)
        {
            lemons = new List<Lemon>();
            for(int i = 0; i < lemonsBought; i++)
            {
                lemons.Add(new Lemon());
            }

        }
        public void AddCupsInventory(int cupsBought)
        {
            cups = new List<Cup>();
            for (int i = 0; i < cupsBought; i++)
            {
                cups.Add(new Cup());
            }
        }
        public void AddSugarCubesInventory(int sugarCubesBought)
        {
            sugarCubes = new List<SugarCubes>();
            for(int i =0; i < sugarCubesBought; i++)
            {
                sugarCubes.Add(new SugarCubes());
            }
        }
        public void AddIceCubesInventory(int iceCubesBought)
        {
            iceCubes = new List<IceCube>();
            for(int i = 0; i < iceCubesBought; i++)
            {
                iceCubes.Add(new IceCube());
            }
        }
        public void SubtractLemonInventory(Recipe recipe)
        {
            lemons = new List<Lemon>();
            for(int i = 0; i < recipe.amountOfLemons; i++)
            {
                lemons.Remove(new Lemon());
            }
        }
        public void SubtractSugarCubeInventory(Recipe recipe)
        {
            for(int i = 0; i < recipe.amountOfSugarCubes; i++)
            {
                sugarCubes.Remove(new SugarCubes());
            }
        }
        public void SubtractIceCubesInventory(Recipe recipe)
        {
            for(int i = 0; i < recipe.amountOfSugarCubes; i++)
            {
                iceCubes.Remove(new IceCube());
            }
        }

    }
}
