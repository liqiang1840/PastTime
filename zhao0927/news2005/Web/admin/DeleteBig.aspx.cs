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

public partial class Web_admin_DeleteBig : System.Web.UI.Page
{
    /// <summary>
    /// 实例化类的对象
    /// </summary>
    Model.BigClass Mb = new Model.BigClass();
    BLL.BigClass Bb = new BLL.BigClass();
    Model.news M_news = new Model.news();
    BLL.news B_news = new BLL.news();
    Model.answer M_answer = new Model.answer();
    BLL.answer B_answer = new BLL.answer();

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
                Mb.id = int.Parse(Request.QueryString["cid"].ToString());
                M_news.BigClassID = int.Parse(Request.QueryString["cid"].ToString());
                M_answer.newID = int.Parse(Request.QueryString["cid"].ToString());

                //删除新闻栏目
                if (Bb.DeleteBigClassByID(Mb))
                {
                    //删除新闻栏目的同时删除该栏目对于的新闻信息及该新闻的全部评论信息
                    if (B_news.DeleteNewsByBigClassID(M_news)&&B_answer.DeleteAllByNewsID(M_answer))
                    {
                        Response.Redirect("Admin_BigClass.aspx");
                    }
                    else
                    {
                        Response.Write("<script language=javascript>alert('数据库操作出错,请正确操作！')</script>");
                    }
                }
                else
                {
                    Response.Write("<script language=javascript>alert('数据库操作出错,请正确操作！')</script>");
                }
            }
        }
    }
}
