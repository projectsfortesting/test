#pragma checksum "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Groups\GroupRoles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f821e24ac969b3dc7ca7b9c74df6f0a8b850a43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Groups_GroupRoles), @"mvc.1.0.view", @"/Views/Groups/GroupRoles.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Groups/GroupRoles.cshtml", typeof(AspNetCore.Views_Groups_GroupRoles))]
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
#line 1 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Groups\GroupRoles.cshtml"
using DevOpsSolution.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f821e24ac969b3dc7ca7b9c74df6f0a8b850a43", @"/Views/Groups/GroupRoles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abb8d4e932ebc175a4435bbece14da39301aa8bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Groups_GroupRoles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DevOpsSolution.Models.SelectGroupRolesViewModel>
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
            BeginContext(152, 10, true);
            WriteLiteral("<h3>Group ");
            EndContext();
            BeginContext(163, 41, false);
#line 8 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Groups\GroupRoles.cshtml"
     Write(Html.DisplayFor(model => model.GroupName));

#line default
#line hidden
            EndContext();
            BeginContext(204, 20, true);
            WriteLiteral(":Permissions</h3>\n\n\n");
            EndContext();
#line 11 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Groups\GroupRoles.cshtml"
 using (Html.BeginForm("GroupRoles", "Groups", FormMethod.Post, new { encType = "multipart/form-data", name = "myform" }))
{
    

#line default
#line hidden
            BeginContext(354, 23, false);
#line 13 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Groups\GroupRoles.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(378, 42, true);
            WriteLiteral("    <div class=\"form-horizontal\">\n        ");
            EndContext();
            BeginContext(421, 28, false);
#line 15 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Groups\GroupRoles.cshtml"
   Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
            BeginContext(449, 86, true);
            WriteLiteral("\n        <div class=\"form-group\">\n            <div class=\"col-md-10\">\n                ");
            EndContext();
            BeginContext(536, 40, false);
#line 18 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Groups\GroupRoles.cshtml"
           Write(Html.HiddenFor(model => model.GroupName));

#line default
#line hidden
            EndContext();
            BeginContext(576, 120, true);
            WriteLiteral("\n            </div>\n        </div>\n        <div class=\"form-group\">\n            <div class=\"col-md-10\">\n                ");
            EndContext();
            BeginContext(697, 38, false);
#line 23 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Groups\GroupRoles.cshtml"
           Write(Html.HiddenFor(model => model.GroupId));

#line default
#line hidden
            EndContext();
            BeginContext(735, 427, true);
            WriteLiteral(@"
            </div>
        </div>
      
        <table class=""table table-bordered"">
            <tr class=""bg-gray"" style=""font-family:Arial;font-size:13px;color:#666666"">
                <th>
                    Select
                </th>
                <th>
                    Permissions
                </th>
                <th>
                    Description
                </th>
            </tr>
            ");
            EndContext();
            BeginContext(1163, 36, false);
#line 39 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Groups\GroupRoles.cshtml"
       Write(Html.EditorFor(model => model.Roles));

#line default
#line hidden
            EndContext();
            BeginContext(1199, 255, true);
            WriteLiteral("\n        </table>\n        <br />\n        <hr />\n        <div class=\"form-group\">\n            <div class=\"col-md-offset-2 col-md-10\">\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-default\" />\n            </div>\n        </div>\n    </div>\n");
            EndContext();
#line 49 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Groups\GroupRoles.cshtml"
}

#line default
#line hidden
            BeginContext(1456, 10, true);
            WriteLiteral("<div>\n    ");
            EndContext();
            BeginContext(1467, 40, false);
#line 51 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Groups\GroupRoles.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1507, 9, true);
            WriteLiteral("\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DevOpsSolution.Models.SelectGroupRolesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
