#pragma checksum "C:\Users\anitageorge\source\repos\RazorIdentity\RazorIdentity\Pages\Prod\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f95a223c452d9c31775193976b8cf43a3c1ec7ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorIdentity.Pages.Prod.Pages_Prod_Details), @"mvc.1.0.razor-page", @"/Pages/Prod/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Prod/Details.cshtml", typeof(RazorIdentity.Pages.Prod.Pages_Prod_Details), null)]
namespace RazorIdentity.Pages.Prod
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\anitageorge\source\repos\RazorIdentity\RazorIdentity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\anitageorge\source\repos\RazorIdentity\RazorIdentity\Pages\_ViewImports.cshtml"
using RazorIdentity;

#line default
#line hidden
#line 3 "C:\Users\anitageorge\source\repos\RazorIdentity\RazorIdentity\Pages\_ViewImports.cshtml"
using RazorIdentity.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f95a223c452d9c31775193976b8cf43a3c1ec7ff", @"/Pages/Prod/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11d3ff2e526abed6a8f71e90aacad23ea423d088", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Prod_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\anitageorge\source\repos\RazorIdentity\RazorIdentity\Pages\Prod\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(98, 122, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Products</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(221, 56, false);
#line 15 "C:\Users\anitageorge\source\repos\RazorIdentity\RazorIdentity\Pages\Prod\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Products.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(277, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(321, 52, false);
#line 18 "C:\Users\anitageorge\source\repos\RazorIdentity\RazorIdentity\Pages\Prod\Details.cshtml"
       Write(Html.DisplayFor(model => model.Products.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(373, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(417, 50, false);
#line 21 "C:\Users\anitageorge\source\repos\RazorIdentity\RazorIdentity\Pages\Prod\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Products.Price));

#line default
#line hidden
            EndContext();
            BeginContext(467, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(511, 46, false);
#line 24 "C:\Users\anitageorge\source\repos\RazorIdentity\RazorIdentity\Pages\Prod\Details.cshtml"
       Write(Html.DisplayFor(model => model.Products.Price));

#line default
#line hidden
            EndContext();
            BeginContext(557, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(601, 51, false);
#line 27 "C:\Users\anitageorge\source\repos\RazorIdentity\RazorIdentity\Pages\Prod\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Products.OnSale));

#line default
#line hidden
            EndContext();
            BeginContext(652, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(696, 47, false);
#line 30 "C:\Users\anitageorge\source\repos\RazorIdentity\RazorIdentity\Pages\Prod\Details.cshtml"
       Write(Html.DisplayFor(model => model.Products.OnSale));

#line default
#line hidden
            EndContext();
            BeginContext(743, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(787, 57, false);
#line 33 "C:\Users\anitageorge\source\repos\RazorIdentity\RazorIdentity\Pages\Prod\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Products.Discontinued));

#line default
#line hidden
            EndContext();
            BeginContext(844, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(888, 53, false);
#line 36 "C:\Users\anitageorge\source\repos\RazorIdentity\RazorIdentity\Pages\Prod\Details.cshtml"
       Write(Html.DisplayFor(model => model.Products.Discontinued));

#line default
#line hidden
            EndContext();
            BeginContext(941, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(985, 53, false);
#line 39 "C:\Users\anitageorge\source\repos\RazorIdentity\RazorIdentity\Pages\Prod\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Products.Category));

#line default
#line hidden
            EndContext();
            BeginContext(1038, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1082, 62, false);
#line 42 "C:\Users\anitageorge\source\repos\RazorIdentity\RazorIdentity\Pages\Prod\Details.cshtml"
       Write(Html.DisplayFor(model => model.Products.Category.CategoryName));

#line default
#line hidden
            EndContext();
            BeginContext(1144, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1188, 57, false);
#line 45 "C:\Users\anitageorge\source\repos\RazorIdentity\RazorIdentity\Pages\Prod\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Products.ProductColor));

#line default
#line hidden
            EndContext();
            BeginContext(1245, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1289, 59, false);
#line 48 "C:\Users\anitageorge\source\repos\RazorIdentity\RazorIdentity\Pages\Prod\Details.cshtml"
       Write(Html.DisplayFor(model => model.Products.ProductColor.Color));

#line default
#line hidden
            EndContext();
            BeginContext(1348, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1395, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16da230ffcf04b1993eacc27d16c1c13", async() => {
                BeginContext(1457, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\anitageorge\source\repos\RazorIdentity\RazorIdentity\Pages\Prod\Details.cshtml"
                           WriteLiteral(Model.Products.ProductId);

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
            BeginContext(1465, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1473, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "810ead3a4e534843ab7e7de7967415ad", async() => {
                BeginContext(1495, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1511, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorIdentity.Pages.Prod.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorIdentity.Pages.Prod.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorIdentity.Pages.Prod.DetailsModel>)PageContext?.ViewData;
        public RazorIdentity.Pages.Prod.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
