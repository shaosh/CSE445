<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LoginSenior.ascx.cs" Inherits="Login" %>



<h1 style="font-family: Cambria;">Senior Service Log In</h1>

<table id="loginTable" style="margin-left: auto; margin-right: auto; margin-top: 80px; border: 1px black solid; background: #A9BCF5;" cellspacing="40" runat="server">
    <tr>
        <td>
            <label id="Label1" runat="server" style="font-family: Cambria;">Username</label>
        </td>
        <td>
            <asp:TextBox ID="Username" runat="server" Width="200px" 
                style="font-family: Cambria;"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <label id="Label2" runat="server" width="100px" style="font-family: Cambria;">Password</label>
        </td>
        <td>
            <asp:TextBox ID="Password" runat="server" Width="200px" TextMode="Password" 
                style="font-family: Cambria;"></asp:TextBox>
        </td>
    </tr>
</table>
<br />
<asp:Label ID="Label3" runat="server" style="margin-left: 425px; font-family: Cambria;" ></asp:Label>
<div id="btndiv" runat="server" style="margin-top: 50px; height: 50px; width: 300px; margin-left: 320px;" >                
    
    <asp:Button class="btn" ID="loginBtn" runat="server" Text="Log In" Width="70px" 
        Height="30px" 
        sytle="font-family: Cambria; margin-left: 30px; margin-right: 30px;" 
        onclick="loginBtn_Click"/>
    <asp:Button class="btn" ID="returnBtn" runat="server" Text="Return" 
        Width="70px" Height="30px" 
        sytle="font-family: Cambria; margin-left: 30px; margin-right: 30px;" 
        onclick="returnBtn_Click"/>
</div>           
  