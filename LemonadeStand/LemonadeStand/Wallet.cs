using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Wallet
    {
        //member variables(Has A)
        double money;
        public double profit;
        public double Money
        {
            get
            {
                return money;
            }
            set
            {
                 money = value;
            }
            
        }

        //constructor(Builder)
        public Wallet()
        {
            money = 20.00;
            

        }

        //member methods(Can Do)
        public void DisplayWallet()
        {
            Console.WriteLine("You currently have $" + money + " in your wallet.");
        }
        public void ProfitPerDay(Day day)
        {
            
        }
    }
}
