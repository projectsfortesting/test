#pragma checksum "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Groups\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a65ece19eb01a79f95b23181b0493ae6d8a375fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Groups_Index), @"mvc.1.0.view", @"/Views/Groups/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Groups/Index.cshtml", typeof(AspNetCore.Views_Groups_Index))]
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
#line 1 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\_ViewImports.cshtml"
using DevOpsPortal.Web;

#line default
#line hidden
#line 2 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\_ViewImports.cshtml"
using DevOpsPortal.Web.Models;

#line default
#line hidden
#line 2 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Groups\Index.cshtml"
using DevOpsSolution.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a65ece19eb01a79f95b23181b0493ae6d8a375fe", @"/Views/Groups/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abb8d4e932ebc175a4435bbece14da39301aa8bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Groups_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GroupViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Views/Groups/Index.cshtml"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/AdminLTE/img/tableico_edit.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/AdminLTE/img/tableico_del.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Groups\Index.cshtml"
   ViewBag.Title = "Groups"; 

#line default
#line hidden
            BeginContext(162, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6c97d4805c049dc9fab46cffbd96c15", async() => {
                BeginContext(200, 27, true);
                WriteLiteral("~/Views/Groups/Index.cshtml");
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
            BeginContext(231, 119, true);
            WriteLiteral("\r\n\r\n<div align=\"right\">\r\n    <input type=\"button\" class=\"bg-blue-active\" name=\"btnCreateGrp\" value=\"+ Create New Group\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 350, "\"", 405, 3);
            WriteAttributeValue("", 360, "onclick=location.href=\'", 360, 23, true);
#line 11 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Groups\Index.cshtml"
WriteAttributeValue("", 383, Url.Action("Create"), 383, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 404, "\'", 404, 1, true);
            EndWriteAttribute();
            BeginContext(406, 375, true);
            WriteLiteral(@" />
</div>

<div class=""table-responsive"">
    <table id=""mytable"" class=""table table-bordered "">
        <thead>
            <tr class=""bg-gray"" style=""font-family:Arial;font-size:13px;color:#666666"">
                <th>GroupName</th>
                <th>Permissions</th>
                <th>Actions</th>

            </tr>
        </thead>

        <tbody>
");
            EndContext();
#line 26 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Groups\Index.cshtml"
             foreach (var item in Model.grplist)
            {

#line default
#line hidden
            BeginContext(846, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(893, 35, false);
#line 29 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Groups\Index.cshtml"
                   Write(Html.DisplayFor(model => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(928, 34, true);
            WriteLiteral(" </td>\r\n\r\n                    <td>");
            EndContext();
            BeginContext(963, 66, false);
#line 31 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Groups\Index.cshtml"
                   Write(Html.ActionLink("Permissions", "GroupRoles", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1029, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1031, 32, false);
#line 31 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Groups\Index.cshtml"
                                                                                       Write(Html.HiddenFor(model => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1063, 57, true);
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1120, 137, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6bca279634a44e30bee6ee81d00e0efa", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1196, "location.href=\'", 1196, 15, true);
#line 33 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Groups\Index.cshtml"
AddHtmlAttributeValue("", 1211, Url.Action("Edit", new { id = item.Id }), 1211, 41, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1252, "\'", 1252, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1257, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1283, 138, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ef31c2f7f85a45e3acda87e61e73c23d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1358, "location.href=\'", 1358, 15, true);
#line 34 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Groups\Index.cshtml"
AddHtmlAttributeValue("", 1373, Url.Action("Delete", new { id = item.Id }), 1373, 43, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1416, "\'", 1416, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1421, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1514, 47, true);
            WriteLiteral("                    </td>\r\n                    ");
            EndContext();
            BeginContext(1562, 34, false);
#line 38 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Groups\Index.cshtml"
               Write(Html.HiddenFor(model => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1596, 27, true);
            WriteLiteral("\r\n\r\n                </tr>\r\n");
            EndContext();
#line 41 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Groups\Index.cshtml"

            }

#line default
#line hidden
            BeginContext(1640, 60, true);
            WriteLiteral("\r\n\r\n        </tbody>\r\n\r\n    </table>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GroupViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
