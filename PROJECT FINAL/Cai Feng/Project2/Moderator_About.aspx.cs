using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Moderator_About : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int homeRecord;
        if (Page.IsPostBack == false)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog= ASP_Project; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("SELECT  *  FROM Website Where Website_Category = 2", conn);

            SqlCommand cmdCount = new SqlCommand("SELECT COUNT(*) FROM Website where Website_Category = 2", conn);

            conn.Open();
            homeRecord = Convert.ToInt32(cmdCount.ExecuteScalar());

            if (homeRecord != 0)
            {

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lbl_tittle.Text = dr["Website_Tittle"].ToString();
                    lbl_Description.Text = dr["Website_Description"].ToString();       
                }
            }
            conn.Close();
        }
    }
}