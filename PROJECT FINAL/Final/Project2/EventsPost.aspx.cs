using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class EventsPost : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int homeRecord;

        if (Page.IsPostBack == false)
        {

            SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog= ASP_Project; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Event where Event_ID = 1", conn);
            SqlCommand cmdCount = new SqlCommand("SELECT COUNT(*) FROM Website where Website_Category = 1", conn);

            String cmdComment = "Select * from Comment Where Comment_Post = 1";


                conn.Open();
                homeRecord = Convert.ToInt32(cmdCount.ExecuteScalar());

                if (homeRecord != 0)
                {

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {

                        lbl_tittle.Text = dr["Event_Name"].ToString();
                        lbl_Description.Text = dr["Event_Description"].ToString();
                        lbl_Date.Text = dr["Event_Date"].ToString();

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

                Repeater1.DataSource = ds;
                Repeater1.DataBind();

                conn.Close();
            }
            


       }

    
}