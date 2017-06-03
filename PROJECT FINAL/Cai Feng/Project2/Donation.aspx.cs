using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

public partial class Donation : System.Web.UI.Page
{
    int userID;
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((bool)Session["LoginStatus"] == false)
        {
            lblPayment.Visible = true;
            RadioButtonList1.Visible = true;
            lblCardHolder.Visible = true;
            txtCardHolder.Visible = true;
            lblCardNumber.Visible = true;
            txtCardNumber.Visible = true;
            lblSecurityCode.Visible = true;
            txtSecurity.Visible = true;

        }
        else
        {
            lblPayment.Visible = false;
            RadioButtonList1.Visible = false;
            lblCardHolder.Visible = false;
            txtCardHolder.Visible = false;
            lblCardNumber.Visible = false;
            txtCardNumber.Visible = false;
            lblSecurityCode.Visible = false;
            txtSecurity.Visible = false;

        }
    }

    protected void btnDonate_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog=ASP_Project; Integrated Security=SSPI");
        conn.Open();

        string mySQL;

        if ((bool)Session["LoginStatus"] == false)
        {
            // userID = Convert.ToInt32(Session["UserID"].ToString());


            mySQL = "INSERT INTO Payment (User_ID,Payment_MethodName,Payment_CardHolder,Payment_CardNumber,Payment_SecurityCode) values(null,'" + RadioButtonList1.SelectedIndex.ToString() + "','" + txtCardHolder.Text.Trim() + "','" + txtCardNumber.Text.Trim() + "','" + txtSecurity.Text.Trim() + "')";

            SqlCommand cmdInsert = new SqlCommand(mySQL, conn); //update users first

            cmdInsert.ExecuteNonQuery();

            mySQL = "INSERT INTO Donation (User_ID,Donation_Amount,Donation_Date,Donation_Organisation) values(null," + txtAmount.Text.Trim() + ",'" + DateTime.Now + "','" + DropDownList1.SelectedItem.Text.Trim() + "')";

            SqlCommand cmdInsert2 = new SqlCommand(mySQL, conn); //update users first

            cmdInsert2.ExecuteNonQuery();
        }

        else
        {

            mySQL = "INSERT INTO Donation (User_ID,Donation_Amount,Donation_Date,Donation_Organisation) values("+Convert.ToString(userID)+"," + txtAmount.Text.Trim() + ",'" + DateTime.Now + "','" + DropDownList1.SelectedItem.Text.Trim() + "')";

            SqlCommand cmdInsert2 = new SqlCommand(mySQL, conn); //update users first

            cmdInsert2.ExecuteNonQuery();
        }

        conn.Close();

        Response.Redirect("Home.aspx");
        
        
    }
}