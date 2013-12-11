using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.IO;

using System.Collections;
// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    private static Boolean anyError = false;
    private static string errorMessage;
    public string verification(string xmlUri, string xsdUri)
    {
        errorMessage = "";
        XmlSchemaSet schemaSet = new XmlSchemaSet();
        schemaSet.Add(null, xsdUri);
        XmlReaderSettings readerSetting = new XmlReaderSettings();
        readerSetting.ValidationType = ValidationType.Schema;
        readerSetting.Schemas = schemaSet;
        readerSetting.ValidationEventHandler += new ValidationEventHandler(validationCallBack);
        XmlReader reader = XmlReader.Create(xmlUri, readerSetting);
        anyError = false;
        while (reader.Read()) ;
        if (anyError == false)
        {
            return ("No error");
        }
        return errorMessage;
    }

    private static void validationCallBack(object sender, ValidationEventArgs e)
    {
        anyError = true;
        errorMessage += "Validation Error: " + e.Message + "\n";
    }

    public string searchWsdl(string wsdlUrl)
    {
        ArrayList operationList = new ArrayList();
        string operationNames = "";
        string name;
        XmlDocument doc = new XmlDocument();
        doc.Load(wsdlUrl);
        XmlNodeList nodeList = doc.GetElementsByTagName("wsdl:operation");
        for (int i = 0; i < nodeList.Count; i++)
        {
            name = nodeList.Item(i).Attributes.GetNamedItem("name").Value;
            if (!operationList.Contains(name))
            {
                operationList.Add(name);
                operationNames += name + "\n";
            }
        }
        return operationNames;
    }
}
