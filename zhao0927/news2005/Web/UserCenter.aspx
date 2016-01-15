<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserCenter.aspx.cs" Inherits="Web_Usercenter" %>

<%@ Register Src="../ascx/top.ascx" TagName="top" TagPrefix="uc1" %>
<%@ Register Src="../ascx/bottom.ascx" TagName="bottom" TagPrefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table align="center" style="width: 325px">
            <tr>
                <td style="height: 188px" colspan="3">
                    <uc1:top ID="Top1" runat="server" />
                </td>
            </tr>
            <tr align="center">
                <td colspan="3">
                    <table style="width: 343px">
                        <tr>
                            <td align="right">
                            </td>
                            <td align="left">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="center" colspan="2">
                                <strong>用 户 基 本 信 息</strong></td>
                        </tr>
                        <tr>
                            <td align="right">
                            </td>
                            <td align="left">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="right">
                                今天是：</td>
                            <td align="left">
                    <asp:Label ID="TodayTime" runat="server" Width="88px"></asp:Label></td>
                        </tr>
                        <tr>
                            <td align="right">
                            </td>
                            <td align="left">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="right">
                                用户名：</td>
                            <td align="left">
                                <asp:Label ID="UserName" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td align="right">
                            </td>
                            <td align="left">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="right">
                                用户油箱：</td>
                            <td align="left">
                                <asp:Label ID="email" runat="server" Width="140px"></asp:Label></td>
                        </tr>
                        <tr>
                            <td align="right">
                            </td>
                            <td align="left">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="right">
                                用户权限：</td>
                            <td align="left">
                                <asp:Label ID="aleave" runat="server"></asp:Label></td>
                        </tr>
                        <tr>
                            <td align="right">
                            </td>
                            <td align="left">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td align="right">
                            </td>
                            <td align="left">
                                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">修改注册信息</asp:LinkButton></td>
                        </tr>
                        <tr>
                            <td align="left" colspan="2">
                                <table id="tb" runat="server" style="width: 253px" visible="false">
                                    <tr>
                                        <td style="width: 74px; height: 16px">
                                        </td>
                                        <td style="width: 101px; height: 16px">
                                        </td>
                                        <td style="height: 16px">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 74px; height: 16px">
                                            用户名称：</td>
                                        <td style="width: 101px; height: 16px">
                                            <asp:TextBox ID="TextBox1" runat="server" MaxLength="12" ReadOnly="True" Width="122px"></asp:TextBox></td>
                                        <td style="height: 16px">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 74px; height: 16px">
                                        </td>
                                        <td style="width: 101px; height: 16px">
                                        </td>
                                        <td style="height: 16px">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 74px">
                                            用户密码：</td>
                                        <td style="width: 101px">
                                            <asp:TextBox ID="TextBox2" runat="server" MaxLength="12" TextMode="Password" Width="122px"></asp:TextBox></td>
                                        <td>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 74px">
                                        </td>
                                        <td style="width: 101px">
                                            &nbsp;</td>
                                        <td>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 74px">
                                            用户邮箱：</td>
                                        <td style="width: 101px">
                                            <asp:TextBox ID="TextBox3" runat="server" Width="122px"></asp:TextBox></td>
                                        <td>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 74px">
                                        </td>
                                        <td style="width: 101px">
                                        </td>
                                        <td>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 74px">
                                        </td>
                                        <td style="width: 101px">
                                            <asp:Button ID="UpdateOK" runat="server" OnClick="UpdateOK_Click" Text="确定修改" /></td>
                                        <td>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                    &nbsp;<br />
                            &nbsp;
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
