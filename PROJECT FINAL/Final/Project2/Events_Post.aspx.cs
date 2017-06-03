using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Events_Post : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (Page.IsPostBack == false)
        {
            int homeRecord;

            SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog= ASP_Project; Integrated Security = true");
            //Querying the individual Event Post
            SqlCommand cmd = new SqlCommand("SELECT * FROM Event where Event_ID = '" + Session["More"].ToString() + "'", conn);
            SqlCommand cmdCount = new SqlCommand("SELECT COUNT(*) FROM Event where Event_ID = '"+Session["More"].ToString()+"'", conn);
            //Querying the individual Event Comment
            String cmdComment = "Select * from Comment Where Comment_Post = '" + "3" +Session["More"].ToString() + "'";

            conn.Open();
            homeRecord = Convert.ToInt32(cmdCount.ExecuteScalar());

                if (homeRecord != 0)
                {
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        //Setting of values onload
                        lbl_tittle.Text = dr["Event_Name"].ToString();
                        lbl_Description.Text = dr["Event_Description"].ToString();
                        Image1.ImageUrl = dr["Event_Image"].ToString();
                        if (dr["Event_CreateBy"].ToString() != null)
                        {
                            lbl_CreatedBy.Text = "Created By:" + dr["Event_CreateBy"].ToString();
                            lbl_CreatedDate.Text = "Created Date:" + dr["Event_CreateDate"].ToString();
                        }
                        if (dr["Event_EditBy"].ToString() != null)
                        {

                            lbl_EditedBy.Text = "Edited By:" + dr["Event_EditBy"].ToString();
                            lbl_EditedDate.Text = "Last Edited Date:" + dr["Event_EditDate"].ToString();

                        }
                    }
                }
                conn.Close();
                SqlDataAdapter da = new SqlDataAdapter(cmdComment, conn);

                conn.Open();

                DataSet ds = new DataSet();

                da.Fill(ds);
                //Repeating the Div for the Comments
                Repeater1.DataSource = ds;
                Repeater1.DataBind();

                conn.Close();
        }

    }
    protected void btn_Comment_Click(object sender, EventArgs e)
    {
        int homeRecord2;
        SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog= ASP_Project; Integrated Security = true");
        conn.Open();

        SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Event where Event_ID = '" + Session["More"].ToString() + "'", conn);
        homeRecord2 = Convert.ToInt32(cmd.ExecuteScalar());


        if (homeRecord2 != 0)
        {
            //Inserting into Comment database
            string mySql = "INSERT INTO Comment (User_UserName,Comment_Description,Comment_Date,Comment_Post) VALUES ('" + txt_Name.Text.Trim() + "','" + txt_Comment.Text.Trim() + "','" + DateTime.Now.ToString() + "','" + "3" + Session["More"].ToString() +"');";
            SqlCommand cmdUpdate = new SqlCommand(mySql, conn);
            cmdUpdate.ExecuteNonQuery();
        }

        conn.Close();
        Response.Redirect("Events_Post.aspx");
    }
}