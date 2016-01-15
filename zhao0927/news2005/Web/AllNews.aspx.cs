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

public partial class Web_AllNews : System.Web.UI.Page
{
    /// <summary>
    /// 实例化类的对象
    /// </summary>
    BLL.news B_news = new BLL.news();
    SQLServerDAL.FomatString fs = new SQLServerDAL.FomatString();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            this.Title = "赵陵铺生活社区----查看全部新闻信息！";

            this.Repeater1.DataSource = B_news.GetData_news();
            this.Repeater1.DataBind();
        }
    }

    /// <summary>
    /// 字符串截取方法
    /// </summary>
    /// <param name="str">要处理的字符串</param>
    /// <param name="len">要截取的字符长度</param>
    /// <returns>截取后的字符串</returns>
    public string cutString(string str, int len)
    {
        return fs.CutString(str, len);
    }
}
