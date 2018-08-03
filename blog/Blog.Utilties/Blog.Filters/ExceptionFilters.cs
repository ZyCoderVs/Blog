using System.Web.Mvc;

namespace Blog.Utilties
{
    public class ExceptionFilters: HandleErrorAttribute
    {
        private readonly LogHelper _log = LogFactory.GetLogger(typeof(ExceptionFilters));
        public override void OnException(ExceptionContext filterContext)
        {
            if (!filterContext.ExceptionHandled)
            {
                string controllerName = (string)filterContext.RouteData.Values["controller"];
                string actionName = (string)filterContext.RouteData.Values["action"];
                HandleErrorInfo model = new HandleErrorInfo(filterContext.Exception, controllerName, actionName);
                _log.Error($"exception:{controllerName}:{actionName}");
                ViewResult result = new ViewResult
                {
                    ViewName = this.View,
                    ViewData = new ViewDataDictionary<HandleErrorInfo>(model)
                };
                filterContext.Result = result;
                filterContext.ExceptionHandled = true;
            }
        }
    }
}
