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
            User user = new User
            {
                UserName = "张宇1"
            };
            bool b= _bll.Add(user);
            List<User>list= _bll.GetUsers();
            return View();
            //HttpContext rq = System.Web.HttpContext.Current;
            //ViewBag.Total=(int)rq.Application["OnLineCount"];
            //ViewBag.Test = _bll.Get();
            //return View();
        }
    }
}