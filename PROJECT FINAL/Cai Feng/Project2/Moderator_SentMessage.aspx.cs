using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Moderator_SentMessage : System.Web.UI.Page
{
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

                DataSet ds = new DataSet();
                string inbox = "SELECT Sender_Name,Message_Subject,Message_Description,Message_Date FROM Message Where Sender_Name = '" + "user" + "'";
                SqlDataAdapter da = new SqlDataAdapter(inbox, conn);

                da.Fill(ds);

                GridView1.DataSource = ds;
                GridView1.DataBind();

            }
            conn.Close();
        }
    }
}