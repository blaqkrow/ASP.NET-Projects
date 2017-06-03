using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

public partial class Contact : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {


    }
    protected void btnSend_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog=ASP_Project; Integrated Security=SSPI");
        conn.Open();
      
        string mySQL;
       
        //Inserting of Query Message to the database
        mySQL = "INSERT INTO [Message](Sender_Name,Message_Subject,Message_Description,Message_Date,Message_Email) VALUES('" + txtName.Text.Trim() + "','" + txtSubject.Text.Trim() + "','" + txtMessage.Text.Trim() + "','" + DateTime.Now + "','" + txtEmail.Text.Trim() + "')";

        SqlCommand cmdAdd = new SqlCommand(mySQL, conn);

        cmdAdd.ExecuteNonQuery();

        conn.Close();

        Response.Redirect("Home.aspx"); //redirect to home page
    }

    protected void btnReset_Click(object sender, EventArgs e)
    {
        //Resetting the fields
        txtName.Text = " ";
        txtSubject.Text = " ";
        txtMessage.Text = " ";
        txtEmail.Text = " ";
    }
}