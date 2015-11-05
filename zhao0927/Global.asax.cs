using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace zhao0927
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);
        }

       public static void RegisterRoutes(RouteCollection routeCollection)
        {
            routeCollection.MapPageRoute("RouteForCustomer", "Context/{name}", "~/Context.aspx");
            //可以使用上面的，但是最好使用下面的，这样可以限制Id为数字
            //routeCollection.MapPageRoute("RouteForCustomer", "Customer/{Id}", "~/Customer.aspx", true, null, newRouteValueDictionary(new { Id = "\\d+" }));
        }
    }
}