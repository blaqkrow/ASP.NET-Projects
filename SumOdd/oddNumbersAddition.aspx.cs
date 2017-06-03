using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class oddNumbersAddition : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCompute_Click(object sender, EventArgs e)
    {
        tbMsg.Text = "To sum all the odd numbers from 1 to 100 \n";

        int i = 1, sum = 0, odd = 0;


            while (i <= 100)
            {
                if (i % 2 == 1)
                {
                    sum += i;
                    odd++;
                }
                i++;
            }
        

        tbMsg.Text += "Total sum is "+sum +" \n";
        tbMsg.Text += "Total number of integers add: " + odd + " \n";


    }
    protected void btnCompute2_Click(object sender, EventArgs e)
    {

        tbMsg2.Text = "To sum all the even numbers from 0 to 100 \n";

        int i = 0, sum = 0, even = 0;

        for (i = 0; i <= 100; i++)
        {

            if (i % 2 == 0)
            {
                sum += i;
                even++;
            }
        }
        


        tbMsg2.Text += "Total sum is " + sum + " \n";
        tbMsg2.Text += "Total number of integers add: " + even + " \n";
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        tbMsg.Text = " ";
    }
    protected void btnClear2_Click(object sender, EventArgs e)
    {
        tbMsg2.Text = " ";
    }
}