using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

[ServiceContract]
public interface IService
{

    [OperationContract]
    string[] WsdlAddress(string URL);

    [OperationContract]
    string[] WsOperations(string url);

    [OperationContract]
    bool checkRotation(string s1, string s2);
    bool isSubstring(string s1, string s2);

    [OperationContract]
    bool checkUnique(string str);

    [OperationContract]
    string replaceSpace(string str);

    [OperationContract]
    string largestCommonSubstring(string str1, string str2);
}
