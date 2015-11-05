using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Zhao.Domain;

namespace zhao0927
{
    public partial class Index : System.Web.UI.Page
    {
        public News News { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                NewsLogic logic = new NewsLogic();
                News = logic.GetNews(HttpRuntime.AppDomainAppPath, "1");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string url;
            url = "Context/1";
            Response.Redirect(url);
        }

        public string GetTitle()
        {
            string title = News.Title;
            int length = 100 - title.Length;
            title = title + ": " + News.Context.Substring(0,length) + "...";
            return title;
        }
    }
}