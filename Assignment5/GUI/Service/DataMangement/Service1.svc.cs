using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.IO;
using System.Security.Permissions;
using System.Web;
using System.Web.Caching;
using System.Web.Hosting;

namespace DataMangement
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
        ServiceReference2.Service1Client service2 = new ServiceReference2.Service1Client();
        public  bool signIn(string username, string pw)
        {
           // pw= service2.StringDecoding(pw);
            string dataFile = HostingEnvironment.ApplicationPhysicalPath + username + ".txt";
            // FileStream fs = new FileStream(username+".txt",FileMode.Open);
            if (!(File.Exists(dataFile)))
            {
                return false;
            }
           // string dataFile = HostingEnvironment.ApplicationPhysicalPath + username + ".txt";
            StreamReader reader = new StreamReader(dataFile);
            string temp = null;
            while (!reader.EndOfStream)
            {
                temp = reader.ReadLine() + temp;
            }

            string beg = "Password:";
            string end = "PasswordEnd";
            string password = temp.Substring(temp.IndexOf(beg) + beg.Length, temp.IndexOf(end) - temp.IndexOf(beg) - beg.Length);
            
            reader.Close();
            if (password.Equals(pw))
                return true;
            else
                return false;

        }


        public  bool register(string username, string password)
        {
            string dataFile = HostingEnvironment.ApplicationPhysicalPath + username + ".txt";
            if ((File.Exists(dataFile)))
            {
                return false;
            }
          //  File.Create(@"c:/a.txt");
            //string dataFile = HostingEnvironment.ApplicationPhysicalPath + username+".txt";
         //   FileStream imageFile = File.OpenRead(@"c:/a.txt");
            FileStream fs = new FileStream(dataFile, FileMode.Create);
            StreamWriter writer = new StreamWriter(fs);
        
           // password = service2.StringDecoding(password);
            writer.Write("Password:");
            writer.Write(password);
            writer.Write("PasswordEnd");
            writer.Write("Data:");
            writer.Write("NULL");
            writer.Write("DataEnd");

            writer.Flush();
            writer.Close();
            return true;

        }
        public int sum(int a, int b)
        {
            int c = (a + b);
            return c;
        }
        public  bool SaveData(string username, string D)
        {
            //  FileStream fs = new FileStream(username + ".txt", FileMode.Open);
            string dataFile = HostingEnvironment.ApplicationPhysicalPath + username + ".txt";
            if (!(File.Exists(dataFile)))
            {
                return false;
            }
            StreamReader reader = new StreamReader(dataFile);

            string temp = null;
            while (!reader.EndOfStream)
            {
                temp = reader.ReadLine();
            }
            string beg = "Data:";
            string end = "DataEnd";
            string data = temp.Substring(temp.IndexOf(beg) + beg.Length, temp.IndexOf(end) - temp.IndexOf(beg) - beg.Length);
            temp = temp.Replace(data, D);
            reader.Close();
            StreamWriter write = new StreamWriter(dataFile);
            write.Write(temp);
            write.Flush();
            write.Close();
            return true;

        }
        public string GetData(string username)
        {
            string dataFile = HostingEnvironment.ApplicationPhysicalPath + username + ".txt";
            if (!(File.Exists(dataFile)))
            {
                return null;
            }
            StreamReader reader = new StreamReader(dataFile);

            string temp = null;
            while (!reader.EndOfStream)
            {
                temp = reader.ReadLine();
            }
            string beg = "Data:";
            string end = "DataEnd";
            string data = temp.Substring(temp.IndexOf(beg) + beg.Length, temp.IndexOf(end) - temp.IndexOf(beg) - beg.Length);
            reader.Close();
            return data;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
