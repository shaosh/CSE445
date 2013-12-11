<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>
<%@ Register TagPrefix="gui" TagName="register" Src="~/Register.ascx" %>>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register Page</title>
    <link rel="stylesheet" type="text/css" href="Styles/Site.css" />
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
        <gui:register runat="server" />
    </form>
</body>
</html>
