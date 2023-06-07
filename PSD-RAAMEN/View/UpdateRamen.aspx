<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateRamen.aspx.cs" Inherits="PSD_RAAMEN.View.UpdateRamen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="New Meat Type :"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="1">Daging Sapi</asp:ListItem>
                <asp:ListItem Value="2">Daging Babi</asp:ListItem>
                <asp:ListItem Value="3">Daging Ayam</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label2" runat="server" Text="New Name :"></asp:Label>
            <asp:TextBox ID="name_txt" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="New Broth :"></asp:Label>
            <asp:TextBox ID="broth_txt" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="New Price :"></asp:Label>
            <asp:TextBox ID="price_txt" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="update_ramen_btn" runat="server" Text="Update Ramen" OnClick="update_ramen_btn_Click" />
        </div>
    </form>
</body>
</html>
