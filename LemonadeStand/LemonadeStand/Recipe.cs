using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        //member variables(Has A)s
        public int amountOfIceCubes;
        public int amountOfSugarCubes;
        public int amountOfLemons;
        public double pricePerCup;


        //constructor(Builder)
        public Recipe()
        {
            amountOfIceCubes = 8;
            amountOfSugarCubes = 4;
            amountOfLemons = 4;
            pricePerCup = .75;
        }

        //member methods(Can Do)

    }
}
