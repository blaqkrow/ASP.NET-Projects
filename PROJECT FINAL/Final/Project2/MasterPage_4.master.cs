using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class MasterPage_4 : System.Web.UI.MasterPage
{

    protected void Page_Load(object sender, EventArgs e)
    {
        int joinStatus;
      
        //Checking of the Loginstatus
        if (Session["LoginStatus"] == null || Convert.ToBoolean(Session["LoginStatus"]) == false)
        { 
            Response.Redirect("Home.aspx");
        }
       
        if (Page.IsPostBack == false)
        {
            
            
            SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog= ASP_Project; Integrated Security = true");
           
            SqlCommand cmdCount = new SqlCommand("SELECT COUNT(*) FROM JoinEvent where  User_Name = '" + Session["UName"].ToString() + "'", conn);
            SqlDataAdapter da = new SqlDataAdapter("SELECT Event.Event_ID,Event.Event_Name  FROM Event INNER JOIN JoinEvent ON Event.Event_ID = JoinEvent.Event_ID Where JoinEvent.User_Name = '" + Session["UName"].ToString() + "'", conn);
            
            conn.Open();
            joinStatus = Convert.ToInt32(cmdCount.ExecuteScalar());
            if (joinStatus != 0)
            {
                DataSet ds = new DataSet();
                da.Fill(ds);
                //Databind the ListBox to the event they joined
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
                //Setting of profile image
                Image1.ImageUrl = dr["User_Image"].ToString();
            }

            dr.Close();
            conn.Close();

        }
        lblUName.Text = (string)Session["UName"];
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        //Reset the session to null
        Session["LoginStatus"] = false;
        Session["UName"] = "";
        Session["FName"] = "";
        Session["LName"] = "";
        Session["Type"] = "0";

        Response.Redirect("Home.aspx");
    }
    protected void lb_Events_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Storing of the item value of the lstbox
        Session["More"] = lb_Events.SelectedItem.Value;
        Response.Redirect("Member_EventPosts.aspx");
    }
}
