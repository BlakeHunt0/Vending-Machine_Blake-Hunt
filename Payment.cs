using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine_Blake_Hunt
{
    //internal for no particular reason
    internal class Payment
    { 
        public static double CoinCounter (double fullprice)
        {
            double price = fullprice;

            double dime = 0.10;
            double quarter = 0.25;
            double dollar = 1.00;

            double fullCoinVal = 0.0;

            //while the rpice hasn't been met
            while (price > fullCoinVal)
            {
                Console.Clear();
                Console.WriteLine("Please insert coins");
                Console.WriteLine("1. Dollar\n2. Quarter\n3. Dime");
                Console.WriteLine("Current Price: " + price);
                Console.WriteLine("Price Remaining: " + (price - fullCoinVal));
                
                //get coin input
                string input = Convert.ToString("" + Console.ReadLine());

                //TODO: I had to put this down i need to make some sort of inventory
            }

            //subtract from price using the previous values
            //once value is reached, vend, and return the differnce

            return price;
        }
    }
}
