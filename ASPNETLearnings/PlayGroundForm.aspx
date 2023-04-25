<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlayGroundForm.aspx.cs" Inherits="ASPNETLearnings.HyperLink" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <div style="height: 467px">
                part 13 vid 13: HyperLink control<br />
                desc: property target=_self<br />
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="" Target="_self">HyperLink</asp:HyperLink>
                <br />
                <br />
                part 14 vid 14:&nbsp; Button, LinkButton, ImageButton<br />
                desc: property onClientclick= return confirm(&#39;are you sure?&#39;)<br />
                <asp:LinkButton ID="LinkButton1" runat="server" OnClientClick="return confirm('Are you sure?')">LinkButton</asp:LinkButton>
                <br />
                <br />
                part 15 vid 15:
           Command Event of an asp.net button control
                <br />
                desc:
                set event handler programattically. not present in html.<br />
                <asp:Button ID="Button1" runat="server"  Text="Button" />
                <br />
                <br />
                desc:event handler function Command_Event_Hanlder. commandargs and commnadname is provided in html of button.<br />
                <asp:Button ID="Button2" runat="server" OnCommand="ButtonCommandHandler" Text="Button 1" CommandName="c1"  />
                <br />
                <asp:Button ID="Button3" runat="server" OnCommand="ButtonCommandHandler" Text="Button 2" CommandName="c2" CommandArgument="arg1" />
                <br />
                <br />
                <br />
                part 16 vid 16: DropDownList<br />
                desc: added items in page_load using DropDownList.Item.Add<br />
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
            </div>
           
    </form>
</body>
</html>
