#pragma checksum "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a3f3393e578de331eed4deb443db81874dfea8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\_ViewImports.cshtml"
using FreeCourse.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\_ViewImports.cshtml"
using FreeCourse.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\_ViewImports.cshtml"
using FreeCourse.Web.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\_ViewImports.cshtml"
using FreeCourse.Web.Models.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\_ViewImports.cshtml"
using FreeCourse.Web.Models.Order;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a3f3393e578de331eed4deb443db81874dfea8c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69962e67833e25c23c87ef5eba8a5d2bafe877fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CourseViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 2 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    var count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Kurslar</h2>\r\n<hr />\r\n");
#nullable restore
#line 9 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Home\Index.cshtml"
 if (Model.Any())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Home\Index.cshtml"
     foreach (var course in Model)
    {
        count++;
        if (count == 1 || count % 3 == 1)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Home\Index.cshtml"
       Write(Html.Raw("<div class='row row-cols-1 row-cols-md-3 g-4 mb-2'>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Home\Index.cshtml"
                                                                            
        }


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col\">\r\n            <div class=\"card h-100\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 436, "\"", 465, 1);
#nullable restore
#line 21 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 442, course.StockPictureUrl, 442, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 23 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Home\Index.cshtml"
                                      Write(course.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <div class=\"badge bg-primary\">Kategori: ");
#nullable restore
#line 24 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Home\Index.cshtml"
                                                       Write(course.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 25 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Home\Index.cshtml"
                                    Write(course.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <h4 class=\"text-primary\">");
#nullable restore
#line 26 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Home\Index.cshtml"
                                        Write(course.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</h4>\r\n\r\n                    <div> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a3f3393e578de331eed4deb443db81874dfea8c7961", async() => {
                WriteLiteral("Detay");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Home\Index.cshtml"
                                                                         WriteLiteral(course.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 32 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Home\Index.cshtml"

        if (count % 3 == 0)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Home\Index.cshtml"
       Write(Html.Raw("</div>"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Home\Index.cshtml"
                               
        }
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Home\Index.cshtml"
     
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CourseViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
