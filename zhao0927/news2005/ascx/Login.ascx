<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Login.ascx.cs" Inherits="ascx_Login" %>
<br />
<table style="width: 164px">
    <tr align="center">
        <td>
<table style="width: 164px" id="login_s" runat="server" >
    <tbody>
        <tr align="center">
            <td bgcolor="#0066cc" colspan="3" height="25">
                <strong><font color="#ffffff">用户登陆</font></strong></td>
        </tr>
        <tr>
            <td align="right" style="width: 50px">
            </td>
            <td colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td align="right" style="width: 50px">
                用户：</td>
            <td colspan="2">
                <asp:TextBox ID="UserName" runat="server" Width="101px"></asp:TextBox></td>
        </tr>
        <tr>
            <td align="right" style="width: 50px">
                密码：</td>
            <td colspan="2">
                <asp:TextBox ID="PassWord" runat="server" Width="101px" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 50px">
            </td>
            <td style="width: 59px">
                <asp:Button ID="login" runat="server" Text="登录" OnClick="login_Click" />
            </td>
            <td style="width: 34px">
                <asp:Button ID="Cancel" runat="server" Text="取消" OnClick="Cancel_Click" /></td>
        </tr>
        <tr>
            <td style="width: 50px">
            </td>
            <td style="width: 59px">
                &nbsp;</td>
            <td style="width: 34px">
            </td>
        </tr>
        <tr>
            <td style="width: 50px; height: 22px;" align="right">
                <img src="../Web/images/to.gif" /></td>
            <td colspan="2" style="height: 22px">
                <asp:LinkButton ID="NewUserAdd" runat="server" PostBackUrl="~/Web/UserReg.aspx">新用户注册</asp:LinkButton></td>
        </tr>
    </tbody>
</table>
        </td>
    </tr>
    <tr>
        <td>
<table style="width: 164px" id="login_E" runat="server">
    <tr>
        <td bgcolor="#0066cc" colspan="3" height="25" align="center">
            <strong><font color="#ffffff">用户信息</font></strong>
        </td>
    </tr>
    <tr>
        <td align="center" colspan="3">
            &nbsp;</td>
    </tr>
    <tr>
        <td align="center" colspan="3">
            用户：<asp:Label ID="Label" runat="server"></asp:Label>你好！</td>
    </tr>
    <tr>
        <td align="center" colspan="3">
            欢迎你来到本站！</td>
    </tr>
    <tr>
        <td align="right" style="width: 34px">
            </td>
        <td align="right" style="width: 27px">
            <img src="../Web/images/to.gif" />&nbsp;</td>
        <td style="width: 36px">
            <asp:LinkButton ID="AddNews" runat="server" Font-Size="Small" Width="96px" PostBackUrl="~/Web/UserAddNews.aspx">发布新闻信息</asp:LinkButton></td>
    </tr>
    <tr>
        <td align="right" style="width: 34px; height: 26px;">
            </td>
        <td align="right" style="height: 26px">
            <img src="../Web/images/to.gif" />&nbsp;</td>
        <td style="width: 36px; height: 26px;">
            <asp:LinkButton ID="LinkButton3" runat="server" Width="98px" PostBackUrl="~/Web/UserCenter.aspx">个人管理中心</asp:LinkButton></td>
    </tr>
    <tr>
        <td align="right" style="width: 34px; height: 26px">
        </td>
        <td align="right" style="height: 26px">
            <img src="../Web/images/to.gif">&nbsp;</td>
        <td style="width: 36px; height: 26px">
            <asp:LinkButton ID="Login_out" runat="server" OnClick="Login_out_Click" Width="86px">退出登录</asp:LinkButton></td>
    </tr>
</table>
        </td>
    </tr>
</table>
