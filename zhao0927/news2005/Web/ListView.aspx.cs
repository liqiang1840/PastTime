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
using System.Text.RegularExpressions;

public partial class Web_ListView : System.Web.UI.Page
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
        if (!IsPostBack)
        {
            if (Request.QueryString["cid"] != null)
            {
                //操作新闻
                ViewState["cid"] = Request.QueryString["cid"];
                M_news.id = int.Parse(Request.QueryString["cid"].ToString());
                B_news.UpdateHits(M_news.id);
                DataBindNews();

                //设置本页标题
                this.Title = NewsTitle();

                //操作评论
                M_answer.newID = M_news.id;
                DataBindAnswer(M_answer.newID);
                //GetAnswerCindexByNewsID(M_answer.newID);
            }
            else
            {
                Response.Write("<script language=javascript>alert('数据库操作有错误!');");
                Response.Write("window.history.back();</script>");
            }
        }
    }

    /// <summary>
    /// 根据当前新闻ID获取新闻的标题
    /// </summary>
    /// <returns></returns>
    public string NewsTitle()
    {
        return B_news.DataBindNews(int.Parse(ViewState["cid"].ToString())).Tables[0].Rows[0][1].ToString();
    }

    /// <summary>
    /// 根据当前新闻ID获取该新闻的评论总数
    /// </summary>
    /// <param name="NewsID">新闻ID</param>
    /// <returns>评论总数</returns>
    public string GetAnswerCindexByNewsID(int NewsID)
    {
        return B_answer.GetCindexByNewsID(NewsID).Tables[0].Rows[0][0].ToString();
    }

    /// <summary>
    /// 获取当前新闻的ID
    /// </summary>
    /// <returns>新闻ID字符串</returns>
    public string NewsID()
    {
        return ViewState["cid"].ToString();
    }

    /// <summary>
    /// 给控件绑定新闻的数据源
    /// </summary>
    public void DataBindNews()
    {
        DataSet ds = B_news.DataBindNews(M_news.id);
        this.repeater1.DataSource = ds;
        this.repeater1.DataBind();
        ds.Clear();
        ds.Dispose();
    }

    /// <summary>
    /// 绑定评论数据到控件
    /// </summary>
    /// <param name="newsID">新闻ID</param>
    public void DataBindAnswer(int  newsID)
    {
        DataSet ds = B_answer.GetAnswerByNewsID(newsID);
        this.Repeater2.DataSource = ds;
        this.Repeater2.DataBind();
        ds.Clear();
        ds.Dispose();
    }

    public string checkcontent(string content)
    {
        //content = @content;
        content = Regex.Replace(content, @"&amp;nbsp;", @" ");
        content = Regex.Replace(content, @"&amp;", @"&");
        content = Regex.Replace(content, @"&lt;", @"<");
        content = Regex.Replace(content, @"&gt;", @">");
        content = Regex.Replace(content, @"&quot;", @"'");
        content = Regex.Replace(content, @"../../uppic/", @"../Web/uppic/");
        return content;
    }

    protected void btn_Answer_Click(object sender, EventArgs e)
    {
        M_answer.A_user = this.TextBox1.Text.Trim();
        M_answer.A_qq = this.TextBox2.Text.Trim();
        M_answer.A_email = this.TextBox3.Text.Trim();
        M_answer.A_word = this.TextBox4.Text.Trim();
        M_answer.A_time = System.DateTime.Now.ToString();
        M_answer.newID = int.Parse(ViewState["cid"].ToString());
        if (B_answer.AddAnswerByNewsID(M_answer))
        {
            Response.Write("<script language=javascript>alert('添加评论成功！');");
        }
        else
        {
            Response.Write("<script language=javascript>alert('添加评论失败！');");
        }
        //从载新闻评判信息
        DataBindAnswer(M_answer.newID);
        //清空文本控件的值
        this.TextBox1.Text = "";
        this.TextBox1.Focus();
        this.TextBox2.Text = "";
        this.TextBox3.Text = "";
        this.TextBox4.Text = "";
    }
}
