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

public partial class Web_admin_Admin_answer : System.Web.UI.Page
{
    /// <summary>
    /// 实例化类的对象
    /// </summary>
    BLL.answer Ba = new BLL.answer();
    SQLServerDAL.FomatString fs = new SQLServerDAL.FomatString();
    BLL.news B_news = new BLL.news();
    Model.answer Ma = new Model.answer();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("Admin_Login.aspx");
            }
            DataBindAnswer();
            DataBindDList();

            DeleteAll.Attributes.Add("onclick", "return  confirm('您真的要删除全部记录吗？')"); 
        }
    }

    /// <summary>
    /// 绑定新闻现有ID
    /// </summary>
    public void DataBindDList()
    {
        this.DLnewsID.DataSource = B_news.GetNewsID();
        this.DLnewsID.DataTextField = "id";
        this.DLnewsID.DataValueField = "id";
        this.DLnewsID.DataBind();
    }

    /// <summary>
    /// 初始化数据
    /// </summary>
    public void DataBindAnswer()
    {
        this.GridView1.DataSource = Ba.GetAllAnswer();
        this.GridView1.DataBind();
    }

    /// <summary>
    /// 字符串截取方法
    /// </summary>
    /// <param name="str">原字符串</param>
    /// <param name="len">要截取的长度</param>
    /// <returns>截取后的字符串</returns>
    public string CutString(string str, int len)
    {
        return fs.CutString(str, len);
    }

    protected void SelectAll_Click(object sender, EventArgs e)
    {
        foreach (GridViewRow gvr in GridView1.Rows)
        {
            CheckBox cb = (CheckBox)gvr.Cells[0].FindControl("CheckBox1");
            if (cb.Checked)
            {
            }
            else
            {
                cb.Checked = true;
            }
        }
    }

    protected void SelectByNewID_Click(object sender, EventArgs e)
    {
        Ma.newID = int.Parse(this.DLnewsID.SelectedValue.ToString());
        this.GridView1.DataSource = Ba.GetALLAnswerByNewsID(Ma.newID);
        this.GridView1.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataBindAnswer();
        Response.Redirect("Admin_answer.aspx");
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
        this.GridView1.PageIndex = e.NewPageIndex;
    }

    protected void DeleteAll_Click(object sender, EventArgs e)
    {
        Ma.newID = int.Parse(this.DLnewsID.SelectedValue.ToString());
        Ba.DeleteAllByNewsID(Ma);
    }
    protected void DeleteCheck_Click(object sender, EventArgs e)
    {
        bool F = false;
        foreach (GridViewRow gvr in GridView1.Rows)
        {
            CheckBox cb = (CheckBox)gvr.Cells[0].FindControl("CheckBox1");
            if (cb.Checked)
            {
                //Ma.newID = int.Parse(gvr.Cells[1].Text.ToString());
                F = true;
            }
        }
        if (!F)
        {
            Response.Write("<script language=javascript>alert('你没有现在任何项！')</script>");
        }
    }
}
