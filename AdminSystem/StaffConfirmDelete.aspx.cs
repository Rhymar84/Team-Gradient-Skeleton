using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key value of the record to be deleted
    Int32 StaffID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session object
        Int32 StaffID = Convert.ToInt32(Session["StaffID"]);
    }
}