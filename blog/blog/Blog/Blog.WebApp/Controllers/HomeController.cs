using Blog.Business.IBLL;
using System.Web.Mvc;

namespace Blog.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITestBLL _bll;
        public HomeController(ITestBLL bll)
        {
            this._bll = bll;
        }
        public ActionResult Index()
        {
            ViewBag.Test= _bll.Get();
            return View();
        }
    }
}