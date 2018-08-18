using BlogCore.EFWork.IRepository;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NLog;
using System;

namespace Blog.Web.Areas.Admin.Controllers
{
    public class LoginController : BaseController
    {
        private readonly IUserRepository _userRepository;
        private readonly Logger _logger;

        public LoginController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _logger = LogManager.GetCurrentClassLogger();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string account, string userPwd)
        {
            var user = _userRepository.Login(account, userPwd);
            if (user == null)
            {
                return Ok(new
                {
                    code = 0,
                    msg = "未查询到相关用户"
                });
            }
            Response.Cookies.Append("lang", JsonConvert.SerializeObject(user), new Microsoft.AspNetCore.Http.CookieOptions
            {
                Expires=DateTime.Now.AddDays(7)
            });
            _logger.Info($"{user.Account}登陆网站");
            return Ok(new
            {
                code = 1,
                msg = "登陆成功"
            });
        }
    }
}