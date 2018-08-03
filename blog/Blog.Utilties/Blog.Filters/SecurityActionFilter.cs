using Blog.Utilties.Blog.Safe;
using System.Web.Mvc;

namespace Blog.Utilties.Blog.Filters
{
    public class SecurityActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.HttpContext.Request.Cookies != null)
            {
                if (SafeCheck.CookieData())
                {
                    filterContext.HttpContext.Response.Write("<script>alert('您提交的Cookie数据有恶意字符！')</script>");
                    filterContext.HttpContext.Response.End();
                }
            }

            if (filterContext.HttpContext.Request.UrlReferrer != null)
            {
                if (SafeCheck.Referer())
                {
                    filterContext.HttpContext.Response.Write("<script>alert('您提交的Referrer数据有恶意字符！')</script>");
                    filterContext.HttpContext.Response.End();
                }
            }

            if (filterContext.HttpContext.Request.RequestType.ToUpper() == "POST")
            {
                if (SafeCheck.PostData())
                {
                    filterContext.HttpContext.Response.Write("<script>alert('您提交的Post数据有恶意字符！')</script>");
                    filterContext.HttpContext.Response.End();
                }
            }

            if (filterContext.HttpContext.Request.RequestType.ToUpper() == "GET")
            {
                if (SafeCheck.GetData())
                {
                    filterContext.HttpContext.Response.Write("<script>alert('您提交的Get数据有恶意字符！')</script>");
                    filterContext.HttpContext.Response.End();
                }
            }
        }
    }
}
