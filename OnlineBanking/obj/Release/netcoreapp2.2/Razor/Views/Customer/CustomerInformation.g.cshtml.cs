#pragma checksum "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\CustomerInformation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76f6effdd75b8f7ee577ff229598cebe009cf3f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_CustomerInformation), @"mvc.1.0.view", @"/Views/Customer/CustomerInformation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/CustomerInformation.cshtml", typeof(AspNetCore.Views_Customer_CustomerInformation))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76f6effdd75b8f7ee577ff229598cebe009cf3f0", @"/Views/Customer/CustomerInformation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5167f54ba00eb82f3f13d8e393f5193874279dce", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_CustomerInformation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineBanking.ViewModels.CustomerInformationViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "updateCustomer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(62, 126, true);
            WriteLiteral("    <div class=\"card\" id=\"welcome\">\r\n        <h1>Customer Information :</h1>\r\n\r\n        <div>\r\n\r\n            <h3>Customer Id: ");
            EndContext();
            BeginContext(189, 29, false);
#line 7 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\CustomerInformation.cshtml"
                        Write(Model.customerInfo.CustomerId);

#line default
#line hidden
            EndContext();
            BeginContext(218, 29, true);
            WriteLiteral("</h3>\r\n            <h3>Name: ");
            EndContext();
            BeginContext(248, 28, false);
#line 8 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\CustomerInformation.cshtml"
                 Write(Model.customerInfo.Givenname);

#line default
#line hidden
            EndContext();
            BeginContext(276, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(278, 26, false);
#line 8 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\CustomerInformation.cshtml"
                                               Write(Model.customerInfo.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(304, 30, true);
            WriteLiteral("</h3>\r\n\r\n            <p>City: ");
            EndContext();
            BeginContext(335, 23, false);
#line 10 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\CustomerInformation.cshtml"
                Write(Model.customerInfo.City);

#line default
#line hidden
            EndContext();
            BeginContext(358, 30, true);
            WriteLiteral("</p>\r\n            <p>Country: ");
            EndContext();
            BeginContext(389, 26, false);
#line 11 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\CustomerInformation.cshtml"
                   Write(Model.customerInfo.Country);

#line default
#line hidden
            EndContext();
            BeginContext(415, 32, true);
            WriteLiteral("</p>\r\n            <p>Telephone: ");
            EndContext();
            BeginContext(448, 34, false);
#line 12 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\CustomerInformation.cshtml"
                     Write(Model.customerInfo.Telephonenumber);

#line default
#line hidden
            EndContext();
            BeginContext(482, 35, true);
            WriteLiteral("</p>\r\n            <p>Total Balance ");
            EndContext();
            BeginContext(518, 18, false);
#line 13 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\CustomerInformation.cshtml"
                        Write(Model.totalBalance);

#line default
#line hidden
            EndContext();
            BeginContext(536, 37, true);
            WriteLiteral("</p>\r\n            <h2>Accounts</h2>\r\n");
            EndContext();
#line 15 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\CustomerInformation.cshtml"
             foreach (var accounts in Model.accountInfo)
            {

#line default
#line hidden
            BeginContext(646, 35, true);
            WriteLiteral("                <h3>Account Number ");
            EndContext();
            BeginContext(682, 18, false);
#line 17 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\CustomerInformation.cshtml"
                              Write(accounts.AccountId);

#line default
#line hidden
            EndContext();
            BeginContext(700, 35, true);
            WriteLiteral("</h3>\r\n                <p>Balance: ");
            EndContext();
            BeginContext(736, 16, false);
#line 18 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\CustomerInformation.cshtml"
                       Write(accounts.Balance);

#line default
#line hidden
            EndContext();
            BeginContext(752, 34, true);
            WriteLiteral("</p>\r\n                <p>Created: ");
            EndContext();
            BeginContext(787, 16, false);
#line 19 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\CustomerInformation.cshtml"
                       Write(accounts.Created);

#line default
#line hidden
            EndContext();
            BeginContext(803, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 20 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\CustomerInformation.cshtml"

            }

#line default
#line hidden
            BeginContext(826, 18, true);
            WriteLiteral("\r\n            <h3>");
            EndContext();
            BeginContext(844, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76f6effdd75b8f7ee577ff229598cebe009cf3f08917", async() => {
                BeginContext(947, 19, true);
                WriteLiteral(" Edit Customer Info");
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
#line 23 "C:\Users\emran\source\repos\ASP.NET MVC-2\OnlineBanking\OnlineBanking\Views\Customer\CustomerInformation.cshtml"
                                                                           WriteLiteral(Model.customerInfo.CustomerId);

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
            BeginContext(970, 53, true);
            WriteLiteral("</h3>\r\n\r\n\r\n        </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
