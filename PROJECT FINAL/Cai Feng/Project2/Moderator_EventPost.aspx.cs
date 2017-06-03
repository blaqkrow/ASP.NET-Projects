using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Moderator_EventPost : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int homeRecord;

        if (Page.IsPostBack == false)
        {

            SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog= ASP_Project; Integrated Security = true");
            if (Session["Moderator"].ToString() ==  "1")
            {
                SqlCommand cmd = new SqlCommand("SELECT  *  FROM Website Where Website_Category = 1", conn);
                SqlCommand cmdCount = new SqlCommand("SELECT COUNT(*) FROM Website where Website_Category = 1", conn);

                String cmdComment = "Select * from Comment Where Comment_Post = 1";
                

                conn.Open();
                homeRecord = Convert.ToInt32(cmdCount.ExecuteScalar());

                if (homeRecord != 0)
                {

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {

                        lbl_tittle.Text = dr["Website_Tittle"].ToString();
                        lbl_Description.Text = dr["Website_Description"].ToString();

                        if (dr["Website_PostBy"].ToString() != null)
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

                SqlDataAdapter da = new SqlDataAdapter(cmdComment, conn);

                conn.Open();

                DataSet ds = new DataSet();

                da.Fill(ds);

                Repeater1.DataSource = ds;
                Repeater1.DataBind();

                conn.Close();
            }
            else if (Session["Moderator"].ToString() == "3")
            {
            }
        }
    }

    protected void btn_Comment_Click1(object sender, EventArgs e)
    {
        int homeRecord2;
        SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog= ASP_Project; Integrated Security = true");
        conn.Open();

        SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Website where Website_Category= '" + Session["Moderator"].ToString() + "'", conn);
        homeRecord2 = Convert.ToInt32(cmd.ExecuteScalar());


        if (homeRecord2 != 0)
        {
            string mySql = "INSERT INTO Comment (User_UserName,Comment_Description,Comment_Date,Comment_Post) VALUES ('" + txt_Name.Text.Trim() + "','" + txt_Comment.Text.Trim() + "','" + DateTime.Now.ToString() + "','" + Session["Moderator"].ToString() + "');";
            SqlCommand cmdUpdate = new SqlCommand(mySql, conn);
            cmdUpdate.ExecuteNonQuery();
        }

        conn.Close();
        Response.Redirect("Moderator_EventPost.aspx");
    }
}