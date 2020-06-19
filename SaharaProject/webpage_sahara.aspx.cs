
using sahara.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace sahara
{
    public partial class webpage_sahara : System.Web.UI.Page
    {
        List<Item> itemList = new List<Item>();
        bool isCatalogVisible;
        private static int itemQuantity=0;

        List<string> cartList = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {
            /*            string cookiename = Request.Cookies["accountName"].Value;
            */            /*welcomeName.InnerText = "Welcome, " + cookiename;*/

            preloadItems();
            fillCatalog();
            cartQuantity.Text = itemQuantity.ToString();
            isCatalogVisible = false;
        }
        protected void preloadItems()
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
            itemList.Add(new Item("Rosewood Flooring", 423.22, "items/rosewoodFlooring.jpg",
                new List<string>() {"flooring", "rosewood", "rose", "rosewood flooring"}));        
            itemList.Add(new Item("Slate Flooring", 423.22, "items/slateFlooring.jpg",
                new List<string>() {"flooring", "slate", "slate flooring"}));


        }
        protected void onClickSearch(object sender, EventArgs e)
        {
            if(isCatalogVisible)
            {
                wrapper.Style.Remove("display");
                isCatalogVisible = false;
            }

            string itemSearch = searchItem.Text.ToLower().Trim();
            foreach (Item item in itemList)
            {
                foreach(string word in item.keyWords)
                {
                    if (itemSearch == word)
                    {   //fills the menu with the items that contain the keyword
                        Image image = new Image();
                        image.ImageUrl = item.imagePath;
                        image.AlternateText = item.itemName;
                        image.Style.Add("width", "300px");
                        image.Style.Add("height", "300px");
                        image.Style.Add("border-radius", "25px");
                        image.Style.Add("padding", "5px");
                        Label label = new Label();
                        label.Style.Add("padding", "20px");
                        label.Text = item.itemName + " $" + item.price;
                        Button button = new Button();
                        button.Text = "Add to Cart";
                        button.Click += addToCart;
                        PlaceHolder1.Controls.Add(image);
                        PlaceHolder1.Controls.Add(label);
                        PlaceHolder1.Controls.Add(button);
                    }
                    /*else searchResult.InnerText = "sorry we dont have that";*/
                }
            }
        }
        protected void toggleCatalog(object sender, EventArgs e)
        {

            if (!isCatalogVisible)
            {
                wrapper.Style.Add("display","block");
                isCatalogVisible = true;
            }
            else
            {
                wrapper.Style.Remove("display");
                isCatalogVisible = false;
            }
        }
        protected void fillCatalog()
        {
            foreach (Item item in itemList)
            {
                foreach (string word in item.keyWords)
                {
                    if ("rug" == word)
                    {   //fills the menu with the items that contain the keyword
                        Image image = new Image();
                        image.ImageUrl = item.imagePath;
                        image.AlternateText = item.itemName;
                        image.Style.Add("width", "300px");
                        image.Style.Add("height", "300px");
                        image.Style.Add("border-radius", "25px");
                        image.Style.Add("padding", "5px");
                        Label label = new Label(); 
                        label.Style.Add("padding", "5px");
                        //label.Style.Add("margin", "20px");
                        label.Text = item.itemName + " $" + item.price;
                        Button button = new Button();
                        button.Text = "Add to Cart";
                        button.Click += addToCart;
                        button.ID = item.itemName;

                        PlaceHolderRugs.Controls.Add(image);
                        PlaceHolderRugs.Controls.Add(label);
                        PlaceHolderRugs.Controls.Add(button);
                    }
                    if ("mat" == word)
                    {   //fills the menu with the items that contain the keyword
                        Image image = new Image();
                        image.ImageUrl = item.imagePath;
                        image.AlternateText = item.itemName;
                        image.Style.Add("width", "300px");
                        image.Style.Add("height", "300px");
                        image.Style.Add("border-radius", "25px");
                        image.Style.Add("padding", "5px");
                        Label label = new Label();
                        label.Style.Add("padding", "5px");
                        //label.Style.Add("margin", "20px");
                        label.Text = item.itemName + " $" + item.price;
                        Button button = new Button();
                        button.Text = "Add to Cart";
                        button.Click += addToCart;
                        button.ID = item.itemName;

                        PlaceHolderMats.Controls.Add(image);
                        PlaceHolderMats.Controls.Add(label);
                        PlaceHolderMats.Controls.Add(button);
                    }
                    if ("flooring" == word)
                    {   //fills the menu with the items that contain the keyword
                        Image image = new Image();
                        image.ImageUrl = item.imagePath;
                        image.AlternateText = item.itemName;
                        image.Style.Add("width", "300px");
                        image.Style.Add("height", "300px");
                        image.Style.Add("border-radius", "25px");
                        image.Style.Add("padding", "5px");
                        Label label = new Label();
                        label.Style.Add("padding", "5px");
                        //label.Style.Add("margin", "20px");
                        label.Text = item.itemName + " $" + item.price;
                        Button button = new Button();
                        button.Text = "Add to Cart";
                        button.Click += addToCart;
                        button.ID = item.itemName;
                        
                        PlaceHolderFloorings.Controls.Add(image);
                        PlaceHolderFloorings.Controls.Add(label);
                        PlaceHolderFloorings.Controls.Add(button);

                    }
                    /*else searchResult.InnerText = "sorry we dont have that";*/
                }
            }
        }

        protected void addToCart(object sender, EventArgs e)
        {
            itemQuantity++;
            cartQuantity.Text = itemQuantity.ToString();
            Button button = (Button)sender;
            string itemName = button.ID;
            cartList.Add(itemName);
            //test to see if the list is gettin updated
            foreach(string item in cartList)
            {
                Trace.Write(item);
                searchResult.InnerText += item;
            }
        }
        protected void goToCart(object sender, EventArgs e)
        {

            string listCstring = string.Join(",", cartList);
            Response.Cookies["listC"].Value = listCstring;
            Response.Redirect("orderItem.aspx");
        }
       


    }
}