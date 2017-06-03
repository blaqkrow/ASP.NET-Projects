using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class Registers : System.Web.UI.Page
{
    int userid = 0;
    bool inUse = false;
    bool filled = false;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
          //  Session["LoginStatus"] = false;

          //  bool lgnStatus = (bool)Session["LoginStatus"];

           // if (lgnStatus == true)
          //  {
           //     Response.Redirect("www.google.com"); //redirect to home page
           // }
        }


        SqlConnection conn2 = new SqlConnection("Data Source=localhost; Initial Catalog=ASP_Project; Integrated Security=SSPI");
        conn2.Open();

        SqlCommand cmd = new SqlCommand("select MAX(User_ID) from [User]", conn2);
        userid = Convert.ToInt32(cmd.ExecuteScalar());

        conn2.Close();
    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog=ASP_Project; Integrated Security=SSPI");
        conn.Open();

        string mySQL,myCheck;
        userid++;
        SqlCommand cmdUser = new SqlCommand("Select User_UName from [User]",conn);
        SqlDataReader dr;
        dr = cmdUser.ExecuteReader();

        while (dr.Read())
        {
            if (txtUName.Text == dr["User_UName"].ToString())
            {
                inUse = true;
            }
            else
            {
                lblError.Text = "";
                inUse = false;
            }
        }
        dr.Close();

        if (txtUName.Text == "" || txtPWord.Text == "" || txtLName.Text == "" || txtFName.Text == "" || txtEmail.Text == "" || txtBirthday.Text == "")
        {
            filled = false;
        }
        else
        {
            filled = true;
        }


        if (inUse)
        {
            lblError.Text = "The Username is in use!";
        }  
        if (!filled)
        {
            lblError.Text = "Please fill in all the fields!";
        }

        if (!(inUse) && filled)
        {

            mySQL = "INSERT INTO [User](User_ID,User_UName,User_FistName,User_LastName,User_Password,User_Birthday,User_Email,Type_ID) VALUES('" + userid + "','" + txtUName.Text.Trim() + "','" + txtFName.Text.Trim() + "','" + txtLName.Text.Trim() + "','" + txtPWord.Text.Trim() + "','" + Convert.ToDateTime(txtBirthday.Text) + "','" + txtEmail.Text.Trim() + "','" + 2 + "')";
            //mySQL = "INSERT INTO [User](User_UName,User_FistName,User_LastName) values('" + txtUName.Text.Trim() + "','" + txtFName.Text.Trim() + "','" + txtLName.Text.Trim() + "')";

            SqlCommand cmdAdd = new SqlCommand(mySQL, conn);

            cmdAdd.ExecuteNonQuery();
            conn.Close();

            Response.Redirect("Home.aspx"); //redirect to home page
        }

    }
}