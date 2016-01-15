<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_answer.aspx.cs" Inherits="Web_admin_Admin_answer" %>

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
	color: #F4F4F4;
}
a:link {
	text-decoration: none;
}
a:visited {
	text-decoration: none;
}
a:hover {
	text-decoration: none;
}
a:active {
	text-decoration: none;
}
-->
</style></head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 596px" align="center">
            <tr align="center">
                <td colspan="3"><strong>
                    <br />
                    新 闻 评 论 管 理</strong></td>
            </tr>
            <tr align="center">
                <td colspan="3">
                    &nbsp;</td>
            </tr>
            <tr align="center">
                <td colspan="3">
                    查询新闻评论(请选择新闻ID)：<asp:DropDownList ID="DLnewsID" runat="server">
                        <asp:ListItem Value="0">请选择</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Button ID="SelectByNewID" runat="server" Text="查　询" OnClick="SelectByNewID_Click" />
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="查询全部" /></td>
            </tr>
            <tr>
                <td colspan="3" style="height: 127px">
                    <asp:GridView ID="GridView1" runat="server" Width="642px" AutoGenerateColumns="False" Height="112px" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowDataBound="GridView1_RowDataBound">
                        <Columns>
                            <asp:TemplateField HeaderText="选择">
                                <ItemTemplate>
                                    <table align="center">
                                        <tr align="center">
                                            <td>
                                    <asp:CheckBox ID="CheckBox1" runat="server" /></td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="评论编号">
                                <ItemTemplate>
                                    <table align="center">
                                        <tr align="center">
                                            <td>
                                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("A_id") %>'></asp:Label></td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="评论用户">
                                <ItemTemplate>
                                    <table align="center">
                                        <tr align="center">
                                            <td>
                                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("A_user") %>'></asp:Label></td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="评论内容">
                                <ItemTemplate>
                                   <table align="center">
                                        <tr align="center">
                                            <td>
                                    <asp:Label ID="Label1" runat="server" Text='<%#CutString(DataBinder.Eval(Container.DataItem,"A_word").ToString(),32)%>'></asp:Label></td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="评论时间">
                                <ItemTemplate>
                                    <table align="center">
                                        <tr align="center">
                                            <td>
                                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("A_time") %>'></asp:Label></td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="新闻编号">
                                <ItemTemplate>
                                    <table align="center">
                                        <tr align="center">
                                            <td>
                                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("newsID") %>'></asp:Label></td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Button ID="SelectAll" runat="server" Text="选择全部" OnClick="SelectAll_Click" />&nbsp;
                    <asp:Button ID="DeleteCheck" runat="server" Text="删除选中项" OnClick="DeleteCheck_Click"/>
                    <asp:Button ID="DeleteAll" runat="server" Text="删除单条新闻的全部评论" OnClick="DeleteAll_Click" /></td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                </td>
                <td>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
