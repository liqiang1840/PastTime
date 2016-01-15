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

public partial class Web_Search : System.Web.UI.Page
{
    Model.news M_news = new Model.news();
    BLL.news B_news = new BLL.news();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //获取查询页面传递过来的查询关键字
            string key = Request.QueryString["key"].ToString();
            //获取查询页面传递过来的查询类别［新闻标题｜新闻内容］
            string type = Request.QueryString["type"].ToString();
            if (type.Equals("title"))
            {
                M_news.title = key;
                Repeater1.DataSource = B_news.QueryByNewsTitle(M_news);
                Repeater1.DataBind();
            }
            else
            {
                M_news.info = key;
                Repeater1.DataSource = B_news.QueryByNewsInfo(M_news);
                Repeater1.DataBind();
            }

            this.Title = "新闻搜索页面----查看搜索新闻列表！！";
        }
    }
}
