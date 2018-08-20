using BlogCore.EFWork.Infrastructure;
using BlogCore.EFWork.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Controllers
{
    [ExceptionFilters]
    public class ArticleController : Controller
    {
        private readonly IArticleRepository _articleRepository;
        public ArticleController(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }
        public IActionResult Index(int id)
        {
            var info = _articleRepository.GetArticle(id);
            return View(info);
        }
    }
}