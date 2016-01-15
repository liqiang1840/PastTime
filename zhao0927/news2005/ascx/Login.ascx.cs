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

public partial class ascx_Login : System.Web.UI.UserControl
{
    Model.admin Ma = new Model.admin();
    BLL.admin Ba = new BLL.admin();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            this.login_E.Visible = false;
        }
    }
    protected void Cancel_Click(object sender, EventArgs e)
    {
        this.UserName.Text = "";
        this.PassWord.Text = "";
        this.UserName.Focus();
    }
    protected void login_Click(object sender, EventArgs e)
    {
        Ma.username = this.UserName.Text.Trim();
        Ma.password = FormsAuthentication.HashPasswordForStoringInConfigFile(this.PassWord.Text.Trim(),"MD5");
        if (Ba.ReRowCount(Ma)>0)
        {
            Session["admin"] = Ma.username.ToString();
            Response.Redirect("../Web/admin/Admin_Index.aspx");
        }
        if (Ba.UserLogin(Ma).Tables[0].Rows.Count>0)
        {
            Session["username"] = Ma.username.ToString();
        }
        this.login_s.Visible = false;
        this.login_E.Visible = true;
        this.Label.Text = Session["username"].ToString();
    }
    protected void Login_out_Click(object sender, EventArgs e)
    {
        this.login_s.Visible = true;
        this.login_E.Visible = false;
        Session.Clear();
    }
}
