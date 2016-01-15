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

public partial class Web_MoreAnswer : System.Web.UI.Page
{
    Model.answer Ma = new Model.answer();
    BLL.answer B_answer = new BLL.answer();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Request.QueryString["NewsID"] == null)
            {
                Response.Write("<script language=javascript>alert(数据库操作出错！)</script>");
            }
            else
            {
                Ma.newID = int.Parse(Request.QueryString["NewsID"].ToString());
                DataBindAnswer(Ma);
                //设置评论页面的标题
                this.Title = Request.QueryString["NewsTitle"].ToString() + "的全部评论列表！";
            }
        }
    }

    /// <summary>
    /// 绑定评论数据到控件
    /// </summary>
    /// <param name="ma">实体层answer类的对象</param>
    public void DataBindAnswer(Model.answer ma)
    {
        DataSet ds = B_answer.GetALLAnswerByNewsID(ma.newID);
        this.Repeater2.DataSource = ds;
        this.Repeater2.DataBind();
        ds.Clear();
        ds.Dispose();
    }
}
