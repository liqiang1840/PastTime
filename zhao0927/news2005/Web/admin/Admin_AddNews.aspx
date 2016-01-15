<%@ Page Language="C#" ValidateRequest="false" AutoEventWireup="true" CodeFile="Admin_AddNews.aspx.cs" Inherits="Web_admin_Admin_AddNews" %>

<%@ Register Assembly="CuteEditor" Namespace="CuteEditor" TagPrefix="CE" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>发布新的新闻</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<style type="text/css">
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
a:link {
	color: #000000;
	text-decoration: none;
}
a {
	font-family: 宋体;
	font-size: 12px;
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
 <table border="0" align="center" cellpadding="0" cellspacing="0" style="width: 76%">
				<tr>
					<td align="center" colSpan="2" height="30">
                        <strong>发 布 新 的 信 息</strong></td>
				</tr>
				<tr>
					<td height="25" style="width: 12%" ><div align="center"><font color="#ff0000">*</font>信息标题：</div></td>
					<td style="width: 620px"><input class="input" id="title" type="text" size="30" name="title" runat="server"><FONT face="宋体">&nbsp;
							<asp:requiredfieldvalidator id="title_check" runat="server" ControlToValidate="title" ErrorMessage="请输入标题"></asp:requiredfieldvalidator></FONT></td>
				</tr>
				<tr>
					<td height="25" style="width: 12%"><div align="center"><font color="#ff0000">*</font>信息类别：</div></td>
					<td style="width: 620px"><asp:dropdownlist id="BigClassID" runat="server"></asp:dropdownlist></td>
				</tr>
				<tr>
					<td vAlign="top" height="25" style="width: 12%"><div align="center"><font color="#ff0000">*</font>信息内容：</div></td>
					<td vAlign="top" style="width: 620px">
                       <%-- <textarea id="content" style="DISPLAY: none; height: 38px;" name="Content" runat="server"></textarea>
						<IFRAME id="eWebEditor1" src="Editor/ewebeditor.asp?id=Content&style=news" frameBorder="0"
							width="550" scrolling="no" height="350" runat="server" style="width: 560px; height: 310px;">

						</IFRAME>--%>
                        <ce:editor id="content" runat="server"  width="550" scrolling="no" height="350"  ></ce:editor>
					</td>
				</tr>
				<tr>
					<td height="25" style="width: 12%"><div align="center"><font color="#ff0000">*</font>发布人：</div></td>
					<td style="width: 620px"><input class="input" id="user" type="text" size="30" name="user" runat="server" value="admin"><FONT face="宋体">&nbsp;
							<asp:requiredfieldvalidator id="user_check" runat="server" ControlToValidate="user" ErrorMessage="请输入发布人"></asp:requiredfieldvalidator></FONT></td>
				</tr>
				<tr>
					<td align="center" colSpan="2" height="30">
                        <asp:Button ID="Btn_OK" runat="server" OnClick="Btn_OK_Click" Text="提交" />
                        &nbsp;<input class="input" type="reset" value="重置" name="Submit2">
					</td>
				</tr>
	  </table>
    </form>
</body>
</html>
