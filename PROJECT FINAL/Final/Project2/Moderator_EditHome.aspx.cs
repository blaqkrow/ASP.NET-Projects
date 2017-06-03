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
    int recordCount;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            int homeRecord;

            SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog= ASP_Project; Integrated Security = true");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT  *  FROM Website Where Website_Category = 1", conn);

            SqlCommand cmdCount = new SqlCommand("SELECT COUNT(*) FROM Website where Website_Category= 1", conn);
            homeRecord = Convert.ToInt32(cmdCount.ExecuteScalar());

            

            if (homeRecord != 0){

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                
                    txt_tittle.Text =  dr["Website_Tittle"].ToString();
                    txt_Description.Text = dr["Website_Description"].ToString();

                    if (dr["Website_PostBy"].ToString() != null)
                    {
                        lbl_CreateBy.Text = "Created By:" + dr["Website_PostBy"].ToString();
                        lbl_CreateDate.Text = "Created Date:" + dr["Website_DateCreate"].ToString();
                    }
                    if (dr["Website_EditBy"].ToString() != null)
                    {

                        lbl_EditBy.Text = "Edited By:" + dr["Website_EditBy"].ToString();
                        lbl_EditDate.Text = "Last Edited Date:" + dr["Website_DateEdited"].ToString();
                    }
             
                }
            }
            conn.Close();


        }
    }
    protected void txt_Update_Click(object sender, EventArgs e)
    {
        int homeRecord2;
        SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog= ASP_Project; Integrated Security = true");
        conn.Open();
        
        SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Website where Website_Category= 1", conn);
        homeRecord2 = Convert.ToInt32(cmd.ExecuteScalar());


        if (homeRecord2 == 0)
        {
            string mySql = "INSERT INTO Website (Website_Tittle, Website_Description, Website_DateCreate,Website_PostBy, Website_Category) VALUES ('" + txt_tittle.Text.Trim() + "','" + txt_Description.Text.Trim() + "','" + DateTime.Now.ToString() + "','" + Session["UName"] + "','" + 1 + "');";
             SqlCommand cmdUpdate = new SqlCommand(mySql, conn);
             cmdUpdate.ExecuteNonQuery();
        }
        else if (homeRecord2 != 0)
        {
            string mySql = "Update Website set Website_Tittle = '" + txt_tittle.Text.Trim() + "' ,Website_Description = '" + txt_Description.Text.Trim() + "' ,Website_DateEdited = '" + DateTime.Now.ToString() + "' , Website_PostBy = '" + Session["UName"] + "' Where Website_Category = 1";
             SqlCommand cmdUpdate = new SqlCommand(mySql, conn);
             cmdUpdate.ExecuteNonQuery();
        }
           
       conn.Close();
       Response.Redirect("Moderator_Home.aspx");
        
    }
}