using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Text;

public partial class Moderator_Inbox : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int homeRecord;

        if (Page.IsPostBack == false)
        {

            SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog= ASP_Project; Integrated Security = true");
            SqlCommand cmdCount = new SqlCommand("SELECT COUNT(*) FROM Message Where Receiver_Name = '" + Session["UName"] + "'", conn);

            conn.Open();
            homeRecord = Convert.ToInt32(cmdCount.ExecuteScalar());

            if (homeRecord != 0)
            {
                SqlCommand cmd = new SqlCommand("select Message_ID,Sender_Name,Receiver_Name,Message_Subject,Message_Description,Message_Date from [Message] ", conn);

                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                GridView1.DataSource = dr;
                GridView1.DataBind();

            }
            conn.Close();
        }

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int selectedRow = GridView1.SelectedIndex;
        Session["Selected3"] = GridView1.Rows[selectedRow].Cells[2].Text;
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Response.Redirect("Moderator_ViewMessage.aspx");
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog=ASP_Project; Integrated Security=SSPI");
        conn.Open();

        string mySQL;

        mySQL = "DELETE FROM Message WHERE Message_ID = " + Convert.ToInt32(Session["Selected3"]) + " ";


        SqlCommand cmdDelete = new SqlCommand(mySQL, conn);
        cmdDelete.ExecuteNonQuery();
        conn.Close();

        Response.Redirect("Moderator_Inbox.aspx");
    }
}