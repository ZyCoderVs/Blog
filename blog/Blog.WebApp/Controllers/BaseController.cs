using Blog.Utilties.Blog.Filters;
using System.Web.Mvc;

namespace Blog.WebApp.Controllers
{
    [ExceptionFilters(View ="")]
    public class BaseController: Controller
    {
    }
}