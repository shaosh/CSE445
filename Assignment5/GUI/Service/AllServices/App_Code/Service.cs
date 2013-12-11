using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Collections;
using System.Web;
using System.Web.Services;
using System.Net;
using System.Xml;
using System.Web.Services.Description;
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Drawing;


// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
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

    // Required Services: 
    // 18. Find the nearest store
    // for example, input: zip is 85281, storeName is safeWay
    // the output is The nearest Safeway: Address is 926 E. Brdway, Tempe. The distance is 3.35615 Miles.

    public string findNearestStore(string zipcode, string storeName)
    {
        string GoogleAPIKey = "AIzaSyBScRISSdiRXflnXd_T4GQv78-VewtIpuc";
        string locationUrl = "";
        string locationResult = "";
        string storeResult = "";
        String searchUrl = "";
        ArrayList latitudeList = new ArrayList();
        ArrayList longitudeList = new ArrayList();
        ArrayList nameList = new ArrayList();
        ArrayList vicinityList = new ArrayList();
        int index = 0;

        locationUrl = "http://maps.googleapis.com/maps/api/geocode/xml?address=" + zipcode + "&sensor=false";
        WebClient webClient = new WebClient();
        webClient.Credentials = CredentialCache.DefaultCredentials;
        Byte[] pageData = webClient.DownloadData(locationUrl);
        locationResult = Encoding.Default.GetString(pageData);

        XmlDocument xmlDocument = new XmlDocument();
        xmlDocument.LoadXml(locationResult);
        XmlNodeList XmlNode = xmlDocument.LastChild.SelectNodes("result/geometry/location");
        double latitude = Convert.ToDouble(XmlNode[0].FirstChild.FirstChild.Value);
        double longitude = Convert.ToDouble(XmlNode[0].LastChild.LastChild.Value);

        searchUrl = "https://maps.googleapis.com/maps/api/place/search/xml?location=" + latitude + "," + longitude + "&radius=32186.88&types=store&name=" + storeName + "&sensor=false&key=" + GoogleAPIKey;
        WebClient webClient2 = new WebClient();
        webClient2.Credentials = CredentialCache.DefaultCredentials;
        Byte[] pageData2 = webClient2.DownloadData(searchUrl);
        storeResult = Encoding.Default.GetString(pageData2);
        xmlDocument.LoadXml(storeResult);

        foreach (XmlNode node in xmlDocument.LastChild.SelectNodes("result"))
        {
            if (node.SelectNodes("geometry/location")[0].Name == "location")
            {
                latitudeList.Add(Convert.ToDouble(node.SelectNodes("geometry/location")[0].FirstChild.FirstChild.Value));
                longitudeList.Add(Convert.ToDouble(node.SelectNodes("geometry/location")[0].LastChild.LastChild.Value));
            }
            if (node.SelectNodes("vicinity")[0].Name == "vicinity")
            {
                vicinityList.Add(node.SelectNodes("vicinity")[0].FirstChild.Value);
            }
            if (node.FirstChild.Name == "name")
            {
                nameList.Add(node.FirstChild.FirstChild.Value);
            }
            index++;
        }
        string message = generateMessage(latitudeList, longitudeList, nameList, vicinityList, 1, latitude, longitude);
        return message;
    }

    public double getDistance(double lat_a, double lng_a, double lat_b, double lng_b)
    {
        double EARTH_RADIUS = 6378137.0;
        double radLat1 = (lat_a * Math.PI / 180.0);
        double radLat2 = (lat_b * Math.PI / 180.0);
        double a = Math.Abs(radLat1 - radLat2);
        double b = Math.Abs((lng_a - lng_b) * Math.PI / 180.0);
        double s = 2 * Math.Asin(Math.Sqrt(Math.Pow(Math.Sin(a / 2), 2)
               + Math.Cos(radLat1) * Math.Cos(radLat2)
               * Math.Pow(Math.Sin(b / 2), 2)));
        s = s * EARTH_RADIUS;
        s = Math.Round(s, 2);
        return s;
    }

    public int getNearestStore(ArrayList StoreLatitude, ArrayList StoreLongitude, double Latitude, double Longitude, int length)
    {
        double min = getDistance(Convert.ToDouble(StoreLatitude[0]), Convert.ToDouble(StoreLongitude[0]), Latitude, Longitude);
        int index = 0;
        for (int i = 1; i < length; i++)
        {
            double distance = getDistance(Convert.ToDouble(StoreLatitude[i]), Convert.ToDouble(StoreLongitude[i]), Latitude, Longitude);
            if (distance < min)
            {
                min = distance;
                index = i;
            }
        }
        return index;
    }

    public string generateMessage(ArrayList latitudeList, ArrayList longitudeList, ArrayList nameList, ArrayList vicinityList, int index,
        double latitude, double longitude)
    {
        string message = "";
        int minIndex = getNearestStore(latitudeList, longitudeList, latitude, longitude, latitudeList.Count);
        double distance = getDistance(Convert.ToDouble(latitudeList[minIndex]), Convert.ToDouble(longitudeList[minIndex]), latitude, longitude);
        if (distance / 1000 > 20)
        {
            message = "no stores within 20 miles.";
        }
        else
        {
            message = "The nearest " + nameList[minIndex] + ": Address is " + vicinityList[minIndex] +
            ". The distance is " + distance / 1000 + " Miles\n";
            latitudeList.Remove(latitudeList[minIndex]);
            longitudeList.Remove(longitudeList[minIndex]);
            nameList.Remove(nameList[minIndex]);
            vicinityList.Remove(vicinityList[minIndex]);
        }
        return message;
    }

    //Required Services: 
    //8. WsHashOperations
    public List<Dictionary> WsHashOperations(string wsdlUrl)
    {
        //initialize
        string name = "";
        string input = "";
        string output = "";
        List<Dictionary> wsdlList = new List<Dictionary>();
        Dictionary dic = new Dictionary();

        UriBuilder uriBuilder = new UriBuilder(wsdlUrl);
        uriBuilder.Query = "WSDL";
        HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(uriBuilder.Uri);
        webRequest.ContentType = "text/xml;charset=\"utf-8\"";
        webRequest.Method = "GET";
        webRequest.Accept = "text/xml";


        ServiceDescription serviceDescription;
        using (WebResponse response = webRequest.GetResponse())
        {
            using (Stream stream = response.GetResponseStream())
            {
                serviceDescription = ServiceDescription.Read(stream);
            }
        }

        foreach (PortType portType in serviceDescription.PortTypes)
        {
            foreach (Operation operation in portType.Operations)
            {
                name = operation.Name.ToString();
                foreach (var message in operation.Messages)
                {
                    if (message is OperationInput)
                        input = ((OperationInput)message).Message.Name.ToString();
                    if (message is OperationOutput)
                        output = ((OperationOutput)message).Message.Name.ToString();
                }
                dic.name = name;
                dic.input = input;
                dic.output = output;
                wsdlList.Add(dic);
            }
        }
        return wsdlList;
    }




    //Elected Services: (easy)
    //1. string compression
    //for example, aaaabbaaa --> a4b2a3

    public String compressString(String str)
    {
        if (str.Length <= 1)
        {
            return str;
        }
        StringBuilder sb = new StringBuilder();
        char prevChar = str[0];
        int counter = 0;
        char currChar;
        int length = str.Length;
        for (int i = 0; i < length; i++)
        {
            currChar = str[i];
            if (currChar == prevChar)
            {
                counter++;
                if (i == length - 1)
                {
                    sb.Append(currChar);
                    sb.Append(counter);
                }
                continue;
            }
            else
            {
                sb.Append(prevChar);
                sb.Append(counter);
                prevChar = currChar;
                counter = 1;
            }
            if (i == length - 1 && str[length - 2] != str[length - 1])
            {
                sb.Append(str[length - 1]);
                sb.Append(1);
            }
        }
        return sb.ToString();
    }

    //Elected Services: (easy)
    //2. string matching (Sunday matching)
    //for example, source is "I am writing the function to find the match.", target is "find", the result is 29, meaning we find the target from 29th char in source.
    //if source is "I am writing the function to find the match.", target is "finds", the result is -1, meaning we cannot find the target from source.

    public int stringMatching(string source, string target)
    {
        int i = 0;
        int j = 0;
        int p = 0;

        while (i <= source.Length - target.Length && j < target.Length)
        {
            if (source[p] == target[j])
            {
                p++;
                j++;
            }
            else
            {
                int k = target.Length;
                while (k > 0)
                {
                    k--;
                    if (target[k] == source[i + target.Length])
                        break;
                }
                i += target.Length - k;
                p = i;
                j = 0;
            }
        }
        if (j == target.Length)
        {
            return i;
        }
        return -1;
    }

    //Elected Services: (easy)
    //3. bidirection_string_convert_binary
    //for example,
    //input "abc" --> output is "string to binary: 011000010000000001100010000000000110001100000000"
    //input "011000010000000001100010000000000110001100000000" --> output is "binary to string: abc"

    public string bidirection_string_Convert_binary(string str)
    {
        int i;
        for (i = 0; i < str.Length; i++)
        {
            if (str[i].Equals('0') || str[i].Equals('1'))
            {
                continue;
            }
            else
            {
                break;
            }
        }
        if (i == str.Length)
        {
            System.Text.RegularExpressions.CaptureCollection cs = System.Text.RegularExpressions.Regex.Match(str, @"([01]{8})+").Groups[1].Captures;
            byte[] data = new byte[cs.Count];
            for (int j = 0; j < cs.Count; j++)
            {
                data[j] = Convert.ToByte(cs[j].Value, 2);
            }
            return "binary to string: " + Encoding.Unicode.GetString(data, 0, data.Length).ToString();
        }
        else
        {
            byte[] data = Encoding.Unicode.GetBytes(str);
            StringBuilder sb = new StringBuilder(data.Length * 8);
            foreach (byte b in data)
            {
                sb.Append(Convert.ToString(b, 2).PadLeft(8, '0'));

            }
            return "string to binary: " + sb.ToString();
        }
    }


    //Elected services: (moderate)  
    //4. use Levenshtein algorithm to calculate the similiary of two string
    // For example, input two string, you will get the such results:
    // Example 1: The similiary degree of alsdkfjklasjfl;akslkdfja;klsdj and alsdkfjklasjfl;akslkdfja;ksldj is 93.00%
    // Example 2: The similiary degree of abcdefg and acefg is 71.00%
    // Example 3: The similiary degree of asdjfaosjdo;fijas;ngjjkldfbg and iewruiopqehtgbdcmvnx,mcbn.x is 7.00%

    public string CalulateSimiliarty(string str1, string str2)
    {
        int value = Levenshtein_Distance(str1, str2);
        decimal similarityPerc = 1 - (decimal)value / Math.Max(str1.Length, str2.Length);
        decimal percentage = Math.Round(similarityPerc, 2) * 100;
        string message = "The similiary degree of " + str1 + " and " + str2 + " is " + percentage + "%";
        return message;
    }

    //get the smallest number
    public int CalulateSmallest(int first, int second, int third)
    {
        int min = Math.Min(first, second);
        return Math.Min(min, third);
    }

    // use Levenshtein algorithm to create the matrix
    public int Levenshtein_Distance(string str1, string str2)
    {
        int[,] Matrix;
        int n = str1.Length;
        int m = str2.Length;

        int temp = 0;
        char ch1;
        char ch2;
        int i = 0;
        int j = 0;
        if (n == 0)
        {
            return m;
        }
        if (m == 0)
        {
            return n;
        }
        Matrix = new int[n + 1, m + 1];

        for (i = 0; i <= n; i++)
        {
            Matrix[i, 0] = i;
        }

        for (j = 0; j <= m; j++)
        {
            Matrix[0, j] = j;
        }

        for (i = 1; i <= n; i++)
        {
            ch1 = str1[i - 1];
            for (j = 1; j <= m; j++)
            {
                ch2 = str2[j - 1];
                if (ch1.Equals(ch2))
                {
                    temp = 0;
                }
                else
                {
                    temp = 1;
                }
                Matrix[i, j] = CalulateSmallest(Matrix[i - 1, j] + 1, Matrix[i, j - 1] + 1, Matrix[i - 1, j - 1] + temp);
            }
        }

        for (i = 0; i <= n; i++)
        {
            for (j = 0; j <= m; j++)
            {
                Console.Write(" {0} ", Matrix[i, j]);
            }
            Console.WriteLine("");
        }
        return Matrix[n, m];
    }

}
