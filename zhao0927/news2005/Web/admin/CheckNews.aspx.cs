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

public partial class Web_admin_CheckNews : System.Web.UI.Page
{
    /// <summary>
    /// 实例化类的对象
    /// </summary>
    Model.news M_news = new Model.news();
    BLL.news B_news = new BLL.news();
    Model.BigClass M_bc = new Model.BigClass();
    BLL.BigClass B_bc = new BLL.BigClass();

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
                M_news.id = int.Parse(Request.QueryString["cid"].ToString());
                M_bc.id = int.Parse(Request.QueryString["sort"].ToString());
                //新闻通过审核的同时设置该新闻有效，既正式为系统某栏目下的新闻，切该栏目下的新闻总数＋１
                if (B_news.CheckNewsByID(M_news)&&B_bc.UpdateNewsCount(M_bc))
                {

                    //Session.Clear();
                    Response.Write("<script language=javascript>alert('审核成功,点击[确定]返回审核页面！')</script>");
                    Response.Redirect("Admin_CheckNews.aspx");
                }
                else
                {
                    Response.Write("<script language=javascript>alert('审核失败！')</script>");
                }
            }
        }
    }
}
