using Blog.Utilties;
using System.Web.Mvc;

namespace Blog.WebApp.Controllers
{
    [ExceptionFilters(View ="")]
    public class BaseController: Controller
    {
    }
}