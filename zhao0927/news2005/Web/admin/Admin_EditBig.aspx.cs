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

public partial class Web_admin_Admin_EditBig : System.Web.UI.Page
{
    Model.BigClass Mb = new Model.BigClass();
    BLL.BigClass Bb = new BLL.BigClass();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Request.QueryString["cid"] == null)
            {
                Response.Write("<script language=javascript>alert('数据库操作出错,请正确操作！')</script>");
            }
            else
            {
                DataBindText(int.Parse(Request.QueryString["cid"].ToString()));
            }
        }
    }

    public void DataBindText(int id)
    {
        DataSet ds = Bb.GetBigClassByID(id);
        this.BigClassid.Text = ds.Tables[0].Rows[0][0].ToString();
        this.BigClassName.Text = ds.Tables[0].Rows[0][1].ToString();
    }
    protected void Edit_Click(object sender, EventArgs e)
    {
        Mb.id = int.Parse(this.BigClassid.Text.Trim());
        Mb.name = this.BigClassName.Text.Trim();
        Mb.flag = this.isVisble.SelectedValue.Trim();
        if (Bb.UpdateBigClassNameAndFlag(Mb))
        {
            Response.Redirect("Admin_BigClass.aspx");
        }
    }
}
