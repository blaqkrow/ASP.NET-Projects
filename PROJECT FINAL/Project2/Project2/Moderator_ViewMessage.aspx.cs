using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Moderator_ViewMessages : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog= ASP_Project; Integrated Security = true");
        conn.Open();
        SqlCommand cmd = new SqlCommand("select Sender_Name,Message_Subject,Message_Description,Message_Date from [Message] where Message_ID = " + Convert.ToInt32(Session["Selected3"]) + " ", conn);

        SqlDataReader dr;

        dr = cmd.ExecuteReader();

        while (dr.Read())
        {
            txtSenderName.Text = dr["Sender_Name"].ToString();
            txtRSubject.Text = dr["Message_Subject"].ToString();
            txtMessage.Text = dr["Message_Description"].ToString();
            lblDate.Text = dr["Message_Date"].ToString();

        }

    }
    protected void btnReply_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog=ASP_Project; Integrated Security=SSPI");
        conn.Open();

        string mySQL;

        mySQL = "INSERT INTO Message (Sender_Name,Receiver_Name,Message_Subject,Message_Description,Message_Date) values('" + Convert.ToString(Session["UName"]) + "','" + txtSenderName.Text + "','" + txtSSubject.Text + "','" + txtMessage.Text + "','" + DateTime.Now + "')";

        SqlCommand cmdAddEvent = new SqlCommand(mySQL, conn); //update users first

        cmdAddEvent.ExecuteNonQuery();

        conn.Close();

        Response.Redirect("Moderator_Home.aspx");
    }
}