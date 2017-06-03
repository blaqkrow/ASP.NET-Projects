using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class quad : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCompute_Click(object sender, EventArgs e)
    {
        int X = Convert.ToInt32(tbX.Text);
        int Y = Convert.ToInt32(tbY.Text);

        if ((X > 0) && (Y > 0))
        {
            lblCoord.Text = "The coordinates ("+ X +","+ Y + ") is in quadrant I";
        }
        if ((X < 0) && (Y > 0))
        {
            lblCoord.Text = "The coordinates (" + X + "," + Y + ") is in quadrant II";
        }
        if ((X < 0) && (Y < 0))
        {
            lblCoord.Text = "The coordinates (" + X + "," + Y + ") is in quadrant III";
        }
        if ((X > 0) && (Y < 0))
        {
            lblCoord.Text = "The coordinates (" + X + "," + Y + ") is in quadrant IV";
        }
        if ((X == 0) && (Y == 0))
        {
            lblCoord.Text = "The coordinates (" + X + "," + Y + ") is at the origin";
        }
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        tbX.Text = " ";
        tbY.Text = " ";
        lblCoord.Text = " ";
    }
}