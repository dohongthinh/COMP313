#pragma checksum "C:\Users\Huy Hoang\Desktop\Fifth semester\COMP231\Thinh\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03e15ce9ddcacff30e822a8e456467e69a61d1ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Index.cshtml", typeof(AspNetCore.Views_Cart_Index))]
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
#line 1 "C:\Users\Huy Hoang\Desktop\Fifth semester\COMP231\Thinh\Views\_ViewImports.cshtml"
using Thinh;

#line default
#line hidden
#line 2 "C:\Users\Huy Hoang\Desktop\Fifth semester\COMP231\Thinh\Views\_ViewImports.cshtml"
using Thinh.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03e15ce9ddcacff30e822a8e456467e69a61d1ad", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22f66129928de919814c3faa7630bd461a1c830e", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CartModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Huy Hoang\Desktop\Fifth semester\COMP231\Thinh\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(119, 451, true);
            WriteLiteral(@"
<h2>My Cart</h2>
<table class=""table table-hover table-striped"" style=""width:100%"">
    <thead>
        <tr>
            <th></th>
            <th>
                ProductId
            </th>
            <th>
                Product Name
            </th>
            <th>
                Product Type
            </th>
            <th>
                Go To Product Page
            </th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 27 "C:\Users\Huy Hoang\Desktop\Fifth semester\COMP231\Thinh\Views\Cart\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(619, 62, true);
            WriteLiteral("            <tr>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(682, 46, false);
#line 32 "C:\Users\Huy Hoang\Desktop\Fifth semester\COMP231\Thinh\Views\Cart\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.productCode));

#line default
#line hidden
            EndContext();
            BeginContext(728, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(796, 46, false);
#line 35 "C:\Users\Huy Hoang\Desktop\Fifth semester\COMP231\Thinh\Views\Cart\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.productName));

#line default
#line hidden
            EndContext();
            BeginContext(842, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(910, 50, false);
#line 38 "C:\Users\Huy Hoang\Desktop\Fifth semester\COMP231\Thinh\Views\Cart\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.productTypeName));

#line default
#line hidden
            EndContext();
            BeginContext(960, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1028, 45, false);
#line 41 "C:\Users\Huy Hoang\Desktop\Fifth semester\COMP231\Thinh\Views\Cart\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.productUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1073, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 44 "C:\Users\Huy Hoang\Desktop\Fifth semester\COMP231\Thinh\Views\Cart\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1128, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CartModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
