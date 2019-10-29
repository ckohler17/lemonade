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
        public Weather weather;
        public List<Customer> customers;
        public string name;

        //constructor(Builder)
        public Day(int i)
        {
            weather = new Weather();
            customers = new List<Customer>();
            name = new List<string>(i) { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };


            
        }

        //member methods(Can Do)

    }
}
