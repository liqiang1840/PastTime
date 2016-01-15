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

public partial class Web_admin_Admin_BigClass : System.Web.UI.Page
{
    BLL.BigClass Bb = new BLL.BigClass();
    Model.BigClass Mb = new Model.BigClass();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["admin"] == null)
            {
                Response.Redirect("Admin_Login.aspx");
            }
            LoadData();
        }
    }

    public void LoadData()
    {
        this.GridView1.DataSource = Bb.GetData_BigClass();
        this.GridView1.DataBind();
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onmouseover", "this.style.backgroundColor='#CCCCCC';this.style.color='#FFFFFF';this.style.cursor='#CCCCCC';");
            e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor='#FFFFFF';this.style.color='#FFFFFF';");
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        if (this.tb_AddBigClassName.Visible == true)
        {
            this.tb_AddBigClassName.Visible = false;
        }
        else
        {
            this.tb_AddBigClassName.Visible = true;
        }
    }
    protected void AddBigClassName_Click(object sender, EventArgs e)
    {
        Mb.name = this.BigClassName.Text.Trim();
        if (Bb.AddBigClass(Mb))
        {
            Response.Write("<script language=javascript>alert('添加成功！')</script>");
        }
        this.BigClassName.Text = "";
        this.BigClassName.Focus();
        LoadData();
    }
}
