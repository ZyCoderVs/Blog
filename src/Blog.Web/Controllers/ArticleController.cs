using BlogCore.EFWork.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Controllers
{
    [ExceptionFilters]
    public class ArticleController : Controller
    {
        public IActionResult Index(int Id)
        {

            return View();
        }
    }
}