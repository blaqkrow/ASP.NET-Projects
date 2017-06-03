using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Text;
using System.Security.Cryptography;

public partial class Registers : System.Web.UI.Page
{
   
    bool inUse = false;
    bool filled = false;
    string path;
    string str;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
         
        }

    }
    //MD5 hashing algorithm function
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

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog=ASP_Project; Integrated Security=SSPI");
        conn.Open();

        string mySQL;
        
        SqlCommand cmdUser = new SqlCommand("Select User_UName from [User]",conn);
        SqlDataReader dr;
        dr = cmdUser.ExecuteReader();

        while (dr.Read())
        {
            //checking whether the username had been used
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

        //checking of empty textboxes
        if (txtUName.Text == "" || txtPWord.Text == "" || txtLName.Text == "" || txtFName.Text == "" || txtEmail.Text == "" || txtBirthday.Text == "")
        {
            filled = false;
        }
        else
        {
            filled = true;
        }

        //showing of error message
        if (inUse)
        {
            lblError.Text = "The Username is in use!";
        }  
        if (!filled)
        {
            lblError.Text = "Please fill in all the fields!";
        }
        //checking of file upload
        if (FileUpload1.HasFile)
        {
            str = FileUpload1.FileName;
            FileUpload1.PostedFile.SaveAs(Server.MapPath(".") + "/Images/" + str);
            path = "~/Images/" + str.ToString();
        }
        else if(!FileUpload1.HasFile)
        {
            Label1.Text = "Please upload your image";
        }

        // if it meet this condition , insert into user table
        if (!(inUse) && filled && FileUpload1.HasFile)
        {
            mySQL = "INSERT INTO [User](User_UName,User_FistName,User_LastName,User_Password,User_Birthday,User_Email,Type_ID,User_Image) VALUES('" + txtUName.Text.Trim() + "','" + txtFName.Text.Trim() + "','" + txtLName.Text.Trim() + "','" + MD5Hash(txtPWord.Text.Trim()) + "','" + Convert.ToDateTime(txtBirthday.Text) + "','" + txtEmail.Text.Trim() + "','" + 1 + "','" + path + "')";
            //mySQL = "INSERT INTO [User](User_UName,User_FistName,User_LastName) values('" + txtUName.Text.Trim() + "','" + txtFName.Text.Trim() + "','" + txtLName.Text.Trim() + "')";

            SqlCommand cmdAdd = new SqlCommand(mySQL, conn);

            cmdAdd.ExecuteNonQuery();
            
            conn.Close();

            Response.Redirect("Home.aspx"); //redirect to home page
        }

    }
    
}