using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

public partial class Moderator_Donation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
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
    protected void btnDonate_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog=ASP_Project; Integrated Security=SSPI");
        conn.Open();

        string mySQL = "INSERT INTO Donation (User_ID,Donation_Amount,Donation_Date,Donation_Organisation) values(" + Session["UserID"] + "," + txtAmount.Text.Trim() + ",'" + DateTime.Now + "','" + DropDownList1.SelectedItem.Text.Trim() + "')";
        SqlCommand cmdInsert2 = new SqlCommand(mySQL, conn); //update users first

        cmdInsert2.ExecuteNonQuery();
        conn.Close();
    }
}