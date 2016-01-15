<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_CheckNews.aspx.cs" Inherits="Web_admin_Admin_CheckNews" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<style type="text/css">
<!--
body,td,th {
	font-family: 宋体;
	color: #000000;
	font-size: 12px;
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
.style1 {font-size: 12px}
-->
</style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <table border="0" cellspacing="0" cellpadding="0" style="width: 561px" align="center">
        <tr>
          <td>&nbsp; </td>
        </tr>
        <tr>
          <td><div align="center" class="style1"><strong>
              <br />
              审 核 最 新 新 闻</strong></div></td>
        </tr>
          <tr>
              <td style="height: 12px">&nbsp;
                  </td>
          </tr>
        <tr>
          <td>
              <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="540px" OnRowDataBound="GridView1_RowDataBound" Height="184px">
                  <Columns>
                      <asp:TemplateField HeaderText="编号">
                          <ItemTemplate>
                          <table align="center">
                                  <tr align="center">
                                      <td>
                                          <asp:Label ID="Label2" runat="server" Text='<%# Bind("id") %>'></asp:Label></td>
                                  </tr>
                              </table>  
                          </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField HeaderText="新闻标题">
                          <ItemTemplate>
                          <table align="center">
                                  <tr align="center">
                                      <td>
                                          <a href='../ListView.aspx?cid=<%#DataBinder.Eval(Container.DataItem,"id")%>' title="" target="_blank"><asp:Label ID="Label3" runat="server" Text='<%# Bind("title") %>'></asp:Label></a></td>
                                  </tr>
                              </table>     
                          </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField HeaderText="所属栏目">
                          <ItemTemplate>
                              <table align="center">
                                  <tr align="center">
                                  <td><a href='../otype.aspx?sort=<%#DataBinder.Eval(Container.DataItem,"BigClassID")%>' title="" target="_blank">
                                  <asp:Label ID="Label7" runat="server" Text='<%# Bind("name") %>'></asp:Label></a>
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
                                          <asp:Label ID="Label4" runat="server" Text='<%# Bind("username") %>'></asp:Label></td>
                                  </tr>
                              </table>   
                          </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField HeaderText="发布时间">
                          <ItemTemplate>
                          <table align="center">
                                  <tr align="center">
                                      <td>
                                          <asp:Label ID="Label5" runat="server" Text='<%# Convert.ToDateTime(DataBinder.Eval(Container.DataItem,"infotime")).ToShortDateString() %>'></asp:Label></td>
                                  </tr>
                              </table>      
                          </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField HeaderText="新闻状态">
                          <ItemTemplate>
                              <table align="center">
                                  <tr align="center">
                                      <td>
                              <asp:Label ID="Label1" runat="server" Text='<%# Bind("flag") %>'></asp:Label></td>
                                  </tr>
                              </table>
                          </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField HeaderImageUrl="~/Web/admin/Editor/ButtonImage/standard/editmenu.gif"
                          HeaderText="操作">
                          <ItemTemplate>
                          <table align="center">
                                  <tr align="center">
                                      <td>
                                          <a href='../admin/CheckNews.aspx?cid=<%#DataBinder.Eval(Container.DataItem,"id")%>&sort=<%#DataBinder.Eval(Container.DataItem,"BigClassID")%>'><asp:Label ID="Label6" runat="server">进行审核</asp:Label></a></td>
                                  </tr>
                              </table> 
                          </ItemTemplate>
                      </asp:TemplateField>
                  </Columns>
              </asp:GridView>
          </td>
        </tr>
          <tr>
              <td align="center" style="height: 12px">
              </td>
          </tr>
        <tr>
          <td align="center" style="height: 12px">&nbsp;<strong><asp:Label ID="Label8" runat="server" Text="没有新的新闻信息！" Font-Size="Large" Height="32px"></asp:Label></strong></td>
        </tr>
      </table>
    
    </div>
    </form>
</body>
</html>
