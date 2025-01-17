﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sahara
{
    public partial class orderItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string liststring = Request.Cookies["listC"].Value;
            //buttons.InnerText = liststring;
            string cookieList = Request.Cookies["listC"].Value;
            label1.Text=cookieList;
        }
        protected void clickBuy (object sender, EventArgs e)
        {
            Random rand = new Random();
            int randPrice = rand.Next(10, 1000);
            buttons.InnerText = "The total price is $"+ randPrice + ".\nThank you for shopping at Sahara!";

        }
        protected void clickCancel(object sender, EventArgs e)
        {
            buttons.InnerText = "We can give you a discount of up to 75% off if you buy 2 items!";
        }
        protected void clickMenu(object sender, EventArgs e)
        {
            Response.Redirect("webpage_sahara.aspx");
        }
    }
}