<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeAdmin.aspx.cs" Inherits="PSD_RAAMEN.View.HomeAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="ADMIN BOS"></asp:Label>
            <br />
            <asp:Button ID="view_customer_btn" runat="server" Text="View Customer" OnClick="view_customer_btn_Click" />
            <br />
            <asp:Button ID="view_staff_btn" runat="server" Text="View Staff" OnClick="view_staff_btn_Click" />
            <br />
            <asp:Button ID="privilege_btn" runat="server" Text="Member and Staff Privilege" />
            <br />
            <asp:Button ID="view_transaction_btn" runat="server" Text="View Transaction" />
            <br />
            <asp:Button ID="view_report_btn" runat="server" Text="View Report" />
            <br />
            <asp:Button ID="user_profile" runat="server" Text="Edit Profile" OnClick="user_profile_Click" />
        </div>
    </form>
</body>
</html>
