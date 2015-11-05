using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace zhao0927
{
    public abstract  class PageBase : System.Web.UI.Page
    {
        public string GetQueryString(string key, string defaultValue = "")
        {
            if (Page.RouteData.Values.Keys.Contains(key))
                return Page.RouteData.Values[key].ToString();
            else if(string.IsNullOrWhiteSpace(Request.QueryString[key]))
                return Request.QueryString[key];
            else
                return defaultValue;
        }
    }
}