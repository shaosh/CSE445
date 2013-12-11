using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.

public class Dictionary
{
    public string name;
    public string input;
    public string output;
}
[ServiceContract]
public interface IService
{
    

	[OperationContract]
	string GetData(int value);

    [OperationContract]
    string findNearestStore(string zipcode, string storeName);

    [OperationContract]
    double getDistance(double lat_a, double lng_a, double lat_b, double lng_b);

    [OperationContract]
    List<Dictionary> WsHashOperations(string wsdlUrl);

    [OperationContract]
    String compressString(String str);

    [OperationContract]
    int stringMatching(string source, string target);

    [OperationContract]
    string bidirection_string_Convert_binary(string str);

    [OperationContract]
    string CalulateSimiliarty(string str1, string str2);

	CompositeType GetDataUsingDataContract(CompositeType composite);

	// TODO: Add your service operations here
}

// Use a data contract as illustrated in the sample below to add composite types to service operations.
[DataContract]
public class CompositeType
{
	bool boolValue = true;
	string stringValue = "Hello ";

	[DataMember]
	public bool BoolValue
	{
		get { return boolValue; }
		set { boolValue = value; }
	}

	[DataMember]
	public string StringValue
	{
		get { return stringValue; }
		set { stringValue = value; }
	}
}
