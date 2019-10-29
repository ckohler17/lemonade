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
        public void ChangeLemonInventory(int lemonsBought)
        {
            lemons = new List<Lemon>();
            for(int i = 0; i < lemonsBought; i++)
            {
                lemons.Add(new Lemon());
            }

        }
        public void ChangeCupsInventory(int cupsBought)
        {
            cups = new List<Cup>();
            for (int i = 0; i < cupsBought; i++)
            {
                cups.Add(new Cup());
            }
        }
        public void ChangeSugarCubesInventory(int sugarCubesBought)
        {
            sugarCubes = new List<SugarCubes>();
            for(int i =0; i < sugarCubesBought; i++)
            {
                sugarCubes.Add(new SugarCubes());
            }
        }
        public void ChangeIceCubesInventory(int iceCubesBought)
        {
            iceCubes = new List<IceCube>();
            for(int i = 0; i < iceCubesBought; i++)
            {
                iceCubes.Add(new IceCube());
            }
        }

    }
}
