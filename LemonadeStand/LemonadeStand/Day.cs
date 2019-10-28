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
        Weather weather;
        public List<Customer> customers;

        //constructor(Builder)
        public Day()
        {
            weather = new Weather();
            customers = new List<Customer>();
        }

        //member methods(Can Do)
    }
}
