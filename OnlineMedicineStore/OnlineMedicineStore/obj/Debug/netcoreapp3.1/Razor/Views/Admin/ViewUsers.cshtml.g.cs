#pragma checksum "H:\Online Medicine Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\ViewUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a97ef9d442c0d71d6e73d6e8c05f3eabc1ceda38"
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
#line 1 "H:\Online Medicine Store\OnlineMedicineStore\OnlineMedicineStore\Views\_ViewImports.cshtml"
using OnlineMedicineStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a97ef9d442c0d71d6e73d6e8c05f3eabc1ceda38", @"/Views/Admin/ViewUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"391fa6e976a60afa56be1d9c34779fd3d90d85a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ViewUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineMedicineStore.Models.ApplicationUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "H:\Online Medicine Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\ViewUsers.cshtml"
  
    Layout = "_AdminLayout";
    ViewData["Title"] = "View Users";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>View All Users</h1>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "H:\Online Medicine Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\ViewUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "H:\Online Medicine Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\ViewUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "H:\Online Medicine Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\ViewUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "H:\Online Medicine Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\ViewUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "H:\Online Medicine Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\ViewUsers.cshtml"
           Write(Html.DisplayNameFor(model => model.ContactNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "H:\Online Medicine Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\ViewUsers.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "H:\Online Medicine Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\ViewUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "H:\Online Medicine Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\ViewUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "H:\Online Medicine Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\ViewUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "H:\Online Medicine Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\ViewUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "H:\Online Medicine Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\ViewUsers.cshtml"
               Write(Html.DisplayFor(modelItem => item.ContactNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 55 "H:\Online Medicine Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\ViewUsers.cshtml"
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
