#pragma checksum "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\ViewUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c7b413317842a6ebe346290533b229a6c722d97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ViewUsers), @"mvc.1.0.view", @"/Views/Admin/ViewUsers.cshtml")]
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
#nullable restore
#line 1 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\_ViewImports.cshtml"
using OnlineMedicineStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c7b413317842a6ebe346290533b229a6c722d97", @"/Views/Admin/ViewUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"391fa6e976a60afa56be1d9c34779fd3d90d85a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ViewUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineMedicineStore.Models.ApplicationUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\ViewUsers.cshtml"
  
    Layout = "_AdminLayout";
    ViewData["Title"] = "View Users";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"h1 text-center\">View All Users</h1>\r\n<hr />\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\ViewUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\ViewUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\ViewUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\ViewUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\ViewUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.ContactNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 32 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\ViewUsers.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\ViewUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\ViewUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\ViewUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\ViewUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\ViewUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.ContactNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n             \r\n            </tr>\r\n");
#nullable restore
#line 52 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\ViewUsers.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineMedicineStore.Models.ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
