<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MoreAnswer.aspx.cs" Inherits="Web_MoreAnswer" %>

<%@ Register Src="../ascx/top.ascx" TagName="top" TagPrefix="uc1" %>
<%@ Register Src="../ascx/bottom.ascx" TagName="bottom" TagPrefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
        <table width="600px">
            <tr>
                <td colspan="3" style="width: 285px">
                    <uc1:top ID="Top1" runat="server" />
                </td>
            </tr>
            <tr>
                <td colspan="3" style="width: 95%" bgColor="#f3f3f3">
                <asp:Repeater ID="Repeater2" runat="server">
                  <ItemTemplate>
                     <table width="95%" border="0" cellspacing="0" cellpadding="0">
                     <tr><hr /></tr>
                     <tr><td colspan="8">
                     <table width="100%" border="0" cellspacing="0" cellpadding="0">
                      <tr>
                        <td width="55" align="center">留言用户:</td>
                        <td width="60" align="left"><%#DataBinder.Eval(Container.DataItem,"A_user")%>
                        <td width="55" align="center">留言时间:</td>
                        <td width="60" align="left"><%#Convert.ToDateTime(DataBinder.Eval(Container.DataItem, "A_time")).ToShortDateString()%></td>
                        <td width="55" align="center">QQ:</td>
                        <td width="60" align="left"><%#DataBinder.Eval(Container.DataItem,"A_qq")%>
                        <td width="55" align="center">E-mail:</td>
                        <td width="90" align="left"><a href="mailto:<%#DataBinder.Eval(Container.DataItem,"A_email")%>"><%#DataBinder.Eval(Container.DataItem,"A_email")%></a></td>
                        <td width="150" align="right">第<font color="#FF0000"><%#DataBinder.Eval(Container.DataItem,"cindex")%></font>楼</td>
                      </tr>
                      </table>
                      </td></tr>
                      <tr><td colspan="8"><hr /></td></tr>
                      <tr>
                        <td width="70" align="left" valign="top">留言内容:</td>
                        <td colspan="7"><div align="left" valign="top"><%#DataBinder.Eval(Container.DataItem,"A_word")%></div></td>
                      </tr>
                      <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                      </tr>
                    </table>
                  </ItemTemplate>
                  </asp:Repeater>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td colspan="3" style="width: 285px">
                    <uc2:bottom ID="Bottom1" runat="server" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
