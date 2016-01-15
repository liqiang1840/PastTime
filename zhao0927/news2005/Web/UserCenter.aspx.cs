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

public partial class Web_Usercenter : System.Web.UI.Page
{
    BLL.admin Ba = new BLL.admin();
    Model.admin Ma = new Model.admin();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["username"] == null)
            {
                Response.Write("<script language=javascript>alert('数据库操作出错！')</script>");
            }
            else
            {
                this.UserName.Text = Session["username"].ToString();
                this.TodayTime.Text = System.DateTime.Now.ToShortDateString().ToString();
                ViewState["name"] = Session["username"].ToString();
                DataBindUserInfo();
                this.TextBox2.Focus();
                this.Title = "用户信息中心！";
            }
        }
    }

    /// <summary>
    /// 数据初始化
    /// </summary>
    public void DataBindUserInfo()
    {
        Ma.username = ViewState["name"].ToString();
        DataSet ds = Ba.QueryUserInfoByName(Ma);
        this.email.Text = ds.Tables[0].Rows[0][3].ToString();
        this.TextBox3.Text = ds.Tables[0].Rows[0][3].ToString();
        this.aleave.Text = ds.Tables[0].Rows[0][4].ToString();
        this.TextBox1.Text = ds.Tables[0].Rows[0][1].ToString();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        if (tb.Visible)
        {
            tb.Visible = false;
        }
        else
        {
            tb.Visible = true;
        }
    }
    protected void UpdateOK_Click(object sender, EventArgs e)
    {
        Ma.username = this.TextBox1.Text.Trim();
        Ma.password = FormsAuthentication.HashPasswordForStoringInConfigFile(this.TextBox2.Text.Trim(),"MD5");
        Ma.useremail = this.TextBox3.Text.Trim();
        if (Ba.UpdateUserInfoByName(Ma))
        {
            tb.Visible = false;
            Response.Write("<script language=javascript>alert('用户信息修改成功！')</script>");
        }
    }
}
