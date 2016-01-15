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

public partial class Web_Default : System.Web.UI.Page
{
    /// <summary>
    /// 实例化接口层news类的对象
    /// </summary>
    BLL.news B_news = new BLL.news();
    BLL.BigClass B_bc = new BLL.BigClass();

    SQLServerDAL.FomatString FString = new SQLServerDAL.FomatString();
    DBbase db = new DBbase();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            DataBindRepeaterNew();
            DataBindRepeaterBigClass();
            this.Title = "赵陵铺生活社区----石家庄市新华区";
            Session.Clear();
        }
    }

    /// <summary>
    /// 获取最新新闻
    /// </summary>
    public void DataBindRepeaterNew()
    {
        RepeaterNew.DataSource = B_news.GetDataEightNew();
        RepeaterNew.DataBind();
    }

    /// <summary>
    /// 获取允许显示的栏目名称集合
    /// </summary>
    public void DataBindRepeaterBigClass()
    {
        Repeater1.DataSource = B_bc.GetBigClass();
        Repeater1.DataBind();
    }

    /// <summary>
    /// 截取字符串
    /// </summary>
    /// <param name="str">要截取的字符串</param>
    /// <param name="len">要截取字符串的长度</param>
    /// <returns>截取后的字符串</returns>
    public string cutString(string str, int len)
    {
        return FString.CutString(str, len); 
    }

    protected void Repeater1_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        object cid;
        cid = DataBinder.Eval(e.Item.DataItem, "id");
        Repeater Repeater2;
        Repeater2 = (Repeater)e.Item.FindControl("Repeater2");
        string sqlnews = "select top 4 id,title,infotime,hits from news where BigClassID='" + int.Parse(cid.ToString()) + "' and flag='已审核' order by cindex";
        DataSet ds1 = db.ReturnDataSet(sqlnews);
        Repeater2.DataSource = ds1.Tables[0].DefaultView;
        Repeater2.DataBind();

    }
}
