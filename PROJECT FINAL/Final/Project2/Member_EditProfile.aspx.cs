using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

public partial class Styles_Member_EditProfile : System.Web.UI.Page
{
    string str;
    string path;

    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {
        
        
        SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog=ASP_Project; Integrated Security=SSPI");
        conn.Open();

        SqlCommand cmdUsers = new SqlCommand("select * from [User] where User_UName = '" + Session["UName"].ToString() + "'", conn);
        SqlCommand cmdCheck2 = new SqlCommand("select count(*) from Payment where User_ID = '" + Session["UserID"].ToString() + "'", conn);
        int count2 = Convert.ToInt32(cmdCheck2.ExecuteScalar());//check if there are payment records

        if (count2 == 0)
        {
            RadioButtonList1.SelectedIndex = 0;

            txt_Cardholder.Enabled = false;
            txt_CardNo.Enabled = false;
            txt_SecurityCode.Enabled = false;
        }

        SqlDataReader dr;
        dr = cmdUsers.ExecuteReader();

        while (dr.Read())
        {
            txt_UName.Text = dr["User_UName"].ToString();
            txt_Password.Text = dr["User_Password"].ToString();
            txt_FName.Text = dr["User_FistName"].ToString();
            txt_LName.Text = dr["User_LastName"].ToString();
            txt_Email.Text = dr["User_Email"].ToString();
            

        }

        dr.Close();

        cmdUsers.CommandText = "select * from [Payment] where User_ID = '" + Session["UserID"].ToString() + "'";
        dr = cmdUsers.ExecuteReader();

        while (dr.Read())
        {
            if (dr["Payment_MethodName"].ToString() == "0")
            {
                RadioButtonList1.SelectedIndex = 0;

            txt_Cardholder.Enabled = false;
            txt_CardNo.Enabled = false;
            txt_SecurityCode.Enabled = false;
            }
            else{

             if (dr["Payment_MethodName"].ToString() == "1")
            {
                RadioButtonList1.SelectedIndex = 1;
            }
            if (dr["Payment_MethodName"].ToString() == "2")
            {
                RadioButtonList1.SelectedIndex = 2;
            }
            if (dr["Payment_MethodName"].ToString() == "3")
            {
                RadioButtonList1.SelectedIndex = 3;
            }

            txt_Cardholder.Enabled = true;
            txt_CardNo.Enabled = true;
            txt_SecurityCode.Enabled = true;

            }

            txt_Cardholder.Text = dr["Payment_CardHolder"].ToString();
            txt_CardNo.Text = dr["Payment_CardNumber"].ToString();
            txt_SecurityCode.Text = dr["Payment_SecurityCode"].ToString();
        }
        dr.Close();
        conn.Close();
    }
        
    }


    protected void btn_Confirm_Click(object sender, EventArgs e)
    {
        //DO THIS TMR LOLOOLOLOLOLOLOLOLLOL UPDATE STATEMENT WRONG!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog=ASP_Project; Integrated Security=SSPI");
        conn.Open();

        string mySQL;

        if (FileUpload1.HasFile)
        {
            str = FileUpload1.FileName;
            FileUpload1.PostedFile.SaveAs(Server.MapPath(".") + "/Images/" + str);
            path = "~/Images/" + str.ToString();
        }
        else if (!FileUpload1.HasFile)
        {
            Label1.Text = "Please upload your image";
        }

        mySQL = "UPDATE [User] SET User_UName='" + txt_UName.Text.Trim() + "',User_FistName='" + txt_FName.Text.Trim() + "',User_LastName='" + txt_LName.Text.Trim() + "',User_Password='" + txt_Password.Text.Trim() + "',User_Email='" + txt_Email.Text.Trim() + "',User_Image ='" + path + "' where User_ID = '" + Session["UserID"].ToString() + "'";
        SqlCommand cmdUpdate = new SqlCommand(mySQL, conn); //update users first

        cmdUpdate.ExecuteNonQuery();

        SqlCommand cmdCheck = new SqlCommand("select count(*) from Payment where User_ID = '" + Session["UserID"].ToString() + "'", conn);
        int count = Convert.ToInt32(cmdCheck.ExecuteScalar());//check if there are payment records

        if (count == 0) //no payment records
        {
            mySQL = "INSERT INTO Payment (User_ID,Payment_MethodName,Payment_CardHolder,Payment_CardNumber,Payment_SecurityCode) values('" + Session["UserID"].ToString() + "','" + RadioButtonList1.SelectedIndex.ToString() + "','" + txt_Cardholder.Text.Trim() + "','" + txt_CardNo.Text.Trim() + "','" + txt_SecurityCode.Text.Trim() + "')";

            SqlCommand cmdAdd2 = new SqlCommand(mySQL, conn);

            cmdAdd2.ExecuteNonQuery();
        }
        if (count > 0)
        {
            mySQL = "UPDATE Payment SET Payment_MethodName='" + RadioButtonList1.SelectedIndex.ToString() + "',Payment_CardHolder='" + txt_Cardholder.Text.Trim() + "',Payment_CardNumber='" + txt_CardNo.Text.Trim() + "',Payment_SecurityCode='" + txt_SecurityCode.Text.Trim() + "' where User_ID = '" + Session["UserID"].ToString()  + "'";

            SqlCommand cmdUpdate2 = new SqlCommand(mySQL, conn);

            cmdUpdate2.ExecuteNonQuery();
        }

        conn.Close();

        Response.Redirect("Member_Home.aspx"); //redirect to home page
    }
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedIndex == 0)
        {
            txt_Cardholder.Enabled = false;
            txt_CardNo.Enabled = false;
            txt_SecurityCode.Enabled = false;

        }
        else
        {
            txt_Cardholder.Enabled = true;
            txt_CardNo.Enabled = true;
            txt_SecurityCode.Enabled = true;
        }
    }
}