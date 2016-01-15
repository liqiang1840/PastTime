<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Count.ascx.cs" Inherits="ascx_Count" %>
<table style="width: 164px">
    <tr align="center" bgcolor="#0066cc">
        <td colspan="2" bgcolor="#0066cc" height="25"><strong><font color="#ffffff">新闻统计</font></strong>
        </td>
    </tr>
    <tr>
        <td style="width: 93px" align="center">
            <strong>栏目名称</strong></td>
        <td style="width: 99px" align="center">
            <strong>新闻条数</strong></td>
    </tr>
    <tr>
        <td align="center" style="width: 93px">
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <table style="width: 82px">
                    <tr>
                        <td><%#DataBinder.Eval(Container.DataItem,"name")%></td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:Repeater>
        </td>
        <td align="center" style="width: 99px">
        <asp:Repeater ID="Repeater2" runat="server">
        <ItemTemplate>
            <table style="width: 82px">
                <tr>
                <td>共<%#DataBinder.Eval(Container.DataItem, "newscount")%>条</td>
                </tr>
            </table>
        </ItemTemplate>
        </asp:Repeater>
        </td>
    </tr>
    <tr>
        <td align="center" style="width: 93px">
        </td>
        <td align="center" style="width: 99px">
            &nbsp;</td>
    </tr>
    <tr>
        <td align="center" style="width: 93px">
        </td>
        <td align="center" style="width: 99px">
            &nbsp;</td>
    </tr>
    <tr>
        <td align="center" style="width: 93px">
        </td>
        <td align="center" style="width: 99px">
            &nbsp;</td>
    </tr>
    <tr>
        <td align="center" style="width: 93px">
        </td>
        <td align="center" style="width: 99px">
            &nbsp;
        </td>
    </tr>
</table>
