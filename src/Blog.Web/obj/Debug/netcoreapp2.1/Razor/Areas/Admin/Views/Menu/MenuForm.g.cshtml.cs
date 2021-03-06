#pragma checksum "F:\ning\BlogCore\Blog\src\Blog.Web\Areas\Admin\Views\Menu\MenuForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26b8408604a139d578146e5acd0cf5dfa0d42d48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Menu_MenuForm), @"mvc.1.0.view", @"/Areas/Admin/Views/Menu/MenuForm.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Menu/MenuForm.cshtml", typeof(AspNetCore.Areas_Admin_Views_Menu_MenuForm))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26b8408604a139d578146e5acd0cf5dfa0d42d48", @"/Areas/Admin/Views/Menu/MenuForm.cshtml")]
    public class Areas_Admin_Views_Menu_MenuForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogCore.EFWork.Entity.Menus>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\ning\BlogCore\Blog\src\Blog.Web\Areas\Admin\Views\Menu\MenuForm.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_FrameLayout.cshtml";

#line default
#line hidden
            BeginContext(144, 85, true);
            WriteLiteral("\r\n<table class=\"insert-tab\" width=\"100%\">\r\n    <input type=\"hidden\" id=\"Id\" name=\"Id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 229, "\"", 247, 1);
#line 9 "F:\ning\BlogCore\Blog\src\Blog.Web\Areas\Admin\Views\Menu\MenuForm.cshtml"
WriteAttributeValue("", 237, Model?.Id, 237, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(248, 63, true);
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"CreateTime\" name=\"CreateTime\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 311, "\"", 337, 1);
#line 10 "F:\ning\BlogCore\Blog\src\Blog.Web\Areas\Admin\Views\Menu\MenuForm.cshtml"
WriteAttributeValue("", 319, Model?.CreateTime, 319, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(338, 59, true);
            WriteLiteral(" />\r\n    <input type=\"hidden\" id=\"IsDelete\" name=\"IsDelete\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 397, "\"", 421, 1);
#line 11 "F:\ning\BlogCore\Blog\src\Blog.Web\Areas\Admin\Views\Menu\MenuForm.cshtml"
WriteAttributeValue("", 405, Model?.IsDelete, 405, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(422, 196, true);
            WriteLiteral(" />\r\n    <tbody>\r\n        <tr>\r\n            <th><i class=\"require-red\">分类:</i></th>\r\n            <td>\r\n                <input class=\"common-text required\" id=\"menuTitle\" name=\"menuTitle\" size=\"50\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 618, "\"", 642, 1);
#line 16 "F:\ning\BlogCore\Blog\src\Blog.Web\Areas\Admin\Views\Menu\MenuForm.cshtml"
WriteAttributeValue("", 626, Model?.MenuName, 626, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(643, 227, true);
            WriteLiteral(" type=\"text\" />\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <th><i class=\"require-red\">标识:</i></th>\r\n            <td>\r\n                <input class=\"common-text required\" id=\"menuCode\" name=\"menuCode\" size=\"50\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 870, "\"", 894, 1);
#line 22 "F:\ning\BlogCore\Blog\src\Blog.Web\Areas\Admin\Views\Menu\MenuForm.cshtml"
WriteAttributeValue("", 878, Model?.MenuCode, 878, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(895, 211, true);
            WriteLiteral(" type=\"text\" />\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <th>内容：</th>\r\n            <td><textarea name=\"menuDesc\" class=\"common-textarea\" id=\"menuDesc\" cols=\"20\" style=\"width: 98%;\" rows=\"10\">");
            EndContext();
            BeginContext(1107, 15, false);
#line 27 "F:\ning\BlogCore\Blog\src\Blog.Web\Areas\Admin\Views\Menu\MenuForm.cshtml"
                                                                                                                   Write(Model?.MenuDesc);

#line default
#line hidden
            EndContext();
            BeginContext(1122, 1090, true);
            WriteLiteral(@"</textarea></td>
        </tr>
        <tr>
            <th></th>
            <td>
                <input class=""btn btn-primary btn6 mr10"" onclick=""saveMenu()"" value=""提交"" type=""button"" />
            </td>
        </tr>
    </tbody>
</table>

<script type=""text/javascript"">
    function saveMenu() {
        var model = {
            MenuName: $(""#menuTitle"").val(),
            MenuCode: $(""#menuCode"").val(),
            MenuDesc: $(""#menuDesc"").val(),
            Id:$(""#Id"").val()
        };
        if (model.MenuName == """") {
            layer.alert('请输入分类名称', {
                icon: 0
            });
            return;
        }
        if (model.MenuCode == """") {
            layer.alert('请输入分类标识', {
                icon: 0
            });
            return;
        }
        $.post(""/Admin/Menu/MenuAdd"", model, function (data) {
            layer.alert(data.msg, {
                icon: data.code
            });
            setTimeout(function () {
                pare");
            WriteLiteral("nt.getData();\r\n            }, 500);\r\n        });\r\n    }\r\n</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogCore.EFWork.Entity.Menus> Html { get; private set; }
    }
}
#pragma warning restore 1591
