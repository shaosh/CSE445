using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dll2;

public partial class km2mile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        double d = Convert.ToDouble(TextBox1.Text);
        double result = Class1.KmToMile(d);
        TextBox2.Text = Convert.ToString(result);
    }
}