<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_EditUser.aspx.cs" Inherits="Web_admin_Admin_EditUser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"><style type="text/css">
<!--
body,td,th {
	font-family: 宋体;
	font-size: 12px;
	color: #000000;
}
body {
	margin-left: 0px;
	margin-top: 0px;
	margin-right: 0px;
	margin-bottom: 0px;
}
a {
	font-family: 宋体;
	font-size: 12px;
	color: #6666FF;
}
a:link {
	text-decoration: none;
}
a:visited {
	text-decoration: none;
	color: #6666FF;
}
a:hover {
	text-decoration: none;
	color: #6666FF;
}
a:active {
	text-decoration: none;
	color: #6666FF;
}
-->
</style></head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td style="width: 187px">
                </td>
                <td style="width: 151px">
                    <br />
                    <br />
                    <br />
                </td>
                <td style="width: 300px">
                </td>
            </tr>
            <tr>
                <td style="width: 187px">
                </td>
                <td style="width: 151px">
                    <div align="center"><strong>修 改 用 户 信 息</strong><br />
                        &nbsp;</div></td>
                <td style="width: 300px">
                </td>
            </tr>
            <tr>
                <td style="width: 187px" align="center">
                    用户编号：</td>
                <td style="width: 151px">
                    <asp:Label ID="UserCid" runat="server" Width="65px"></asp:Label></td>
                <td style="width: 300px">
                </td>
            </tr>
            <tr>
                <td style="width: 187px">
                    <div align="center">用户名称：</div></td>
                <td style="width: 151px">
                    <asp:TextBox ID="UserName" runat="server"></asp:TextBox></td>
                <td style="width: 300px">
                </td>
            </tr>
            <tr>
                <td style="width: 187px">
                    <div align="center">用户密码：</div></td>
                <td style="width: 151px">
                    <asp:TextBox ID="UserPwd" runat="server" TextMode="Password" Width="149px"></asp:TextBox></td>
                <td style="width: 300px">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UserPwd"
                        ErrorMessage="＊请输入密码！" Font-Size="Small"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td style="width: 187px">
                    <div align="center">用户邮箱：</div></td>
                <td style="width: 151px">
                    <asp:TextBox ID="UserEmail" runat="server"></asp:TextBox></td>
                <td style="width: 300px">
                </td>
            </tr>
            <tr>
                <td style="width: 187px">
                    <div align="center">用户权限：</div></td>
                <td style="width: 151px">
                    <asp:DropDownList ID="UserAleave" runat="server">
                        <asp:ListItem>管理员</asp:ListItem>
                        <asp:ListItem>普通用户</asp:ListItem>
                    </asp:DropDownList></td>
                <td style="width: 300px">
                </td>
            </tr>
            <tr>
                <td style="width: 187px">
                </td>
                <td style="width: 151px">
                </td>
                <td style="width: 300px">
                </td>
            </tr>
            <tr>
                <td style="width: 187px">
                </td>
                <td style="width: 151px">
                    <asp:Button ID="Btn_OK" runat="server" OnClick="Btn_OK_Click" Text="确定修改" /></td>
                <td style="width: 300px">
                </td>
            </tr>
            <tr>
                <td style="width: 187px">
                </td>
                <td style="width: 151px">
                </td>
                <td style="width: 300px">
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Web/images/back.gif"
                        PostBackUrl="~/Web/admin/Admin_AllUsers.aspx" /></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
