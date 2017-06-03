using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Member_ComposeMessage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_Submit_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog= ASP_Project; Integrated Security = true");

        if (txt_receiver.Text.Trim() == null || txt_Subject.Text.Trim() == null || txt_Message.Text.Trim() == null)
        {
            if (txt_receiver.Text.Trim() == null)
            {
                lbl_receiver.Text = "Please fill in the receiver name.";
            }
            if (txt_Subject.Text.Trim() == null)
            {
                lbl_subject.Text = "Please fill in the Subject.";
            }
            if (txt_Message.Text.Trim() == null)
            {
                lbl_message.Text = "Please fill in the Message.";
            }
        }
        else if (txt_receiver.Text.Trim() != null || txt_Subject.Text.Trim() != null || txt_Message.Text.Trim() != null)
        {
            conn.Open();
            string mySql = "INSERT INTO Message  (Sender_Name, Receiver_Name, Message_Subject,Message_Description, Message_Date) VALUES ('" + Session["UName"] + "','" + txt_receiver.Text.Trim() + "','" + txt_Subject.Text.Trim() + "','" + txt_Message.Text.Trim() + "','" + DateTime.Now.ToString() + "');";
            SqlCommand cmdUpdate = new SqlCommand(mySql, conn);
            cmdUpdate.ExecuteNonQuery();
            conn.Close();
        }
        Response.Redirect("Member_Inbox.aspx");// change to inbox hyperlink later on.
    }
    protected void btn_reset_Click(object sender, EventArgs e)
    {
        txt_receiver.Text = "";
        txt_Subject.Text = "";
        txt_Message.Text = "";
    }
}