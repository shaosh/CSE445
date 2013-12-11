<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Register.ascx.cs" Inherits="Register" %>

<table id="registerTable" runat="server" style="margin: auto; margin-top: 80px; border: 1px black solid; background: #A9BCF5;" cellspacing="40">
    <tr>
        <td>
            <label id="Label1" runat="server" style="font-family: Cambria;">User Name</label>
        </td>
        <td>
            <asp:TextBox ID="Username" runat="server" Width="200px" style="font-family: Cambria;"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <label id="Label2" runat="server" width="100px" style="font-family: Cambria;">Password</label>
        </td>
        <td>
            <asp:TextBox ID="Password" runat="server" Width="200px" TextMode="Password" style="font-family: Cambria;"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <label id="Label3" runat="server" width="100px" style="font-family: Cambria;">Confirm Password</label>
        </td>
        <td>
            <asp:TextBox ID="Confirm" runat="server" Width="200px" TextMode="Password" style="font-family: Cambria;"></asp:TextBox>
        </td>
    </tr>
</table>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Label ID="Label4" runat="server"></asp:Label>
<div style="margin-top: 50px; margin-left: 320px;">
    <asp:Button ID="registerBtn" runat="server" Text="Register" 
        style="font-family: Cambria; width: 70px; height: 30px; margin-left: 30px; margin-right: 30px;" 
        onclick="registerBtn_Click" />
    <asp:Button ID="cancelBtn" runat="server" Text="Cancel" 
        style="font-family: Cambria; width: 70px; height: 30px; margin-left: 30px; margin-right: 30px;" 
        onclick="cancelBtn_Click" />
</div>