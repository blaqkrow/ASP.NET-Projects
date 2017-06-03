using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

public partial class Moderator_Events : System.Web.UI.Page
{
    string firstColumn;
    string secondColumn;
    int[] eventSelected = new int[100];
    int i = 0;
    protected void Page_Load(object sender, EventArgs e)
    {


        SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog=ASP_Project; Integrated Security=SSPI");
        conn.Open();

        SqlCommand cmd = new SqlCommand("select Event_ID,Event_Name,Event_Description,Event_Date,Event_Participant,Event_Participant,Event_CreateBy,Event_CreateDate from [Event] ", conn);

        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        GridView1.DataSource = dr;
        GridView1.DataBind();

        while (dr.Read())
        {
            eventSelected[i] = (int)dr["Event_ID"];

            i++;
        }

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog=ASP_Project; Integrated Security=SSPI");
        conn.Open();

        string mySQL;

        mySQL = "DELETE FROM Event WHERE Event_ID = " + Convert.ToInt32(Session["Selected"]) + "";

        SqlCommand cmdDelete = new SqlCommand(mySQL, conn);
        cmdDelete.ExecuteNonQuery();
        conn.Close();

        Response.Redirect("Moderator_Events.aspx");
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Response.Redirect("Moderator_EditEvent.aspx");
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int selectedRow = GridView1.SelectedIndex;
        //teaking the value of first column in selected row
        firstColumn = GridView1.Rows[selectedRow].Cells[0].Text;
        //taking the value of second column in selected row
        Session["Selected"] = GridView1.Rows[selectedRow].Cells[1].Text;

    }
    protected void btn_Add_Click(object sender, EventArgs e)
    {
        Response.Redirect("Moderator_AddEvent.aspx");
    }
}