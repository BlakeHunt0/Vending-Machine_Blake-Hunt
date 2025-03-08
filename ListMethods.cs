using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Vending_Machine_Blake_Hunt
{
    internal class ListMethods
    {
        //put in some data at start
        public static void InitData(List<Item> current)
        {
            string[] allNames = {
                //new items must be formated as follows:
                //    price must span from the 0-5 string characters starting with a "$"
                //    price must be bellow $9.99
                //    price must be made up of dollars, quarters, and dimes
                //    name is separated by a space and can span for as long as needed
                "$2.38 Lays Plain Potato Chips",
                "$3.50 Lays Barbique Potato Chips",
                "$4.00 Lays Sour Cream and Onion",
                "$3.98 Sun Chips French Onion",
                "$3.98 Sun Chips Salsa",
                "$2.38 Doritos Nacho Cheese",
                "$2.38 Doritos Cool Ranch",
                "$3.33 Cheetos Cheese Flavor",
                "$4.48 Freetos standard"
            };

            int i = 0;

            foreach (string name in allNames)
            { 
                //item name
                string itemName = allNames[i].Substring(6);

                //item price
                string priceString = allNames[i].Substring(1, 4);
                double itemPrice = Convert.ToDouble(priceString);

                //get inventory quantity
                string txtFull = System.IO.Path.Combine(Environment.CurrentDirectory, @"..\..\..\Data\Inventory.txt");
                string txtPath = Path.GetFullPath(txtFull);
                //skip is the line
                string qLine = File.ReadLines(txtPath).Skip(i).Take(1).Last();
                string quantityNum = qLine.Substring(2);
                int itemQuantity = Convert.ToInt16(quantityNum);

                //add new item to list
                current.Add(new Item(itemName, i + 1, itemPrice, itemQuantity));
                i++;
            }
        }

        //print all items
        public static void PrintAll(List<Item> itemList)
        {
            int i = 0;
            foreach (Item product in itemList)
            {
                Console.Write(itemList[i].ItemNumber.ToString() + " ");
                Console.Write(itemList[i].ItemName.ToString() + " ");
                Console.Write("Price " + itemList[i].ItemPrice.ToString() + " ");
                Console.Write("Available Stock " + itemList[i].ItemQuantity.ToString() + " \n\n");

                i++;
            }
        }

        //vend one item
        public static void VendOne(List<Item> itemList, int x)
        {
            //create vending message
            Console.WriteLine("Vending:");
            Console.WriteLine(itemList[x - 1].ItemName.ToString());

            //remove one item from inventory
            string text = File.ReadAllText(@"..\..\..\Data\Inventory.txt");
            string findLine = (x + " " + itemList[x - 1].ItemQuantity).ToString();
            string replaceLine = (x + " " + (itemList[x - 1].ItemQuantity - 1)).ToString();
            text = text.Replace(findLine, replaceLine);
            File.WriteAllText(@"..\..\..\Data\Inventory.txt", text);

            //lower ItemQuantity
            itemList[x].ItemQuantity = itemList[x].ItemQuantity - 1;

            //it only occurs to me now that I could've made use of ItemQuantity 
        }

        //add one item
        public static void Add(List<Item> itemList, string name, double price, int inventoryNum)
        {
            //add new item to list
            int i = (itemList.Count + 1);
            itemList.Add(new Item(name, i, price, inventoryNum));
        }
    }
}
