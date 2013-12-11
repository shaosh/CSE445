<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true"
    CodeFile="JuniorService.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html id="Html1" xmlns="http://www.w3.org/1999/xhtml" runat="server">
    <head id="Head1" runat="server">
        <title>Junior Service Page</title>
        <link rel="stylesheet" type="text/css" href="/GUI/Styles/Service.css" />
    </head>
    <body>
        <div id="header" runat="server">            
            <h1>
                STRING PROCESSING PAGE
            </h1>
            <h2>598 Group 1</h2>
            <h2>Jie Guo, Yunlong Jiang, Shihuan Shao, Hao Yan</h2>
        </div>
        <form id="entity" runat="server">
            <label style="float: left;">Welcome,&nbsp</label>
            <asp:Label style="float: left;" id="id" runat="server"></asp:Label>
            <asp:Button runat="server" style="float: right;" ID="Button7" 
                Text="Clear Cookies" onclick="Button7_Click1" />
            <asp:Button runat="server" ID="logoutBtn" Text="Log Out" 
                style="float: right; margin-right: 30px;" onclick="logoutBtn_Click" />
            <asp:Button runat="server" ID="returnBtn" Text="Return" 
                style="float: right; margin-right: 30px;" onclick="returnBtn_Click" />    
            <br />
            <h2>
                Junior String Process Service
            </h2>
            <div id="es1" class="servicediv" style="padding-left: 20px; padding-bottom: 20px; margin-top: 10px;">
                <p>Elective Service 1: AllCombination</p> 
                <p>string[] allCombination(string input): List all the combination of the char in the string(repeated char only count once).</p>
                <p><a href="http://10.0.2.137/AllCombination/Service.svc">http://10.0.2.137/AllCombination/Service.svc</a></p>
                <p><a href="http://10.0.2.137/AllCombination/Service.svc?wsdl">http://10.0.2.137/AllCombination/Service.svc?wsdl</a></p>
                <p>
                    <label>string:&nbsp</label>
                    <asp:TextBox ID="es1str" Width="750px" runat="server" />    
                    <asp:Button ID="Button3" Text="submit" OnClick="TestElectiveService1" runat="server" />                    
                </p>
                <p>
                    <label>Result: &nbsp</label><br />
                    <asp:TextBox ID="es1result" Width="750px" Height="100px" runat="server" ReadOnly="true" TextMode="MultiLine" style="margin-top: 10px"/>
                </p>
            </div>

            <div id="es2" class="servicediv" style="padding-left: 20px; padding-bottom: 20px; margin-top: 10px;">
                <p>Elective Service 2: FindLongestPalindrome</p> 
                <p>int palindrome(string str): Find the length of the longest palindrome sequence in given string.</p>
                <p><a href="http://10.0.2.137/Palindrome/Service.svc">http://10.0.2.137/Palindrome/Service.svc</a></p>
                <p><a href="http://10.0.2.137/Palindrome/Service.svc?wsdl">http://10.0.2.137/Palindrome/Service.svc?wsdl</a></p>
                <p>
                    <label>string:&nbsp</label>
                    <asp:TextBox ID="es2str" Width="300px" runat="server" />    
                    <asp:Button ID="Button4" Text="submit" OnClick="TestElectiveService2" runat="server" />                    
                    <label style="margin-left: 50px">Result: &nbsp</label>
                    <asp:TextBox ID="es2result" Width="50px" runat="server" ReadOnly="true" />
                </p>
            </div>

            <div id="es3" class="servicediv" style="padding-left: 20px; padding-bottom: 20px; margin-top: 10px;">
                <p>Elective Service 3: DeleteChar</p> 
                <p>string delete(string str1, string str2): Delete chars of str2 in str1 and shift the remaining chars correspondingly.</p>
                <p><a href="http://10.0.2.137/DeleteChar/Service.svc">http://10.0.2.137/DeleteChar/Service.svc</a></p>
                <p><a href="http://10.0.2.137/DeleteChar/Service.svc?wsdl">http://10.0.2.137/DeleteChar/Service.svc?wsdl</a></p>
                <p>
                    <label>string1:&nbsp</label>
                    <asp:TextBox ID="es3str1" Width="300px" runat="server" /> 
                    <label style="margin-left: 50px">string2:&nbsp</label>
                    <asp:TextBox ID="es3str2" Width="300px" runat="server" />       
                    <asp:Button ID="Button5" Text="submit" OnClick="TestElectiveService3" runat="server" /><br />                    
                    <label>Result: &nbsp</label>
                    <asp:TextBox ID="es3result" Width="300px" runat="server" ReadOnly="true" />
                </p>
            </div>

            <div id="es4" class="servicediv" style="padding-left: 20px; padding-bottom: 20px; margin-top: 10px;">
                <p>Elective Service 4: MergeSort</p> 
                <p>string mergeSorting(string chars): Sort the chars using merge sort.</p>
                <p><a href="http://10.0.2.137/MergeSorting/Service.svc">http://10.0.2.137/MergeSorting/Service.svc</a></p>
                <p><a href="http://10.0.2.137/MergeSorting/Service.svc?wsdl">http://10.0.2.137/MergeSorting/Service.svc?wsdl</a></p>
                <p>
                    <label>input (only alphabets allowed):&nbsp</label>
                    <asp:TextBox ID="es4str" Width="750px" runat="server" />    
                    <asp:Button ID="Button6" Text="submit" OnClick="TestElectiveService4" runat="server" /><br />                  
                    <label>Result: &nbsp</label>
                    <asp:TextBox ID="es4result" Width="750px" runat="server" ReadOnly="true" />
                </p>
            </div>
        </form>    
    </body>
</html>
