<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Search.aspx.cs" Inherits="Web_Search" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table width="600" border="0" cellpadding="0" cellspacing="0">
<tr><td style="width: 158px; height: 12px;">
    &nbsp;</td><td style="height: 12px">
    &nbsp;</td><td style="height: 12px">
    &nbsp;</td></tr>
	<tr align="right">
		<td height="30" rowspan="2" style="width: 158px"><img src="../Web/images/sub.gif" width="31" height="30"></td>
		<td width="76%" height="28" align="left"><FONT face="宋体"></FONT><FONT face="宋体"></FONT><FONT face="宋体"></FONT>
			<asp:Label id="搜索到的新闻" runat="server"><strong>搜索到的新闻</strong></asp:Label>
		</td>
		<td align="center" style="width: 18%"></td>
	</tr>
	<tr>
		<td height="2" colspan="2" bgcolor="#6699cc"></td>
	</tr>
	<asp:Repeater id="Repeater1" runat="server">
	<ItemTemplate>
	<tr>
		<td height="24" align="center">◎</td>
		<td height="24" colspan="2" style="BORDER-BOTTOM: #999999 1px dotted">
			<a href='ListView.aspx?cid=<%#DataBinder.Eval(Container.DataItem,"id")%>' target="_blank"><%#DataBinder.Eval(Container.DataItem,"title")%></a><font color="#999999">
			[<%#Convert.ToDateTime(DataBinder.Eval(Container.DataItem,"infotime")).ToShortDateString()%>] (阅读<font color="#ff0000"><%#DataBinder.Eval(Container.DataItem,"hits")%></font>次)</font>										
		</td>
	</tr>
	</ItemTemplate>
	</asp:Repeater>
	</table>
</asp:Content>

