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

public partial class Web_admin_Default2 : System.Web.UI.Page
{
    /// <summary>
    /// 实例化类的对象
    /// </summary>
    BLL.BigClass B_bc = new BLL.BigClass();
    BLL.news B_news = new BLL.news();
    SQLServerDAL.FomatString fs = new SQLServerDAL.FomatString();
    Model.news M_news = new Model.news();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("Admin_Login.aspx");
            }

            DataSet sortDS = B_bc.GetBigClass();
            string content = "";
            for (int i = 0; i < sortDS.Tables[0].DefaultView.Count; i++)
            {
                content = content + "<td align='center' onmouseover=this.bgColor='#FFFFFF'; onmouseout=this.bgColor='#CCCCCC'; bgColor='#cccccc'>";
                content = content + "<a href='Admin_NewsList.aspx?sort=" + sortDS.Tables[0].Rows[i][0].ToString() + "'>" + "<font size=2 color='#000000'>" + sortDS.Tables[0].Rows[i][1].ToString() + "</font> "+"</a></td>";
            }
            content = content + "<td align='center' onmouseover=this.bgColor='#FFFFFF'; onmouseout=this.bgColor='#CCCCCC'; bgColor='#cccccc'>";
            content = content + "<a href='Admin_NewsList.aspx'>" + "<font size=2 color='#000000'>从新排序"  + "</font>" + "</a></td>";
            BigClass.Text = content;

            //分栏目获取新闻列表
            if (Request.QueryString["sort"] == null)
            {
                LoadNewInfo();
            }
            else
            {
                M_news.BigClassID = int.Parse(Request.QueryString["sort"].ToString());
                LoadNewInfo(M_news.BigClassID);
            }
        }
    }

    /// <summary>
    /// 加载数据方法
    /// </summary>
    public void LoadNewInfo()
    {
        GridView1.DataSource = B_news.GetData_news();
        GridView1.DataBind();
    }

    /// <summary>
    /// 加载数据方法
    /// </summary>
    public void LoadNewInfo(int BigClassID)
    {
        GridView1.DataSource = B_news.GetData_news(BigClassID);
        GridView1.DataBind();
    }

    /// <summary>
    /// 字符串截取方法
    /// </summary>
    /// <param name="str">要截取的字符串</param>
    /// <param name="len">要截取的字符长度</param>
    /// <returns>截取后的字符串</returns>
    public string CutString(string str, int len)
    {
        return fs.CutString(str, len);
    }

    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        //设置鼠标的指向行变效果
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "this.style.backgroundColor='#CCCCCC';this.style.color='#FFFFFF';this.style.cursor='#CCCCCC';");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor='#FFFFFF';this.style.color='#FFFFFF';");
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        this.GridView1.PageIndex = e.NewPageIndex + 1;
        LoadNewInfo();
        //this.GridView1.DataBind();
    }

    protected void QueryNews_Click(object sender, EventArgs e)
    {
        //处理模糊查询方向
        if (this.DropDownList1.SelectedValue.ToString().Equals("title"))
        {
            M_news.title = this.TextBox1.Text.Trim();
            this.GridView1.DataSource = B_news.AdminQueryByNewsTitle(M_news);
            this.GridView1.DataBind();
        }
        else
        {
            M_news.info = this.TextBox1.Text.Trim();
            this.GridView1.DataSource = B_news.AdminQueryByNewsInfo(M_news);
            this.GridView1.DataBind();
        }
    }
}
