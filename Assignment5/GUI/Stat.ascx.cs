using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.IO;

public partial class Stat : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        XmlDocument xmlDoc = new XmlDocument();
        string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"App_Data\Stat.xml");
        xmlDoc.Load(path);
        XmlElement element = (XmlElement)(xmlDoc.GetElementsByTagName("count").Item(0));
        int visitCount = Int32.Parse(element.InnerText);
        visitCount++;
        element.InnerText = visitCount.ToString();
        count.Text = visitCount.ToString();
        xmlDoc.Save(path);
    }
}