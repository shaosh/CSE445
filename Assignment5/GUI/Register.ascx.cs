using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml;

public partial class Register : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label4.Text = "";
    }

    protected void cancelBtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
    protected void registerBtn_Click(object sender, EventArgs e)
    {
        if (Username.Text == "HaoYan" || Username.Text == "ShihuanShao" || Username.Text == "JieGuo" || Username.Text == "YunlongJiang")
            Label4.Text = "Your username is not allowed!";
        else if (Password.Text == Confirm.Text)
        {
            string fLocation = Path.Combine(Request.PhysicalApplicationPath, @"App_Data\user.xml");
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(fLocation);
            XmlDocumentFragment xfrag = xdoc.CreateDocumentFragment();
            xfrag.InnerXml = @"<User><username>" + Username.Text + "</username>" + "<password>" + Password.Text + "</password>" + "</User>";
            xdoc.DocumentElement.AppendChild(xfrag);
            xdoc.Save(fLocation);
        }
        else
            Label4.Text = "Your confirm password is wrong!";
    }
}