<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="XMLDemo.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnClick" runat="server" Text="Click Here" OnClick="btnClick_Click" />
            <asp:Label ID="lbltxt" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
