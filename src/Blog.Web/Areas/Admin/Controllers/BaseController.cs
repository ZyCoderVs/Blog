using BlogCore.EFWork.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [ExceptionFilters]
    public class BaseController : Controller
    {
    }
}