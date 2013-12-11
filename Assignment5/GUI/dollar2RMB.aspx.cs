using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dll4;

public partial class dollar2RMB : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        double d = Convert.ToInt32( Convert.ToDouble(  TextBox1.Text));
        double result = Class1.DollarToRMB(d);
        TextBox2.Text = Convert.ToString(result);
    }
}