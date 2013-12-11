using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie myCookies = Request.Cookies["myKeyie"];
        if ((myCookies != null) && (myCookies["Username"] != ""))
        {
            Label1.Text = myCookies["Username"];
            Label2.Text = myCookies["Password"];
        }
        totalLabel.Text = " " + ((int)Application["accesses"]) / 2;
        currentLabel.Text = " "+(int)Application["users"];
    }
    protected void Unnamed3_Click(object sender, EventArgs e)
    {
        Session.Clear();
        HttpCookie myCookies = Request.Cookies["myKeyie"];
        if (myCookies != null)
        {
            myCookies.Expires = DateTime.Now.AddDays(-1d);
            Response.Cookies.Add(myCookies);
        }
//        FormsAuthentication.SignOut();
        Response.Redirect("/GUI/default.aspx");
    }
}
