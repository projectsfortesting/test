#pragma checksum "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "197bd471ec324dd5d26b128005929552bc7a332e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Index.cshtml", typeof(AspNetCore.Views_Account_Index))]
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
#line 1 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Account\Index.cshtml"
using DevOpsSolution.Models;

#line default
#line hidden
#line 3 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Account\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"197bd471ec324dd5d26b128005929552bc7a332e", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abb8d4e932ebc175a4435bbece14da39301aa8bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DevOpsSolution.Models.EditUserViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/AdminLTE/img/tableico_del.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-title", new global::Microsoft.AspNetCore.Html.HtmlString("Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("deleteUserbtn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Account\Index.cshtml"
   ViewBag.Title = "Users"; 

#line default
#line hidden
            BeginContext(158, 208, true);
            WriteLiteral("<script type=\"text/javascript\" src=\"https://ajax.googleapis.com/ajax/libs/jquery/2.1.3/jquery.min.js\"></script>\r\n<script src=\"http://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js\"></script>\n\n\n\n\n");
            EndContext();
#line 11 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Account\Index.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(401, 23, false);
#line 13 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Account\Index.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(428, 156, true);
            WriteLiteral("    <div id=\"indexcontent\">\r\n        <div align=\"right\">\r\n            <input type=\"button\" class=\"bg-blue-active\" name=\"btnCreate\" value=\"+ Create New User\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 584, "\"", 641, 3);
            WriteAttributeValue("", 594, "onclick=location.href=\'", 594, 23, true);
#line 17 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Account\Index.cshtml"
WriteAttributeValue("", 617, Url.Action("Register"), 617, 23, false);

