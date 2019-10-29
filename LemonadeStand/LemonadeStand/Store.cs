using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        //member variables(Has A)
        double pricePerLemon;
        double pricePerIceCube;
        double pricePerCup;
        double pricePerSugarCube;
        

        //constructor(Builder)
        public Store()
        {
            pricePerCup = .01;
            pricePerIceCube = .02;
            pricePerLemon = .05;
            pricePerSugarCube = .05;
            
        }

        //member methods(Can Do)
        public void DisplayPricePerCup() 
        {
            Console.WriteLine("The price of a cup is " + pricePerCup + ".");
        }
        public void DisplayPricePerIceCube()
        {
            Console.WriteLine("The price of an ice cube is " + pricePerIceCube + ".");
        }
        public void DisplayPricePerLemon()
        {
            Console.WriteLine("The price of a lemon is " + pricePerLemon + ".");
        }
        public void DisplayPricePerSugarCube()
        {
            Console.WriteLine("The price of a sugar cube is " + pricePerSugarCube + ".");
        }
        public void DisplayPriceOfAllItems()
        {
            Console.WriteLine("The price of a cup is " + pricePerCup + ".");
            Console.WriteLine("The price of an ice cube is " + pricePerIceCube + ".");
            Console.WriteLine("The price of a lemon is " + pricePerLemon + ".");
            Console.WriteLine("The price of a sugar cube is " + pricePerSugarCube + ".");
        }
        public void HowManyCupsToBuy() 
        {
            Console.WriteLine("How many cups would you like to buy?");
            int cupsBought = int.Parse(Console.ReadLine());
        }
        public void HowManyIceCubesToBuy()
        {
            Console.WriteLine("How many ice cubes would you like to buy?)";
            int iceCubesBought = int.Parse(Console.ReadLine());
        }
        public void HowManyLemonsToBuy()
        {
            Console.WriteLine("How many lemons would you like to buy?");
            int lemonsBought = int.Parse(Console.ReadLine());
        }
        public void HowManySugarCubesToBuy()
        {
            Console.WriteLine("How many sugar cubes would you like to buy?)";
            int sugarCubesBought = int.Parse(Console.ReadLine());
        }

        
    }
}
