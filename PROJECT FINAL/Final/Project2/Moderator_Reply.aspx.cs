using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

public partial class Moderator_Reply : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtRecieverName.Text = (string)Session["recieverName"];
    }

    protected void Reply_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog=ASP_Project; Integrated Security=SSPI");
        conn.Open();

        string mySQL;

        mySQL = "INSERT INTO Message (Sender_Name,Receiver_Name,Message_Subject,Message_Description,Message_Date) values('" + Convert.ToString(Session["UName"]) + "','" + txtRecieverName.Text + "','" + txtMessageSubject.Text + "','" + txtMessage.Text + "','" + DateTime.Now + "')";

        SqlCommand cmdAddEvent = new SqlCommand(mySQL, conn); //update users first

        cmdAddEvent.ExecuteNonQuery();

        conn.Close();

        Response.Redirect("Moderator_Inbox.aspx");

    }
}