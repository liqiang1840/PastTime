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

public partial class Web_admin_Admin_EditUser : System.Web.UI.Page
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
            if (Request.QueryString["cid"] == null)
            {
                Response.Write("<script language=javascript>alert('数据库操作出错,请正确操作！')</script>");
            }
            else
            {
                DataBindText(int.Parse(Request.QueryString["cid"].ToString()));
            }
        }
    }

    /// <summary>
    /// 绑定数据项
    /// </summary>
    /// <param name="id"></param>
    public void DataBindText(int id)
    {
        //根据id获取数据集合
        DataSet ds = Ba.QueryUserInfoByID(id);
        //绑定数据到控件上
        this.UserCid.Text = ds.Tables[0].Rows[0][0].ToString();
        this.UserName.Text = ds.Tables[0].Rows[0][1].ToString();
        this.UserPwd.Text = ds.Tables[0].Rows[0][2].ToString();
        this.UserEmail.Text = ds.Tables[0].Rows[0][3].ToString();
    }
    protected void Btn_OK_Click(object sender, EventArgs e)
    {
        Ma.cid = int.Parse(this.UserCid.Text.Trim());
        Ma.username = this.UserName.Text.Trim();
        Ma.password = FormsAuthentication.HashPasswordForStoringInConfigFile(this.UserPwd.Text.Trim(),"MD5");
        Ma.useremail = this.UserEmail.Text.Trim();
        Ma.aleave = this.UserAleave.SelectedValue.Trim();
        if (Ba.UpdateUserInfo(Ma))
        {
            Response.Redirect("Admin_AllUsers.aspx");
        }
    }
}
