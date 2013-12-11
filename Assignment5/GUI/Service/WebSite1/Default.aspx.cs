using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    bool loginflag;
    string useN;
    ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
    ServiceReference2.Service1Client service2 = new ServiceReference2.Service1Client();
    ServiceReference3.Service1Client service3 = new ServiceReference3.Service1Client();
    ServiceReference4.Service1Client service4 = new ServiceReference4.Service1Client();
    ServiceReference5.Service1Client service5 = new ServiceReference5.Service1Client();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //Click事件
    protected void btn_Go_Click(object sender, EventArgs e)
    {
        
        string name = nam.Text;
        string pass = pw.Text;
       // pass=service2.StringEncoding(pass);
        bool flag =service.register(name, pass);
     //   bool flag = service(name, pass);
        if (flag)
        {
            ret.Text = "sucess";
            btn_Go.Enabled = false;
        }
        else
            ret.Text = "fail";
       
    }



    protected void btn(object sender, EventArgs e)
    {
        
        string name = TextBox1.Text;
        useN = name;
        string pass =TextBox2.Text;
       // pass = service2.StringEncoding(pass);
         loginflag= service.signIn(name, pass);
         Session["un"] = useN;
         Session["pw"] = loginflag;
        if (loginflag)
            Label3.Text = "sucess";
        else
            Label3.Text = "fail";
    }
    protected void btn2(object sender, EventArgs e)
    {
        if (Session["pw"]!=null)
        loginflag = (bool)Session["pw"];
        if (!loginflag)
        {
            Label6.Text = "Please login in ";
            return;
        }
        useN = (string)Session["un"];
        string data=TextBox3.Text;
        service.SaveData(useN, data);
        Label6.Text = "sucess";
        Button1.Enabled = false;
    }
    protected void btn3(object sender, EventArgs e)
    {
        if (Session["pw"] != null)
        loginflag = (bool)Session["pw"];
        if (!loginflag)
        {
            Label7.Text = "Please login in ";
            return;
        }
        useN = (string)Session["un"];
       
        string dd=service.GetData(useN);
        Label7.Text = dd;
    }

    protected void btn4(object sender, EventArgs e)
    {
        string encode = service2.StringEncoding(TextBox5.Text);
        Label9.Text = encode;
    }
    protected void btn5(object sender, EventArgs e)
    {
        string encode = service5.StringDecoding(TextBox14.Text);
        Label11.Text = encode;
    }
    protected void btn6(object sender, EventArgs e)
    {
        string returnword = service3.returnStem(TextBox4.Text);
        Label13.Text = returnword;
    }
    protected void btn7(object sender, EventArgs e)
    {
        string returnweather = service4.getWeather(TextBox6.Text);
        Label15.Text = returnweather;
    }
}