#line default
#line hidden
            WriteAttributeValue("", 640, "\'", 640, 1, true);
            EndWriteAttribute();
            BeginContext(642, 271, true);
            WriteLiteral(@" />
        </div>

        <div class=""table-responsive"">
            <table id=""UsersList"" class=""table table-bordered"">
                <tr class=""bg-gray"" style=""font-family:Arial;font-size:13px;color:#666666"">
                    <th>
                        ");
            EndContext();
            BeginContext(914, 44, false);
#line 24 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Account\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(958, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1038, 45, false);
#line 27 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Account\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1083, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1163, 44, false);
#line 30 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Account\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1207, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1287, 41, false);
#line 33 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Account\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1328, 90, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>Actions</th>\r\n                </tr>\r\n");
            EndContext();
#line 37 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Account\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1483, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1568, 43, false);
#line 41 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Account\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1611, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1703, 44, false);
#line 44 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Account\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1747, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1839, 43, false);
#line 47 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Account\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1882, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1974, 40, false);
#line 50 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Account\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2014, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2106, 67, false);
#line 53 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Account\Index.cshtml"
                       Write(Html.ActionLink("Groups", "UserGroups", new { id = item.UserName }));

#line default
#line hidden
            EndContext();
            BeginContext(2173, 32, true);
            WriteLiteral(" |\r\n                            ");
            EndContext();
            BeginContext(2206, 87, false);
#line 54 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Account\Index.cshtml"
                       Write(Html.ActionLink("Effective Permissions", "UserPermissions", new { id = item.UserName }));

#line default
#line hidden
            EndContext();
            BeginContext(2293, 32, true);
            WriteLiteral(" |\r\n                            ");
            EndContext();
            BeginContext(2326, 59, false);
#line 55 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Account\Index.cshtml"
                       Write(Html.ActionLink("Edit", "Edit", new { id = item.UserName }));

#line default
#line hidden
            EndContext();
            BeginContext(2385, 3, true);
            WriteLiteral("|\r\n");
            EndContext();
            BeginContext(2778, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(2806, 180, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6a62a86b7ea74ce7aabbe05541b3cd7a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginWriteTagHelperAttribute();
#line 58 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Account\Index.cshtml"
                                                                                                                                                                                         Write(item.UserName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-usrid", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2986, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3555, 58, true);
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 66 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Account\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(3632, 1831, true);
            WriteLiteral(@"            </table>

        </div>
        <div class=""modal fade"" id=""delete"" tabindex=""-1"" role=""dialog"" aria-labelledby=""edit"" aria-hidden=""true"">
            <div class=""modal-dialog"" style=""display:table-cell;vertical-align:middle"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <button type=""button"" class=""close"" aria-hidden=""true""><span class=""glyphicon glyphicon-remove"" aria-hidden=""true""></span></button>
                        <h4 class=""modal-title custom_align"" id=""Heading"">Delete User</h4>
                    </div>
                    <div class=""modal-body"">
                        <div class=""alert alert-danger""><span class=""glyphicon glyphicon-warning-sign""></span>Are you sure you want to delete the following user?</div>

                    </div>
                    <div class=""modal-footer"">
                        <input type=""hidden"" id=""usrid"" />
                        <div>
                         ");
            WriteLiteral(@"   <div class=""col-md-offset-2 col-md-10"">
                                <div class=""col-md-4"">
                                    <button type=""button"" id=""DeleteYesBtn"" class=""bg-blue-active"" data-dismiss=""modal"" onclick=""deleteclick()"">Yes,Delete</button>
                                </div>
                                <div class=""col-md-4"">
                                    <button type=""button"" class=""btn-default text-blue"" style=""width:60pt"" data-dismiss=""modal"">No</button>
                                </div>

                            </div>


                        </div>

                    </div>
                    <!-- /.modal-content -->
                </div>
                <!-- /.modal-dialog -->
            </div>
        </div>

    </div>
");
            EndContext();
            BeginContext(5468, 867, true);
            WriteLiteral(@"    <div>
            <div class=""modal fade"" id=""authorizefailedPopup"" tabindex=""-1"" role=""dialog"" aria-labelledby=""edit"" aria-hidden=""true"">
                <div class=""modal-dialog"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h4 class=""modal-title custom_align"" id=""Heading"">Authorization Failed</h4>
                        </div>
                        <div class=""modal-body"" id=""authorizecontainer"">
                            <h2>You are not authorized to perform this action. Please contact administrator to get permissions</h2>
                        </div>
                    </div>

                    <!-- /.modal-content -->
                </div>
                <!-- /.modal-dialog -->
            </div>
        </div> <!-- authorize popup-->
");
            EndContext();
#line 124 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Account\Index.cshtml"
}

#line default
#line hidden
            BeginContext(6431, 530, true);
            WriteLiteral(@"
<script>
    $('#delete').on('show.bs.modal', function (event) {

        var usrid = $(event.relatedTarget).data('usrid');
        $('#usrid').val(usrid);

    })

</script>

<script>
    function deleteclick( )
    {
        //$("".deleteUserbtn"").on(""click"", ""#DeleteYesBtn"", function (event) {
            var usrid = $('#usrid').val();
            console.log(usrid);
         
            //event.preventDefault();   
            $('#delete').modal('hide');
          //  alert(usrid);
            $.post('");
            EndContext();
            BeginContext(6962, 31, false);
#line 151 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Account\Index.cshtml"
               Write(Url.Action("Delete", "Account"));

#line default
#line hidden
            EndContext();
            BeginContext(6993, 267, true);
            WriteLiteral(@"',
                    { id: usrid, ""__RequestVerificationToken"": $('input[name=__RequestVerificationToken]').val() })
                    .done( function(response) {
                        alert('Successfully Deleted the Selected User'); window.location.href = '");
            EndContext();
            BeginContext(7261, 30, false);
#line 154 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Account\Index.cshtml"
                                                                                            Write(Url.Action("Index", "Account"));

#line default
#line hidden
            EndContext();
            BeginContext(7291, 365, true);
            WriteLiteral(@"';} )
             .fail(function (xhr, textStatus, errorThrown) {
                 alert(xhr.responseText);
             }
                    
                 );
            event.defaultPrevented;           
            return false;
        //});
    }


</script>

<script>
    $(document).ready(function () {

        var isnotauthorized = '");
            EndContext();
            BeginContext(7657, 34, false);
#line 171 "C:\Users\ramanathanso\source\repos\DevOpsPortal\DevOpsPortal.Web\Views\Account\Index.cshtml"
                          Write(ViewData["OpenAuthorizationPopup"]);

#line default
#line hidden
            EndContext();
            BeginContext(7691, 348, true);
            WriteLiteral(@"';

        if (isnotauthorized)
            {
                $('#authorizefailedPopup').modal('show');
                $('#indexcontent').hide();
            }
            else
            {
                $('#authorizefailedPopup').modal('hide');
                $('#indexcontent').show();
            }

        });

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DevOpsSolution.Models.EditUserViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
