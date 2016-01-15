<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserReg.aspx.cs" Inherits="Web_UserReg" %>

<%@ Register Src="../ascx/top.ascx" TagName="top" TagPrefix="uc1" %>
<%@ Register Src="../ascx/bottom.ascx" TagName="bottom" TagPrefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>新用户注册页面</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table align="center">
            <tr>
                <td colspan="3">
                    <uc1:top ID="Top1" runat="server" />
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <table align="center">
                        <tr>
                            <td align="center" colspan="3">
                                &nbsp;
                                <br />
                                <br />
                                &nbsp;<br />
                                <br />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" align="center">
                                <strong>新 用 户 注 册</strong></td>
                        </tr>
                        <tr>
                            <td style="width: 151px">
                            </td>
                            <td style="width: 142px">
                            </td>
                            <td style="width: 139px">
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 151px">
                                <strong>用户名称：</strong><br />
                                注册用户名由大小写字母、数字长度限制为3－12字节</td>
                            <td style="width: 142px">
                                <asp:TextBox ID="UserName" runat="server" MaxLength="12"></asp:TextBox></td>
                            <td style="width: 139px">
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="UserName"
                                    ErrorMessage="*用户名格式不正确！" ValidationExpression="^[a-zA-Z0-9]+$"></asp:RegularExpressionValidator><br />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UserName"
                                    ErrorMessage="*用户名不能为空！"></asp:RequiredFieldValidator></td>
                        </tr>
                        <tr>
                            <td style="width: 151px">
                            </td>
                            <td style="width: 142px">
                                <asp:Button ID="CheckUser" runat="server" OnClick="CheckUser_Click" Text="检测用户" /></td>
                            <td style="width: 139px">
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 151px">
                            </td>
                            <td style="width: 142px">
                            </td>
                            <td style="width: 139px">
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 151px">
                                <strong>用户密码：</strong><br />
                                请输入密码，区分大小写</td>
                            <td style="width: 142px">
                                <asp:TextBox ID="UserPwd1" runat="server"></asp:TextBox></td>
                            <td rowspan="3" style="width: 139px" valign="top">
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="UserPwd1"
                                    ControlToValidate="UserPwd2" ErrorMessage="*两次输入密码不一致！"></asp:CompareValidator>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 151px">
                            </td>
                            <td style="width: 142px">
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 151px">
                                <strong>确认密码：</strong><br />
                                请在次输入密码</td>
                            <td style="width: 142px">
                                <asp:TextBox ID="UserPwd2" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td style="width: 151px">
                            </td>
                            <td style="width: 142px">
                            </td>
                            <td rowspan="1" style="width: 139px" valign="top">
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 151px; height: 16px;">
                                <strong>电子邮箱：<br />
                                </strong>请输入有效的邮件地址,如admin@.163.com.<a href="http://mail.163.com">如果没有邮箱请先注册免费邮箱</a></td>
                            <td style="width: 142px; height: 16px;">
                                <asp:TextBox ID="email" runat="server"></asp:TextBox></td>
                            <td style="width: 139px; height: 16px;">
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="email"
                                    ErrorMessage="*电子邮箱格式不正确！" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 151px">
                            </td>
                            <td style="width: 142px">
                            </td>
                            <td style="width: 139px">
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 151px">
                            </td>
                            <td style="width: 142px">
                                <asp:Button ID="Reg" runat="server" OnClick="Reg_Click" Text="提　交" /></td>
                            <td style="width: 139px">
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 151px">
                            </td>
                            <td style="width: 142px">
                            </td>
                            <td style="width: 139px">
                                <br />
                                <br />
                                <br />
                                &nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <uc2:bottom ID="Bottom1" runat="server" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
