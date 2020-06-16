using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sahara.entities
{
    public class Items
    {

        public double price { get; set; }
        public string itemName { get; set; }
        public List<string> keyWords { get; set; }
        public string imagePath { get; set; }
        public Items() { }
        public Items(string newItemName, double newPrice, string newImagePath, List<string> newKeyWords)
        {
            itemName = newItemName;
            price = newPrice;
            imagePath = newImagePath;
            keyWords = newKeyWords;
        }

    }
}