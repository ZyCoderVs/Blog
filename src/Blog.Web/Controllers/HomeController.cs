using Blog.Web.Models;
using BlogCore.EFWork.Infrastructure;
using BlogCore.EFWork.IRepository;
using BlogCore.EFWork.Model;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Blog.Web.Controllers
{
    [ExceptionFilters]
    public class HomeController : Controller
    {
        private readonly IArticleRepository _articleRepository;
        public HomeController(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public IActionResult Index(int type, int page)
        {
            GridPage gridPage = new GridPage
            {
                Page = page <=1 ? 1 : page,
                Rows=3
            };
            var list= _articleRepository.GetArticlesPage(ref gridPage, "", type.ToString());
            ViewBag.Type = type;
            ViewBag.List = list;
            ViewBag.Page = gridPage;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
