<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin_AllUsers.aspx.cs" Inherits="Web_admin_Admin_AllUsers" %>

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
	color: #6666FF;
}
a:link {
	text-decoration: none;
}
a:visited {
	text-decoration: none;
	color: #6666FF;
}
a:hover {
	text-decoration: none;
	color: #6666FF;
}
a:active {
	text-decoration: none;
	color: #6666FF;
}
-->
</style></head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 569px" align="center">
            <tr>
                <td align="center" style="width: 38648px; height: 5px">
                    &nbsp; 
                </td>
                <td align="center" style="width: 822px; height: 5px">
                </td>
            </tr>
            <tr>
                <td style="width: 38648px; height: 14px">
                </td>
                <td style="width: 822px; height: 14px;">
                    <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;系 统 用 户 管 理</strong></td>
            </tr>
            <tr>
                <td style="width: 38648px; height: 14px">
                </td>
                <td style="width: 822px; height: 14px">
                </td>
            </tr>
            <tr>
                <td  style="width: 38648px">
                </td>
                <td style="width: 822px">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="550px" OnRowDataBound="GridView1_RowDataBound" Height="140px">
                        <Columns>
                            <asp:TemplateField HeaderText="用户编号">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("cid") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <table align="center">
                                        <tr align="center">
                                            <td >
                                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("cid") %>'></asp:Label></td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="用户帐号">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("username") %>'></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <table align="center">
                                        <tr align="center">
                                            <td>
                                                <asp:Label ID="Label4" runat="server" Text='<%# Bind("username") %>'></asp:Label></td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="电子邮箱">
                                <ItemTemplate><table align="center">
                                    <tr align="center">
                                        <td >
                                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("email") %>'></asp:Label></td>
                                    </tr>
                                </table>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="用户权限">
                                <ItemTemplate>
                                    <table align="center">
                        <tr align="center">
                            <td>
                                    <asp:Label ID="Label6" runat="server" Text='<%# Bind("aleave") %>'></asp:Label></td>
                        </tr>
                    </table>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="修　改">
                                <ItemTemplate>
                                    <table align="center">
                                        <tr align="center">
                                            <td>
                                    <asp:Label ID="Label2" runat="server" Width="25px"><a href="Admin_EditUser.aspx?cid=<%#DataBinder.Eval(Container.DataItem,"cid")%>">修改</a></asp:Label></td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="删　除">
                                <ItemTemplate>
                                    <table align="center">
                                        <tr align="center">
                                            <td>
                                    <asp:Label ID="Label1" runat="server"><a href="DeleteUser.aspx?cid=<%#DataBinder.Eval(Container.DataItem,"cid")%>">删除</a></asp:Label></td>
                                        </tr>
                                    </table>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td style="width: 38648px">
                </td>
                <td style="width: 822px">&nbsp;
                    
              </td>
            </tr>
            <tr>
                <td style="width: 38648px">
                </td>
                <td style="width: 822px">
                    <asp:LinkButton ID="AddUserSet" runat="server" Font-Size="Small" OnClick="AddUserSet_Click">点击这里添加新的用户资料</asp:LinkButton></td>
            </tr>
            <tr>
                <td style="width: 38648px">
                </td>
                <td style="width: 822px">
                    <table id="tb" runat="server" style="width: 401px" visible="false">
                        <tr>
                            <td style="width: 119px; height: 20px">
                            </td>
                            <td style="width: 172px; height: 20px">
                                <strong>添加用户信息</strong></td>
                            <td style="width: 132px; height: 20px">
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 119px">
                                用户名称：</td>
                            <td style="width: 172px">
                                <asp:TextBox ID="UserName" runat="server" Width="117px"></asp:TextBox></td>
                            <td style="width: 132px">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UserName"
                                    ErrorMessage="＊用户名不能为空！" Font-Size="Small" Width="118px"></asp:RequiredFieldValidator></td>
                        </tr>
                        <tr>
                            <td style="width: 119px">
                            </td>
                            <td style="width: 172px">
                            </td>
                            <td style="width: 132px">
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 119px">
                                用户密码：</td>
                            <td style="width: 172px">
                                <asp:TextBox ID="UserPwd" runat="server" Width="117px"></asp:TextBox></td>
                            <td style="width: 132px">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="UserPwd"
                                    ErrorMessage="＊用户密码不能为空！" Font-Size="Small" Width="133px"></asp:RequiredFieldValidator></td>
                        </tr>
                        <tr>
                            <td style="width: 119px">
                            </td>
                            <td style="width: 172px">
                            </td>
                            <td style="width: 132px">
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 119px">
                                用户邮箱：</td>
                            <td style="width: 172px">
                                <asp:TextBox ID="UserEmail" runat="server" Width="117px"></asp:TextBox></td>
                            <td style="width: 132px">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="UserEmail"
                                    ErrorMessage="＊用户邮箱不能为空！" Font-Size="Small"></asp:RequiredFieldValidator><br />
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="UserEmail"
                                    ErrorMessage="*电子邮箱格式不正确！" Font-Size="Small" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                                    Width="138px"></asp:RegularExpressionValidator></td>
                        </tr>
                        <tr>
                            <td style="width: 119px">
                                用户权限：</td>
                            <td style="width: 172px">
                                <asp:DropDownList ID="DownListAleave" runat="server">
                                    <asp:ListItem Value="管理员">管理员</asp:ListItem>
                                    <asp:ListItem>普通用户</asp:ListItem>
                                </asp:DropDownList></td>
                            <td style="width: 132px">
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 119px">
                            </td>
                            <td style="width: 172px">
                            </td>
                            <td style="width: 132px">
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 119px">
                            </td>
                            <td style="width: 172px">
                                <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="添　加" />
                            </td>
                            <td style="width: 132px">
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    
        <p>
            &nbsp;</p>
    </div>
    </form>
</body>
</html>
