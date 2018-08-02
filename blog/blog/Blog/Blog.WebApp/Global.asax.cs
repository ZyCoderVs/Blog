using Blog.WebApp.App_Start;
using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace Blog.WebApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Application["OnLineCount"] = 0;
            AutofacConfig.Config();
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application.Lock();
            Application["OnLineCount"] = (int)Application["OnLineCount"] + 1;
            Application.UnLock();
        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application.Lock();
            Application["OnLineCount"] = (int)Application["OnLineCount"] - 1;
            Application.UnLock();
        }
    }
}
