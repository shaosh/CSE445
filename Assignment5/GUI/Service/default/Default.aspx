<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to the StringToolkit of 598 Group 1!
    </h2>
    <table style="margin: 20px auto;" cellspacing="0">
        <tr style="background-color: #87ceeb">
            <th>Provider name</th>
            <th>Service name and deployed URL in server</th>
            <th>Service description</th>
            <th>Server link to test page</th>
            <th>Language and Platform</th>
        </tr>

        <%-- Jie Guo --%>
        <tr>
            <td>Jie Guo</td>
            <td><label><a href="http://10.0.2.137/DataMangement/Service1.svc" />register </label><br />
                <label><a href="http://10.0.2.137/DataMangement/Service1.svc" />V-Lab URL</label>
            </td>
            <td  style="text-align: left; padding-left: 10px">register the user(challenge)</td>
            <td><a href="http://10.0.2.137/WebSite1/" />Try it</td>
            <td>WCF svc</td>
        </tr>
        <tr>
            <td>Jie Guo</td>
            <td><label><a href="http://10.0.2.137/DataMangement/Service1.svc" />sign in</label><br />
                <label><a href="http://10.0.2.137/DataMangement/Service1.svc" />V-Lab URL</label>
            </td>
            <td  style="text-align: left; padding-left: 10px">sign in the user if the user name exist, it will fail(challenge)</td>
            <td><a href="http://10.0.2.137/WebSite1/" />Try it</td>
            <td>WCF svc</td>
        </tr>
        <tr>
            <td>Jie Guo</td>
            <td><label><a href="http://10.0.2.137/DataMangement/Service1.svc" />Save data</label><br />
                <label><a href="http://10.0.2.137/DataMangement/Service1.svc" />V-Lab URL</label>
            </td>
            <td  style="text-align: left; padding-left: 10px">if the user sign in it can save the data(challenge)</td>
            <td><a href="http://10.0.2.137/WebSite1/" />Try it</td>
            <td>WCF svc</td>
        </tr>
        <tr>
            <td>Jie Guo</td>
            <td><label><a href="http://10.0.2.137/DataMangement/Service1.svc" />read data</label><br />
                <label><a href="http://10.0.2.137/DataMangement/Service1.svc" />V-Lab URL</label>
            </td>
            <td  style="text-align: left; padding-left: 10px">if the user sign in it can read the data which you store in the last time(challenge)</td>
            <td><a href="http://10.0.2.137/WebSite1/" />Try it</td>
            <td>WCF svc</td>
        </tr>
        <tr>
            <td>Jie Guo</td>
            <td><label><a href="http://10.0.2.137/encoding/Service1.svc" />encoding </label><br />
                <label><a href="http://10.0.2.137/encoding/Service1.svc" />V-Lab URL</label>
            </td>
            <td  style="text-align: left; padding-left: 10px">encoding the string</td>
            <td><a href="http://10.0.2.137/WebSite1/" />Try it</td>
            <td>WCF svc</td>
        </tr>       
        <tr>
            <td>Jie Guo</td>
            <td><label><a href="http://10.0.2.137/decoding/Service1.svc" />decoding </label><br />
                <label><a href="http://10.0.2.137/decoding/Service1.svc" />V-Lab URL</label>
            </td>
            <td  style="text-align: left; padding-left: 10px">decoding string </td>
            <td><a href="http://10.0.2.137/WebSite1/" />Try it</td>
            <td>WCF svc</td>
        </tr>
          <tr>
            <td>Jie Guo</td>
            <td><label><a href="http://10.0.2.137/stemservice/Service1.svc" />require service 3</label><br />
                <label><a href="http://10.0.2.137/stemservice/Service1.svc" />V-Lab URL</label>
            </td>
            <td  style="text-align: left; padding-left: 10px">return the stem word</td>
            <td><a href="" />Try it</td>
            <td>WCF svc</td>
        </tr>
         <tr>
            <td>Jie Guo</td>
            <td><label><a href="http://10.0.2.137/weather(require13)/Service1.svc" />require service 13</label><br />
                <label><a href="http://10.0.2.137/weather(require13)/Service1.svc" />V-Lab URL</label>
            </td>
            <td  style="text-align: left; padding-left: 10px">wearther service</td>
            <td><a href="" />Try it</td>
            <td>WCF svc</td>
        </tr>

        <%-- Yunlong Jiang --%>
        <tr>
            <td>Yunlong Jiang</td>
            <td><label><a href="http://10.0.2.137/allservices/Service.asmx" />findNearestStore</label><br />
                <label><a href="http://10.0.2.137/allservices/Service.asmx" />V-Lab URL</label>
            </td>
            <td  style="text-align: left; padding-left: 10px">Find the nearest store, such as find safeway in zip 85281</td>
            <td><a href="http://10.0.2.137/allservice_tryitpage/" />Try it</td>
            <td>WCF svc</td>
        </tr>
        <tr>
            <td>Yunlong Jiang</td>
            <td><label><a href="http://10.0.2.137/allservices/Service.asmx" />WsHashOperations</label><br />
                <label><a href="http://10.0.2.137/allservices/Service.asmx" />V-Lab URL</label>
            </td>
            <td  style="text-align: left; padding-left: 10px">Analyze a WSDL file in XML format and return operation names and their corresponding input parameter types and return type in a Hashtable or a similar data structure</td>
            <td><a href="http://10.0.2.137/allservice_tryitpage/" />Try it</td>
            <td>WCF svc</td>
        </tr>
        <tr>
            <td>Yunlong Jiang</td>
            <td><label><a href="http://10.0.2.137/allservices/Service.asmx" />compressString</label><br />
                <label><a href="http://10.0.2.137/allservices/Service.asmx" />V-Lab URL</label>
            </td>
            <td  style="text-align: left; padding-left: 10px">string compression, such as aaaabbaaa --> a4b2a3</td>
            <td><a href="http://10.0.2.137/allservice_tryitpage/" />Try it</td>
            <td>WCF svc</td>
        </tr>
        <tr>
            <td>Yunlong Jiang</td>
            <td><label><a href="http://10.0.2.137/allservices/Service.asmx" />stringMatching</label><br />
                <label><a href="http://10.0.2.137/allservices/Service.asmx" />V-Lab URL</label>
            </td>
            <td  style="text-align: left; padding-left: 10px">string matching, find the target string index in source string</td>
            <td><a href="http://10.0.2.137/allservice_tryitpage/" />Try it</td>
            <td>WCF svc</td>
        </tr>
        <tr>
            <td>Yunlong Jiang</td>
            <td><label><a href="http://10.0.2.137/allservices/Service.asmx" />bidirection_string_Convert_binary</label><br />
                <label><a href="http://10.0.2.137/allservices/Service.asmx" />V-Lab URL</label>
            </td>
            <td  style="text-align: left; padding-left: 10px">binary to string or string to binary</td>
            <td><a href="http://10.0.2.137/allservice_tryitpage/" />Try it</td>
            <td>WCF svc</td>
        </tr>
        <tr>
            <td>Yunlong Jiang</td>
            <td><label><a href="http://10.0.2.137/allservices/Service.asmx" />CalulateSimiliarty</label><br />
                <label><a href="http://10.0.2.137/allservices/Service.asmx" />V-Lab URL</label>
            </td>
            <td  style="text-align: left; padding-left: 10px">Calculate the similiarty of two strings</td>
            <td><a href="http://10.0.2.137/allservice_tryitpage/" />Try it</td>
            <td>WCF svc</td>
        </tr>

        <%-- Shihuan Shao --%>
        <tr>
            <td>Shihuan Shao</td>
            <td><label><a href="http://10.0.2.137/Top10words/service.svc" />Top10Words</label><br />
                <label><a href="http://10.0.2.137/Top10words/service.svc" />V-Lab URL</label>
            </td>
            <td style="text-align: left; padding-left: 10px">Analyze the webpage at a given url and return the ten most-frequently occurred words.</td>
            <td><a href="http://10.0.2.137/Tryitpage/" />Try it</td>
            <td>WCF svc</td>
        </tr>
        <tr>
            <td>Shihuan Shao</td>
            <td><label><a href="http://10.0.2.137/WordFilter/service.svc" />WordFilter</label><br />
                <label><a href="http://10.0.2.137/WordFilter/service.svc" />V-Lab URL</label>
            </td>
            <td style="text-align: left; padding-left: 10px">Analyze a string of words, filter out the stop words, and return a string with those words removed.</td>
            <td><a href="http://10.0.2.137/Tryitpage/" />Try it</td>
            <td>WCF svc</td>
        </tr>
        <tr>
            <td>Shihuan Shao</td>
            <td><label><a href="http://10.0.2.137/AllCombination/service.svc" />AllCombination</label><br />
                <label><a href="http://10.0.2.137/AllCombination/service.svc" />V-Lab URL</label>
            </td>
            <td style="text-align: left; padding-left: 10px">List all the combination of the char in the string(repeated char only count once).</td>
            <td><a href="http://10.0.2.137/Tryitpage/" />Try it</td>
            <td>WCF svc</td>
        </tr>
        <tr>
            <td>Shihuan Shao</td>
            <td><label><a href="http://10.0.2.137/Palindrome/service.svc" />FindLongestPalindrome</label><br />
                <label><a href="http://10.0.2.137/Palindrome/service.svc" />V-Lab URL</label>
            </td>
            <td style="text-align: left; padding-left: 10px">Find the length of the longest palindrome sequence in given string.</td>
            <td><a href="http://10.0.2.137/Tryitpage/" />Try it</td>
            <td>WCF svc</td>
        </tr>
        <tr>
            <td>Shihuan Shao</td>
            <td><label><a href="http://10.0.2.137/DeleteChar/service.svc" />DeleteChar</label><br />
                <label><a href="http://10.0.2.137/DeleteChar/service.svc" />V-Lab URL</label>
            </td>
            <td style="text-align: left; padding-left: 10px">Delete chars of str2 in str1 and shift the remaining chars correspondingly.</td>
            <td><a href="http://10.0.2.137/Tryitpage/" />Try it</td>
            <td>WCF svc</td>
        </tr>
        <tr>
            <td>Shihuan Shao</td>
            <td><label><a href="http://10.0.2.137/MergeSorting/service.svc" />MergeSort</label><br />
                <label><a href="http://10.0.2.137/MergeSorting/service.svc" />V-Lab URL</label>
            </td>
            <td style="text-align: left; padding-left: 10px">Sort the chars using merge sort.</td>
            <td><a href="http://10.0.2.137/Tryitpage/" />Try it</td>
            <td>WCF svc</td>
        </tr>
        
        <%-- Hao Yan --%>
        <tr>
            <td>Hao Yan</td>
            <td><label><a href="http://10.0.2.137/Hao_Yan_Services/Service.asmx" />WsdlAddress</label><br />
                <label><a href="http://10.0.2.137/Hao_Yan_Services/Service.asmx" />V-Lab URL</label>
            </td>
            <td  style="text-align: left; padding-left: 10px">Find all WSDL addresses in a web page.</td>
            <td><a href="http://10.0.2.137/Try It Test Pages/" />Try it</td>
            <td>WCF svc</td>
        </tr>
        <tr>
            <td>Hao Yan</td>
            <td><label><a href="http://10.0.2.137/Hao_Yan_Services/Service.asmx" />WsOperations</label><br />
                <label><a href="http://10.0.2.137/Hao_Yan_Services/Service.asmx" />V-Lab URL</label>
            </td>
            <td  style="text-align: left; padding-left: 10px">Find all method names and their input parameter and return types.</td>
            <td><a href="http://10.0.2.137/Try It Test Pages/" />Try it</td>
            <td>WCF svc</td>
        </tr>
        <tr>
            <td>Hao Yan</td>
            <td><label><a href="http://10.0.2.137/Hao_Yan_Services/Service.asmx" />CheckRotation</label><br />
                <label><a href="http://10.0.2.137/Hao_Yan_Services/Service.asmx" />V-Lab URL</label>
            </td>
            <td  style="text-align: left; padding-left: 10px">Check whether a string is a rotation of another string.</td>
            <td><a href="http://10.0.2.137/Try It Test Pages/" />Try it</td>
            <td>WCF svc</td>
        </tr>
        <tr>
            <td>Hao Yan</td>
            <td><label><a href="http://10.0.2.137/Hao_Yan_Services/Service.asmx" />CheckUnique</label><br />
                <label><a href="http://10.0.2.137/Hao_Yan_Services/Service.asmx" />V-Lab URL</label>
            </td>
            <td  style="text-align: left; padding-left: 10px">Check whether a string has unique characters.</td>
            <td><a href="http://10.0.2.137/Try It Test Pages/" />Try it</td>
            <td>WCF svc</td>
        </tr>
        <tr>
            <td>Hao Yan</td>
            <td><label><a href="http://10.0.2.137/Hao_Yan_Services/Service.asmx" />ReplaceSpace</label><br />
                <label><a href="http://10.0.2.137/Hao_Yan_Services/Service.asmx" />V-Lab URL</label>
            </td>
            <td  style="text-align: left; padding-left: 10px">Replace all spaces with '%SPACE%'.</td>
            <td><a href="http://10.0.2.137/Try It Test Pages/" />Try it</td>
            <td>WCF svc</td>
        </tr>
        <tr>
            <td>Hao Yan</td>
            <td><label><a href="http://10.0.2.137/Hao_Yan_Services/Service.asmx" />FindLargestCommonSubstring</label><br />
                <label><a href="http://10.0.2.137/Hao_Yan_Services/Service.asmx" />V-Lab URL</label>
            </td>
            <td  style="text-align: left; padding-left: 10px">Find the largest common substring between two strings.</td>
            <td><a href="http://10.0.2.137/Try It Test Pages/" />Try it</td>
            <td>WCF svc</td>
        </tr>
    </table>
    <p><a href=""/>Required Document</p>
</asp:Content>
