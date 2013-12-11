using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text.RegularExpressions; 
using System.Text;

namespace weather_require13_
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
        string returnTempeture;
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
        public string getWeather(string zip)
        {

            gov.weather.graphical.ndfdXML gg = new gov.weather.graphical.ndfdXML();
            gov.weather.graphical.weatherParametersType pa = new gov.weather.graphical.weatherParametersType();
            pa.maxt = true;
            pa.mint = true;
            // pa.iceaccum = true;
            pa.dryfireo = true;
            //pa.dew = true;
            string information = gg.LatLonListZipCode("85281");
            int x = information.IndexOf("</latLonList>");
            int y = information.IndexOf("<latLonList>");

            string location = information.Substring(information.IndexOf("<latLonList>") + 12, information.IndexOf("</latLonList>") - information.IndexOf("<latLonList>") - 12);
            string[] lat = location.Split(',');

            //33.4357,-111.917
            string w = gg.NDFDgen(Convert.ToDecimal(lat[0]), Convert.ToDecimal(lat[1]), "time-series", DateTime.Now, DateTime.Now.AddDays(4), "e", pa);
            string TMbeg = "<name>Daily Maximum Temperature</name>";
            string TMend = "</temperature>";
            string Mtemepeture = w.Substring(w.IndexOf(TMbeg) + TMbeg.Length, w.IndexOf(TMend) - w.IndexOf(TMbeg) - TMbeg.Length);
            Mtemepeture = Mtemepeture.Trim();
            string[] max = System.Text.RegularExpressions.Regex.Split(Mtemepeture, "\n");
            returnTempeture = "Max Temepture: " + Regex.Replace(max[0], @"[^\d.\d]", "");
            for (int i = 1; i < max.Length; i++)
            {
                returnTempeture = returnTempeture + ",";
                returnTempeture = returnTempeture + Regex.Replace(max[i], @"[^\d.\d]", "");

            }


            string TNbeg = "<name>Daily Minimum Temperature</name>";
            string duplicate = "</temperature>";
            string TNend = "<fire";
            int ee = w.IndexOf(TNend);
            int e = w.IndexOf(TMend);
            string Ntemepeture = w.Substring(w.IndexOf(TNbeg) + TNbeg.Length, w.IndexOf(TNend) - w.IndexOf(TNbeg) - TNbeg.Length);
            Ntemepeture = Ntemepeture.Trim();
            Ntemepeture = Ntemepeture.Substring(0, Ntemepeture.Length - duplicate.Length).Trim();
            string[] min = System.Text.RegularExpressions.Regex.Split(Ntemepeture, "\n");
            returnTempeture = returnTempeture + "\n";
            returnTempeture = returnTempeture + "Min Temepture: " + Regex.Replace(min[0], @"[^\d.\d]", "");
            for (int i = 1; i < min.Length; i++)
            {
                returnTempeture = returnTempeture + ",";
                returnTempeture = returnTempeture + Regex.Replace(min[i], @"[^\d.\d]", "");

            }
            return returnTempeture;
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
