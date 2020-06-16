
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
        

        protected void Page_Load(object sender, EventArgs e)
        {
            string cookiename = Request.Cookies["accountName"].Value;
            welcomeName.InnerText = "Welcome, " + cookiename;
            wrapper.Style.Add("display", "none");
            wrapper.Visible = false;
          
        }

        protected void onClickSearch(object sender, EventArgs e)
        {
            List<Items> itemList = item.getList();
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