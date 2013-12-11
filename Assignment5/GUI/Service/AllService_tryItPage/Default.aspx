<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AllService_tryItPage._Default" %>

<form id="form1" runat="server">
Required 1:<br />
<br />
(A) find the nearest store: (for example, input zip = 85281, store name = 
safeway)<br />
(B) Server URL of each service (.svc file) : 
http://10.0.2.137/allservices/Service.svc<br />
(C) Server URL of the WSDL file : 
http://10.0.2.137/allservices/Service.svc?wsdl<br />
(D) Method names, with parameter type list and the return type for each 
endpoint: string findNearestStore(string zipcode, string storeName)<br />
(E-G)<br />
zip code:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<p>
   store name:&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Search" />
</p>
<p>
    result:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server"></asp:Label>
</p>
<p>
    &nbsp;</p>
<p>
    Required2:</p>
<p>
    (A) WsHashOperations: (for example, input: 
    http://www.webservicex.net/CreditCard.asmx?WSDL )<br />
(B) Server URL of each service (.svc file) : 
    http://10.0.2.137/allservices/Service.svc<br />
(C) Server URL of the WSDL file : http://10.0.2.137/allservices/Service.svc?wsdl<br />
    (D) Method names, with parameter type list and the return type for each 
    endpoint: List<Dictionary> WsHashOperations(string wsdlUrl)<br />
    (E-G)</p>
wsdlURL:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
    style="height: 26px" Text="Press" />
<p id="p1">
    <asp:Label ID="Label2" runat="server"></asp:Label>
</p>
<p>
    &nbsp;</p>
<p>
    Elective 1: (Easy)</p>
<p>
    (A) String Compression: (for example, input: aaaaabbbccaa)<br />
(B) Server URL of each service (.svc file) : 
    http://10.0.2.137/allservices/Service.svc<br />
(C) Server URL of the WSDL file : http://10.0.2.137/allservices/Service.svc?wsdl<br />
    (D) Method names, with parameter type list and the return type for each 
    endpoint: String compressString(String str)<br />
    (E-G)</p>
<p>
    String:&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
        Text="Compress" />
    <br />
    <br />
    <asp:Label ID="Label3" runat="server"></asp:Label>
</p>
<p>
    &nbsp;</p>
<p>
    Elective 2: (Easy)</p>
<p>
    (A) String Matching: (for example, input: Source = I have a dream, Target = dre)<br />
(B) Server URL of each service (.svc file) : 
    http://10.0.2.137/allservices/Service.svc<br />
(C) Server URL of the WSDL file : http://10.0.2.137/allservices/Service.svc?wsdl<br />
    (D) Method names, with parameter type list and the return type for each 
    endpoint: int stringMatching(string source, string target)arget)<br />
    (E-G)</p>
<p>
    Source:&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Target:&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button4" runat="server" onclick="Button4_Click" 
        Text="Find Match" />
    <br />
    <br />
    <asp:Label ID="Label4" runat="server"></asp:Label>
</p>
<p>
    &nbsp;</p>
<p>
    Elective 3: (Easy)</p>
<p>(A) String/Binary to Binary/String: (for example, input 0111001100000000 
    or s)<br />
(B) Server URL of each service (.svc file) : 
    http://10.0.2.137/allservices/Service.svc<br />
(C) Server URL of the WSDL file : http://10.0.2.137/allservices/Service.svc?wsdl<br />
    (D) Method names, with parameter type list and the return type for each 
    endpoint: string bidirection_string_Convert_binary(string str)(string str)<br />
    (E-G)</p>
<p>
    String/Binary:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button5" runat="server" onclick="Button5_Click" 
        Text="Convert" />
</p>
<p>
    Binary/String:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label5" runat="server"></asp:Label>
</p>
<p>
    &nbsp;</p>
<p>
    Elective 4:</p(A) Calculate two Strings&#39; similiarity (for example, input aaaabb and abccaa)<br />&nbsp; 
    (Moderate)</p>
<p>
    (A) Calculate similiarty between two String: (for example, input aaabbcc and 
    abbddaas)<br />
(B) Server URL of each service (.svc file) : 
    http://10.0.2.137/allservices/Service.svc<br />
(C) Server URL of the WSDL file : http://10.0.2.137/allservices/Service.svc?wsdl<br />
    (D) Method names, with parameter type list and the return type for each 
    endpoint: string CalulateSimiliarty(string str1, string str2)string str2)<br />
    (E-G)</p>
<p>
    First String:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
</p>
<p>
    Second String:&nbsp;&nbsp;&nbsp;&nbsp; 
    <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button6" runat="server" onclick="Button6_Click" 
        Text="Calculate Similiarity" />
</p>
<asp:Label ID="Label6" runat="server"></asp:Label>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
</form>


