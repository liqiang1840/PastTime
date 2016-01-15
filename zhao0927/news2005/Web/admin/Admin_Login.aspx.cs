using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Web_admin_AdminLogin : System.Web.UI.Page
{
    /// <summary>
    /// 实例化类的对象
    /// </summary>
    Model.admin Ma = new Model.admin();
    BLL.admin Ba = new BLL.admin();
  
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
        }

    }
    protected void btn_Cancel_Click(object sender, EventArgs e)
    {
        UserName.Text = "";
        PassWord.Text = "";
        this.UserName.Focus();
    }
    protected void btn_Login_Click(object sender, EventArgs e)
    {
        if (UserName.Text.Equals(""))
        {
            Response.Write("<script language=javascript>alert('请输入管理员用户名！')</script>");
        }
        if (PassWord.Text.Equals(""))
        {
            Response.Write("<script language=javascript>alert('请输入管理员密码！')</script>");
        }
        Ma.username = UserName.Text.Trim();
        Ma.password = FormsAuthentication.HashPasswordForStoringInConfigFile(PassWord.Text.Trim(), "MD5");
        if (Ba.ReRowCount(Ma) > 0)
        {
            Session["admin"] = UserName.Text.Trim();
            Response.Redirect("Admin_Index.aspx");
        }
        else
        {
            //Response.Write("<script language=javascript>alert('登录失败,请从新登录！')</script>");
            //this.Error.Text = "登录失败,请从新登录！";
            Response.Redirect("Admin_Login.aspx");
        }
    }
}
