<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_BigClass.aspx.cs" Inherits="Web_admin_Admin_BigClass" %>

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
	color: #6600FF;
}
a:link {
	text-decoration: none;
}
a:visited {
	text-decoration: none;
	color: #6600FF;
}
a:hover {
	text-decoration: none;
	color: #6600FF;
}
a:active {
	text-decoration: none;
	color: #6600FF;
}
-->
</style></head>
<body>
    <form id="form1" runat="server">
        <table border="0" align="center" cellpadding="0" cellspacing="0" style="width: 555px">
      <tr>
        <td style="width: 43px">&nbsp;</td>
        <td width="324"><p>
            <br />
            &nbsp;</p>
        </td>
      </tr>
      <tr>
        <td style="width: 43px">&nbsp;</td>
        <td><div align="center"><strong>管 理 新 闻 类 别<br />
        </strong></div></td>
      </tr>
      <tr>
        <td style="width: 43px">&nbsp;</td>
        <td>
            &nbsp;<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="550px" OnRowDataBound="GridView1_RowDataBound" Height="140px">
                <Columns>
                    <asp:TemplateField HeaderText="栏目编号">
                        <ItemTemplate>
                        <table align="center">
                                  <tr align="center">
                                      <td>
                                          <asp:Label ID="Label1" runat="server" Text='<%# Bind("id") %>'></asp:Label></td>
                                  </tr>
                              </table>       
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="栏目名称">
                        <ItemTemplate>
                        <table align="center">
                                  <tr align="center">
                                      <td>
                                          <asp:Label ID="Label2" runat="server" Text='<%# Bind("name") %>'></asp:Label></td>
                                  </tr>
                              </table>       
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="栏目属性">
                        <ItemTemplate>
                        <table align="center">
                                  <tr align="center">
                                      <td>
                                           <asp:Label ID="Label3" runat="server" Text='<%# Bind("flag") %>'></asp:Label></td>
                                  </tr>
                              </table>  
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="修改栏目">
                        <ItemTemplate>
                        <table align="center">
                                  <tr align="center">
                                      <td>
                                          <asp:Label ID="Label5" runat="server"><a href="Admin_EditBig.aspx?cid=<%# DataBinder.Eval(Container.DataItem,"id") %>">修改</a></asp:Label></td>
                                  </tr>
                              </table>  
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="删除栏目">
                        <ItemTemplate>
                        <table align="center">
                                  <tr align="center">
                                      <td>
                                          <asp:Label ID="Label4" runat="server"><a href="DeleteBig.aspx?cid=<%# DataBinder.Eval(Container.DataItem,"id") %>">删除</a></asp:Label></td>
                                  </tr>
                              </table>  
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </td>
      </tr>
            <tr>
                <td style="width: 43px">
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 43px">
                </td>
                <td>
                    &nbsp;</td>
            </tr>
      <tr>
        <td style="width: 43px">&nbsp;</td>
        <td>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">添加新的新闻类别</asp:LinkButton></td>
      </tr>
      <tr>
        <td colspan="2"><table width="400" border="0" cellspacing="0" cellpadding="0" id="tb_AddBigClassName" runat="server" visible="false">
          <tr>
            <td style="width: 40px">&nbsp;</td>
            <td colspan="2">&nbsp;</td>
          </tr>
          <tr>
            <td style="width: 40px">&nbsp;</td>
            <td colspan="2"><div>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;添 加 新 闻 类 别</div></td>
          </tr>
          <tr>
            <td style="width: 40px">&nbsp;</td>
            <td style="width: 63px">&nbsp;</td>
          <td width="250">&nbsp;</td>
          </tr>
          <tr>
            <td style="width: 40px">&nbsp;</td>
            <td style="width: 63px">类别名称：</td>
          <td>
              <asp:TextBox ID="BigClassName" runat="server" Width="126px">　</asp:TextBox>&nbsp;&nbsp;<asp:RequiredFieldValidator
                  ID="RequiredFieldValidator1" runat="server" ControlToValidate="BigClassName"
                  ErrorMessage="＊请输入类别名称！"></asp:RequiredFieldValidator></td>
          </tr>
          <tr>
            <td style="height: 12px; width: 40px;">&nbsp;</td>
            <td style="height: 12px; width: 63px;">&nbsp;</td>
          <td style="height: 12px">&nbsp;</td>
          </tr>
            <tr>
                <td style="height: 12px; width: 40px;">
                </td>
                <td style="height: 12px; width: 63px;">
                </td>
                <td style="height: 12px">&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="AddBigClassName" runat="server" Text="确定添加" OnClick="AddBigClassName_Click" /></td>
            </tr>
        </table></td>
        </tr>
      <tr>
        <td style="width: 43px">&nbsp;</td>
        <td>&nbsp;</td>
      </tr>
    </table>
    </form>
</body>
</html>
