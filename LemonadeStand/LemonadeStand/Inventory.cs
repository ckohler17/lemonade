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
            lemons = new List<Lemon>();
            cups = new List<Cup>();
            sugarCubes = new List<SugarCubes>();
            iceCubes = new List<IceCube>();
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

    }
}
