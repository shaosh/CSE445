<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeFile="LoginJunior.aspx.cs" Inherits="Login" %>
<%@ Register TagPrefix="gui" TagName="login" Src="~/LoginSenior.ascx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html id="Html1" xmlns="http://www.w3.org/1999/xhtml" runat="server">
    <head id="Head1" runat="server">
        <title>Log In Page</title>
        <link rel="stylesheet" type="text/css" href="Styles/Login.css" />
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
            <gui:login runat="server" />
        </form>
    </body>
</html>
