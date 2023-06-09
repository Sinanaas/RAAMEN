﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="PSD_RAAMEN.View.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Username :  "></asp:Label>
            <asp:TextBox ID="username_text" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Email    :  "></asp:Label>
            <asp:TextBox ID="email_text" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Gender   :  "></asp:Label>
            <br />
            <asp:RadioButton ID="male_radio" runat="server" GroupName="gender_group" Text="Male" />
            <asp:RadioButton ID="female_radio" runat="server" GroupName="gender_group" Text="Female" />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Password :  "></asp:Label>
            <asp:TextBox ID="password_text" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Confirm Password :  "></asp:Label>
            <asp:TextBox ID="confirm_password_text" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="register_btn" runat="server" Text="Register" OnClick="register_btn_Click"/>
        </div>
    </form>
</body>
</html>
