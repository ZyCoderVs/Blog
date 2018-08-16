using BlogCore.EFWork.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Web.ViewComponents
{
    public class NavViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Menus> list = new List<Menus>();
            list.Add(new Menus
            {
                Id=1,
                MenuName="DotNet"
            });
            list.Add(new Menus
            {
                Id = 2,
                MenuName = "Java"
            });
            ViewData["list"] = list;
            return View();
        }
    }
}
