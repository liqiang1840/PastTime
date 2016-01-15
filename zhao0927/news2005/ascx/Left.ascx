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
</style><%@ Control Language="C#" AutoEventWireup="true" CodeFile="Left.ascx.cs" Inherits="ascx_Left" %>
<table width="164" height="110" border="0" cellpadding="0" cellspacing="0">
  <tr>
	<td  colspan="2" align="center" bgColor="#0066cc" height="26"><font color="#ffffff">新闻搜索</font></td>
  </tr>
  <tr>
    <td align="center" colspan="2" style="height: 11px">
        <asp:TextBox ID="tb_value" runat="server" BorderColor="#804000"></asp:TextBox></td>
  </tr>
  <tr>
    <td align="center" height="24">&nbsp;<asp:DropDownList ID="DL_Type" runat="server">
            <asp:ListItem Value="title">新闻标题</asp:ListItem>
            <asp:ListItem Value="newinfo">新闻内容</asp:ListItem>
        </asp:DropDownList></td>
    <td align="center">
        <asp:Button ID="Search" runat="server" Text="搜索"   OnClick="Search_Click" />&nbsp;</td>
  </tr>
  <tr bgColor="#9999cc">
    <td height="22" bgColor="#0066cc"><div align="center"><font color="#ffffff">热门新闻标题</font></div></td>
  <td bgColor="#0066cc"><div align="right"><font color="#ffffff">Top10</font></div></td>
  </tr>
  <tr>
    <td colspan="2">
      <table width="100%" border="0" cellpadding="0" cellspacing="0">
      <asp:Repeater ID="RepHits" runat="server" EnableTheming="True">
         <ItemTemplate>
	        <tr bgColor="#efefef">
	            <td width="82%" onmousemove="style.backgroundColor='#CCCCCC'" onmouseout="style.backgroundColor='#efefef'" >&nbsp;&nbsp;<a href='ListView.aspx?cid=<%# DataBinder.Eval(Container.DataItem,"id")%>' title="<%# DataBinder.Eval(Container.DataItem,"title")%>" target=_blank><%# cutString(DataBinder.Eval(Container.DataItem,"title").ToString(),14)%></a></td>
	            <td width="18%" height="22" align="center"><%# DataBinder.Eval(Container.DataItem,"hits")%></font></td>
	        </tr>
         </ItemTemplate>
      </asp:Repeater>
      </table>
    </td>
  </tr>
</table>
<script language="javascript">
function Checktb_value()
{
   if(document.all.tb_value.value=="")
   {
      alert('请输入查询关键字！');
   }
}
</script>