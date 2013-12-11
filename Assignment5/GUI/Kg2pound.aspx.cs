using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dll3;

public partial class pound2Kg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        double d = Convert.ToInt32(Convert.ToDouble(TextBox1.Text));
        double result = Class1.BtoKG(d);
        TextBox2.Text = Convert.ToString(result);
    }
}