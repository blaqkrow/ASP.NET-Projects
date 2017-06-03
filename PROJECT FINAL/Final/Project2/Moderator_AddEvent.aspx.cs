using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

public partial class Moderator_AddEvent : System.Web.UI.Page
{
    string mySQL, str, path;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void txtAdd_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog=ASP_Project; Integrated Security=SSPI");
        conn.Open();

        if (FileUpload1.HasFile)
        {
            str = FileUpload1.FileName;
            FileUpload1.PostedFile.SaveAs(Server.MapPath(".") + "/Images/Events/" + str);
            path = "~/Images/Events/" + str.ToString();
        }
        else if (!FileUpload1.HasFile)
        {
            Label1.Text = "Please upload your image";
        }

        mySQL = "INSERT INTO Event (Event_Name,Event_Description,Event_Date,Event_Participant,Event_CreateBy,Event_CreateDate,Event_Image) values('" + txtEName.Text.Trim() + "','" + txtDescription.Text.Trim() + "','" + Calendar2.SelectedDate + "','" + 0 + "','" + Session["UName"].ToString() + "','" + DateTime.Now + "','" + path + "')";

        SqlCommand cmdAddEvent = new SqlCommand(mySQL, conn); //update users first
        cmdAddEvent.ExecuteNonQuery();
        conn.Close();
        Response.Redirect("Moderator_Events.aspx");
    }
}