<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="Application._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2 style="padding-left: 10px;">
        XML service test page</h2>
    <p style="padding-left: 10px; padding-right: 10px;">
        Shihuan Shao 1203060451</p>
    <div style="padding-left: 10px;">
        <p>
            <b>Question 4.1: verification</b></p>
        <p>
            Takes the URL of an XML file and the URL of the corresponding XMLS file as 
            input, validates the XML file against the XMLS file. Returns “No Error” or an 
            error message.
        </p>
        
        <label>XML file URL: </label><br />
        <asp:TextBox ID="xmlurl" Width="900px" runat="server" style="margin-bottom: 10px; font-family: Arial;" /><br />
        <label>XMLS file URL: </label><br />
        <asp:TextBox ID="xsdurl" Width="900px" style="font-family: Arial;" runat="server" />
        <asp:Button ID="test1" Text="test" OnClick="TestService1" Width="100px" runat="server" style="margin-top: 10px; margin-bottom: 10px;" /><br />
        <label>Result:</label><br />
        <asp:TextBox ID="result1" Width="900px" Height="100px" runat="server" ReadOnly="true" TextMode="MultiLine" style="font-family: Arial;" />
    </div>

    <div style="padding-left: 10px;">
        <p>
            <b>Question 4.5: searchWsdl</b></p>
        <p>
            Takes the URL of a wsdl file, reads the WSDL file as an xml file and returns the 
            list of operation names in the wsdl file.
        </p>
        
        <label>WSDL file URL: </label><br />
        <asp:TextBox ID="wsdlurl" Width="900px" style="font-family: Arial;" runat="server" /><br />
        <asp:Button ID="test2" Text="test" OnClick="TestService2" Width="100px" runat="server" style="margin-top: 10px; margin-bottom: 10px;" /><br />
        <label>Result:</label><br />
        <asp:TextBox ID="result2" Width="900px" Height="100px" runat="server" ReadOnly="true" TextMode="MultiLine" style="margin-bottom: 10px; font-family: Arial;" />
    </div>
</asp:Content>
