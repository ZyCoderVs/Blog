using BlogCore.EFWork.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Areas.Admin.Controllers
{
    [Authentication]
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}