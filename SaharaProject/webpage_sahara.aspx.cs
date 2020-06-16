
using sahara.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace sahara
{
    public partial class webpage_sahara : System.Web.UI.Page
    {
        Items item = new Items();
        List<Items> itemList = new List<Items>();

        protected void Page_Load(object sender, EventArgs e)
        {
            string cookiename = Request.Cookies["accountName"].Value;
            welcomeName.InnerText = "Welcome, " + cookiename;
            wrapper.Style.Add("display", "none");
            wrapper.Visible = false;
          
        }
        public List<Items> GetItems()
        {
            List<Items> itemList = new List<Items>()
            {
                new Items("Bedrock Rug", 457.39, "items/bedrockRug.jpg", 
                    new List<string>() { "rug","bed", "rock", "bedrock", "bedrock rug" }),
                new Items("Rose Rug", 356.99, "items/roseRug.jpg",
                    new List<string>() { "rug","rose", "rose rug" }),
                new Items("Lacy Rug", 122.56, "items/lacyRug.jpg",
                    new List<string>() { "rug","lacy", "bedrock rug" }),
                new Items("Tropical Rug", 271.59, "items/tropicalRug.jpg",
                    new List<string>() { "rug","tropical", "tropical rug" }),
                new Items("Fluffy Rug", 562.81, "items/fluffyRug.jpg",
                    new List<string>() { "rug","fluffy", "fluffy rug" }),


                new Items("Brown Mat", 245.51, "items/brownMat.jpg",
                    new List<string>() { "mat","brown", "brown mat" }),
                new Items("Tatami Mat", 423.45, "items/tatamiMat.jpg",
                    new List<string>() { "mat","tatami", "tatami mat" }),
                new Items("Red Kilim Mat", 367.99, "items/redKilimMat.jpg",
                    new List<string>() { "mat","red", "red kilim", "kilim", "red kilim mat", "kilim mat" }),
                new Items("Avocado mat", 454.36, "items/avocadoMat.jpg",
                    new List<string>() { "mat","avocado", "avocado mat" }),
                new Items("Ivory Mat", 345.57, "items/ivoryMat.jpg",
                    new List<string>() { "mat","ivory", "ivory mat" })


            };
            return itemList;
        }
        protected void onClickSearch(object sender, EventArgs e)
        {
            
            foreach (Items anItem in itemList)
            {
                if (searchItem.Text.ToLower().Trim() == anItem.itemName.ToLower() ||
                    anItem.itemName.Contains(searchItem.Text))
                {
                    /*searchResult.InnerText = "Yes we have the item " + anItem.itemName + "\n its is sold for the price of " + anItem.price;*/

                    searchResult2.Style.Remove("display");
                    searchImage.ImageUrl = anItem.imagePath;
                    searchName.Text = anItem.itemName + " $" + anItem.price;
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
            List<Items> itemList = item.getList();
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