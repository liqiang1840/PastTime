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

public partial class Web_admin_Admin_AllUsers : System.Web.UI.Page
{
    /// <summary>
    /// 实例化类的对象
    /// </summary>
    Model.admin Ma = new Model.admin();
    BLL.admin ba = new BLL.admin();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("Admin_Login.aspx");
            }
            LoadData();
        }
    }

    /// <summary>
    /// 绑定数据－－初始化数据
    /// </summary>
    public void LoadData()
    {
        this.GridView1.DataSource = ba.GetDataAdmin();
        this.GridView1.DataBind();
    }

    protected void AddUserSet_Click(object sender, EventArgs e)
    {
        if (tb.Visible == true)
        {
            tb.Visible = false;
        }
        else
        {
            tb.Visible = true;
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Ma.username = this.UserName.Text.Trim();
        Ma.password = FormsAuthentication.HashPasswordForStoringInConfigFile(this.UserPwd.Text.Trim(),"MD5");
        Ma.useremail = this.UserEmail.Text.Trim();
        Ma.aleave = this.DownListAleave.SelectedValue.Trim();
        if (ba.AddUser(Ma))
        {
            Response.Write("<script language=javascript>alert('添加成功！')</script>");
        }
        tb.Visible = false;
        LoadData();
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "this.style.backgroundColor='#CCCCCC';this.style.color='#FFFFFF';this.style.cursor='#CCCCCC';");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor='#FFFFFF';this.style.color='#FFFFFF';");
        }
    }
}
