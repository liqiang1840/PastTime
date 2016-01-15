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

public partial class Web_admin_Admin_AddNews : System.Web.UI.Page
{
    BLL.BigClass B_bc = new BLL.BigClass();
    Model.news M_news = new Model.news();
    BLL.news B_news = new BLL.news();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("Admin_Login.aspx");
            }
            DataBindDrownLst();
        }
    }
    /// <summary>
    /// 绑定下拉列表框的值
    /// </summary>
    public void DataBindDrownLst()
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
    protected void Btn_OK_Click(object sender, EventArgs e)
    {
        M_news.title = this.title.Value.Trim().ToString();
        M_news.BigClassID = int.Parse(this.BigClassID.SelectedValue.Trim());
        M_news.info = this.content.Text.Trim().ToString();
        M_news.username = this.user.Value.Trim().ToString();
        if (B_news.AddNews(M_news))
        {
            Response.Write("<script language='JavaScript'>if (confirm('按[确定]继续录入，按[取消]回到管理列表'))");
            Response.Write("{window.location = 'Admin_AddNews.aspx';}");
            Response.Write("else {window.location = 'Admin_NewsList.aspx';}</script>");
        }
        else
        {
            Response.Write("<script language=javascript>alert('数据库操作有错误!');");
            Response.Write("</script>");
        }
    }
}
