using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

public partial class Admin_AddEvent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void txtAdd_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog=ASP_Project; Integrated Security=SSPI");
        conn.Open();

        string mySQL;

        mySQL = "INSERT INTO Event (Event_Name,Event_Description,Event_Date,Event_Participant) values('" + txtEName.Text.Trim() + "','" + txtDescription.Text.Trim() + "','" + Calendar2.SelectedDate + "',0)";

        SqlCommand cmdAddEvent = new SqlCommand(mySQL, conn); //update users first

        cmdAddEvent.ExecuteNonQuery();

        conn.Close();

        Response.Redirect("Adminstrator.aspx");
    }
}