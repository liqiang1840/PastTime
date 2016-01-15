<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserAddNews.aspx.cs" Inherits="Web_UserAddNews" %>

<%@ Register Src="../ascx/top.ascx" TagName="top" TagPrefix="uc1" %>
<%@ Register Src="../ascx/bottom.ascx" TagName="bottom" TagPrefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table align="center">
            <tr>
                <td colspan="3">
                    <uc1:top ID="Top1" runat="server" />
                </td>
            </tr>
            <tr>
                <td style="width: 61px">
                </td>
                <td colspan="2">
                <table border="0" align="center" cellpadding="0" cellspacing="0" style="width: 100%">
				<tr>
					<td align="center" colSpan="2" height="30">
                        <strong>发 布 新 的 信 息</strong></td>
				</tr>
				<tr>
					<td height="25" style="width: 17%" ><div align="center"><font color="#ff0000">*</font>信息标题：</div></td>
					<td style="width: 620px"><input class="input" id="title" type="text" size="30" name="title" runat="server"><FONT face="宋体">&nbsp;
							<asp:requiredfieldvalidator id="title_check" runat="server" ControlToValidate="title" ErrorMessage="请输入标题"></asp:requiredfieldvalidator></FONT></td>
				</tr>
				<tr>
					<td height="25" style="width: 17%"><div align="center"><font color="#ff0000">*</font>信息类别：</div></td>
					<td style="width: 620px"><asp:dropdownlist id="BigClassID" runat="server"></asp:dropdownlist></td>
				</tr>
				<tr>
					<td vAlign="top" height="25" style="width: 17%"><div align="center"><font color="#ff0000">*</font>信息内容：</div></td>
					<td vAlign="top" style="width: 620px"><textarea id="content" style="DISPLAY: none; height: 38px;" name="Content" runat="server"></textarea>
                        <iframe id="eWebEditor1" runat="server" frameborder="0" height="350" scrolling="no"
                            src="admin/Editor/ewebeditor.asp?id=Content&style=news" style="width: 560px; height: 310px"
                            width="550"></iframe>
						
					</td>
				</tr>
				<tr>
					<td height="25" style="width: 17%"><div align="center"><font color="#ff0000">*</font>发布人：</div></td>
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
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <uc2:bottom ID="Bottom1" runat="server" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
