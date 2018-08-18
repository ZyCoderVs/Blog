using BlogCore.EFWork.Entity;
using BlogCore.EFWork.Infrastructure;
using BlogCore.EFWork.IRepository;
using BlogCore.EFWork.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace Blog.Web.Areas.Admin.Controllers
{
    [Authentication]
    public class ArticleController : BaseController
    {
        private readonly IArticleRepository _articleRepository;
        private readonly IMenuRepository _menuRepository;
        public ArticleController(IArticleRepository articleRepository,IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
            _articleRepository = articleRepository;
        }
        public IActionResult Index()
        {
            ViewBag.MenuList = _menuRepository.GetMenus();
            return View();
        }

        [HttpPost]
        public IActionResult DocView(GridPage gridPage, string keyWord,string menuId)
        {
            var list = _articleRepository.GetArticlesPage(ref gridPage, keyWord,menuId);
            ViewBag.List = list;
            ViewBag.Page = gridPage;
            ViewBag.PageList = PageHelper.GetPageList(gridPage.Page, gridPage.Total, 10);
            return View();
        }

        public IActionResult ArtForm(int id)
        {
            ViewBag.Menus= _menuRepository.GetMenus();
            Article article = _articleRepository.GetArticle(id);
            return View(article);
        }

        [HttpPost]
        public IActionResult ArtAdd(Article Article)
        {
            Request.Cookies.TryGetValue("lang", out string info);
            var user = JsonConvert.DeserializeObject<User>(info);
            Article.UserId = user.Id;
            if (Article.Id == 0)
                Article.CreateTime = DateTime.Now;
            bool b = _articleRepository.AddArt(Article);
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
        public IActionResult ArtDelete(int id)
        {
            var b = _articleRepository.Delete(id);
            if (b)
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