using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace cs_mvc_01
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
