<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Web_Default" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   <table width="200" border="0" cellspacing="0" cellpadding="0">
  <tr align="left" valign="top">
    <td><table width="500" border="0" cellspacing="0" cellpadding="0">
      <tr><td>&nbsp;</td><td>&nbsp;</td><td>&nbsp;</td></tr>
      <tr>
        <td style="width: 41px" align="right"><IMG height="30" src="../Web/images/sub.gif" width="31"></td>
        <td style="width: 1286px"><strong>最新新闻</strong></td>
        <td align="center" style="width: 166px"><a href="AllNews.aspx">更多...</a></td>
      </tr>
        <tr>
            <td align="right" style="width: 41px"><hr width="100%">
            </td>
            <td style="width: 1286px"><hr width="100%">
            </td>
            <td align="center" style="width: 166px"><hr width="100%">
            </td>
        </tr>
    </table></td>
  </tr>
  
</table>
<table width="585" border="0" cellspacing="0" cellpadding="0">
  <tr>
    <td style="width: 173px" id="TD1">
        &nbsp;
    <script language="javascript">
<!--
 
 var focus_width=200
 var focus_height=183
 var text_height=0
 var swf_height = focus_height+text_height
 
var pics='../Web/Uppic/32611.jpg|../Web/Uppic/47533.jpg|../Web/Uppic/47726.jpg|../Web/Uppic/15650.jpg'

var links=' http://cq.digi.qq.com/a/20070626/000201.htm|http://cq.digi.qq.com/a/20070626/000155.htm|http://cq.digi.qq.com/a/20070628/000430.htm|http://cq.digi.qq.com/zt/2007/chengtai/index.htm'

var texts='新闻系统图片新闻栏目'
 
 document.write('<object classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000" codebase="http://fpdownload.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=6,0,0,0" width="'+ focus_width +'" height="'+ swf_height +'">');
 document.write('<param name="allowScriptAccess" value="sameDomain"><param name="movie" value="../Web/images/playswf.swf"><param name=wmode value=transparent><param name="quality" value="high">');
 document.write('<param name="menu" value="false"><param name=wmode value="opaque">');
 document.write('<param name="FlashVars" value="pics='+pics+'&links='+links+'&texts='+texts+'&borderwidth='+focus_width+'&borderheight='+focus_height+'&textheight='+text_height+'">');
 document.write('<embed src="../Web/images/playswf.swf" wmode="opaque" FlashVars="pics='+pics+'&links='+links+'&texts='+texts+'&borderwidth='+focus_width+'&borderheight='+focus_height+'&textheight='+text_height+'" menu="false" bgcolor="#DADADA" quality="high" width="'+ focus_width +'" height="'+ swf_height +'" allowScriptAccess="sameDomain" type="application/x-shockwave-flash" pluginspage="http://www.macromedia.com/go/getflashplayer" />');  
 document.write('</object>');
 
 //-->
 </script>
        </td>
    <td width="75%">
        <asp:Repeater ID="RepeaterNew" runat="server">
        <ItemTemplate>
			<table width="100%" border="0" cellpadding="0" cellspacing="0">
			<tr>
			    <td height="24" style="BORDER-bottom: #999999 1px dotted">
			    &nbsp;◎&nbsp;<span style="font-size:9pt;line-height:15pt">
			    <a href='ListView.aspx?cid=<%#DataBinder.Eval(Container.DataItem,"id")%>' title="" target="_blank"><%#cutString(DataBinder.Eval(Container.DataItem,"title").ToString(),30)%></a></span>
			    <font color="#999999" >[<%#Convert.ToDateTime(DataBinder.Eval(Container.DataItem,"infotime")).ToShortDateString()%>]</font> <font color="#999999" >(阅读<font color="#FF0000"><%#DataBinder.Eval(Container.DataItem,"hits")%></font>次)</font>
			    </td>
			</tr>
			</table>
		</ItemTemplate>
        </asp:Repeater>
    </td>
  </tr>
</table>
<table cellSpacing="0" cellPadding="0" border="0" style="width: 590px">
    <tr>
	<td>&nbsp;
        &nbsp;<asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_ItemDataBound">
    <ItemTemplate>
	    <tr>
		    <td>
			    <table width="100%" border="0" cellpadding="0" cellspacing="0">
				    <tr>
					    <td width="6%" height="30" rowspan="2"><img src="../Web/images/sub.gif" width="31" height="30"></td>
					    <td width="76%" height="28">
						    <strong><%#DataBinder.Eval(Container.DataItem,"name")%></strong></td>
					    <td width="18%" align="center"><a href='otype.aspx?sort=<%#DataBinder.Eval(Container.DataItem,"id")%>'>更多...</a></td>
				    </tr>
				    <tr>
					    <td height="2" colspan="2" bgcolor="#6699cc">
					    </td>
				    </tr>
				    <tr>
					    <td>
					    </td>
					    <td colspan="2">
						    <asp:repeater id="Repeater2" runat="server">
							    <ItemTemplate>
								    <table width="100%" border="0" cellpadding="0" cellspacing="0">
								    <tr><td height="24" style="BORDER-bottom: #999999 1px dotted">
								    ◎&nbsp;<span style="font-size:9pt;line-height:15pt">
								    <a href='ListView.aspx?cid=<%#DataBinder.Eval(Container.DataItem,"id")%>' title="" target="_blank"><%#cutString(DataBinder.Eval(Container.DataItem,"title").ToString(),30)%></a></span>
								    <font color="#999999" >[<%#Convert.ToDateTime(DataBinder.Eval(Container.DataItem,"infotime")).ToShortDateString()%>]</font> <font color="#999999" >(阅读<font color="#FF0000"><%#DataBinder.Eval(Container.DataItem,"hits")%></font>次)</font>
								    </td></tr>
								    </table>
							    </ItemTemplate>
						    </asp:repeater>	
					    </td>
				    </tr>
			    </table>
		    </td>
	    </tr>
    </ItemTemplate>
    </asp:Repeater>
    </td>
    </tr>
</table>
</asp:Content>

