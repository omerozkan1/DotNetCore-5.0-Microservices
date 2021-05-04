#pragma checksum "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Basket\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11d253388eb186e7af97e7bd7675121af7dbb575"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basket_Index), @"mvc.1.0.view", @"/Views/Basket/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11d253388eb186e7af97e7bd7675121af7dbb575", @"/Views/Basket/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c236550418592d75369f943547494186bd1346fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Basket_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BasketViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Basket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveBasketItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Basket\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-8 offset-md-2\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\"> \r\n                    Sepet\r\n                </h5>\r\n\r\n");
#nullable restore
#line 14 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Basket\Index.cshtml"
                 if (Model != null && Model.BasketItems.Any())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table class=""table table-striped"">

                        <tr>
                            <th>Kurs ismi</th>
                            <th>Kurs fiyatı</th>
                            <th>İşlemler</th>
                        </tr>

");
#nullable restore
#line 24 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Basket\Index.cshtml"
                         foreach (var basketItem in Model.BasketItems)
	                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t                    <tr>\r\n                                <td>");
#nullable restore
#line 27 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Basket\Index.cshtml"
                               Write(basketItem.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 29 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Basket\Index.cshtml"
                               Write(basketItem.GetCurrentPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺\r\n                                </td>\r\n                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11d253388eb186e7af97e7bd7675121af7dbb5756666", async() => {
                WriteLiteral("Sil");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-courseId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Basket\Index.cshtml"
                                                                                                                            WriteLiteral(basketItem.CourseId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["courseId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-courseId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["courseId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 35 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Basket\Index.cshtml"
	                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Basket\Index.cshtml"
                         if (Model.HasDiscount)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>İndirim oranı</td>\r\n                                <th colspan=\"2\">% ");
#nullable restore
#line 41 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Basket\Index.cshtml"
                                             Write(Model.DiscountRate.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            </tr>\r\n");
#nullable restore
#line 43 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Basket\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <tr>\r\n                            <td>");
#nullable restore
#line 46 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Basket\Index.cshtml"
                            Write(Model.HasDiscount ? "İndirimli Fiyat" : "Toplam Fiyat");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <th colspan=\"2\">");
#nullable restore
#line 47 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Basket\Index.cshtml"
                                       Write(Model.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</th>\r\n                        </tr>\r\n\r\n                    </table>\r\n");
#nullable restore
#line 51 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Basket\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-info\">Sepetiniz boş</div>\r\n");
#nullable restore
#line 55 "C:\Users\ÖmerÖzkan\source\repos\Microservices\Clients\FreeCourse.Web\Views\Basket\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BasketViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591