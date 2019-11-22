<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Azure.aspx.cs" Inherits="AzureWeb.Azure" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                AZURE WEB
            <br /><br />
    <asp:TextBox ID="txtValue" runat="server">
    </asp:TextBox>
        <br /><br />
        <asp:Button ID="btnClick" runat="server" OnClick="btnClick_Click" Text="Login" />
        <br /><br />
        <asp:Label ID="lblErrorMessage" runat="server" ForeColor="Red"></asp:Label>
            </center>
        </div>
    </form>
</body>
</html>
