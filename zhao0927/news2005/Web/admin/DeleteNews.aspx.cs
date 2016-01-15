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

public partial class Web_admin_DeleteNews : System.Web.UI.Page
{
    /// <summary>
    /// 实例化类的对象
    /// </summary>
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
                //执行删除操作,删除新闻及该新闻的全部评论信息
                M_news.id = int.Parse(Request.QueryString["cid"].ToString());
                M_answer.newID = int.Parse(Request.QueryString["cid"].ToString());

                if (B_news.DeleteNewByID(M_news)&&B_answer.DeleteAllByNewsID(M_answer))
                {
                    Response.Redirect("Admin_NewsList.aspx");
                }
            }
        }
    }
}
