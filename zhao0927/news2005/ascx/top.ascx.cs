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

public partial class ascx_top : System.Web.UI.UserControl
{
    /// <summary>
    /// 实例花接口层类BigClass的对象B_bc
    /// </summary>
    BLL.BigClass B_bc = new BLL.BigClass();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            DataSet sortDS = B_bc.GetBigClass();
            string content = "";
            for (int i = 0; i < sortDS.Tables[0].DefaultView.Count; i++)
            {
                content = content + "<td align='center' onmouseover=this.bgColor='#FFFFFF'; onmouseout=this.bgColor='#CCCCCC'; bgColor='#cccccc'>";
                content = content + "<a href='otype.aspx?sort=" + sortDS.Tables[0].Rows[i][0].ToString() + "'>" + sortDS.Tables[0].Rows[i][1].ToString() + "</a></td>";
            }
            sort.Text = content;
        }
    }
}
