<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PSD_RAAMEN.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Login.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1> Login Page</h1>

        <div class="content">
            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
            <br />
            <asp:TextBox ID="username_text" runat="server" Width="210px"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            <br />
            <asp:TextBox ID="password_text" runat="server" Width="210px"></asp:TextBox>
            <br />
            <asp:CheckBox ID="remember_check" runat="server" />
            <asp:Label ID="Label3" runat="server" Text="Remember Me"></asp:Label>
            <br />
            <asp:Button ID="login_btn" runat="server" Text="Login" OnClick="login_btn_Click" Width="218px"/>
            <br />
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
        </div>
    </form>
    </body>
</html>
