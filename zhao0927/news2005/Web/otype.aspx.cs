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

public partial class Web_otype : System.Web.UI.Page
{
    /// <summary>
    /// 实例化类的对象
    /// </summary>
    BLL.BigClass B_bc = new BLL.BigClass();
    Model.BigClass M_bc = new Model.BigClass();

    BLL.news B_news = new BLL.news();
    Model.news M_news = new Model.news();

    /// <summary>
    /// 全局变量
    /// </summary>
    protected int pagesize;
    public int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Request.QueryString["sort"].ToString() != null)
            {
                Session["id"] = Request.QueryString["sort"].ToString();
                DataBindcsort();
                M_news.BigClassID = int.Parse(Session["id"].ToString());
                Repeater1.DataSource = B_news.GetDataByBigClass(M_news.BigClassID);
                Repeater1.DataBind();
            }
            else
            {
                Response.Write("<script language=javascript>alert('数据库操作有错误!');");
                Response.Write("window.history.back();</script>");
            }
        }
    }

    #region 动态获取栏目名称
    /// <summary>
    /// 动态获取栏目名称
    /// </summary>
    public void DataBindcsort()
    {
        M_bc.id = Convert.ToInt32(Session["id"].ToString());
        if (B_bc.GetBigClassByID(M_bc.id).Tables[0].Rows.Count>0)
        {
            this.csort.Text = B_bc.GetBigClassByID(M_bc.id).Tables[0].Rows[0][1].ToString();
            this.csort.Font.Bold = true;
            this.Title = B_bc.GetBigClassByID(M_bc.id).Tables[0].Rows[0][1].ToString() + "专题栏目----";
        }
    }
    #endregion
}
