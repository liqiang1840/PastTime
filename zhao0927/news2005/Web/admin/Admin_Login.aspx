<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_Login.aspx.cs" Inherits="Web_admin_AdminLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>新闻发布系统----后台管理员登录页面</title>
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
      <table width="800" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td colspan="3"><img src="images/admin_01.jpg" width="800" height="272" /></td>
        </tr>
        <tr align="left" valign="top">
          <td width="251" height="341"><img src="images/admin_02.jpg" width="251" height="328" /></td>
          <td width="388"><table width="388" height="328" border="0" cellpadding="0" cellspacing="0">
            <tr>
              <td><img src="images/admin_03.jpg" width="388" height="20" /></td>
            </tr>
            <tr>
              <td background="images/admin_05.jpg" style="height: 19px"><div align="center">
                  <asp:Label ID="Label1" runat="server" Text="管理员用户："></asp:Label>
                  <asp:TextBox ID="UserName" runat="server" Height="14px" Width="130px"></asp:TextBox>
              </div></td>
            </tr>
            <tr>
              <td><img src="images/admin_06.jpg" width="388" height="18" /></td>
            </tr>
            <tr>
              <td background="images/admin_07.jpg"><div align="center">
                  <asp:Label ID="Label2" runat="server" Text="管理员密码："></asp:Label>
                  <asp:TextBox ID="PassWord" runat="server" Height="14px" TextMode="Password" Width="130px"></asp:TextBox>
              </div></td>
            </tr>
            <tr>
              <td background="images/admin_07.jpg"><img src="images/admin_08.jpg" width="388" height="18" /></td>
            </tr>
            <tr>
              <td background="images/admin_09.jpg"><div align="center">
                  <asp:Button ID="btn_Login" runat="server" Text="登　录" OnClick="btn_Login_Click" />          
                  <asp:Button ID="btn_Cancel" runat="server" Text="从　置" OnClick="btn_Cancel_Click" />          
              </div></td>
            </tr>
            <tr>
              <td height="223" align="left" valign="top"><br />
                  <br />
                  <img src="images/admin_11.jpg" width="388" height="180" /></td>
            </tr>
          </table></td>
          <td width="161" height="341" valign="top"><br />
          <img src="images/admin_04.jpg" width="161" height="316" /> </td>
        </tr>
      </table>
    
    <p>&nbsp;</p>
    </div>
    </form>
</body>
</html>
