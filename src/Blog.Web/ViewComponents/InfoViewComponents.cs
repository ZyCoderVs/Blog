using BlogCore.EFWork.Infrastructure;
using BlogCore.EFWork.IRepository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Blog.Web.ViewComponents
{
    public class InfoViewComponent : ViewComponent
    {
        private readonly IUserRepository _userRepository;

        public InfoViewComponent(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var info = _userRepository.Login("1056805316@qq.com", "950729");
            return View(info);
        }
    }
}
