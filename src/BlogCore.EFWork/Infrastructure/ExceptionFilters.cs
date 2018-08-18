using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NLog;

namespace BlogCore.EFWork.Infrastructure
{
    public class ExceptionFilters : ExceptionFilterAttribute
    {
        private readonly Logger _logger;
        public ExceptionFilters()
        {
            _logger = LogManager.GetCurrentClassLogger();
        }
        public override void OnException(ExceptionContext context)
        {
            string area= context.RouteData.Values["area"]?.ToString();
            string controller = context.RouteData.Values["controller"]?.ToString();
            string action = context.RouteData.Values["action"]?.ToString();
            _logger.Error($"{area}:{context}:{action}");
            context.Result = new ViewResult
            {
                ViewName= "/Views/Shared/Error.cshtml"
            };
        }


    }
}
