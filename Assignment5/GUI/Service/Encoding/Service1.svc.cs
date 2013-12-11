using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Encoding
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        public string StringEncoding(string pwd)
        {
            char[] arrChar = pwd.ToCharArray();
            string strChar = "";
            for (int i = 0; i < arrChar.Length; i++)
            {
                arrChar[i] = Convert.ToChar(arrChar[i] + 3);
                strChar = strChar + arrChar[i].ToString();
            }
            return strChar;
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
