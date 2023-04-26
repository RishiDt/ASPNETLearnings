<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlayGroundForm2.aspx.cs" Inherits="ASPNETLearnings.PlayGroundForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 280px">
            <br />
            part 17 vid 17 : Binding DropDownList to an XML<br />
            desc: Items present in XMLFile1.xml&nbsp; one additional element &quot;Select&quot; added at 0th position using items.Insert().<br />
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
