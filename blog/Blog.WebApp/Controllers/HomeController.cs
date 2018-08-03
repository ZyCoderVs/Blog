using Blog.Business.IBLL;
using System.Web;
using System.Web.Mvc;

namespace Blog.WebApp.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ITestBLL _bll;
        public HomeController(ITestBLL bll)
        {
            this._bll = bll;
        }
        public ActionResult Index()
        {
            throw new System.Exception();
            //HttpContext rq = System.Web.HttpContext.Current;
            //ViewBag.Total=(int)rq.Application["OnLineCount"];
            //ViewBag.Test = _bll.Get();
            //return View();
        }
    }
}