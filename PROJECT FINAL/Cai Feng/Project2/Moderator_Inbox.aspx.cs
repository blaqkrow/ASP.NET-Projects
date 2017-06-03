using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Text;

public partial class Moderator_Inbox : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int homeRecord;

        if (Page.IsPostBack == false)
        {

            SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog= ASP_Project; Integrated Security = true");
            SqlCommand cmdCount = new SqlCommand("SELECT COUNT(*) FROM Message Where Receiver_Name = '"+"user"+"'", conn);

            conn.Open();
            homeRecord = Convert.ToInt32(cmdCount.ExecuteScalar());

            if (homeRecord != 0)
            {

                DataSet ds = new DataSet();
                string inbox = "SELECT Sender_Name,Message_Subject,Message_Description,Message_Date FROM Message Where Receiver_Name = '" + "user" + "'";
                SqlDataAdapter da = new SqlDataAdapter(inbox, conn);

                da.Fill(ds);

                GridView1.DataSource = ds;
                GridView1.DataBind();

            }
            conn.Close();
        }

    }
    //protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    //{
    //    if (e.CommandName == "hello")
    //    {
    //        GridViewRow grid = (GridViewRow)((Control)e.CommandSource).NamingContainer;
    //        int index = grid.RowIndex;

    //        Label smth = (Label)GridView1.Rows[index].Cells[0].FindControl("");

    //    }
    //}
    protected void btn_Delete_Click(object sender, EventArgs e)
    {
        StringBuilder sbQuery = new StringBuilder();
        bool flag = false;
        foreach (GridViewRow row in GridView1.Rows)
        {
            CheckBox chk = (CheckBox)row.FindControl("chkdelete");
            if (((CheckBox)row.FindControl("chkdelete")).Checked)
            {
                flag = true;
                lbl_test.Text = "Here";

            }

        }
    }
}