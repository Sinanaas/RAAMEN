<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeAdmin.aspx.cs" Inherits="PSD_RAAMEN.View.HomeAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="HomeAdmin.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 250px;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <table>
            <asp:Label ID="Label1" runat="server" class="title-page" Text="Admin Page"></asp:Label>
                <tr>
                    <td>
            <asp:Button ID="view_customer_btn" class="btn" runat="server" Text="View Customer" OnClick="view_customer_btn_Click" />
                    </td>
                    <td class="auto-style1">
            <asp:Button ID="view_staff_btn" class="btn" runat="server" Text="View Staff" OnClick="view_staff_btn_Click"/>
                    </td>
                    <td>
            <asp:Button ID="privilege_btn" class="btn" runat="server" Text="Member and Staff Privilege" />
                    </td>
                </tr>
                <tr>
                    <td>
            <asp:Button ID="view_transaction_btn" class="btn" runat="server" Text="View Transaction" />
                    </td>
                    <td class="auto-style1">
            <asp:Button ID="view_report_btn" class="btn" runat="server" Text="View Report" OnClick="view_report_btn_Click" />
                    </td>
                    <td>
            <asp:Button ID="user_profile" class="btn" runat="server" Text="Edit Profile" OnClick="user_profile_Click" />
                    </td>
                </tr>
            </table>
    </form>
</body>
</html>
