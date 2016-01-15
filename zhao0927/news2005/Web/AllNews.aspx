<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AllNews.aspx.cs" Inherits="Web_AllNews" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;&nbsp;
    <asp:Repeater ID="Repeater1" runat="server">
    <ItemTemplate>
    <table width="605px" border="0" cellpadding="0" cellspacing="0">
	<tr>
	<td height="24" style="BORDER-bottom: #999999 1px dotted">
	&nbsp;◎&nbsp;
	<span style="font-size:9pt;line-height:15pt">
	<a href='ListView.aspx?cid=<%#DataBinder.Eval(Container.DataItem,"id")%>' title="" target="_blank"><%#cutString(DataBinder.Eval(Container.DataItem,"title").ToString(),30)%></a>
	</span>
	<font color="#999999" >[<%#Convert.ToDateTime(DataBinder.Eval(Container.DataItem,"infotime")).ToShortDateString()%>]</font> <font color="#999999" >(阅读<font color="#FF0000"><%#DataBinder.Eval(Container.DataItem,"hits")%></font>次)</font>
	</td>
	</tr>
	</table>
    </ItemTemplate>
    </asp:Repeater>
</asp:Content>

