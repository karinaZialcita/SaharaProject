
using sahara.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace sahara
{
    public partial class webpage_sahara : System.Web.UI.Page
    {
        Item item = new Item();
        List<Item> itemList = new List<Item>();

        protected void Page_Load(object sender, EventArgs e)
        {
            string cookiename = Request.Cookies["accountName"].Value;
            welcomeName.InnerText = "Welcome, " + cookiename;
            wrapper.Style.Add("display", "none");
            wrapper.Visible = false;
            preloadItems();
        }
        private void preloadItems()
        {
            //added key words

            //rugs
            itemList.Add(new Item("Bedrock Rug", 457.39, "items/bedrockRug.jpg",
                new List<string>() { "rug", "bed", "rock", "bedrock", "bedrock rug" }));
            itemList.Add(new Item("Rose Rug", 356.99, "items/roseRug.jpg",
                    new List<string>() { "rug", "rose", "rose rug" }));
            itemList.Add(new Item("Lacy Rug", 122.56, "items/lacyRug.jpg",
                    new List<string>() { "rug", "lacy", "bedrock rug" }));
            itemList.Add(new Item("Tropical Rug", 271.59, "items/tropicalRug.jpg",
                    new List<string>() { "rug", "tropical", "tropical rug" }));
            itemList.Add(new Item("Fluffy Rug", 562.81, "items/fluffyRug.jpg",
                    new List<string>() { "rug", "fluffy", "fluffy rug" }));

            //mats
            itemList.Add(new Item("Brown Mat", 245.51, "items/brownMat.jpg",
                    new List<string>() { "mat", "brown", "brown mat" }));
            itemList.Add(new Item("Tatami Mat", 423.45, "items/tatamiMat.jpg",
                    new List<string>() { "mat", "tatami", "tatami mat" }));
            itemList.Add(new Item("Red Kilim Mat", 367.99, "items/redKilimMat.jpg",
                    new List<string>() { "mat", "red", "red kilim", "kilim", "red kilim mat", "kilim mat" }));
            itemList.Add(new Item("Avocado mat", 454.36, "items/avocadoMat.jpg",
                    new List<string>() { "mat", "avocado", "avocado mat" }));
            itemList.Add(new Item("Ivory Mat", 345.57, "items/ivoryMat.jpg",
                    new List<string>() { "mat", "ivory", "ivory mat" }));

            //floorings
            itemList.Add(new Item("Bamboo Flooring", 423.22, "items/bambooFlooring.jpg",
                new List<string>() {"flooring", "bamboo", "bamboo flooring"}));            
            itemList.Add(new Item("Birch Flooring", 423.22, "items/birchFlooring.jpg",
                new List<string>() {"flooring", "birch", "birch flooring"}));            
            itemList.Add(new Item("Flag Stone Flooring", 423.22, "items/flagStoneFlooring.jpg",
                new List<string>() {"flooring", "flag", "flag stone", "stone", "flag stone flooring"}));            
            itemList.Add(new Item("Monochromatic Tile Flooring", 423.22, "items/monochromaticTileFlooring.jpg",
                new List<string>() {"flooring", "mono", "monochromatic","monochrome", "monochromatic tile", "monochromatic tile flooring"}));            
            itemList.Add(new Item("Rosewood Flooring", 423.22, "items/rosewoodFlooring.jpg",
                new List<string>() {"flooring", "rosewood", "rose", "rosewood flooring"}));        
            itemList.Add(new Item("Slate Flooring", 423.22, "items/slateFlooring.jpg",
                new List<string>() {"flooring", "slate", "slate flooring"}));


        }
        protected void onClickSearch(object sender, EventArgs e)
        {
            string itemSearch = searchItem.Text.ToLower().Trim();
            foreach (Item item in itemList)
            {
                foreach(string word in item.keyWords)
                {
                    if (itemSearch == word)
                    {
                        searchResult.InnerText = "Yes we have the item " + item.itemName + "\n its is sold for the price of " + item.price;

                        searchResult2.Style.Remove("display");
                        searchImage.ImageUrl = item.imagePath;
                        searchName.Text = item.itemName + " $" + item.price;
                    }
                    /*else searchResult.InnerText = "sorry we dont have that";*/
                }
            }
        }
        protected void onClickCatalog(object sender, EventArgs e)
        {
            searchResult.Style.Add("display", "none");
            searchResult2.Style.Add("display", "none");
            if (wrapper.Visible == false)
            {
                wrapper.Style.Remove("display");

                wrapper.Visible = true;

            }
            else
            {
                wrapper.Style.Add("display", "none");
                wrapper.Visible = false;
            }


        }
        protected void clickItem (object sender, EventArgs e)
        {

            ImageButton button = (ImageButton)sender;
            string imagePth = button.ImageUrl;
            Response.Cookies["itemName"].Value = button.AlternateText;
/*            foreach(Items item in itemList)
            {
                if(button.AlternateText == item.itemName)
                {
                    Response.Cookies["itemPrice"].Value = item.price.ToString();

                }
            }*/
            Response.Cookies["imagePath"].Value = imagePth;
            Response.Redirect("orderItem.aspx");
        }

    }
}