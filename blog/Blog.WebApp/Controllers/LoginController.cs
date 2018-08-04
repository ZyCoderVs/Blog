using Blog.Business.IBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.WebApp.Controllers
{
    public class LoginController : BaseController
    {
        private readonly IUserBLL _bll;
        public LoginController(IUserBLL bll)
        {
            this._bll = bll;
        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="userPwd"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Index(string userName,string userPwd)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                ModelState.AddModelError("", "请输入账号");
                return View();
            }
            if(string.IsNullOrWhiteSpace(userPwd))
            {
                ModelState.AddModelError("", "请输入密码");
                return View();
            }
            Entity.User user = new Entity.User
            {
                UserName = userName,
                Pwd=userPwd
            };
            bool b= _bll.Add(user);
            // 注册成功跳转到主页
            if (b)
                return RedirectToAction("Index","Home");
            ModelState.AddModelError("", "注册失败");
            return View();
        }
    }
}