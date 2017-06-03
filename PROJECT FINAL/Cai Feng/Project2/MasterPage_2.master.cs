using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

public partial class MasterPage_2 : System.Web.UI.MasterPage
{

    protected void Page_Load(object sender, EventArgs e)
    {
        Session["LoginStatus"] = false;
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {

        SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog=ASP_Project; Integrated Security=SSPI");
        conn.Open();

        SqlCommand cmdUsers = new SqlCommand("select * from [User] where User_UName = '" + txtUser.Text.Trim() + "'", conn);

        SqlDataReader dr;
        dr = cmdUsers.ExecuteReader();

        while (dr.Read())
        {
            if (txtPass.Text.Trim() == dr["User_Password"].ToString())
            {
                Session["LoginStatus"] = true;
                Session["UserID"] = dr["User_ID"].ToString();
                Session["UName"] = txtUser.Text;
                Session["FName"] = dr["User_FistName"].ToString();
                Session["LName"] = dr["User_LastName"].ToString();
                Session["Type"] = dr["Type_ID"].ToString();
            }
            else
            {
                //login has failed
                Response.Redirect("www.google.com");
            }

        }

        //Response.Redirect("http://www.google.com");


        if ((string)Session["Type"] == "1")
        {
            //go members page
            Response.Redirect("Member_Home.aspx");
        }
        if ((string)Session["Type"] == "2")
        {
            //go admin page
            Response.Redirect("Admin_Home.aspx");
        }
        if ((string)Session["Type"] == "3")
        {
            //go admin page
            Response.Redirect("Moderator_Home.aspx");
        }
    }
}
