<%@ Page Language="C#"  AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Register TagPrefix="gui" TagName="stat" Src="~/Stat.ascx" %>
<%@ Register TagPrefix="gui" TagName="ip" Src="~/Ip.ascx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" runat="server">
    <head runat="server">
        <title>598 Group 1 Page</title>
        <link rel="stylesheet" type="text/css" href="Styles/Site.css" />
    </head>
    <body>
        <form id="form1" runat="server">
        
        <div id="header" runat="server">
            <h1>
                STRING PROCESSING PAGE
            </h1>
            <h2>598 Group 1</h2>
            <h2>Jie Guo, Yunlong Jiang, Shihuan Shao, Hao Yan</h2>
        </div>
        <div id="entity" runat="server" style="font-family: Cambria;">
            <h2 style="font-family: Cambria; float: left;">Welcome to String Processing Page!</h2>
            <asp:Button runat="server" Text="Log Out" style="float: right;" 
                onclick="Unnamed3_Click"/><br /><br />
            <hr size=4 color="black" style="float: left;"><br />
            <div id="links" runat="server">
                <label class="page" runat="server"><a href="/GUI/ProtectedJuniorService/JuniorService.aspx" runat="server">Junior String Processing Service</a></label>
                <label class="page" runat="server"><a href="/GUI/ProtectedSeniorService/SeniorService.aspx" runat="server">Senior String Processing Service</a></label>
            </div>
            <br />
            <div runat="server" style="font-family: Cambria;">
                <p>Dll:&nbsp
                    <label runat="server" style="margin: 0 20px;"><a href="C2F.aspx" runat="server">Jie Dll</a></label>
                    <label runat="server" style="margin: 0 20px;"><a href="dollar2RMB.aspx" runat="server">Hao Dll</a></label>
                    <label runat="server" style="margin: 0 20px;"><a href="Km2mile.aspx" runat="server">Shao Dll</a></label>
                    <label runat="server" style="margin: 0 20px;"><a href="Kg2pound.aspx" runat="server">Jiang Dll</a></label>
                </p>
            </div>
            <br />
            <div id="statdiv" runat="server">
                <asp:Label ID="Label3" runat="server" Text="Cookie value: " class="label"></asp:Label>
                <asp:Label ID="Label1" runat="server" Text="Guest" class="label"></asp:Label>

                <br /><br />
                <asp:Label ID="Label2" runat="server" Text="Password" class="label"></asp:Label>
                <gui:stat runat="server" />
            </div>
            <div id="ipdiv" runat="server" style="">
                <gui:ip runat="server" />
            </div>
            <div id="totaldiv" runat ="server">
                <label>Total visits:&nbsp</label>
                <asp:Label runat="server" ID="totalLabel"></asp:Label>
            </div>
            <br />
            <div id="currentdiv" runat ="server">
                <label>Current users:&nbsp</label>
                <asp:Label runat="server" ID="currentLabel"></asp:Label>
            </div>
        </div> 
        
           
        </form>

    </body>
</html>
