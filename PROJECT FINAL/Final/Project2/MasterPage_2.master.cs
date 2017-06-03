using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Text;
using System.Security.Cryptography;

public partial class MasterPage_2 : System.Web.UI.MasterPage
{

    protected void Page_Load(object sender, EventArgs e)
    {
        Session["LoginStatus"] = false;
        if (Page.IsPostBack == false)
        {
            //Session["LoginFailed"] = false;
            if (Request.Cookies["LoginCookies"] != null)
            {
                txtUser.Text = Request.Cookies["LoginCookies"].Value;  //For Second Way
            }
        }

        //if ((bool)Session["LoginFailed"] == true)
        //{
        //    lblError.Text = "Username or password is invalid. Please try again!";
        //}
       
    }
    //Hashing Algorithm Function
    public static string MD5Hash(string text)
    {
        MD5 md5 = new MD5CryptoServiceProvider();

        //compute hash from the bytes of text
        md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

        //get hash result after compute it
        byte[] result = md5.Hash;

        StringBuilder strBuilder = new StringBuilder();
        for (int i = 0; i < result.Length; i++)
        {
            //change it into 2 hexadecimal digits
            //for each byte
            strBuilder.Append(result[i].ToString("x2"));
        }

        return strBuilder.ToString();
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //Saving of Data to Cookies
        Response.Cookies["LoginCookies"].Value = txtUser.Text;
        Response.Cookies["LoginCookies"].Expires = DateTime.Now.AddDays(1);
       
        SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog=ASP_Project; Integrated Security=SSPI");
        conn.Open();

        SqlCommand cmdUsers = new SqlCommand("select * from [User] where User_UName = '" + txtUser.Text.Trim() + "'", conn);

        SqlDataReader dr;
        dr = cmdUsers.ExecuteReader();

        while (dr.Read())
        {
            //Hash the password to compare with the database data
            if (MD5Hash(txtPass.Text.Trim()) == dr["User_Password"].ToString())
            {
                Session["LoginStatus"] = true;
                Session["UserID"] = dr["User_ID"].ToString();
                Session["UName"] = txtUser.Text;
                Session["FName"] = dr["User_FistName"].ToString();
                Session["LName"] = dr["User_LastName"].ToString();
                Session["Type"] = dr["Type_ID"].ToString();
            }
            else
            {
                //login has failed
                //Response.Redirect("Home.aspx");
                //Session["LoginFailed"] = true;
               
                lblError.Text = "Username or password is invalid. Please try again!";
            }

        }

        if ((bool)Session["LoginStatus"] == false)
        {
            lblError.Text = "Username or password is invalid. Please try again!";
        }

        //Autenticate to the different user type
        if ((string)Session["Type"] == "1")
        {
            //go members page
            Response.Redirect("Member_Home.aspx");
        }
        if ((string)Session["Type"] == "2")
        {
            //go admin page
            Response.Redirect("Admin_Home.aspx");
        }
        if ((string)Session["Type"] == "3")
        {
            //go admin page
            Response.Redirect("Moderator_Home.aspx");
        }
    }
}
