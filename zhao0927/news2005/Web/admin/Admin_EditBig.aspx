<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_EditBig.aspx.cs" Inherits="Web_admin_Admin_EditBig" %>

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
	color: #000000;
}
a:link {
	text-decoration: none;
}
a:visited {
	text-decoration: none;
	color: #000000;
}
a:hover {
	text-decoration: none;
	color: #000000;
}
a:active {
	text-decoration: none;
	color: #000000;
}
-->
</style></head>
<body>
    <form id="form1" runat="server">
    <div>
      <table width="579" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td colspan="2"><p>&nbsp;</p>
          <p>&nbsp;</p></td>
        </tr>
        <tr>
          <td colspan="2"><table width="579" border="0" cellspacing="0" cellpadding="0">
            <tr>
              <td width="131">&nbsp;</td>
              <td width="448"><p><strong>修 改 新 闻 类 别</strong></p>
              </td>
            </tr>
          </table></td>
        </tr>
        <tr>
          <td width="21">&nbsp;</td>
        <td width="558"><div align="left"></div>
          <table width="320" border="0" align="left" cellpadding="0" cellspacing="0" >
          <tr>
            <td align="center" valign="top"></td>
            <td></td>
          </tr>
          <tr>
            <td colspan="2" align="center" valign="bottom" style="height: 12px"><hr /></td>
            </tr>
          <tr>
            <td align="center" style="height: 12px" valign="bottom"> 新闻编号：</td>
            <td align="left" valign="middle" style="height: 12px"><br />
                <asp:Label ID="BigClassid" runat="server"></asp:Label>
            </td>
          </tr>
          <tr>
            <td align="center" valign="middle" style="height: 14px" colspan="2"><hr /></td>
          </tr>
          <tr>
            <td width="64" align="center" valign="bottom">新闻名称：</td>
            <td width="257" align="left" valign="middle"><br />
                <asp:TextBox ID="BigClassName" runat="server"></asp:TextBox>
              </td>
          </tr>
          <tr>
            <td align="center" valign="middle" colspan="2"><hr />
              </td>
          </tr>
          <tr>
            <td align="center" valign="bottom">是否可见：</td>
            <td valign="middle">
                <br />
                <asp:DropDownList ID="isVisble" runat="server">
                <asp:ListItem Value="显示">显示</asp:ListItem>
                <asp:ListItem Value="隐藏">隐藏</asp:ListItem>
            </asp:DropDownList>
              </td>
          </tr>
          <tr>
            <td align="center" valign="middle" colspan="2"><hr />
              </td>
          </tr>
          <tr>
            <td align="center" valign="middle">&nbsp;</td>
            <td><asp:Button ID="Edit" runat="server" OnClick="Edit_Click" Text="确定修改" />&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Web/images/back.gif"
                    PostBackUrl="~/Web/admin/Admin_BigClass.aspx" /></td>
          </tr>
          <tr>
            <td align="center" valign="top"></td>
            <td></td>
          </tr>
        </table></td>
        </tr>
      </table>
      </div>
    </form>
</body>
</html>
