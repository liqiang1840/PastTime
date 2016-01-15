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

public partial class Web_admin_Admin_EditNews : System.Web.UI.Page
{
    Model.news M_news = new Model.news();
    BLL.news B_news = new BLL.news();
    BLL.BigClass B_bc = new BLL.BigClass();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            BindBigClass();
            Session["id"] = int.Parse(Request.QueryString["cid"].ToString());
            M_news.id = int.Parse(Request.QueryString["cid"].ToString());
            DataSet ds = B_news.DataBindNews(M_news.id);
            if (ds.Tables[0].Rows.Count > 0)
            {
                this.title.Text = ds.Tables[0].Rows[0][1].ToString();
                this.content.Text = ds.Tables[0].Rows[0][2].ToString();
                this.user.Value = ds.Tables[0].Rows[0][4].ToString();
            }

        }
    }
    protected void Btn_OK_Click(object sender, EventArgs e)
    {
        //得到页面的值
        M_news.id = int.Parse(Session["id"].ToString());
        M_news.title = this.title.Text.Trim().ToString();
        M_news.BigClassID = int.Parse(this.BigClassID.SelectedValue.Trim());
        M_news.info = this.content.Text.Trim().ToString();
        M_news.username = this.user.Value.Trim().ToString();
        //检测是否更新成功
        if (B_news.UpdateNews(M_news))
        {
            Response.Write("<script language='JavaScript'>if (confirm('按[确定]回到管理列表，按[取消]返回首页！'))");
            Response.Write("{window.location = 'Admin_NewsList.aspx';}");
            Response.Write("else {window.location = 'Default.aspx';}</script>");
        }
    }
    /// <summary>
    /// 绑定新闻类别下拉列表框
    /// </summary>
    public void BindBigClass()
    {
        DataSet ds = B_bc.GetBigClass();
        for (int i = 0; i < ds.Tables[0].DefaultView.Count; i++)
        {
            ListItem item = new ListItem();
            item.Text = ds.Tables[0].Rows[i]["name"].ToString();
            item.Value = ds.Tables[0].Rows[i]["id"].ToString();
            BigClassID.Items.Add(item);
            BigClassID.SelectedIndex = -1;
        }
    }
}