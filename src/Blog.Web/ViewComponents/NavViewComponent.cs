using BlogCore.EFWork.Entity;
using BlogCore.EFWork.IRepository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Web.ViewComponents
{
    public class NavViewComponent: ViewComponent
    {
        private readonly IMenuRepository _menuRepository;
        public NavViewComponent(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Menus> list = _menuRepository.GetMenus();
            ViewData["list"] = list;
            return View();
        }
    }
}
