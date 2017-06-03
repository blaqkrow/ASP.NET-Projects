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
    string mySQL, str, path;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

            SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog=ASP_Project; Integrated Security=SSPI");
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from [Event] where Event_ID = '" + Convert.ToInt32(Session["Selected"]) + "'", conn);

            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtEName.Text = dr["Event_Name"].ToString();
                txtDescription.Text = dr["Event_Description"].ToString();
                Calendar2.SelectedDate = Convert.ToDateTime(dr["Event_Date"].ToString());

            }
        }
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
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
        //mySQL = "INSERT INTO Event (Event_Name,Event_Description,Event_Date,Event_Participant) values('" + txtEName.Text.Trim() + "','" + txtDescription.Text.Trim() + "','" + Calendar2.SelectedDate + "',0)";
        mySQL = "UPDATE Event SET Event_Name='" + txtEName.Text.Trim() + "',Event_Description='" + txtDescription.Text.Trim() + "',Event_Date='" + Calendar2.SelectedDate + "', Event_EditBy='" + Session["UName"] + "',Event_EditDate='" + DateTime.Now.ToString() +"',Event_Image='"+path+"' where Event_ID = " + Convert.ToInt32(Session["Selected"]) + "";

        SqlCommand cmdAddEvent = new SqlCommand(mySQL, conn); //update users first

        cmdAddEvent.ExecuteNonQuery();

        conn.Close();

        Response.Redirect("Admin_Events.aspx");
    }
}