using BlogCore.EFWork.Entity;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using NLog;

namespace BlogCore.EFWork.Infrastructure
{
    public class AuthenticationAttribute : ActionFilterAttribute
    {
        private readonly Logger _logger;
        public AuthenticationAttribute()
        {
            _logger = LogManager.GetCurrentClassLogger();
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            string area = context.RouteData.Values["area"]?.ToString();
            string controller = context.RouteData.Values["controller"]?.ToString();
            string action = context.RouteData.Values["action"]?.ToString();
            _logger.Info($"{area}:{context}:{action}");
            string cookie = context.HttpContext.Request.Cookies["lang"];
            if (string.IsNullOrWhiteSpace(cookie))
            {
                context.HttpContext.Response.Redirect("/Admin/Login");
            }
            else
            {
                var user = JsonConvert.DeserializeObject<User>(cookie);
                if (user == null)
                {
                    context.HttpContext.Response.Redirect("/Admin/Login");
                }
            }
        }
    }
}
