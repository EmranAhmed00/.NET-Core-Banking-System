#pragma checksum "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchCustomer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d578e3a3d8c6aea16892a5c9dcb3b28516b41298"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_SearchCustomer), @"mvc.1.0.view", @"/Views/Customer/SearchCustomer.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/SearchCustomer.cshtml", typeof(AspNetCore.Views_Customer_SearchCustomer))]
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
#line 1 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchCustomer.cshtml"
using PagedList;

#line default
#line hidden
#line 2 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchCustomer.cshtml"
using PagedList.Mvc;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d578e3a3d8c6aea16892a5c9dcb3b28516b41298", @"/Views/Customer/SearchCustomer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5167f54ba00eb82f3f13d8e393f5193874279dce", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_SearchCustomer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineBanking.ViewModels.CustomerInformationViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SearchCustomer2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("get"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CustomerInformation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(106, 27, true);
            WriteLiteral("\r\n<div class=\" card\">\r\n    ");
            EndContext();
            BeginContext(133, 2983, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d578e3a3d8c6aea16892a5c9dcb3b28516b412985682", async() => {
                BeginContext(208, 640, true);
                WriteLiteral(@"

        <div class=""card"" id=""welcome"">
            <h2> Search By City or Name   </h2>

            <p>
                <input type=""text"" name=""search"" />
                <input type=""hidden"" name=""page"" value=""1"" />
                <input type=""submit"" value=""Search"" />
            </p>
         
            <div >
                <h2> Search by Name and City </h2>
                <p>
                    <input type=""text""  name=""nam"" />
                  
                    <input type=""text""  name=""city"" />
                    <input type=""submit"" value=""Search"" />
                </p>
            </div>
");
                EndContext();
#line 27 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchCustomer.cshtml"
             if (Model.pageSize > 0)
            {
          
                    

#line default
#line hidden
#line 30 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchCustomer.cshtml"
                     for( int i= 1; ( i*Model.pageSize) < Model.TotalNumberOfItems + Model.pageSize; i++)
                     
                {

#line default
#line hidden
                BeginContext(1062, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(1082, 135, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d578e3a3d8c6aea16892a5c9dcb3b28516b412987403", async() => {
                    BeginContext(1206, 5, true);
                    WriteLiteral("Page ");
                    EndContext();
                    BeginContext(1212, 1, false);
#line 33 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchCustomer.cshtml"
                                                                                                                                                Write(i);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 33 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchCustomer.cshtml"
                                                                                  WriteLiteral(i);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 33 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchCustomer.cshtml"
                                                                                                        WriteLiteral(Model.Search);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["search"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-search", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["search"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1217, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 34 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchCustomer.cshtml"

                }

#line default
#line hidden
#line 35 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchCustomer.cshtml"
                 
            }

#line default
#line hidden
                BeginContext(1255, 673, true);
                WriteLiteral(@"

        </div>
        
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
#line 60 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchCustomer.cshtml"
                         if (Model.customerslist != null)
                        {
                            

#line default
#line hidden
#line 62 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchCustomer.cshtml"
                             if (Model.customerslist.Count > 0)
                            {
                                

#line default
#line hidden
#line 64 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchCustomer.cshtml"
                                 foreach (var customer in Model.customerslist)
                                {


#line default
#line hidden
                BeginContext(2227, 86, true);
                WriteLiteral("                                    <tr>\r\n                                        <td>");
                EndContext();
                BeginContext(2313, 122, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d578e3a3d8c6aea16892a5c9dcb3b28516b4129813574", async() => {
                    BeginContext(2412, 19, false);
#line 68 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchCustomer.cshtml"
                                                                                                                                         Write(customer.CustomerId);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 68 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchCustomer.cshtml"
                                                                                                            WriteLiteral(customer.CustomerId);

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
                BeginContext(2435, 53, true);
                WriteLiteral("</td>\r\n\r\n                                        <td>");
                EndContext();
                BeginContext(2489, 18, false);
#line 70 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchCustomer.cshtml"
                                       Write(customer.Givenname);

#line default
#line hidden
                EndContext();
                BeginContext(2507, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2509, 16, false);
#line 70 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchCustomer.cshtml"
                                                           Write(customer.Surname);

#line default
#line hidden
                EndContext();
                BeginContext(2525, 53, true);
                WriteLiteral("</td>\r\n\r\n                                        <td>");
                EndContext();
                BeginContext(2579, 16, false);
#line 72 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchCustomer.cshtml"
                                       Write(customer.Country);

#line default
#line hidden
                EndContext();
                BeginContext(2595, 51, true);
                WriteLiteral("</td>\r\n                                        <td>");
                EndContext();
                BeginContext(2647, 13, false);
#line 73 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchCustomer.cshtml"
                                       Write(customer.City);

#line default
#line hidden
                EndContext();
                BeginContext(2660, 51, true);
                WriteLiteral("</td>\r\n                                        <td>");
                EndContext();
                BeginContext(2712, 22, false);
#line 74 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchCustomer.cshtml"
                                       Write(customer.Streetaddress);

#line default
#line hidden
                EndContext();
                BeginContext(2734, 51, true);
                WriteLiteral("</td>\r\n                                        <td>");
                EndContext();
                BeginContext(2786, 19, false);
#line 75 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchCustomer.cshtml"
                                       Write(customer.NationalId);

#line default
#line hidden
                EndContext();
                BeginContext(2805, 51, true);
                WriteLiteral("</td>\r\n                                        <td>");
                EndContext();
                BeginContext(2857, 17, false);
#line 76 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchCustomer.cshtml"
                                       Write(customer.Birthday);

#line default
#line hidden
                EndContext();
                BeginContext(2874, 50, true);
                WriteLiteral("</td>\r\n                                    </tr>\r\n");
                EndContext();
#line 78 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchCustomer.cshtml"

                                }

#line default
#line hidden
#line 79 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchCustomer.cshtml"
                                 

                            }

#line default
#line hidden
#line 81 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\SearchCustomer.cshtml"
                             
                        }

#line default
#line hidden
                BeginContext(3021, 88, true);
                WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        \r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            BeginContext(3116, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineBanking.ViewModels.CustomerInformationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
