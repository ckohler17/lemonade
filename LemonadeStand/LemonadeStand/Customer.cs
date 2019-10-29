using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        //member variables(Has A)
        List<string> names;
        


        //constructor(Builder)
        public Customer()
        {
            names = new List<string>() { "First Person", "Candy Cane", "Carolynn Kohler", "Fourth Person", "Minnie Mouse", "Mickey Mouse",
            "Lolli Pop", "Tootsie Roll"};
            
        }

        //member methods(Can Do)

        public void IsCustomerWillingToBuy()
        {

        }
    }
}
