using Microsoft.AspNetCore.Mvc;
using UEditor.Core;

namespace Blog.Web.Areas.Admin.Controllers
{

    [Route("api/[controller]")] //配置路由
    public class UEditorController : Controller
    {
        private readonly UEditorService _ueditorService;

        public UEditorController(UEditorService uEditorService)
        {
            _ueditorService = uEditorService;
        }
        [HttpGet, HttpPost]
        public ContentResult Upload()
        {
            var response = _ueditorService.UploadAndGetResponse(HttpContext);
            return Content(response.Result, response.ContentType);
        }

    }
}