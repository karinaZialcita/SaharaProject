using sahara.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sahara
{
    public partial class sahara_registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void register_name(object sender, EventArgs e)
        {
            Account newAccount = new Account();
            int num = 0;
            if (!int.TryParse(txtName.Text.Trim(), out num) && 
                txtEmailAdr.Text.Contains('@') && txtEmailAdr.Text.Contains(".com") &&
                txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                newAccount.name = txtName.Text;
                newAccount.emailAddress = txtEmailAdr.Text;
                newAccount.phoneNum = txtPhoneNum.Text;
                newAccount.password = txtPassword.Text;
                Response.Cookies["accountName"].Value = newAccount.name;
                Response.Redirect("webpage_sahara.aspx");
            }
            else
            {
                lblName.ForeColor = System.Drawing.Color.Red;
                lblName.Text = "Please check your input";
            }
        }
        protected void clickLogin(object sender,EventArgs e)
        {
            Account account = new Account();
            List<Account> listAcc = account.getAccounts();

            foreach(Account accs in listAcc)
            {
                if(txtLoginEmail.Text == accs.emailAddress && txtLoginPass.Text == accs.password)
                {
                    Response.Cookies["accountName"].Value = accs.name;
                    Response.Redirect("webpage_sahara.aspx");
                }
                else
                {
                    popuplabel.ForeColor = System.Drawing.Color.Red;
                    popuplabel.Text = "Invalid Account";
                }
            }

        }
       
    }
}
