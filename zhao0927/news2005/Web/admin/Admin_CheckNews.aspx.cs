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

public partial class Web_admin_Admin_CheckNews : System.Web.UI.Page
{
    BLL.news B_news = new BLL.news();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("Admin_Login.aspx");
            }
            if (GetDS().Tables[0].Rows.Count > 0)
            {
                this.Label8.Visible = false;
            }
            else
            {
                this.Label8.Visible = true;
            }
            LoadData();
        }
    }

    /// <summary>
    /// 初始化数据
    /// </summary>
    public void LoadData()
    {
        this.GridView1.DataSource = B_news.GetNewsOfFlag0();
        this.GridView1.DataBind();
    }
    /// <summary>
    /// 获取没有通过审核的数据集合
    /// </summary>
    /// <returns></returns>
    public DataSet GetDS()
    {
        return B_news.GetNewsOfFlag0();
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
