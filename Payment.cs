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
        public static decimal GetItemPrice (List<Item> itemList, int itmnum)
        {
            decimal price = 0;

            //get item string
            string priceString = itemList[itmnum - 1].ItemName.ToString();

            //pull out the price
            string priceString2 = priceString.Substring(1, 4);
            price = Convert.ToDecimal(priceString2);

            return price;
        }

        public static decimal Ppp (decimal fullprice)
        {
            decimal price = fullprice;

            //lowest change i can find a vending machine accepting is a dime, so the total must be a multiple of 5 (quarter)
            decimal dime = 0.10m;
            decimal quarter = 0.25m;
            decimal dollar = 1.00m;

            //subtract from price using the previous values
            //once valuw is reached, vend, and return the differnce

            return price;
        }
    }
}
