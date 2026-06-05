using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomersLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {

        clsCustomerUser AnUser = new clsCustomerUser();
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;
        Boolean Found = false;
        UserName = Convert.ToString(txtUserName.Text);
        Password = Convert.ToString(txtPassword.Text);
        Found = AnUser.FindUser(UserName, Password);
        if (txtUserName.Text == " ")
        {
            lblError.Text = "Enter a username";
        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Enter a password";
        }
        else if (Found == true)
        {

            Response.Redirect("CustomersList.aspx");
        }
        else
        {
            lblError.Text = "Incorrect username or password";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        // redirect back to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}