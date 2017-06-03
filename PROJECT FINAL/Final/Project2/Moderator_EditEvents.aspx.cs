using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

public partial class Moderator_EditEvents : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lbl_CreateBy.Text = DateTime.Now.ToString();
    }
}