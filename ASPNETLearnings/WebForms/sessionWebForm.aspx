<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sessionWebForm.aspx.cs" Inherits="WebApplication2.sessionWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 80px">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-left: 78px" Text="Button" Width="124px" />
        </div>
    </form>
</body>
</html>
