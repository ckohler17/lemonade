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
    }
}
