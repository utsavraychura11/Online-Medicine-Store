#pragma checksum "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Order\myorder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "632cb3a3b0ab595e8448ea496ef2a77aa0c6a0ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_myorder), @"mvc.1.0.view", @"/Views/Order/myorder.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"632cb3a3b0ab595e8448ea496ef2a77aa0c6a0ca", @"/Views/Order/myorder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"391fa6e976a60afa56be1d9c34779fd3d90d85a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_myorder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Order\myorder.cshtml"
  
    ViewData["Title"] = "My Orderes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Order\myorder.cshtml"
  
    int no = 1;
    int i = 0;

    int j = 0;

    int k = 0;
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table"">
    <thead>
        <tr>
            <th>
                No:
            </th>

            <th>
                Ordered Medicines
            </th>
            <th></th>

            <th>
                Quantity

            </th>
            <th>
                Sub-Total

            </th>
            <th>  </th>
            <th>
                Total-Price
            </th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 45 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Order\myorder.cshtml"
         foreach (var item in ViewBag.medname)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Order\myorder.cshtml"
           Write(no);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 50 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Order\myorder.cshtml"
                  no = no + 1;
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </th>\r\n\r\n            <th>\r\n");
#nullable restore
#line 55 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Order\myorder.cshtml"
                  j = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Order\myorder.cshtml"
                 foreach (string var1 in item)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p> ");
#nullable restore
#line 58 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Order\myorder.cshtml"
                   Write(var1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
#nullable restore
#line 59 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Order\myorder.cshtml"
                  
                     j = j+ 1;
                        
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </th>\r\n            <th></th>\r\n            <th>\r\n");
#nullable restore
#line 66 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Order\myorder.cshtml"
                 for (k=0;k<j;k++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                       <p> ");
#nullable restore
#line 68 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Order\myorder.cshtml"
                      Write(ViewBag.quantity[i][k]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 69 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Order\myorder.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </th>\r\n            <th>\r\n\r\n");
#nullable restore
#line 73 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Order\myorder.cshtml"
                 for (k = 0; k < j; k++)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p>");
#nullable restore
#line 76 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Order\myorder.cshtml"
                  Write(ViewBag.cost[i][k]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 77 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Order\myorder.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </th>\r\n            <th></th>\r\n            <th>\r\n\r\n\r\n\r\n                ");
#nullable restore
#line 85 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Order\myorder.cshtml"
           Write(ViewBag.total[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 91 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Order\myorder.cshtml"
                  i = i + 1;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n");
#nullable restore
#line 96 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Order\myorder.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
