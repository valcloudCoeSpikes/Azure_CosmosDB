#pragma checksum "D:\SRC\Cosmos\MicrosoftDocs\CosmosDemo - Copy\CosmosDemo\Views\Item\CreateTask.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2ed8ddd091c12be0fd8dd75c051f1a8d4ca5641"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_CreateTask), @"mvc.1.0.view", @"/Views/Item/CreateTask.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Item/CreateTask.cshtml", typeof(AspNetCore.Views_Item_CreateTask))]
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
#line 1 "D:\SRC\Cosmos\MicrosoftDocs\CosmosDemo - Copy\CosmosDemo\Views\_ViewImports.cshtml"
using CosmosDemo;

#line default
#line hidden
#line 2 "D:\SRC\Cosmos\MicrosoftDocs\CosmosDemo - Copy\CosmosDemo\Views\_ViewImports.cshtml"
using CosmosDemo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2ed8ddd091c12be0fd8dd75c051f1a8d4ca5641", @"/Views/Item/CreateTask.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e4225719fb6b4af554fba7554fc53ae38ed03de", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_CreateTask : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CosmosDemo.Models.ProjectTask>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bundles/jqueryval"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\SRC\Cosmos\MicrosoftDocs\CosmosDemo - Copy\CosmosDemo\Views\Item\CreateTask.cshtml"
  
    //ViewData["Title"] = "CreateTask";
    ViewBag.Title = "CreateTask";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(170, 25, true);
            WriteLiteral("\r\n<h2>CreateTask</h2>\r\n\r\n");
            EndContext();
#line 11 "D:\SRC\Cosmos\MicrosoftDocs\CosmosDemo - Copy\CosmosDemo\Views\Item\CreateTask.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(230, 23, false);
#line 13 "D:\SRC\Cosmos\MicrosoftDocs\CosmosDemo - Copy\CosmosDemo\Views\Item\CreateTask.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(257, 59, true);
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <hr />\r\n        ");
            EndContext();
            BeginContext(317, 64, false);
#line 17 "D:\SRC\Cosmos\MicrosoftDocs\CosmosDemo - Copy\CosmosDemo\Views\Item\CreateTask.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(381, 48, true);
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(430, 97, false);
#line 19 "D:\SRC\Cosmos\MicrosoftDocs\CosmosDemo - Copy\CosmosDemo\Views\Item\CreateTask.cshtml"
       Write(Html.LabelFor(model => model.TaskName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(527, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(583, 97, false);
#line 21 "D:\SRC\Cosmos\MicrosoftDocs\CosmosDemo - Copy\CosmosDemo\Views\Item\CreateTask.cshtml"
           Write(Html.EditorFor(model => model.TaskName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(680, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(699, 86, false);
#line 22 "D:\SRC\Cosmos\MicrosoftDocs\CosmosDemo - Copy\CosmosDemo\Views\Item\CreateTask.cshtml"
           Write(Html.ValidationMessageFor(model => model.TaskName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(785, 84, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(870, 99, false);
#line 26 "D:\SRC\Cosmos\MicrosoftDocs\CosmosDemo - Copy\CosmosDemo\Views\Item\CreateTask.cshtml"
       Write(Html.LabelFor(model => model.AssignedTo, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(969, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1025, 99, false);
#line 28 "D:\SRC\Cosmos\MicrosoftDocs\CosmosDemo - Copy\CosmosDemo\Views\Item\CreateTask.cshtml"
           Write(Html.EditorFor(model => model.AssignedTo, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1124, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1143, 88, false);
#line 29 "D:\SRC\Cosmos\MicrosoftDocs\CosmosDemo - Copy\CosmosDemo\Views\Item\CreateTask.cshtml"
           Write(Html.ValidationMessageFor(model => model.AssignedTo, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1231, 84, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1316, 95, false);
#line 33 "D:\SRC\Cosmos\MicrosoftDocs\CosmosDemo - Copy\CosmosDemo\Views\Item\CreateTask.cshtml"
       Write(Html.LabelFor(model => model.Status, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1411, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1467, 95, false);
#line 35 "D:\SRC\Cosmos\MicrosoftDocs\CosmosDemo - Copy\CosmosDemo\Views\Item\CreateTask.cshtml"
           Write(Html.EditorFor(model => model.Status, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1562, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1581, 84, false);
#line 36 "D:\SRC\Cosmos\MicrosoftDocs\CosmosDemo - Copy\CosmosDemo\Views\Item\CreateTask.cshtml"
           Write(Html.ValidationMessageFor(model => model.Status, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1665, 69, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1734, "\"", 1750, 1);
#line 39 "D:\SRC\Cosmos\MicrosoftDocs\CosmosDemo - Copy\CosmosDemo\Views\Item\CreateTask.cshtml"
WriteAttributeValue("", 1739, ViewBag.Id, 1739, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1751, 184, true);
            WriteLiteral(">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 45 "D:\SRC\Cosmos\MicrosoftDocs\CosmosDemo - Copy\CosmosDemo\Views\Item\CreateTask.cshtml"
}

#line default
#line hidden
            BeginContext(1938, 11, true);
            WriteLiteral("<div>\r\n    ");
            EndContext();
            BeginContext(1950, 66, false);
#line 47 "D:\SRC\Cosmos\MicrosoftDocs\CosmosDemo - Copy\CosmosDemo\Views\Item\CreateTask.cshtml"
Write(Html.ActionLink("Back to List", "Tasks", new { id = @ViewBag.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2016, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
            BeginContext(2026, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5916fb8008646c896601c4c6a11c952", async() => {
                BeginContext(2060, 1, true);
                WriteLiteral(" ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2070, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CosmosDemo.Models.ProjectTask> Html { get; private set; }
    }
}
#pragma warning restore 1591
