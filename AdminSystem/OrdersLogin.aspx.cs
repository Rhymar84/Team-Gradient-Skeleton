using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrdersLogin : System.Web.UI.Page
{
    bool HasLoaded = false;

    protected void Page_Load(object sender, EventArgs e)
    {   
        if (!HasLoaded)
        {
            Session.Remove("Login"); //log user out on first load for demo purposes
            HasLoaded = true;
        }
        
        if (IsPostBack == false)
        {
            if ((clsOrdersUser)Session["Login"] != null) //redirect to list if already logged in
            {
                Response.Redirect("OrdersList.aspx");
                return;
            }
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsOrdersUser AUser = new clsOrdersUser();
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;

        if (txtUserName.Text == "") //No username error
        {
            lblError.Text = "You must enter a username.";
            return;
        }
        if (txtPassword.Text == "") //No password error
        {
            lblError.Text = "You must enter a password.";
            return;
        }

        if (AUser.FindUser(UserName, Password)) //find record
        {
            Session["Login"] = AUser;
            Response.Redirect("OrdersList.aspx");
        } 
        else // record not found
        {
            lblError.Text = "Login details are incorrect. Please try again.";
        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}