<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlayGroundForm3.aspx.cs" Inherits="ASPNETLearnings.WebForms.PlayGroundForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            part 19 vid 19 : ServerMapPath method to get to root directory and navigating to parent dir<br />
            desc: Click Button to see paths returned byMapPath<br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <br />
            <br />
            part 20 vid 20 : demo of ServerMapPath<br />
            desc: see DropDownList using XML<br />
            <br />
            <br />
            part 21 vid 21: SelectedIndex SelectedValue SelectedItem.Text&nbsp; and .Value<br />
            desc:&nbsp; hit button to see text value and index
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="As">Asia</asp:ListItem>
                <asp:ListItem Value="Am">America</asp:ListItem>
                <asp:ListItem Value="Af">Africa</asp:ListItem>
                <asp:ListItem Value="Ar">Artic</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
            <br />
            <br />
            <br />
            part 22: cascading dropdownlist<br />
            desc:Implimentation demonstration using database method<br />
            <br />
            <br />
            <br />
            part23: checkboxlist<br />
            desc:
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>diploma</asp:ListItem>
                <asp:ListItem>graduate</asp:ListItem>
                <asp:ListItem>postgraduate</asp:ListItem>
                <asp:ListItem>doctrate</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Button" />
            <br />
            <br />
            <br />
            part 24: selecting Index in CheckBoxList<br />
            desc left button shows selection right one selects graduate programmatically<br />
            <asp:CheckBoxList ID="CheckBoxList2" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>diploma</asp:ListItem>
                <asp:ListItem>graduate</asp:ListItem>
                <asp:ListItem>postgraduate</asp:ListItem>
                <asp:ListItem>doctrate</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Show Selection" />
            <asp:Button ID="Button5" runat="server" Height="25px" OnClick="Button5_Click" Text="Select Graduate" Width="117px" />
            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="SelectAll" />
            <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="DIsselectAll" />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
