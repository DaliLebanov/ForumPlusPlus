#pragma checksum "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Profile\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "471ca43e0666c62eed7e86d60aab56a4f8c776d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Detail), @"mvc.1.0.view", @"/Views/Profile/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Profile/Detail.cshtml", typeof(AspNetCore.Views_Profile_Detail))]
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
#line 1 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\_ViewImports.cshtml"
using ForumPlusPlus;

#line default
#line hidden
#line 2 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\_ViewImports.cshtml"
using ForumPlusPlus.Models;

#line default
#line hidden
#line 3 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\_ViewImports.cshtml"
using ForumPlusPlus.Models.ForumViewModels;

#line default
#line hidden
#line 4 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\_ViewImports.cshtml"
using ForumPlusPlus.Models.PostViewModels;

#line default
#line hidden
#line 5 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\_ViewImports.cshtml"
using ForumPP.WebModels.AccontViewModels;

#line default
#line hidden
#line 6 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 7 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\_ViewImports.cshtml"
using ForumPlusPlus.Models.SearchViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"471ca43e0666c62eed7e86d60aab56a4f8c776d2", @"/Views/Profile/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9b56adb87c7a88b1f0b0aef12d1f51c4cf3da8b", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProfileModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UploadProfileImage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 150, true);
            WriteLiteral("\r\n<div class=\"container body-content\">\r\n   \r\n    <div class=\"row userProfile\">\r\n        <div class=\"col-md-4\">\r\n            <div id=\"userPorfileImage\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 171, "\"", 223, 3);
            WriteAttributeValue("", 179, "background-image:url(", 179, 21, true);
#line 7 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Profile\Detail.cshtml"
WriteAttributeValue("", 200, Model.ProfileImageUrl, 200, 22, false);

#line default
#line hidden
            WriteAttributeValue("", 222, ")", 222, 1, true);
            EndWriteAttribute();
            BeginContext(224, 9, true);
            WriteLiteral("></div>\r\n");
            EndContext();
#line 8 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Profile\Detail.cshtml"
             if (User.Identity.Name == Model.UserName)
            {

#line default
#line hidden
            BeginContext(304, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(320, 510, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "057aca184b174dd1ab16aaa70fbaa536", async() => {
                BeginContext(427, 396, true);
                WriteLiteral(@"
                    <div id=""upload"">
                        <label class=""btn btn-default btn-file  photoUploader"">
                            Browse <input type=""file"" style=""display:none"" class=""fileName"" />
                        </label>
                    </div>
                    <button type=""submit"" id=""btn-profile"" class=""btn btn-default"">Submit</button>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(830, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 18 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Profile\Detail.cshtml"
            }

#line default
#line hidden
            BeginContext(847, 80, true);
            WriteLiteral("        </div>\r\n        <div class=\"col-md-8\">\r\n            <span id=\"userName\">");
            EndContext();
            BeginContext(928, 14, false);
#line 21 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Profile\Detail.cshtml"
                           Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(942, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 22 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Profile\Detail.cshtml"
             if (Model.IsAdmin)
            {

#line default
#line hidden
            BeginContext(999, 52, true);
            WriteLiteral("                <span class=\"isAdmin\">Admin</span>\r\n");
            EndContext();
#line 25 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Profile\Detail.cshtml"
            }

#line default
#line hidden
            BeginContext(1066, 50, true);
            WriteLiteral("            <span id=\"userRating\">Current Rating: ");
            EndContext();
            BeginContext(1117, 16, false);
#line 26 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Profile\Detail.cshtml"
                                             Write(Model.UserRating);

#line default
#line hidden
            EndContext();
            BeginContext(1133, 54, true);
            WriteLiteral("</span>\r\n            <span id=\"userEmailLabel\">Email: ");
            EndContext();
            BeginContext(1188, 11, false);
#line 27 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Profile\Detail.cshtml"
                                        Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1199, 63, true);
            WriteLiteral("</span>\r\n            <span id=\"userCreatedLabel\">Member Since: ");
            EndContext();
            BeginContext(1263, 40, false);
#line 28 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Profile\Detail.cshtml"
                                                 Write(Model.MemberSince.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1303, 47, true);
            WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1368, 327, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('.photoUploader').on(""change"", function () {
                var fileName = $('.fileName').val().split('\\').pop();;
                $('.photoUploader').html(fileName);
                console.log(fileName)
            });
        });
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProfileModel> Html { get; private set; }
    }
}
#pragma warning restore 1591