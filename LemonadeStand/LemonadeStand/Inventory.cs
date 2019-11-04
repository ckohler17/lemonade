using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        //this is an example of Open/Close Principle. It is open to add any new methods that might need to be added
        //for more ingredients but wouldn't change the current functionality.
        
        //member variables(Has A)
        public List<Lemon> lemons;
        public List<Cup> cups;
        public List<SugarCubes> sugarCubes;
        public List<IceCube> iceCubes;

        //constructor(Builder)
        public Inventory()
        {
            lemons = new List<Lemon>();
            cups = new List<Cup>();
            sugarCubes = new List<SugarCubes>();
            iceCubes = new List<IceCube>();

        }

        //member methods(Can Do)
       public void DisplayInventory()
        {
            Console.WriteLine("This is what your inventory looks like:");
            Console.WriteLine("Lemons: " + lemons.Count);
            Console.WriteLine("Cups: " + cups.Count);
            Console.WriteLine("Sugar cubes: " + sugarCubes.Count);
            Console.WriteLine("Ice cubes: " + iceCubes.Count);
        }
        public void AddLemonInventory(int lemonsBought)
        {            
            for(int i = 0; i < lemonsBought; i++)
            {
                lemons.Add(new Lemon());
            }
        }
        public void AddCupsInventory(int cupsBought)
        {            
            for (int i = 0; i < cupsBought; i++)
            {
                cups.Add(new Cup());
            }
        }
        public void AddSugarCubesInventory(int sugarCubesBought)
        {            
            for(int i =0; i < sugarCubesBought; i++)
            {
                sugarCubes.Add(new SugarCubes());
            }
        }
        public void AddIceCubesInventory(int iceCubesBought)
        {           
            for(int i = 0; i < iceCubesBought; i++)
            {
                iceCubes.Add(new IceCube());
            }
        }
        public void SubtractLemonInventory(Recipe recipe)
        {
           for(int i = 0; i < recipe.amountOfLemons; i++)
            {
                lemons.RemoveAt(lemons.Count-1);
            }
        }
        public void SubtractSugarCubeInventory(Recipe recipe)
        {
            for(int i = 0; i < recipe.amountOfSugarCubes; i++)
            {
                sugarCubes.RemoveAt(sugarCubes.Count-1);
            }
        }
        public void SubtractIceCubesInventory(Recipe recipe)
        {
            for(int i = 0; i < recipe.amountOfIceCubes; i++)
            {
                iceCubes.RemoveAt(iceCubes.Count-1);
            }
        }
        public void SubtractCupsInventory()
        {
            cups.RemoveAt(cups.Count - 1);
        }

    }
}
