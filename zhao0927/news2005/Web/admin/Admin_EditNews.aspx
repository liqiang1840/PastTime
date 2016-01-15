<%@ Page Language="C#" ValidateRequest="false"  AutoEventWireup="true" CodeFile="Admin_EditNews.aspx.cs" Inherits="Web_admin_Admin_EditNews" %>
<%@ Register Assembly="CuteEditor" Namespace="CuteEditor" TagPrefix="CE" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>修改新闻页面</title>
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
        <table align="center" border="0" cellpadding="0" cellspacing="0" style="width: 76%">
            <tr>
                <td align="center" colspan="2" height="30">
                    修 改 新 闻</td>
            </tr>
            <tr>
                <td height="25" style="width: 12%">
                    <div align="center">
                        <font color="#ff0000">*</font>信息标题：</div>
                </td>
                <td style="width: 620px">
                    <font
                        face="宋体">
                        <asp:TextBox ID="title" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="title_check" runat="server" ControlToValidate="title"
                            ErrorMessage="请输入标题"></asp:RequiredFieldValidator></font></td>
            </tr>
            <tr style="color: #000000">
                <td height="25" style="width: 12%">
                    <div align="center">
                        <font color="#ff0000">*</font>信息类别：</div>
                </td>
                <td style="width: 620px">
                    <asp:DropDownList ID="BigClassID" runat="server">
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td height="25" style="width: 12%" valign="top">
                    <div align="center">
                        <font color="#ff0000"><span style="color: #000000">*</span></font>信息内容：</div>
                </td>
                <td style="width: 620px" valign="top">
                   <%-- <textarea id="content" runat="server" name="Content" style="display: none"></textarea>
                    <iframe id="eWebEditor1" runat="server" frameborder="0" height="350" scrolling="no"
                        src="Editor/ewebeditor.asp?id=Content&style=news" style="width: 560px; height: 310px;" width="550">
                    </iframe>--%>
                     <ce:editor id="content" runat="server"  width="550" scrolling="no" height="350"  ></ce:editor>
                </td>
            </tr>
            <tr>
                <td height="25" style="width: 12%">
                    <div align="center">
                        <font color="#ff0000"><span style="color: #000000">*</span></font>发布人：</div>
                </td>
                <td style="width: 620px">
                    <input id="user" runat="server" class="input" name="user" size="30" type="text" /><font
                        face="宋体">&nbsp;
                        <asp:RequiredFieldValidator ID="user_check" runat="server" ControlToValidate="user"
                            ErrorMessage="请输入发布人"></asp:RequiredFieldValidator></font></td>
            </tr>
            <tr>
                <td style="width: 12%; height: 13px">
                </td>
                <td style="width: 620px; height: 13px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td height="25" style="width: 12%">
                </td>
                <td style="width: 620px">
                    <asp:Button ID="Btn_OK" runat="server" OnClick="Btn_OK_Click" Text="提交" /></td>
            </tr>
            <tr>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
