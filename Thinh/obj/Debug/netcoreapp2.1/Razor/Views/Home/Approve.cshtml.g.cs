#pragma checksum "C:\Users\Huy Hoang\Desktop\Fifth semester\COMP231\Thinh\Views\Home\Approve.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20ac00be76058d548915e18d9a58e8bbf68709f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Approve), @"mvc.1.0.view", @"/Views/Home/Approve.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Approve.cshtml", typeof(AspNetCore.Views_Home_Approve))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20ac00be76058d548915e18d9a58e8bbf68709f4", @"/Views/Home/Approve.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22f66129928de919814c3faa7630bd461a1c830e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Approve : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Thinh.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Approve", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Huy Hoang\Desktop\Fifth semester\COMP231\Thinh\Views\Home\Approve.cshtml"
  
    ViewData["Title"] = "Approve";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(132, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(139, 28, false);
#line 7 "C:\Users\Huy Hoang\Desktop\Fifth semester\COMP231\Thinh\Views\Home\Approve.cshtml"
Write(ViewData["Title"].ToString());

#line default
#line hidden
            EndContext();
            BeginContext(167, 34, true);
            WriteLiteral("</h2>\r\n<hr />\r\n<div class=\"row\">\r\n");
            EndContext();
#line 10 "C:\Users\Huy Hoang\Desktop\Fifth semester\COMP231\Thinh\Views\Home\Approve.cshtml"
       for (int i = 0; i < Model.Count(); i++)
        {

#line default
#line hidden
            BeginContext(260, 79, true);
            WriteLiteral("            <div style=\"min-height: 300px;\" class=\"col-md-4\">\r\n                ");
            EndContext();
            BeginContext(339, 296, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "899f23ac7f7f405c96f33027315781c8", async() => {
                BeginContext(408, 51, true);
                WriteLiteral("\r\n                    <img width=\"300\" height=\"300\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 459, "\"", 524, 1);
#line 14 "C:\Users\Huy Hoang\Desktop\Fifth semester\COMP231\Thinh\Views\Home\Approve.cshtml"
WriteAttributeValue("", 465, Html.DisplayFor(model => Model.ElementAt(i).productImgUrl), 465, 59, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(525, 31, true);
                WriteLiteral(" /><br />\r\n                    ");
                EndContext();
                BeginContext(557, 56, false);
#line 15 "C:\Users\Huy Hoang\Desktop\Fifth semester\COMP231\Thinh\Views\Home\Approve.cshtml"
               Write(Html.DisplayFor(model => Model.ElementAt(i).productName));

#line default
#line hidden
                EndContext();
                BeginContext(613, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 13 "C:\Users\Huy Hoang\Desktop\Fifth semester\COMP231\Thinh\Views\Home\Approve.cshtml"
                                          WriteLiteral(Model.ElementAt(i).productId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(635, 43, true);
            WriteLiteral("\r\n                <p>\r\n                    ");
            EndContext();
            BeginContext(679, 50, false);
#line 18 "C:\Users\Huy Hoang\Desktop\Fifth semester\COMP231\Thinh\Views\Home\Approve.cshtml"
               Write(Html.DisplayFor(model => Model.ElementAt(i).Price));

#line default
#line hidden
            EndContext();
            BeginContext(729, 42, true);
            WriteLiteral("\r\n                </p>\r\n\r\n                ");
            EndContext();
            BeginContext(771, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c2c8dfab74d429faa7a7d470fbb8410", async() => {
                BeginContext(886, 9, true);
                WriteLiteral("Send Help");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 21 "C:\Users\Huy Hoang\Desktop\Fifth semester\COMP231\Thinh\Views\Home\Approve.cshtml"
                                                                                        WriteLiteral(Model.ElementAt(i).productId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(899, 24, true);
            WriteLiteral("\r\n\r\n            </div>\r\n");
            EndContext();
#line 24 "C:\Users\Huy Hoang\Desktop\Fifth semester\COMP231\Thinh\Views\Home\Approve.cshtml"
            if (i != 0 && (i) % 3 == 2)
            {

#line default
#line hidden
            BeginContext(979, 62, true);
            WriteLiteral("                <div class=\"w-100 d-none d-md-block\">⠀</div>\r\n");
            EndContext();
#line 27 "C:\Users\Huy Hoang\Desktop\Fifth semester\COMP231\Thinh\Views\Home\Approve.cshtml"
            }
        }
    

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Thinh.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
