using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Text.RegularExpressions;
using System.Web.Services.Description;
using System.Xml;
using System.Xml.Schema;
using System.IO;
using System.Net;

public class Service : IService
{
    // Required
    // Author - Hao Yan, ASU ID: 1205007670
    public string[] WsdlAddress(string URL)
    {

        WebToString.Service web2stringService = new WebToString.Service();
        string str = web2stringService.GetWebContent(URL);
        Regex pattern1 = new Regex("[\n\r\t\v]+");
        str = pattern1.Replace(str, "");
        Regex pattern2 = new Regex("[ ]+");
        str = pattern2.Replace(str, " ");
        string[] _strS = str.Split(' ');
        Regex pattern = new Regex(@"http://[^\f\n\r\t\v]+[.?][wW][sS][dD][lL][^\<]");
        List<string> wsdlAddress = new List<string>();
        string[] _wsdlAddress;

        foreach (string _str in _strS)
        {
            Match match = pattern.Match(_str);
            if (match.Value != "")
                wsdlAddress.Add(match.Value);
        }

        _wsdlAddress = wsdlAddress.ToArray();
        return _wsdlAddress;
    }

    // Required
    // Author - Hao Yan, ASU ID: 1205007670
    public string[] WsOperations(string url)
    {
        UriBuilder uriBuilder = new UriBuilder(url);
        uriBuilder.Query = "wsdl";
        HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(uriBuilder.Uri);
        webRequest.ContentType = "text/xml;charset=\"utf-8\"";
        webRequest.Method = "GET";
        webRequest.Accept = "text/xml";
        ServiceDescription wsdl;
        using (WebResponse response = webRequest.GetResponse())
        {
            using (Stream stream = response.GetResponseStream())
            {
                wsdl = ServiceDescription.Read(stream);
            }
        }
        List<string> operationInfo = new List<string>();
        List<string> name = new List<string>();
        List<string> returnType = new List<string>();
        List<string> inputType = new List<string>();
        List<string> _inputType = new List<string>();
        Int32[] inputCount = new Int32[100];
        Int32 index = 0;
        bool input_Type = false;
        bool output_Type = false;
        PortType portType = wsdl.PortTypes[0];
        foreach (Operation operation in portType.Operations)
            name.Add(operation.Name);
        Types types = wsdl.Types;
        XmlSchema xmlSchema = types.Schemas[0];
        foreach (object item in xmlSchema.Items)
        {
            XmlSchemaElement schemaElement = item as XmlSchemaElement;
            XmlSchemaComplexType schemaComplexType = item as XmlSchemaComplexType;

            if (schemaElement != null)
            {
                string str = schemaElement.Name;
                XmlSchemaType type = schemaElement.SchemaType;
                XmlSchemaComplexType complexType = type as XmlSchemaComplexType;
                if (str != name[index] + "Response")
                {
                    index = name.FindIndex(delegate(string _str) { return _str == str; });

                    if (complexType != null)
                    {
                        XmlSchemaParticle particle = complexType.Particle;
                        XmlSchemaSequence sequence = particle as XmlSchemaSequence;
                        if (sequence != null)
                        {
                            foreach (XmlSchemaElement childElement in sequence.Items)
                            {
                                if (index != -1)
                                {
                                    inputType.Add(childElement.SchemaTypeName.Name);
                                    inputCount[index]++;
                                    input_Type = true;
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (complexType != null)
                    {
                        XmlSchemaParticle particle = complexType.Particle;
                        XmlSchemaSequence sequence = particle as XmlSchemaSequence;
                        if (sequence != null)
                        {
                            foreach (XmlSchemaElement childElement in sequence.Items)
                            {
                                if (index != -1)
                                {
                                    returnType.Add(childElement.SchemaTypeName.Name);
                                    output_Type = true;
                                }
                            }
                        }
                    }
                }
            }
        }
        for (int i = 0, j = 0; i < inputType.Count && j < inputCount.Length; i += inputCount[j], j++)
        {
            string s = null;
            for (int m = 0; m < inputCount[j]; m++)
            {
                s = s + inputType[i + m] + ", ";
            }
            _inputType.Add(s);
        }
        for (int j = 0; j < name.Count; j++)
        {
            if (input_Type && output_Type)
                operationInfo.Add("Operation Name: " + name[j] + ", " + "Input Type: " + _inputType[j] + "Return Type: " + returnType[j]);
            else if (input_Type)
                operationInfo.Add("Operation Name: " + name[j] + ", " + "Input Type: " + _inputType[j]);
            else if (output_Type)
                operationInfo.Add("Operation Name: " + name[j] + ", " + "Return Type: " + returnType[j]);
            else
                operationInfo.Add("Operation Name: " + name[j]);
        }
        string[] list = operationInfo.ToArray();
        return list;
    }

    //  Elective - Easy
    //  Author - Hao Yan, ASU ID: 1205007670
    //  The function checks whether a string is the rotation of another one.
    //  For example, 'waterbottle' is the rotation of 'bottlewater'.
    public bool checkRotation(string s1, string s2)
    {
        if (s1.Length == s2.Length && s1.Length > 0)
        {
            string s2s2 = s2 + s2;
            bool state = isSubstring(s1, s2s2);
            return state;
        }
        return false;
    }

    public bool isSubstring(string s1, string s2)
    {
        if (s1.Length > s2.Length)
            return false;
        int i = 0;
        for (int j = 0; j < s2.Length; j++)
        {
            if (s1[0] == s2[j])
            {
                if (s2.Length - j - 1 >= s1.Length)
                {
                    for (i = 1; i < s1.Length; i++)
                        if (s1[i] != s2[i + j])
                            break;
                    if (i == s1.Length)
                        return true;
                }
                else
                    return false;
            }
        }
        return false;
    }

    // Elective - Easy
    // Author - Hao Yan, ASU ID: 1205007670
    // The function checks whether the string has unique characters.
    public bool checkUnique(string str)
    {
        if (str.Length > 256)
            return false;
        char[] arr = str.ToCharArray();
        Boolean[] char_set = new Boolean[256];
        for (int i = 0; i < str.Length; i++)
        {
            int val = arr[i] - 'a';
            if (char_set[val])
            {
                return false;
            }
            char_set[val] = true;
        }
        return true;
    }

    // Elective - Easy
    // Author - Hao Yan, ASU ID: 1205007670
    // The function replaces all space with '%SPACE%'.
    public string replaceSpace(string str)
    {
        int spaceCount = 0;
        int length = str.Length;
        int newLength;
        int i = 0;
        char[] s = str.ToCharArray();
        for (i = 0; i < length; i++)
        {
            if (s[i] == ' ')
                spaceCount++;
        }
        newLength = length + spaceCount * 6;
        char[] _s = new char[newLength];
        for (i = length - 1; i >= 0; i--)
        {
            if (s[i] == ' ')
            {
                _s[newLength - 1] = '%';
                _s[newLength - 2] = 'E';
                _s[newLength - 3] = 'C';
                _s[newLength - 4] = 'A';
                _s[newLength - 5] = 'P';
                _s[newLength - 6] = 'S';
                _s[newLength - 7] = '%';
                newLength = newLength - 7;
            }
            else
            {
                _s[newLength - 1] = s[i];
                newLength = newLength - 1;
            }
        }
        string _str = new string(_s);
        return _str;
    }

    // Elective - Moderate
    // Author - Hao Yan, ASU ID: 1205007670
    // The function applies dynamic programming algorithm to find the largest common substring between two strings.
    public string largestCommonSubstring(string str1, string str2)
    {
        int maxLength = 0;
        if (str1 == str2)
            maxLength = str1.Length;
        int[] maxtix = new int[str1.Length];
        int startNum = 0;
        int str1Num = str1.Length;
        int str2Num = str2.Length;
        if ((String.IsNullOrEmpty(str1)) || (String.IsNullOrEmpty(str2)))
        {
            maxLength = 0;
        }
        for (int i = 0; i < str2Num; i++)
        {
            for (int j = str1Num - 1; j >= 0; j = j - 1)
            {
                if (str2[i] == str1[j])
                {
                    if ((i == 0) || (j == 0))
                    {
                        maxtix[j] = 1;
                    }
                    else
                    {
                        maxtix[j] = maxtix[j - 1] + 1;
                    }
                }
                else
                {
                    maxtix[j] = 0;
                }
                if (maxtix[j] > maxLength)
                {
                    maxLength = maxtix[j];
                    startNum = j;
                }
            }
        }
        int start, end;
        start = startNum - maxLength + 1;
        end = startNum;
        char[] lcs = new char[maxLength];
        for (int i = start, j = 0; i <= end; i++, j++)
        {
            lcs[j] = str1[i];
        }
        string s = new string(lcs);
        if (s == "")
            s = "Sorry, there is no common substring.";
        else
            s = "The largest common substring is: '" + s + "', and its lenght is: " + maxLength + ".";
        return s;
    }
}
