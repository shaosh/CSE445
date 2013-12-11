using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Application
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void TestService1(object sender, EventArgs e) {
            xmlService.ServiceClient client = new xmlService.ServiceClient();
            if (xmlurl.Text != "" && xsdurl.Text != "")
            {
                string validationResult = client.verification(xmlurl.Text, xsdurl.Text);
                result1.Text = validationResult;
            }
            else
            {
                result1.Text = "Empty url is not allowed!";
            }
        }

        protected void TestService2(object sender, EventArgs e)
        {
            xmlService.ServiceClient client = new xmlService.ServiceClient();
            if (wsdlurl.Text != "")
            {
                string searchWsdlResult = client.searchWsdl(wsdlurl.Text);
                result2.Text = searchWsdlResult;
            }
            else
            {
                result1.Text = "Empty url is not allowed!";
            }
        }
    }
}
