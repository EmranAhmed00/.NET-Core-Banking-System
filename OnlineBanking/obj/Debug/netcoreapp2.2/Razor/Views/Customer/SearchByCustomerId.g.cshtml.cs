#pragma checksum "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchByCustomerId.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "031b321fd21f085a04ceb62cec14dd9d6714a90d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_SearchByCustomerId), @"mvc.1.0.view", @"/Views/Customer/SearchByCustomerId.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/SearchByCustomerId.cshtml", typeof(AspNetCore.Views_Customer_SearchByCustomerId))]
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
#line 1 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\_ViewImports.cshtml"
using OnlineBanking;

#line default
#line hidden
#line 2 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\_ViewImports.cshtml"
using OnlineBanking.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"031b321fd21f085a04ceb62cec14dd9d6714a90d", @"/Views/Customer/SearchByCustomerId.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5167f54ba00eb82f3f13d8e393f5193874279dce", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_SearchByCustomerId : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineBanking.Models.Customers>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CustomerInformation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "searchByCustomerId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(41, 1704, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "031b321fd21f085a04ceb62cec14dd9d6714a90d5218", async() => {
                BeginContext(131, 229, true);
                WriteLiteral("\r\n\r\n    <div class=\"card\" id=\"welcome\">\r\n        <h2> Search by CustomerId </h2>\r\n\r\n        <p>\r\n\r\n            <input type=\"number\" value=\"search\" name=\"id\" />\r\n            <input type=\"submit\" value=\"Search\" />\r\n        </p>\r\n\r\n");
                EndContext();
#line 14 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchByCustomerId.cshtml"
         if ((string)TempData["success"] == "abc")
        {

#line default
#line hidden
                BeginContext(423, 75, true);
                WriteLiteral("            <h2 class=\"text-danger\"> Please enter the CustomerId    </h2>\r\n");
                EndContext();
#line 17 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchByCustomerId.cshtml"
        }

#line default
#line hidden
                BeginContext(509, 559, true);
                WriteLiteral(@"    </div>
    <div class=""card"">

        <table class=""table"">
            <thead>
                <tr>

                    <th scope=""col"">CustomerId</th>
                    <th scope=""col"">Name</th>
                    <th scope=""col"">Country</th>
                    <th scope=""col"">City</th>

                    <th scope=""col"">StreetAddress</th>
                    <th scope=""col"">NationalId</th>
                    <th scope=""col"">Birthday</th>
                </tr>
            </thead>

            <tbody>

              
");
                EndContext();
#line 39 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchByCustomerId.cshtml"
                 if (Model.CustomerId > 0)
                {

#line default
#line hidden
                BeginContext(1131, 54, true);
                WriteLiteral("                    <tr>\r\n                        <td>");
                EndContext();
                BeginContext(1185, 116, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "031b321fd21f085a04ceb62cec14dd9d6714a90d7514", async() => {
                    BeginContext(1281, 16, false);
#line 42 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchByCustomerId.cshtml"
                                                                                                                      Write(Model.CustomerId);

#line default
#line hidden
                    EndContext();
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
#line 42 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchByCustomerId.cshtml"
                                                                                            WriteLiteral(Model.CustomerId);

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
                BeginContext(1301, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1337, 15, false);
#line 43 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchByCustomerId.cshtml"
                       Write(Model.Givenname);

#line default
#line hidden
                EndContext();
                BeginContext(1352, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1354, 13, false);
#line 43 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchByCustomerId.cshtml"
                                        Write(Model.Surname);

#line default
#line hidden
                EndContext();
                BeginContext(1367, 37, true);
                WriteLiteral("</td>\r\n\r\n                        <td>");
                EndContext();
                BeginContext(1405, 13, false);
#line 45 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchByCustomerId.cshtml"
                       Write(Model.Country);

#line default
#line hidden
                EndContext();
                BeginContext(1418, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1454, 10, false);
#line 46 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchByCustomerId.cshtml"
                       Write(Model.City);

#line default
#line hidden
                EndContext();
                BeginContext(1464, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1500, 19, false);
#line 47 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchByCustomerId.cshtml"
                       Write(Model.Streetaddress);

#line default
#line hidden
                EndContext();
                BeginContext(1519, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1555, 16, false);
#line 48 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchByCustomerId.cshtml"
                       Write(Model.NationalId);

#line default
#line hidden
                EndContext();
                BeginContext(1571, 35, true);
                WriteLiteral("</td>\r\n                        <td>");
                EndContext();
                BeginContext(1607, 14, false);
#line 49 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchByCustomerId.cshtml"
                       Write(Model.Birthday);

#line default
#line hidden
                EndContext();
                BeginContext(1621, 34, true);
                WriteLiteral("</td>\r\n                    </tr>\r\n");
                EndContext();
#line 51 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchByCustomerId.cshtml"

                }

#line default
#line hidden
                BeginContext(1676, 62, true);
                WriteLiteral("\r\n\r\n            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1745, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineBanking.Models.Customers> Html { get; private set; }
    }
}
#pragma warning restore 1591