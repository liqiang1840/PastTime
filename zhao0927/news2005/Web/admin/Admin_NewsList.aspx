<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_NewsList.aspx.cs" Inherits="Web_admin_Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>管理新闻页面</title>
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
	background-image: url();
}
a {
	font-family: 宋体;
	font-size: 12px;
	color: #000000;
}
a:link {
	text-decoration: none;
	color: #3300FF;
}
a:visited {
	text-decoration: none;
	color: #3300FF;
}
a:hover {
	text-decoration: none;
	color: #3300FF;
}
a:active {
	text-decoration: none;
	color: #3300FF;
}
-->
</style></head>
<body>
    <form id="form1" runat="server">
      <table border="0" cellspacing="0" cellpadding="0" style="width: 520px" align="center">
          <tr align="center">
              <td style="width: 700px; height: 12px">
                  &nbsp;</td>
          </tr>
          <tr align="center">
              <td style="height: 12px; width: 700px;"><strong>管 理 现 有 新 闻</strong></td>
          </tr>
          <tr align="center">
              <td style="width: 700px">&nbsp;
                  
              </td>
          </tr>
        <tr align="center">
          <td style="width: 700px">&nbsp;搜索新闻列表关键字：<asp:TextBox ID="TextBox1" runat="server" Height="14px" Width="119px"></asp:TextBox>&nbsp;<asp:DropDownList
                  ID="DropDownList1" runat="server">
                  <asp:ListItem Value="title">按标题</asp:ListItem>
                  <asp:ListItem Value="info">按内容</asp:ListItem>
              </asp:DropDownList>
              <asp:Button ID="QueryNews" runat="server" Text="搜　索" OnClick="QueryNews_Click" /></td>
        </tr>
          <tr align="center">
              <td style="width: 700px">&nbsp;
                  
              </td>
          </tr>
          <tr>
              <td style="width: 700px; height: 12px;">
                  </td>
          </tr>
        <tr align="center" bgColor='#CCCCCC'>
        </tr>
      </table>
        <table width="640" border="0" cellspacing="0" cellpadding="0" align="center">
            <tr align="center">
              <asp:Label ID="BigClass" runat="server" Text="Label"></asp:Label></tr>
          </table> 
        <tr align="center">
              <td>
              
              </td>
          </tr>
          &nbsp;<tr align="center">
            <td align="center">
            
           </td>
         </tr>
        <table align="center">
        <tr align="center">
        <td align="center">
        <asp:GridView AllowPaging="True" AutoGenerateColumns="False" ID="GridView1" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowDataBound="GridView1_RowDataBound" runat="server" Width="641px">
          <Columns>
                      <asp:TemplateField HeaderText="序号">
                          <ItemTemplate>
                              <table align="center">
                                  <tr align="center">
                                      <td style="width: 16px; height: 14px">
                                      </td>
                                          <asp:Label ID="Label5" runat="server" Text='<%# Bind("id") %>' Width="12px"></asp:Label>
                                  </tr>
                              </table>
                          </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField HeaderText="信息标题">
                          <ItemTemplate>
                              <a href='../ListView.aspx?cid=<%#DataBinder.Eval(Container.DataItem,"id")%>' target="_blank"
                                  title="">
                                  <asp:Label ID="Label1" runat="server" Text='<%#CutString(DataBinder.Eval(Container.DataItem,"title").ToString(),14)%>'></asp:Label></a>
                          </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField HeaderText="所属分类">
                          <ItemTemplate>
                              <table align="center">
                                  <tr align="center">
                                      <td>
                                          <a href='../otype.aspx?sort=<%#DataBinder.Eval(Container.DataItem,"BigClassID")%>'
                                              target="_blank" title="">
                                              <asp:Label ID="Label6" runat="server" Text='<%# Bind("name") %>'></asp:Label></a>
                                      </td>
                                  </tr>
                              </table>
                          </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField HeaderText="发布者">
                          <ItemTemplate>
                              <table align="center">
                                  <tr align="center">
                                      <td>
                                          <asp:Label ID="Label4" runat="server" Text='<%# Bind("username") %>' Width="56px"></asp:Label>
                                      </td>
                                  </tr>
                              </table>
                          </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField HeaderText="点击率">
                          <ItemTemplate>
                              <table align="center">
                                  <tr align="center">
                                      <td style="width: 15px">
                                          <asp:Label ID="Label7" runat="server" Text='<%# Bind("hits") %>'></asp:Label></td>
                                  </tr>
                              </table>
                          </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField HeaderText="发布日期">
                          <ItemTemplate>
                              <table align="center">
                                  <tr align="center">
                                      <td style="width: 35px; height: 14px">
                                          <asp:Label ID="Label2" runat="server" Text='<%# Convert.ToDateTime(DataBinder.Eval(Container.DataItem,"infotime")).ToShortDateString() %>'
                                              Width="64px"></asp:Label></td>
                                  </tr>
                              </table>
                          </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField HeaderText="审核状态">
                          <ItemTemplate>
                              <table align="center">
                                  <tr align="center">
                                      <td style="width: 25px; height: 14px">
                                          <asp:Label ID="Label3" runat="server" Text='<%# Bind("flag") %>' Width="38px"></asp:Label>
                                      </td>
                                  </tr>
                              </table>
                          </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField HeaderImageUrl="~/Web/admin/Editor/ButtonImage/standard/editmenu.gif"
                          HeaderText="修改">
                          <ItemTemplate>
                              <table align="center">
                                  <tr align="center">
                                      <td style="width: 25px; height: 14px">
                                          <asp:Label ID="Label3" runat="server" ForeColor="Blue"><a href="Admin_EditNews.aspx?cid=<%# DataBinder.Eval(Container.DataItem,"id") %>">修改</a></asp:Label></td>
                                  </tr>
                              </table>
                          </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField HeaderImageUrl="~/Web/admin/Editor/ButtonImage/standard/delete.gif"
                          HeaderText="删除">
                          <ItemTemplate>
                              <table align="center">
                                  <tr align="center">
                                      <td style="width: 25px; height: 14px">
                                          <asp:Label ID="Label3" runat="server" ForeColor="Blue"><a href="DeleteNews.aspx?cid=<%# DataBinder.Eval(Container.DataItem,"id") %>">删除</a></asp:Label></td>
                                  </tr>
                              </table>
                          </ItemTemplate>
                      </asp:TemplateField>
                  </Columns>
      </asp:GridView>
        </td>
        </tr>
        </table>
    &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    </form>
</body>
</html>
