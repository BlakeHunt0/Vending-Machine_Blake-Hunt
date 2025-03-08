using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine_Blake_Hunt
{
    class Item
    {
        public Item(string itemName, int itemNumber, double itemPrice, int itemQuantity)
        {
            this.ItemName = itemName;
            this.ItemNumber = itemNumber;
            this.ItemPrice = itemPrice;
            this.ItemQuantity = itemQuantity;
        }

        [Required]
        public string ItemName {  get; set; }
        [Required]
        public int ItemNumber {  get; set; }
        [Required]
        public double ItemPrice { get; set; }
        [Required]
        public int ItemQuantity { get; set; }
    }
}
