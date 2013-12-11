using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace stemservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        public string returnStem(string str)
        {
            str = str.ToLower();
            string[] five = new string[] { "ility", "ative" };
            string[] four = new string[] { "able", "hood", "less", "like" };
            string[] three = new string[] { "age", "ful", "ile", "ing", "ism", "ive", "est" };
            string[] two = new string[] { "al", "ed", "er", "ee", "ic", "fy" };
            string[] one = new string[] { "s", "y" };
            for (int i = 0; i < five.Length; i++)
            {
                if (five[i].Equals(str.Substring(str.Length - 5)))
                    return str.Substring(0, str.Length - 5);
            }
            for (int i = 0; i < four.Length; i++)
            {
                if (four[i].Equals(str.Substring(str.Length - 4)))
                    return str.Substring(0, str.Length - 4);
            }
            for (int i = 0; i < three.Length; i++)
            {
                if (three[i].Equals(str.Substring(str.Length - 3)))
                    return str.Substring(0, str.Length - 3);
            }
            for (int i = 0; i < two.Length; i++)
            {
                if (two[i].Equals(str.Substring(str.Length - 2)))
                    return str.Substring(0, str.Length - 2);
            }
            for (int i = 0; i < one.Length; i++)
            {
                if (one[i].Equals(str.Substring(str.Length - 1)))
                    return str.Substring(0, str.Length - 1);

            }
            return str;

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
