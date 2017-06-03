using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage_5 : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Session["LoginStatus"] = true;// temporary only

        if (Session["LoginStatus"] == null)
        {
            Response.Redirect("Home.aspx");
        }

        lblUName.Text = (string)Session["UName"];
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session["LoginStatus"] = false;
        Session["UName"] = "";
        Session["FName"] = "";
        Session["LName"] = "";
        Session["Type"] = "0";

        Response.Redirect("Home.aspx");
    }
}
