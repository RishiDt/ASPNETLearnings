<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RadioButton.aspx.cs" Inherits="ASPNETLearnings.RadioButton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 255px; margin-left: 80px">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
&nbsp;
            <asp:RadioButton ID="RadioButton4" runat="server" AutoPostBack="True" GroupName="G1" OnCheckedChanged="RadioButton4_CheckedChanged" Text="choice1" />
            <asp:RadioButton ID="RadioButton5" runat="server" AutoPostBack="True" GroupName="G1" OnCheckedChanged="RadioButton4_CheckedChanged" Text="choice2" />
&nbsp;<asp:RadioButton ID="RadioButton6" runat="server" AutoPostBack="True" GroupName="G1" OnCheckedChanged="RadioButton4_CheckedChanged" Text="choice3" />
        </div>
    </form>
</body>
</html>
