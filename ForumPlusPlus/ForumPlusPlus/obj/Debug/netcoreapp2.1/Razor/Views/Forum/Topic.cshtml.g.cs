#pragma checksum "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Forum\Topic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ae4073e90d3217ee6550542168c048a5f579ae3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Forum_Topic), @"mvc.1.0.view", @"/Views/Forum/Topic.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Forum/Topic.cshtml", typeof(AspNetCore.Views_Forum_Topic))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ae4073e90d3217ee6550542168c048a5f579ae3", @"/Views/Forum/Topic.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"959b71bb4870c0ab3519761e840da66a9afddcfc", @"/Views/_ViewImports.cshtml")]
    public class Views_Forum_Topic : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ForumTopicModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(24, 23, true);
            WriteLiteral("\r\n\r\n<h1>Welcome to the ");
            EndContext();
            BeginContext(48, 16, false);
#line 4 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Forum\Topic.cshtml"
              Write(Model.Forum.Name);

#line default
#line hidden
            EndContext();
            BeginContext(64, 42, true);
            WriteLiteral(" Forum!</h1>\r\n<span id=\"headingBtn\">\r\n    ");
            EndContext();
            BeginContext(106, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d5256f10105449d9e275b0b5c1b4f9d", async() => {
                BeginContext(211, 12, true);
                WriteLiteral("Create Post ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-forumId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 6 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Forum\Topic.cshtml"
                                                        WriteLiteral(Model.Forum.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["forumId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-forumId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["forumId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(227, 13, true);
            WriteLiteral("\r\n</span>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Forum\Topic.cshtml"
 if (Model.Posts.Any())
{

#line default
#line hidden
            BeginContext(268, 71, true);
            WriteLiteral("    <table class=\"table table-bordered table-hover\">\r\n        <tbody>\r\n");
            EndContext();
#line 13 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Forum\Topic.cshtml"
             foreach (var post in Model.Posts)
            {

#line default
#line hidden
            BeginContext(402, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(474, 143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "baa5cfb5e1e0402592bb0fed1fa4c447", async() => {
                BeginContext(546, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(577, 10, false);
#line 18 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Forum\Topic.cshtml"
                       Write(post.Title);

#line default
#line hidden
                EndContext();
                BeginContext(587, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-postId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 17 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Forum\Topic.cshtml"
                                                                          WriteLiteral(post.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-postId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(617, 53, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
            EndContext();
            BeginContext(671, 15, false);
#line 21 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Forum\Topic.cshtml"
                   Write(post.AuthorName);

#line default
#line hidden
            EndContext();
            BeginContext(686, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(718, 15, false);
#line 22 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Forum\Topic.cshtml"
                   Write(post.DatePosted);

#line default
#line hidden
            EndContext();
            BeginContext(733, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(765, 17, false);
#line 23 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Forum\Topic.cshtml"
                   Write(post.RepliesCount);

#line default
#line hidden
            EndContext();
            BeginContext(782, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 25 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Forum\Topic.cshtml"
            }

#line default
#line hidden
            BeginContext(827, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 28 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Forum\Topic.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(871, 80, true);
            WriteLiteral("    <div class=\"noPosts\">\r\n        <h3>\r\n            It looks like there are no ");
            EndContext();
            BeginContext(952, 16, false);
#line 33 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Forum\Topic.cshtml"
                                  Write(Model.Forum.Name);

#line default
#line hidden
            EndContext();
            BeginContext(968, 52, true);
            WriteLiteral(" posts yet <br />\r\n            Why not\r\n            ");
            EndContext();
            BeginContext(1020, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18944e5a9d9a473e8f946dcd9f909943", async() => {
                BeginContext(1101, 51, true);
                WriteLiteral("\r\n                <span>Create</span>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-forumId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 35 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Forum\Topic.cshtml"
                                                                WriteLiteral(Model.Forum.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["forumId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-forumId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["forumId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1156, 47, true);
            WriteLiteral("\r\n            one?\r\n        </h3>\r\n    </div>\r\n");
            EndContext();
#line 41 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Forum\Topic.cshtml"
}

#line default
#line hidden
            BeginContext(1206, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ForumTopicModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
