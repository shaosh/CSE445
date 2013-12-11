<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        String Process Service by Shihuan Shao
    </h2>
    <div id="rs1" style="border: 1px dashed grey; padding-left: 20px; padding-bottom: 20px; margin-top: 10px;">
        <p>Required Service 1: Top10Words</p> 
        <p>string[] Top10Words(string url): Analyze the webpage at a given url and return the ten most-frequently occurred words</p>
        <p>
            <label>url:&nbsp</label>
            <asp:TextBox ID="rs1str" Width="750px" runat="server" Text="http://" />
            <asp:Button ID="Button1" Text="submit" OnClick="TestRequiredService1" runat="server" />
        </p>
        <p>
            <label>Result: &nbsp</label>
            <asp:TextBox ID="rs1result" Width="750px" runat="server" ReadOnly="true"/>
        </p>
    </div>

    <div id="rs2" style="border: 1px dashed grey; padding-left: 20px; padding-bottom: 20px; margin-top: 10px;">
        <p>Required Service 2: WordFilter</p> 
        <p>string WordFilter(string str): Analyze a string of words, filter out the stop words, and return a string with those words removed.</p>
        <p>
            <label>string:&nbsp</label>
            <asp:Button Text="submit" ID="Button2" OnClick="TestRequiredService2" runat="server" /><br />
            <asp:TextBox ID="rs2str" Width="750px" Height="100px" runat="server" TextMode="MultiLine" style="margin-top: 10px"/>            
        </p>
        <p>
            <label>Result: &nbsp</label><br />
            <asp:TextBox ID="rs2result" Width="750px" Height="100px" runat="server" ReadOnly="true" TextMode="MultiLine" style="margin-top: 10px"/>
        </p>
    </div>

    <div id="es1" style="border: 1px dashed grey; padding-left: 20px; padding-bottom: 20px; margin-top: 10px;">
        <p>Elective Service 1: AllCombination</p> 
        <p>string[] allCombination(string input): List all the combination of the char in the string(repeated char only count once).</p>
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

    <div id="es2" style="border: 1px dashed grey; padding-left: 20px; padding-bottom: 20px; margin-top: 10px;">
        <p>Elective Service 2: FindLongestPalindrome</p> 
        <p>int palindrome(string str): Find the length of the longest palindrome sequence in given string.</p>
        <p>
            <label>string:&nbsp</label>
            <asp:TextBox ID="es2str" Width="300px" runat="server" />    
            <asp:Button ID="Button4" Text="submit" OnClick="TestElectiveService2" runat="server" />                    
            <label style="margin-left: 50px">Result: &nbsp</label>
            <asp:TextBox ID="es2result" Width="50px" runat="server" ReadOnly="true" />
        </p>
    </div>

    <div id="es3" style="border: 1px dashed grey; padding-left: 20px; padding-bottom: 20px; margin-top: 10px;">
        <p>Elective Service 3: DeleteChar</p> 
        <p>string delete(string str1, string str2): Delete chars of str2 in str1 and shift the remaining chars correspondingly.</p>
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

    <div id="es4" style="border: 1px dashed grey; padding-left: 20px; padding-bottom: 20px; margin-top: 10px;">
        <p>Elective Service 4: MergeSort</p> 
        <p>string mergeSorting(string chars): Sort the chars using merge sort.</p>
        <p>
            <label>input (only alphabets allowed):&nbsp</label>
            <asp:TextBox ID="es4str" Width="750px" runat="server" />    
            <asp:Button ID="Button6" Text="submit" OnClick="TestElectiveService4" runat="server" /><br />                  
            <label>Result: &nbsp</label>
            <asp:TextBox ID="es4result" Width="750px" runat="server" ReadOnly="true" />
        </p>
    </div>
</asp:Content>
