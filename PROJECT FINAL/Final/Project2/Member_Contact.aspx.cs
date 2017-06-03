using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

public partial class Member_Contact : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog=ASP_Project; Integrated Security=SSPI");
        conn.Open();

        string mySQL = "INSERT INTO [Message](Sender_Name,Receiver_Name,Message_Subject,Message_Description,Message_Date) VALUES('" + Session["UName"] + "','"+"Admin"+"','" + txtSubject.Text.Trim() + "','" + txtMessage.Text.Trim() + "','" + DateTime.Now + "')";
        SqlCommand cmdAdd = new SqlCommand(mySQL, conn);
        cmdAdd.ExecuteNonQuery();

        conn.Close();

        Response.Redirect("Member_Home.aspx"); //redirect to home page
    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
        txtSubject.Text = " ";
        txtMessage.Text = " ";
    }
}