using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ip : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string ipStr = HttpContext.Current.Request.UserHostAddress;
        if (ipStr != null)
            ipLabel.Text = ipStr;
        else
            ipLabel.Text = "IP address cannot be detected.";
    }
}