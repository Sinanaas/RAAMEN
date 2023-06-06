<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeStaff.aspx.cs" Inherits="PSD_RAAMEN.View.HomeStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Staff bOS"></asp:Label>
            <br />
            <asp:GridView ID="ramenGridView" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
