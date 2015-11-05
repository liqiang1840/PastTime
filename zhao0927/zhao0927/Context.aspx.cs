using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Zhao.Domain;

namespace zhao0927
{
    public partial class Context : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string id = GetQueryString("name");
                if (string.IsNullOrWhiteSpace(id))
                    { id = "1"; }


                NewsLogic logic = new NewsLogic();
                var one = logic.GetNews(HttpRuntime.AppDomainAppPath, id);
            }
        }
    }
}