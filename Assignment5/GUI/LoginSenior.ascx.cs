using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml;
using System.Web.Security;

public partial class Login : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        HttpCookie myCookies = Request.Cookies["myKeyie"];
        if (myCookies != null)
        {
            Session["Username"] = myCookies["Username"];
            Session["Password"] = myCookies["Password"];        
        }
    }
    
    protected void returnBtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
    protected void loginBtn_Click(object sender, EventArgs e)
    {
        HttpCookie myCookies = new HttpCookie("myKeyie");
        bool redirect = false;

        if (FormsAuthentication.Authenticate(Username.Text, Password.Text))
        {
            FormsAuthentication.RedirectFromLoginPage(Username.Text, true);
            Session["Username"] = Username.Text;
            Session["Password"] = Password.Text;
            myCookies["Username"] = Username.Text;
            myCookies["Password"] = Password.Text;
            myCookies.Expires = DateTime.Now.AddMonths(6);
            Response.Cookies.Add(myCookies);
            redirect = true;
            Response.Redirect("ProtectedSeniorService/SeniorService.aspx");
        }
        if (!redirect)
            Label3.Text = "Your username or password is incorrect!";
    }
}