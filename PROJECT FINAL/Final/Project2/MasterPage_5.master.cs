using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

public partial class MasterPage_5 : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Session["LoginStatus"] = true;// temporary only
        int joinStatus;
        //Checking of login status
        if (Session["LoginStatus"] == null || Convert.ToBoolean(Session["LoginStatus"]) == false)
        {
            Response.Redirect("Home.aspx");
        }
        if (Page.IsPostBack == false)
        {


            SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog= ASP_Project; Integrated Security = true");

            SqlCommand cmdCount = new SqlCommand("SELECT COUNT(*) FROM Event where  Event_CreateBy = '" + Session["UName"].ToString() + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Event where  Event_CreateBy = '" + Session["UName"].ToString() + "'", conn);

            conn.Open();
            joinStatus = Convert.ToInt32(cmdCount.ExecuteScalar());
            if (joinStatus != 0)
            {
                DataSet ds = new DataSet();
                da.Fill(ds);
                //Databind the events to lstbox created by this admin
                lb_Events.DataSource = ds;
                lb_Events.DataTextField = "Event_Name";
                lb_Events.DataValueField = "Event_ID";
                lb_Events.DataBind();

            }

            SqlCommand cmdUsers = new SqlCommand("select User_Image from [User] where User_UName = '" + Session["UName"].ToString() + "'", conn);

            SqlDataReader dr;
            dr = cmdUsers.ExecuteReader();

            while (dr.Read())
            {
                //Setting of profile picture image
                Image1.ImageUrl = dr["User_Image"].ToString();
            }

            dr.Close();
            conn.Close();

        }

        lblUName.Text = (string)Session["UName"];
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        //Resetting of session variable
        Session["LoginStatus"] = false;
        Session["UName"] = "";
        Session["FName"] = "";
        Session["LName"] = "";
        Session["Type"] = "0";

        Response.Redirect("Home.aspx");
    }
}
