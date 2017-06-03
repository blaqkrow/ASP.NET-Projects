using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Member_Events : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        int homeRecord;
        String cmdComment = "Select * from Event ";
        if (Page.IsPostBack == false)
        {

            SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog= ASP_Project; Integrated Security = true");
            SqlCommand cmdCount = new SqlCommand("SELECT COUNT(*) FROM Event ", conn);
            

            conn.Open();
            homeRecord = Convert.ToInt32(cmdCount.ExecuteScalar());
            conn.Close();

            if (homeRecord != 0)
            {

                SqlDataAdapter da = new SqlDataAdapter(cmdComment, conn);
                conn.Open();

                DataSet ds = new DataSet();
                da.Fill(ds);
                Repeater1.DataSource = ds;
                Repeater1.DataBind();

                conn.Close();
            }

        }

    }
    protected void lnkpro_Click(object sender, EventArgs e)
    {

        Button myButton = sender as Button;
        if (myButton != null)
        {
            Session["More"] = myButton.Text;
            Response.Redirect("Member_EventPosts.aspx");
        }

    }
}