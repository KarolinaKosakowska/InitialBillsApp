#pragma checksum "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "442580a13d6e199efb10cb976c02b9c1a81524ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaction_Delete), @"mvc.1.0.view", @"/Views/Transaction/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Transaction/Delete.cshtml", typeof(AspNetCore.Views_Transaction_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"442580a13d6e199efb10cb976c02b9c1a81524ec", @"/Views/Transaction/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b672db96256f6e0b3bed4f8162cd2180ddd0c6c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Transaction_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BillsData.Transaction>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(74, 172, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Transaction</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(247, 40, false);
#line 15 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(287, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(331, 36, false);
#line 18 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(367, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(411, 47, false);
#line 21 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(458, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(502, 43, false);
#line 24 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(545, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(589, 51, false);
#line 27 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TransactionDate));

#line default
#line hidden
            EndContext();
            BeginContext(640, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(684, 47, false);
#line 30 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TransactionDate));

#line default
#line hidden
            EndContext();
            BeginContext(731, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(775, 46, false);
#line 33 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreateDate));

#line default
#line hidden
            EndContext();
            BeginContext(821, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(865, 42, false);
#line 36 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreateDate));

#line default
#line hidden
            EndContext();
            BeginContext(907, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(951, 52, false);
#line 39 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ModyficationDate));

#line default
#line hidden
            EndContext();
            BeginContext(1003, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1047, 48, false);
#line 42 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ModyficationDate));

#line default
#line hidden
            EndContext();
            BeginContext(1095, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1139, 41, false);
#line 45 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1180, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1224, 37, false);
#line 48 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1261, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1305, 55, false);
#line 51 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TransactionCategory));

#line default
#line hidden
            EndContext();
            BeginContext(1360, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1404, 56, false);
#line 54 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TransactionCategory.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1460, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1504, 47, false);
#line 57 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PaymentType));

#line default
#line hidden
            EndContext();
            BeginContext(1551, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1595, 46, false);
#line 60 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PaymentType.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1641, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1679, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b644ce71bf243ec971f7521084ccb8e", async() => {
                BeginContext(1705, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1715, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "099f0eeebaa145028cdca61a821922fe", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 65 "C:\Users\HP.LAPTOP-9OCPGB0M\Desktop\Kurs C#\REPOZYTORIA\Initial_Exercises\BillsApplication\BillsApplication\Views\Transaction\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1751, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1835, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fda7a2d9c3cd4c759f5e6392d437245a", async() => {
                    BeginContext(1857, 12, true);
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
                BeginContext(1873, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1886, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BillsData.Transaction> Html { get; private set; }
    }
}
#pragma warning restore 1591
