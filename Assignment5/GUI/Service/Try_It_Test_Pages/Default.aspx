<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Try_It_Test_Pages._Default" %>

<form id="form1" runat="server">
<p>
    1. Required Service: WsdlAddress</p>
<p>
    A. This service has one operation: find all wsdl addresses in a web page.</p>
<p>
    B. Server URL of the service: http://10.0.2.137/Hao_Yan_Services/Service.svc</p>
<p>
    C. Server URL of the WSDL file: 
    http://10.0.2.137/Hao_Yan_Services/Service.svc?wsdl</p>
<p>
    D. Method name, parameter type list and return type: string[] WsdlAddress(string 
    URL)</p>
<p>
    E-G. Enter the URL which you want to get the wsdl address(e.g. 
    http://www.actionscript.org/forums/showthread.php3?t=70742):</p>
<p>
    <asp:TextBox ID="TextBox1" runat="server" Width="434px"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="Call Service" />
</p>
<asp:Label ID="Result1" runat="server" Text="Label"></asp:Label>
<br />
<p>
    2. Required Service: WsOperations</p>
<p>
    A. This service has one operation: find operation name, input parameter and 
    return types.</p>
<p>
    B. Server URL of the service: http://10.0.2.137/Hao_Yan_Services/Service.svc</p>
<p>
    C. Server URL of the WSDL file: 
    http://10.0.2.137/Hao_Yan_Services/Service.svc?wsdl</p>
<p>
    D. Method name, parameter type list and return type: string[] 
    WsOperations(string url)</p>
<p>
    E-G Please enter a WSDL file(e.g. 
    http://www.webservicex.net/ConvertAcceleration.asmx?WSDL).</p>
<asp:TextBox ID="TextBox2" runat="server" Width="425px"></asp:TextBox>
<br />
<asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
    Text="Call Service" />
<br />
<br />
<asp:Label ID="Result2" runat="server" Text="Label"></asp:Label>
<br />
<br />
<br />
3. Elective Service: CheckRotation - Easy<p>
    A. This service has one operation: check if a string is a rotation of another 
    one.</p>
<p>
    B. Server URL of the service: http://10.0.2.137/Hao_Yan_Services/Service.svc</p>
<p>
    C. Server URL of the WSDL file: 
    http://10.0.2.137/Hao_Yan_Services/Service.svc?wsdl</p>
<p>
    D. Method name, parameter type list and return type: bool checkRotation(string 
    s1, string s2)</p>
<p>
    E-G. Please enter a string(e.g. &#39;waterbottle&#39;, &#39;bottlewater&#39;):</p>
<p>
    String A:
    <asp:TextBox ID="TextBox3" runat="server" Width="454px"></asp:TextBox>
</p>
<p>
    String B:
    <asp:TextBox ID="TextBox4" runat="server" Width="453px"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
        Text="Call Service" />
</p>
<p>
    <asp:Label ID="Result3" runat="server" Text="Label"></asp:Label>
</p>
<p>
    &nbsp;</p>
<p>
    4. Elective Service: CheckUnique - Easy</p>
<p>
    A. This service has one operation: check if a string has unique characters.</p>
<p>
    B. Server URL of the service: http://10.0.2.137/Hao_Yan_Services/Service.svc</p>
<p>
    C. Server URL of the WSDL file: 
    http://10.0.2.137/Hao_Yan_Services/Service.svc?wsdl</p>
<p>
    D. Method name, parameter type list and return type: bool checkUnique(string s)</p>
<p>
    E-G. Please enter a string to check(e.g. &#39;abcdeefgou&#39;):</p>
<p>
    <asp:TextBox ID="TextBox5" runat="server" Width="356px"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button4" runat="server" onclick="Button4_Click" 
        Text="Call Service" />
</p>
<p>
    <asp:Label ID="Result4" runat="server" Text="Label"></asp:Label>
</p>
<p>
    &nbsp;</p>
<p>
    5. Elective Service: ReplaceSpace - Easyy</p>
<p>
    A. This service has one operation: replace all spaces with &#39;%SPACE%&#39;.</p>
<p>
    B. Server URL of the service: http://10.0.2.137/Hao_Yan_Services/Service.svc</p>
<p>
    C. Server URL of the WSDL file: 
    http://10.0.2.137/Hao_Yan_Services/Service.svc?wsdl</p>
<p>
    D. Method name, parameter type list and return type: string replaceSpace(string 
    str)</p>
<p>
    E-G. Please enter your string(e.g. &#39;microsoft&nbsp; sucks&nbsp; all the time&#39;).</p>
<p>
    <asp:TextBox ID="TextBox6" runat="server" Width="361px"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button5" runat="server" onclick="Button5_Click" 
        Text="Call Service" />
</p>
<p>
    <asp:Label ID="Result5" runat="server" Text="Label"></asp:Label>
</p>
<p>
    &nbsp;</p>
<p>
    6. Elective Service - FindLargestCommonSubstring - Moderatee</p>
<p>
    A. This service has one operation: find largest common substring between two 
    strings.</p>
<p>
    B. Server URL of the service: http://10.0.2.137/Hao_Yan_Services/Service.svc</p>
<p>
    C. Server URL of the WSDL file: 
    http://10.0.2.137/Hao_Yan_Services/Service.svc?wsdl</p>
<p>
    D. Method name, parameter type list and return type: string 
    largestCommonSubstring(string str1, string str2)</p>
<p>
    E-G Please enter two strings to find their largest common substring(e.g. 
    &#39;abcdegh&#39;, &#39;poscdeglqw&#39;):.</p>
<p>
    String A:
    <asp:TextBox ID="TextBox7" runat="server" Width="302px"></asp:TextBox>
</p>
<p>
    String B:
    <asp:TextBox ID="TextBox8" runat="server" Width="300px"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Button6" runat="server" onclick="Button6_Click" 
        Text="Call Service" />
</p>
<p>
    <asp:Label ID="Result6" runat="server" Text="Label"></asp:Label>
</p>
</form>


