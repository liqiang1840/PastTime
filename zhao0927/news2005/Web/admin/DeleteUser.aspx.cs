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

public partial class Web_admin_DeleteUser : System.Web.UI.Page
{
    /// <summary>
    /// 实例化类的对象
    /// </summary>
    Model.admin Ma = new Model.admin();
    BLL.admin Ba = new BLL.admin();

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
                Ma.cid = int.Parse(Request.QueryString["cid"].ToString());
                if (Ba.DeleteAdmin(Ma))
                {
                    Response.Redirect("Admin_AllUsers.aspx");
                }
                else
                {
                    Response.Write("<script language=javascript>alert('数据库操作出错,请正确操作！')</script>");
                }
            }
        }
    }
}
