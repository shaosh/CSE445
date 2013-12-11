using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace AllService_tryItPage
{
    public class Dictionary
    {
        public string name;
        public string input;
        public string output;
    }

    public partial class _Default : System.Web.UI.Page
    {
        YJServices.ServiceClient s = new YJServices.ServiceClient();
      //  YJServices.ServiceClient s = new YJServices.ServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String result = s.findNearestStore(TextBox1.Text, TextBox2.Text);
            Label1.Text = result;
        }

        protected void Button2_Click(object sender, EventArgs e)
        { 
            YJServices.Dictionary[] dic = s.WsHashOperations(TextBox3.Text);
            String[] str = new String[dic.Length];
            for (int i = 0; i < dic.Length; i++)
            {
                str[i] = "Name: " + dic[i].name + " Input: " + dic[i].input + " Output: " + dic[i].output;
                Label2.Text = Label2.Text + "<BR>" + str[i];
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            String result = s.compressString(TextBox4.Text);
            Label3.Text = result;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int result = s.stringMatching(TextBox5.Text, TextBox6.Text);
            Label4.Text = result.ToString();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            String result = s.bidirection_string_Convert_binary(TextBox7.Text);
            Label5.Text = result;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            String result = s.CalulateSimiliarty(TextBox8.Text, TextBox9.Text);
            Label6.Text = result;
        }
    }
}