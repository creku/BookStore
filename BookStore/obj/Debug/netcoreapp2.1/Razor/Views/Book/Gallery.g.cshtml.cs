#pragma checksum "C:\Users\Mad Coder\Documents\Visual Studio 2017\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "baeb564f4c8eabcc8bc8537c8a79ad10878d2025"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Gallery), @"mvc.1.0.view", @"/Views/Book/Gallery.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Gallery.cshtml", typeof(AspNetCore.Views_Book_Gallery))]
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
#line 1 "C:\Users\Mad Coder\Documents\Visual Studio 2017\Projects\BookStore\BookStore\Views\_ViewImports.cshtml"
using BookStore;

#line default
#line hidden
#line 2 "C:\Users\Mad Coder\Documents\Visual Studio 2017\Projects\BookStore\BookStore\Views\_ViewImports.cshtml"
using BookStore.Models;

#line default
#line hidden
#line 3 "C:\Users\Mad Coder\Documents\Visual Studio 2017\Projects\BookStore\BookStore\Views\_ViewImports.cshtml"
using BookStore.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baeb564f4c8eabcc8bc8537c8a79ad10878d2025", @"/Views/Book/Gallery.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aecfecbd0cb1e534be9dfda97b12d4a74df2d43e", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Gallery : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookStore.Models.Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/shop-homepage.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-box-cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Mad Coder\Documents\Visual Studio 2017\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
  
ViewData["Title"] = "Gallery";

#line default
#line hidden
            BeginContext(84, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(86, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ffbd171b2614437392487cb2cbd84bdb", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(142, 24, true);
            WriteLiteral("\r\n\r\n<h2>Gallery</h2>\r\n\r\n");
            EndContext();
            BeginContext(220, 365, true);
            WriteLiteral(@"
<div class=""row"">

    <div class=""col-md-3"" >
        <p class=""lead"">Shop Name</p>
        <div class=""list-group"">
        <a href=""#"" class=""list-group-item"">Category 1</a>
        <a href=""#"" class=""list-group-item"">Category 2</a>
        <a href=""#"" class=""list-group-item"">Category 3</a>
        </div>
    </div>

    <div class=""col-md-9"">

");
            EndContext();
            BeginContext(2232, 31, true);
            WriteLiteral("\r\n        <div class=\"row\">\r\n\r\n");
            EndContext();
#line 61 "C:\Users\Mad Coder\Documents\Visual Studio 2017\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(2320, 182, true);
            WriteLiteral("                <div class=\"col-sm-4 col-lg-4 col-md-4\">\r\n                    <div class=\"thumbnail\">\r\n                        <div class=\"img-box\">\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2502, "\"", 2533, 1);
#line 66 "C:\Users\Mad Coder\Documents\Visual Studio 2017\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
WriteAttributeValue("", 2508, Url.Content(item.ImgUrl), 2508, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2534, 38, true);
            WriteLiteral(" alt=\"\">\r\n                            ");
            EndContext();
            BeginContext(2572, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b84fe13ec25c4168a29991ec668f54fb", async() => {
                BeginContext(2610, 11, true);
                WriteLiteral("Add to Cart");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2625, 133, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"caption\">\r\n                            <h4 class=\"pull-right\">$");
            EndContext();
            BeginContext(2759, 10, false);
#line 70 "C:\Users\Mad Coder\Documents\Visual Studio 2017\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
                                               Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2769, 85, true);
            WriteLiteral("</h4>\r\n                            <h4>\r\n                                <a href=\"#\">");
            EndContext();
            BeginContext(2855, 9, false);
#line 72 "C:\Users\Mad Coder\Documents\Visual Studio 2017\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
                                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2864, 160, true);
            WriteLiteral("</a>\r\n                            </h4>\r\n                            <h5>\r\n                                <a target=\"_blank\" href=\"http://www.fb.com/shbsovon\">");
            EndContext();
            BeginContext(3025, 11, false);
#line 75 "C:\Users\Mad Coder\Documents\Visual Studio 2017\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
                                                                                Write(item.Author);

#line default
#line hidden
            EndContext();
            BeginContext(3036, 72, true);
            WriteLiteral("</a>\r\n                            </h5>\r\n                            <p>");
            EndContext();
            BeginContext(3109, 12, false);
#line 77 "C:\Users\Mad Coder\Documents\Visual Studio 2017\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
                          Write(item.Details);

#line default
#line hidden
            EndContext();
            BeginContext(3121, 702, true);
            WriteLiteral(@"</p>
                        </div>
                        <div class=""ratings"">
                            <p class=""pull-right"">15 reviews</p>
                            <p>
                                <span class=""glyphicon glyphicon-star""></span>
                                <span class=""glyphicon glyphicon-star""></span>
                                <span class=""glyphicon glyphicon-star""></span>
                                <span class=""glyphicon glyphicon-star""></span>
                                <span class=""glyphicon glyphicon-star""></span>
                            </p>
                        </div>
                    </div>
                </div>
");
            EndContext();
#line 91 "C:\Users\Mad Coder\Documents\Visual Studio 2017\Projects\BookStore\BookStore\Views\Book\Gallery.cshtml"
            }

#line default
#line hidden
            BeginContext(3864, 42, true);
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookStore.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591