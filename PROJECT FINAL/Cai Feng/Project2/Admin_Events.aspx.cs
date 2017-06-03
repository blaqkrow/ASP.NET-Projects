using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Adminstrator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button3_Click(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {

    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "hello")
        {
            GridViewRow grid = (GridViewRow)((Control)e.CommandSource).NamingContainer;
            int index = grid.RowIndex;

            Label smth = (Label)GridView1.Rows[index].Cells[0].FindControl("");

        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

    }
}