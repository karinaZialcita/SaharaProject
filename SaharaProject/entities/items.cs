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

        public string imagePath { get; set; }
        public Items() { }
        public Items(string newItemName, double newPrice, string newImagePath)
        {
            itemName = newItemName;
            price = newPrice;
            imagePath = newImagePath;
        }
        public List<Items> getList()
        {
            List<Items> listOfItems = new List<Items>()
            {   new Items("BedrockRug", 457.39,"items/bedrockRug.jpg"),
                new Items("Rose Rug", 356.99,"items/roseRug.jpg"),
                new Items("Lacy Rug", 122.56,"items/lacyRug.jpg"),
                new Items("Tropical Rug", 271.59,"items/tropicalRug.jpg"),
                new Items("Fluffy Rug", 562.81,"items/fluffyRug.jpg"),
                new Items("Brown Mat", 245.51,"items/brownMat.jpg"),
                new Items("Tatami Mat", 423.45,"items/tatamiMat.jpg"),
                new Items("Red Kilim Mat", 367.99,"items/redKilimMat.jpg"),
                new Items("avocadomat", 454.36,"items/avocadoMat.jpg"),
                new Items("Ivory Mat", 345.57,"items/ivoryMat.jpg")

            };
            return listOfItems;
        }
    }
}