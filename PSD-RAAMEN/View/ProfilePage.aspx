<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="PSD_RAAMEN.View.ProfilePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
            <asp:Label ID="Label1" runat="server" Text="Username :"></asp:Label>
            <asp:TextBox ID="username_txt" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Email :"></asp:Label>
            <asp:TextBox ID="email_txt" runat="server"></asp:TextBox>
            <br />
            <asp:RadioButton ID="male_radio" runat="server" GroupName="gender_group" Text="Male" />
            <asp:RadioButton ID="female_radio" runat="server" GroupName="gender_group" Text="Female" />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Password :"></asp:Label>
            <asp:TextBox ID="password_txt" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="update_btn" runat="server" Text="Update" OnClick="update_btn_Click" />
            <br />
            <asp:Label ID="status" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
