using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

public partial class Styles_Member_Profile : System.Web.UI.Page
{
    int userID;
    protected void Page_Load(object sender, EventArgs e)
    {
       
        SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog=ASP_Project; Integrated Security=SSPI");
        conn.Open();

        SqlCommand cmdUsers = new SqlCommand("select * from [User] where User_UName = '" + Session["UName"].ToString() + "'", conn);

        SqlDataReader dr;
        dr = cmdUsers.ExecuteReader();

        while (dr.Read())
        {
            lbl_UName.Text = dr["User_UName"].ToString();
            lbl_Payment.Text = dr["Payment_ID"].ToString();
            lbl_FName.Text = dr["User_FistName"].ToString();
            lbl_LName.Text = dr["User_LastName"].ToString();
            lbl_Email.Text = dr["User_Email"].ToString();
            Image1.ImageUrl = dr["User_Image"].ToString();

        }

        dr.Close();

        SqlDataReader dr2;
        SqlCommand cmdUsers2 = new SqlCommand("select * from [Payment] where User_ID = '" + Session["UserID"].ToString() + "'", conn);
        dr2 = cmdUsers2.ExecuteReader();

        while (dr2.Read())
        {
            if (dr2["Payment_MethodName"].ToString() == "0")
            {
                lbl_Payment.Text = "None";
            }
            if (dr2["Payment_MethodName"].ToString() == "1")
            {
                lbl_Payment.Text = "MasterCard";
            }
            if (dr2["Payment_MethodName"].ToString() == "2")
            {
                lbl_Payment.Text = "Visa";
            }
            if (dr2["Payment_MethodName"].ToString() == "3")
            {
                lbl_Payment.Text = "AmericanExpress";
            }
            
        }
        dr2.Close();
    }
    protected void btn_Edit_Click(object sender, EventArgs e)
    {
        Response.Redirect("Member_EditProfile.aspx");
    }
}