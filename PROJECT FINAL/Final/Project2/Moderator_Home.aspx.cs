using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

public partial class Moderator_Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int homeRecord;

        if (Page.IsPostBack == false){

            SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog= ASP_Project; Integrated Security = true");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT  *  FROM Website Where Website_Category = 1", conn);

            SqlCommand cmdCount = new SqlCommand("SELECT COUNT(*) FROM Website where Website_Category = 1", conn);

           
            homeRecord = Convert.ToInt32(cmdCount.ExecuteScalar());

            if (homeRecord != 0)
            {

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    lbl_tittle.Text = dr["Website_Tittle"].ToString();
                    lbl_Description.Text = dr["Website_Description"].ToString();

                    if ( dr["Website_PostBy"].ToString() != null)
                    {
                        lbl_CreatedBy.Text = "Created By:" + dr["Website_PostBy"].ToString();
                        lbl_CreatedDate.Text = "Created Date:" + dr["Website_DateCreate"].ToString();
                    }
                    if (dr["Website_EditBy"].ToString() != null)
                    {

                        lbl_EditedBy.Text = "Edited By:" + dr["Website_EditBy"].ToString();
                        lbl_EditedDate.Text = "Last Edited Date:" + dr["Website_DateEdited"].ToString();

                    }
                }
            }
            conn.Close();
        }
    }
    protected void btn_More_Click(object sender, EventArgs e)
    {
        Session["Moderator"] = "1";
        Response.Redirect("Moderator_EventPost.aspx");
    }
}