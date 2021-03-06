#pragma checksum "D:\SRC\Cosmos\MicrosoftDocs\CosmosDemo - Copy\CosmosDemo\Views\Item\Tasks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6467ae2413c0b5ee6d1332fbcf9cc7357855f03c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_Tasks), @"mvc.1.0.view", @"/Views/Item/Tasks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Item/Tasks.cshtml", typeof(AspNetCore.Views_Item_Tasks))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6467ae2413c0b5ee6d1332fbcf9cc7357855f03c", @"/Views/Item/Tasks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e4225719fb6b4af554fba7554fc53ae38ed03de", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_Tasks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CosmosDemo.Models.ProjectTask>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\SRC\Cosmos\MicrosoftDocs\CosmosDemo - Copy\CosmosDemo\Views\Item\Tasks.cshtml"
  
    ViewData["Title"] = "Tasks";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(141, 45, true);
            WriteLiteral("\r\n<h2 class=\"text-center\">Tasks</h2>\r\n\r\n<p>\r\n");
            EndContext();
            BeginContext(237, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(242, 67, false);
#line 12 "D:\SRC\Cosmos\MicrosoftDocs\CosmosDemo - Copy\CosmosDemo\Views\Item\Tasks.cshtml"
Write(Html.ActionLink("Create New", "CreateTask", new { id=@ViewBag.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(309, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(402, 44, false);
#line 18 "D:\SRC\Cosmos\MicrosoftDocs\CosmosDemo - Copy\CosmosDemo\Views\Item\Tasks.cshtml"
           Write(Html.DisplayNameFor(model => model.TaskName));

#line default
#line hidden
            EndContext();
            BeginContext(446, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(502, 46, false);
#line 21 "D:\SRC\Cosmos\MicrosoftDocs\CosmosDemo - Copy\CosmosDemo\Views\Item\Tasks.cshtml"
           Write(Html.DisplayNameFor(model => model.AssignedTo));

#line default
#line hidden
            EndContext();
            BeginContext(548, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(604, 42, false);
#line 24 "D:\SRC\Cosmos\MicrosoftDocs\CosmosDemo - Copy\CosmosDemo\Views\Item\Tasks.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(646, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 30 "D:\SRC\Cosmos\MicrosoftDocs\CosmosDemo - Copy\CosmosDemo\Views\Item\Tasks.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(764, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(813, 43, false);
#line 33 "D:\SRC\Cosmos\MicrosoftDocs\CosmosDemo - Copy\CosmosDemo\Views\Item\Tasks.cshtml"
           Write(Html.DisplayFor(modelItem => item.TaskName));

#line default
#line hidden
            EndContext();
            BeginContext(856, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(912, 45, false);
#line 36 "D:\SRC\Cosmos\MicrosoftDocs\CosmosDemo - Copy\CosmosDemo\Views\Item\Tasks.cshtml"
           Write(Html.DisplayFor(modelItem => item.AssignedTo));

#line default
#line hidden
            EndContext();
            BeginContext(957, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1013, 41, false);
#line 39 "D:\SRC\Cosmos\MicrosoftDocs\CosmosDemo - Copy\CosmosDemo\Views\Item\Tasks.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1054, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1110, 83, false);
#line 42 "D:\SRC\Cosmos\MicrosoftDocs\CosmosDemo - Copy\CosmosDemo\Views\Item\Tasks.cshtml"
           Write(Html.ActionLink("Edit", "EditTask", new { id = @ViewBag.Id, taskId = item.TaskId }));

#line default
#line hidden
            EndContext();
            BeginContext(1193, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1214, 89, false);
#line 43 "D:\SRC\Cosmos\MicrosoftDocs\CosmosDemo - Copy\CosmosDemo\Views\Item\Tasks.cshtml"
           Write(Html.ActionLink("Details", "DetailsTask", new { id = @ViewBag.Id, taskId = item.TaskId }));

#line default
#line hidden
            EndContext();
            BeginContext(1303, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1324, 87, false);
#line 44 "D:\SRC\Cosmos\MicrosoftDocs\CosmosDemo - Copy\CosmosDemo\Views\Item\Tasks.cshtml"
           Write(Html.ActionLink("Delete", "DeleteTask", new { id = @ViewBag.Id, taskId = item.TaskId }));

#line default
#line hidden
            EndContext();
            BeginContext(1411, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 47 "D:\SRC\Cosmos\MicrosoftDocs\CosmosDemo - Copy\CosmosDemo\Views\Item\Tasks.cshtml"
}

#line default
#line hidden
            BeginContext(1450, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CosmosDemo.Models.ProjectTask>> Html { get; private set; }
    }
}
#pragma warning restore 1591
