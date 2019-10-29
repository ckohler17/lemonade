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
            DetermineDayOfWeek(i);
                       
        }

        //member methods(Can Do)
        public void DetermineDayOfWeek(int i)
        {
           
                switch (i)
            {
                case 0:
                    name = "Sunday";
                    break;
                case 1:
                    name = "Monday";
                    break;
                case 2:
                    name = "Tuesday";
                    break;
                case 3:
                    name = "Wednesday";
                    break;
                case 4:
                    name = "Thursday";
                    break;
                case 5:
                    name = "Friday";
                    break;
                case 6:
                    name = "Saturday";
                    break;                  

            }

        }

    }
}
