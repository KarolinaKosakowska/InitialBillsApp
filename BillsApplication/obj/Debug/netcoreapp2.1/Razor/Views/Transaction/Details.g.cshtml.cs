#pragma checksum "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "449903915ef3e1b0ffac63dfeedbc754846803e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaction_Details), @"mvc.1.0.view", @"/Views/Transaction/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Transaction/Details.cshtml", typeof(AspNetCore.Views_Transaction_Details))]
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
#line 1 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\_ViewImports.cshtml"
using BillsApplication;

#line default
#line hidden
#line 2 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\_ViewImports.cshtml"
using BillsApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"449903915ef3e1b0ffac63dfeedbc754846803e0", @"/Views/Transaction/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b672db96256f6e0b3bed4f8162cd2180ddd0c6c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Transaction_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BillsApplication.Models.TransactionForm.DetailsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(106, 81, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Transaction</h4>\r\n    <img class=\"imageSize\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 187, "\"", 233, 2);
            WriteAttributeValue("", 193, "data:image/png;base64,", 193, 22, true);
#line 11 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Details.cshtml"
WriteAttributeValue(" ", 215, Model.Attachment, 216, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(234, 94, true);
            WriteLiteral(" alt=\"Obrazka brak\" />\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(329, 55, false);
#line 15 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TransactionCategory));

#line default
#line hidden
            EndContext();
            BeginContext(384, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(428, 51, false);
#line 18 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Details.cshtml"
       Write(Html.DisplayFor(model => model.TransactionCategory));

#line default
#line hidden
            EndContext();
            BeginContext(479, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(523, 40, false);
#line 21 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(563, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(607, 36, false);
#line 24 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(643, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(687, 47, false);
#line 27 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(734, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(778, 43, false);
#line 30 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(821, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(865, 51, false);
#line 33 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TransactionDate));

#line default
#line hidden
            EndContext();
            BeginContext(916, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(960, 47, false);
#line 36 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Details.cshtml"
       Write(Html.DisplayFor(model => model.TransactionDate));

#line default
#line hidden
            EndContext();
            BeginContext(1007, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1051, 41, false);
#line 39 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1092, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1136, 37, false);
#line 42 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1173, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1217, 47, false);
#line 45 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PaymentType));

#line default
#line hidden
            EndContext();
            BeginContext(1264, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1308, 43, false);
#line 48 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Details.cshtml"
       Write(Html.DisplayFor(model => model.PaymentType));

#line default
#line hidden
            EndContext();
            BeginContext(1351, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1395, 48, false);
#line 51 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreationDate));

#line default
#line hidden
            EndContext();
            BeginContext(1443, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1487, 44, false);
#line 54 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreationDate));

#line default
#line hidden
            EndContext();
            BeginContext(1531, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1575, 52, false);
#line 57 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ModyficationDate));

#line default
#line hidden
            EndContext();
            BeginContext(1627, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1671, 48, false);
#line 60 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Details.cshtml"
       Write(Html.DisplayFor(model => model.ModyficationDate));

#line default
#line hidden
            EndContext();
            BeginContext(1719, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1763, 43, false);
#line 63 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Product));

#line default
#line hidden
            EndContext();
            BeginContext(1806, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1850, 39, false);
#line 66 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Details.cshtml"
       Write(Html.DisplayFor(model => model.Product));

#line default
#line hidden
            EndContext();
            BeginContext(1889, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1933, 42, false);
#line 69 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1975, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2019, 38, false);
#line 72 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Details.cshtml"
       Write(Html.DisplayFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(2057, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2101, 51, false);
#line 75 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TransactionTags));

#line default
#line hidden
            EndContext();
            BeginContext(2152, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2196, 47, false);
#line 78 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Details.cshtml"
       Write(Html.DisplayFor(model => model.TransactionTags));

#line default
#line hidden
            EndContext();
            BeginContext(2243, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2290, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee82402137734d7da2a9ec434259b13a", async() => {
                BeginContext(2336, 4, true);
                WriteLiteral("Edit");
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
#line 83 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Details.cshtml"
                           WriteLiteral(Model.ID);

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
            BeginContext(2344, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2352, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d66d2e3f5f64f25aadb4f6e54acb59f", async() => {
                BeginContext(2374, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2390, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BillsApplication.Models.TransactionForm.DetailsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
