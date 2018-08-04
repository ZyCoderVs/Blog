using Blog.Utilties;
using System.Web.Mvc;

namespace Blog.WebApp.Controllers
{
    [ExceptionFilters(View ="Error")]
    [SecurityActionFilter]
    public class BaseController: Controller
    {
    }
}