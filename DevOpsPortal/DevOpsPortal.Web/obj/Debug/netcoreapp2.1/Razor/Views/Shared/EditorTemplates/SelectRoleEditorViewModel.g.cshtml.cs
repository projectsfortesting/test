#pragma checksum "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Shared\EditorTemplates\SelectRoleEditorViewModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d4550a148c683bc4907415444844c26beef98f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditorTemplates_SelectRoleEditorViewModel), @"mvc.1.0.view", @"/Views/Shared/EditorTemplates/SelectRoleEditorViewModel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/EditorTemplates/SelectRoleEditorViewModel.cshtml", typeof(AspNetCore.Views_Shared_EditorTemplates_SelectRoleEditorViewModel))]
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
#line 1 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Shared\EditorTemplates\SelectRoleEditorViewModel.cshtml"
using DevOpsSolution.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d4550a148c683bc4907415444844c26beef98f3", @"/Views/Shared/EditorTemplates/SelectRoleEditorViewModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abb8d4e932ebc175a4435bbece14da39301aa8bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_EditorTemplates_SelectRoleEditorViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DevOpsSolution.Models.SelectRoleEditorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(86, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(88, 39, false);
#line 5 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Shared\EditorTemplates\SelectRoleEditorViewModel.cshtml"
Write(Html.HiddenFor(model => model.RoleName));

#line default
#line hidden
            EndContext();
            BeginContext(127, 49, true);
            WriteLiteral("\n<tr>\n    <td style=\"text-align:center\">\n        ");
            EndContext();
            BeginContext(177, 41, false);
#line 8 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Shared\EditorTemplates\SelectRoleEditorViewModel.cshtml"
   Write(Html.CheckBoxFor(model => model.Selected));

#line default
#line hidden
            EndContext();
            BeginContext(218, 55, true);
            WriteLiteral("\n    </td>\n    <td style=\"padding-right:20px\">\n        ");
            EndContext();
            BeginContext(274, 40, false);
#line 11 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Shared\EditorTemplates\SelectRoleEditorViewModel.cshtml"
   Write(Html.DisplayFor(model => model.RoleName));

#line default
#line hidden
            EndContext();
            BeginContext(314, 55, true);
            WriteLiteral("\n    </td>\n    <td style=\"padding-right:20px\">\n        ");
            EndContext();
            BeginContext(370, 43, false);
#line 14 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Shared\EditorTemplates\SelectRoleEditorViewModel.cshtml"
   Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(413, 18, true);
            WriteLiteral("\n    </td>\n</tr>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DevOpsSolution.Models.SelectRoleEditorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
