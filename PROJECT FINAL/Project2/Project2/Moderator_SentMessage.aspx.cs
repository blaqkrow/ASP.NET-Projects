﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Moderator_SentMessage : System.Web.UI.Page
{
    string firstColumn;
    protected void Page_Load(object sender, EventArgs e)
    {
        int homeRecord;

        if (Page.IsPostBack == false)
        {

            SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog= ASP_Project; Integrated Security = true");
            SqlCommand cmdCount = new SqlCommand("SELECT COUNT(*) FROM Message Where Sender_Name = '" + "user" + "'", conn);

            conn.Open();
            homeRecord = Convert.ToInt32(cmdCount.ExecuteScalar());

            if (homeRecord != 0)
            {

                //DataSet ds = new DataSet();
                //string inbox = "SELECT Sender_Name,Message_Subject,Message_Description,Message_Date,Message_ID FROM Message Where Sender_Name = '" + "user" + "'";
                //SqlDataAdapter da = new SqlDataAdapter(inbox, conn);

                //da.Fill(ds);

                //GridView1.DataSource = ds;
                //GridView1.DataBind();

                SqlCommand cmd = new SqlCommand("select Message_ID,Sender_Name,Receiver_Name,Message_Subject,Message_Description,Message_Date from [Message] where Sender_Name = '" + Session["UName"]+"'", conn);

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
        //teaking the value of first column in selected row
        //firstColumn = GridView1.Rows[selectedRow].Cells[0].Text;
        //taking the value of second column in selected row
        Session["Selected2"] = GridView1.Rows[selectedRow].Cells[2].Text;
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog=ASP_Project; Integrated Security=SSPI");
        conn.Open();

        string mySQL;

        mySQL = "DELETE FROM Message WHERE Message_ID = "+ Convert.ToInt32(Session["Selected2"])+" ";
      

        SqlCommand cmdDelete = new SqlCommand(mySQL, conn);
        cmdDelete.ExecuteNonQuery();
        conn.Close();

        Response.Redirect("Moderator_SentMessage.aspx");
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        //reply message
        SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog=ASP_Project; Integrated Security=SSPI");
        conn.Open();

        SqlCommand cmd = new SqlCommand("select Sender_Name from Message where Message_ID = "+Convert.ToInt32(Session["Selected2"]) +"",conn);

        Session["recieverName"] = Convert.ToString(cmd.ExecuteScalar());

        conn.Close();

        Response.Redirect("Moderator_Reply.aspx"); //go to reply page

    }
}