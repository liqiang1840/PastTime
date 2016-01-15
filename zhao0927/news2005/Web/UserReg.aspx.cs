using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Text;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Web_UserReg : System.Web.UI.Page
{
    Model.admin Ma = new Model.admin();
    BLL.admin Ba = new BLL.admin();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Reg_Click(object sender, EventArgs e)
    {
        Ma.username = this.UserName.Text.Trim();
        Ma.password = FormsAuthentication.HashPasswordForStoringInConfigFile(this.UserPwd1.Text.Trim(), "MD5");
        Ma.useremail = this.email.Text.Trim();
        Ma.aleave = "普通用户";
        if (Ba.AddUser(Ma))
        {
            Response.Write("<script language=javascript>alert('注册成功！')</script>");
        }
        Session["username"] = Ma.username.ToString();
        Response.Redirect("UserCenter.aspx");
    }
    protected void CheckUser_Click(object sender, EventArgs e)
    {
        Ma.username = this.UserName.Text.Trim();
        if (Ba.CheckUser(Ma) > 0)
        {
            Response.Write("<script language=javascript>alert('该用户已存在！')</script>");
        }
        else
        {
            Response.Write("<script language=javascript>alert('该用户可以注册！')</script>");
        }
        this.UserName.Text = "";
    }
}
