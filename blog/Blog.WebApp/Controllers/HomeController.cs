using Blog.Business.IBLL;
using Blog.Entity;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Blog.WebApp.Controllers
{
    public class HomeController : BaseController
    {
        private IUserBLL _bll;
        public HomeController(IUserBLL bll)
        {
            this._bll = bll;
        }
        public ActionResult Index()
        {
            // 控制器向页面传递数据 渲染试图
            ViewBag.Users= _bll.GetUsers();
            return View();
        }
    }
}