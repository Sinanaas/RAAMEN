<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="PSD_RAAMEN.View.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="CUSTOMER BOS"></asp:Label>
            <asp:Button ID="ButOut" runat="server" Text="Log Out"  OnClick="ButOut_Click"/>
            <br />
            <asp:GridView ID="ramenGridView" runat="server">
                
            </asp:GridView>
        </div>
    </form>
</body>
</html>
