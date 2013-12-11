using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dll1;

public partial class C2F : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int d = Convert.ToInt32(Convert.ToDouble(TextBox1.Text));
        int result = Class1.getFahrenheit(d);
        TextBox2.Text = Convert.ToString(result);
    }
}