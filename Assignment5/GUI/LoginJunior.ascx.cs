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
    protected void registerBtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx");
    }
    protected void returnBtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
    protected void loginBtn_Click(object sender, EventArgs e)
    {
        HttpCookie myCookies = new HttpCookie("myKeyie");
        string fLocation1 = Path.Combine(Request.PhysicalApplicationPath, @"App_Data\user.xml");
        bool redirect = false;
         
        if (File.Exists(fLocation1))
        {
            FileStream fS = new FileStream(fLocation1, FileMode.Open, FileAccess.Read, FileShare.Read);
            XmlDocument xd = new XmlDocument();
            xd.Load(fS);
            XmlNode node = xd;
            XmlNodeList children = node.ChildNodes;
            foreach (XmlNode child in children.Item(1))
            {
                if (Username.Text == child.FirstChild.InnerText)
                {
                    if (Password.Text == child.LastChild.InnerText)
                    {
                        Session["Username"] = Username.Text;
                        Session["Password"] = Password.Text;
                        myCookies["Username"] = Username.Text;
                        myCookies["Password"] = Password.Text;
                        myCookies.Expires = DateTime.Now.AddMonths(6);
                        Response.Cookies.Add(myCookies);
                        Response.Redirect("ProtectedJuniorService/JuniorService.aspx");                        
                        redirect = true;
                    }
                }
            }
            fS.Close();
        }
        if (!redirect)
            Label3.Text = "Your username or password is incorrect!";
    }
}