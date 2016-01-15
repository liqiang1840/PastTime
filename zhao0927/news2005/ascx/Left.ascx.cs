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

public partial class ascx_Left : System.Web.UI.UserControl
{
    /// <summary>
    /// 实例化接口层news类的对象B_news
    /// </summary>
    BLL.news B_news = new BLL.news();
    SQLServerDAL.FomatString D_fstring = new SQLServerDAL.FomatString();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            this.RepHits.DataSource = B_news.GetDataTopTenHits();
            this.RepHits.DataBind(); 
        }
       // Search.Attributes.Add("onclick", " return Checktb_value()");
    }
    protected void Search_Click(object sender, EventArgs e)
    {
        if (this.tb_value.Text.Equals(""))
        {
            Response.Write("<script language=javascript>alert('请输入关键字！');</script>");
        }
        else
        {
            Response.Redirect("Search.aspx?key=" + tb_value.Text.ToString() + "&type=" + DL_Type.SelectedValue.ToString());
        }
    }
    /// <summary>
    /// 截取字符串方法
    /// </summary>
    /// <param name="str">要截取的原字符串</param>
    /// <param name="len">要截取的长度</param>
    /// <returns>截取后的字符串</returns>
    public string cutString(string str, int len)
    {
        return D_fstring.CutString(str, len);
    }
}
