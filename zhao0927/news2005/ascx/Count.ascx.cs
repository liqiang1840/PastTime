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

public partial class ascx_Count : System.Web.UI.UserControl
{
    /// <summary>
    /// 实例化类的对象
    /// </summary>
    BLL.BigClass Bb = new BLL.BigClass();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            GetBigClass();
            GetNewsCount();
        }
    }

    /// <summary>
    /// 获取栏目名称
    /// </summary>
    public void GetBigClass()
    {
        this.Repeater1.DataSource = Bb.GetBigClass();
        this.Repeater1.DataBind();
    }

    /// <summary>
    /// 获取栏目下的新闻总条数
    /// </summary>
    public void GetNewsCount()
    {
        this.Repeater2.DataSource = Bb.GetNewsCount();
        this.Repeater2.DataBind();
    }
}
