using BlogCore.EFWork.Entity;
using BlogCore.EFWork.Infrastructure;
using BlogCore.EFWork.IRepository;
using BlogCore.EFWork.Model;
using Microsoft.AspNetCore.Mvc;
using NLog;
using System;

namespace Blog.Web.Areas.Admin.Controllers
{
    [Authentication]
    public class MenuController : BaseController
    {
        private readonly IMenuRepository _menuRepository;
        private readonly Logger _logger;
        public MenuController(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
            _logger = LogManager.GetCurrentClassLogger();
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DocView(GridPage gridPage,string keyWord)
        {
            var list= _menuRepository.GetMenusList(ref gridPage, keyWord);
            ViewBag.List = list;
            ViewBag.Page = gridPage;
            ViewBag.PageList = PageHelper.GetPageList(gridPage.Page, gridPage.Total, 10);
            return View();
        }

        public IActionResult MenuForm(int Id)
        {
            Menus menus = _menuRepository.GetMenu(Id);
            return View(menus);
        }

        [HttpPost]
        public IActionResult MenuAdd(Menus menus)
        {
            bool b = _menuRepository.AddOrUpdateMenu(menus);
            if (b)
            {
                return Ok(new
                {
                    code = 1,
                    msg = "添加成功"
                });
            }
            return Ok(new
            {
                code = 0,
                msg = "添加失败"
            });
        }

        [HttpPost]
        public IActionResult MenuDelete(int id)
        {
            var b= _menuRepository.Delete(id);
            if(b)
            {
                return Ok(new
                {
                    code = 1,
                    msg = "删除成功"
                });
            }
            return Ok(new
            {
                code = 0,
                msg = "删除失败"
            });
        }
    }
}