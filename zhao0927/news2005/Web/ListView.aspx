<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListView.aspx.cs" Inherits="Web_ListView" %>

<%@ Register Src="../ascx/top.ascx" TagName="top" TagPrefix="uc1" %>
<%@ Register Src="../ascx/bottom.ascx" TagName="bottom" TagPrefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>查看新闻详细页面</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
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
</style>
<SCRIPT language="JavaScript">
			var currentpos,timer;

			function initialize()
			{
			timer=setInterval("scrollwindow()",50);
			}
			function sc(){
			clearInterval(timer);
			}
			function scrollwindow()
			{
			currentpos=document.body.scrollTop;
			window.scroll(0,++currentpos);
			if (currentpos != document.body.scrollTop)
			sc();
			}
			document.onmousedown=sc
			document.ondblclick=initialize
		</SCRIPT>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <table width="600" border="0" align="center" cellpadding="0" cellspacing="0" bgColor="#f3f3f3">
        <tr>
          <td>
              <uc1:top ID="Top1" runat="server" />
          </td>
        </tr>
        <tr>
          <td align="center">
          <asp:repeater id="repeater1" Runat="server">
								<ItemTemplate>
									<table width="95%" border="0" align="center" cellpadding="0" cellspacing="0"> 
										<tr>
											<td height="50" colspan="2" align="center" style="font-size:x-large;line-height:100px;font-weight:700" ><%#DataBinder.Eval(Container.DataItem,"title")%></td>
										</tr>
										<tr>
											<td width="40%" height="30" style="BORDER-TOP: #666666 1px solid; BORDER-BOTTOM: #666666 1px solid">双击自动滚屏</td>
											<td width="60%" align="center" style="BORDER-TOP: #666666 1px solid; BORDER-BOTTOM: #666666 1px solid">发布者：<%#DataBinder.Eval(Container.DataItem,"username")%> 
												发布时间：<%#Convert.ToDateTime(DataBinder.Eval(Container.DataItem,"infotime")).ToShortDateString()%>
												阅读：<font color="#ff0000"><%#DataBinder.Eval(Container.DataItem,"hits")%></font>次
												评论：<font color="#ff0000"><%#GetAnswerCindexByNewsID(int.Parse(DataBinder.Eval(Container.DataItem, "id").ToString()))%></font>次</td>
										</tr>
										<tr>
											<td colspan="2"><br>
												<div style='FONT-SIZE:12px'><%#checkcontent(DataBinder.Eval(Container.DataItem,"info").ToString())%></div>
											</td>
										</tr>
										<tr align="right">
											<td colspan="2" height="30">
											</td>
										</tr>
										<tr align="right">
											<td colspan="2">
											</td>
										</tr>
									</table>
								</ItemTemplate>
							</asp:repeater>
          </td>
        </tr>
          <tr>
              <td bgcolor="#74ECE8">
                  &nbsp;&nbsp;&nbsp;&nbsp;<strong>网友评论</strong></td>
          </tr>
          <tr>
              <td style="height: 12px" align="center"  >
                  <asp:Repeater ID="Repeater2" runat="server">
                  <ItemTemplate>
                     <table width="95%" border="0" cellspacing="0" cellpadding="0">
                     <tr><hr /></tr>
                     <tr><td colspan="8">
                     <table width="100%" border="0" cellspacing="0" cellpadding="0">
                      <tr>
                        <td width="55" align="right">网友姓名:</td>
                        <td width="60" align="left"><%#DataBinder.Eval(Container.DataItem,"A_user")%>
                        <td width="55" align="right">留言时间:</td>
                        <td width="130" align="left"><%#DataBinder.Eval(Container.DataItem, "A_time")%></td>
                        <td width="30" align="right">QQ:</td>
                        <td width="80" align="left"><%#DataBinder.Eval(Container.DataItem,"A_qq")%>
                        <td width="55" align="right">E-mail:</td>
                        <td width="90" align="left"><a href="mailto:<%#DataBinder.Eval(Container.DataItem,"A_email")%>"><%#DataBinder.Eval(Container.DataItem,"A_email")%></a></td>
                        <td width="150" align="right">第<font color="#FF0000"><%#DataBinder.Eval(Container.DataItem,"cindex")%></font>楼</td>
                      </tr>
                      </table>
                      </td></tr>
                      <tr><td colspan="8"><hr /></td></tr>
                      <tr>
                        <td width="55" align="left" valign="top">留言内容:</td>
                        <td colspan="6"><div align="left" valign="top"><%#DataBinder.Eval(Container.DataItem,"A_word")%></div></td>
                        
                      </tr>
                      <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                      </tr>
                    </table>
                  </ItemTemplate>
                  </asp:Repeater>
              </td>
          </tr>
          <tr>
              <td align="right" >
                   <a href="MoreAnswer.aspx?NewsID=<%=NewsID()%>&NewsTitle=<%=NewsTitle()%>"><strong>更多评论....</strong></a>&nbsp;&nbsp;<br />
                  &nbsp;</td>
          </tr>
          <tr>
              <td bgcolor="#74ECE8">                   
                  &nbsp;&nbsp;&nbsp;&nbsp;<strong>我要评论</strong>
              </td>
          </tr>
          <tr>
              <td>
              <table border="0" cellspacing="0" cellpadding="0" style="width: 637px">
                  <tr align="left" valign="top">
                    <td colspan="8" style="height: 31px">
	                <table width="600" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                            <td colspan="6" style="height: 14px">
                            <hr />
                            </td>
                        </tr>
                    <tr>
                        <td style="width: 110px" align="right">网友名称：</td>
                        <td width="113">
                            <asp:TextBox ID="TextBox1" runat="server" Width="125px" MaxLength="20"></asp:TextBox></td>
                        <td style="width: 70px" align="right">QQ：</td>
                        <td width="183">
                            <asp:TextBox ID="TextBox2" runat="server" Width="125px" MaxLength="9"></asp:TextBox></td>
                        <td width="70px" align="right">E-mail:</td>
                        <td width="130px">
                            <asp:TextBox ID="TextBox3" runat="server" Width="125px" MaxLength="40"></asp:TextBox></td>
                     </tr>
                    </table>
                   </td>
                      <td colspan="1" style="width: 138px; height: 31px">
                          <br />
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                              ErrorMessage="*网友名称不能为空！" Font-Size="Small" Width="124px"></asp:RequiredFieldValidator><br />
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
                              ErrorMessage="*联系QQ不能为空！" Font-Size="Small" Width="124px"></asp:RequiredFieldValidator><br />
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3"
                              ErrorMessage="*E-mail不能为空！" Font-Size="Small" Width="124px"></asp:RequiredFieldValidator><br />
                      </td>
                  </tr>
                  <tr>
                    <td align="right" valign="top" style="width: 75px">评论内容：</td>
                    <td colspan="7" align="left" valign="top">
                        <asp:TextBox ID="TextBox4" runat="server" Height="87px" Width="522px" MaxLength="100"></asp:TextBox></td>
                      <td align="left" colspan="1" valign="top" style="width: 138px">
                          <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4"
                              ErrorMessage="*评论内容不能为空！" Font-Size="Small" Width="124px"></asp:RequiredFieldValidator><br />
                          <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox2"
                              ErrorMessage="*QQ号只能为数字！" Font-Size="Small" ValidationExpression="^[0-9]+$" Width="137px"></asp:RegularExpressionValidator><br />
                          <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox3"
                              ErrorMessage="＊E-mail格式不正确！" Font-Size="Small" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                              Width="137px"></asp:RegularExpressionValidator></td>
                  </tr>
                  <tr>
                    <td style="width: 75px; height: 12px">&nbsp;</td>
                    <td width="68" style="height: 12px">&nbsp;</td>
                    <td width="78" style="height: 12px">
                        <asp:Button ID="btn_Answer" runat="server" OnClick="btn_Answer_Click" Text="提交评论" /></td>
                    <td width="78" style="height: 12px">&nbsp;</td>
                    <td width="78" style="height: 12px">&nbsp;</td>
                    <td width="78" style="height: 12px">&nbsp;</td>
                    <td width="78" style="height: 12px">&nbsp;</td>
                    <td width="77" style="height: 12px">&nbsp;</td>
                      <td style="height: 12px; width: 138px;">
                      </td>
                  </tr>
                </table>
              </td>
          </tr>
        <tr>
          <td align="right" style="height: 16px"><A onclick="javascript:window.open('pinglun.asp?id=','','width=295,height=185,toolbar=no, status=no, menubar=no, resizable=yes, scrollbars=no');return false;"
											href="#"></A> &nbsp;| <IMG height="14" src="images/printer.gif" width="16" align="absMiddle">
										<A href="javascript:window.print()">打印本页</A> | <IMG height="14" src="images/close.gif" width="14" align="absMiddle">
										<A href="javascript:window.close()">关闭窗口</A></td>
        </tr>
        <tr>
          <td colSpan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>本站发表读者评论，并不代表我们赞同或者支持读者的观点。我们的立场仅限于传播更多读者感兴趣的信息。</b></td>
        </tr>
        <tr>
          <td>
              <uc2:bottom ID="Bottom1" runat="server" />
          </td>
        </tr>
      </table>
    
    </div>
    </form>
</body>
</html>
