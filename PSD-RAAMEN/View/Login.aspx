﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PSD_RAAMEN.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="Label1" runat="server" Text="Username :  "></asp:Label>
            <asp:TextBox ID="username_text" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Password :  "></asp:Label>
            <asp:TextBox ID="password_text" runat="server"></asp:TextBox>
            <br />
            <asp:CheckBox ID="remember_check" runat="server" />
            <asp:Label ID="Label3" runat="server" Text="Remember Me"></asp:Label>
            <br />
            <asp:Button ID="login_btn" runat="server" Text="Login" OnClick="login_btn_Click" />
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>