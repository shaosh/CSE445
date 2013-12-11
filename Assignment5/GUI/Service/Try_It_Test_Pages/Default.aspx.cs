using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Try_It_Test_Pages
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Result1.Text = "";
            Result2.Text = "";
            Result3.Text = "";
            Result4.Text = "";
            Result5.Text = "";
            Result6.Text = "";
        }

        myServices.ServiceClient s = new myServices.ServiceClient();

        protected void Button1_Click(object sender, EventArgs e)
        {
            string url = TextBox1.Text;
            string[] arr = s.WsdlAddress(TextBox1.Text);
            for (int i = 0; i < arr.Length; i++)
            {
                Result1.Text = Result1.Text + "<BR>" + arr[i];
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string url = TextBox2.Text;
            string[] arr = s.WsOperations(TextBox2.Text);
            for (int i = 0; i < arr.Length; i++)
            {
                Result2.Text = Result2.Text + "<BR>" + arr[i];
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (s.checkRotation(TextBox3.Text, TextBox4.Text))
                Result3.Text = "Yes! String A '" + TextBox3.Text + "' is the rotation of String B '" + TextBox4.Text + "'.";
            else
                Result3.Text = "No! String A '" + TextBox3.Text + "' is not the rotation of String B '" + TextBox4.Text + "'.";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (s.checkUnique(TextBox5.Text))
                Result4.Text = "Yes, this string has unique characters.";
            else
                Result4.Text = "No, this string has some duplicate characters.";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Result5.Text = s.replaceSpace(TextBox6.Text);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Result6.Text = s.largestCommonSubstring(TextBox7.Text, TextBox8.Text);
        }
    }
}