#pragma checksum "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10ed8866b41cfe3138fc39a6fbc0533bf47ffd1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 8 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\_ViewImports.cshtml"
using ForumPlusPlus.Models.ReplyViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10ed8866b41cfe3138fc39a6fbc0533bf47ffd1e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0eea98176e785b9441c5c9b412f594f4ba4d0925", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ForumIndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("homeSearch"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Search..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Forum", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Topic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(24, 367, true);
            WriteLiteral(@"
    <div class=""container body-content"">
        <div class=""row frontPageSplash"">
            <div class=""col-md-6 frontPageLearn"">
                <div class=""frontPageHeading"">Learn, Collaborate, Share Knowlage</div>
                <p class=""frontPageSubHeading"">Forum ++ is the world's fastest growing forum</p>
                <div>
                    ");
            EndContext();
            BeginContext(391, 205, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4800dfd2e4d54aab90f3534c3f802848", async() => {
                BeginContext(455, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(481, 86, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "709eaa483ec042e29560efd27e29534b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 10 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchQuery);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(567, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(596, 298, true);
            WriteLiteral(@"
                </div>
            </div>
            <div class=""col-md-6""></div>
        </div>

        <div class=""row frontPageContent"">
            <h3 id=""latestsPosts"">Latest Posts</h3>
            <table class=""table table-hover"" id=""latestsPostsTable"">
                <tbody>
");
            EndContext();
#line 21 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Home\Index.cshtml"
                     foreach (var post in Model.LatestPosts)
                    {

#line default
#line hidden
            BeginContext(979, 118, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <div class=\"forumLogo\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1097, "\"", 1171, 5);
            WriteAttributeValue("", 1105, "background-image:", 1105, 17, true);
            WriteAttributeValue(" ", 1122, "url(", 1123, 5, true);
#line 25 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Home\Index.cshtml"
WriteAttributeValue("", 1127, post.Forum.ImageUrl, 1127, 20, false);

#line default
#line hidden
            WriteAttributeValue("", 1147, ");", 1147, 2, true);
            WriteAttributeValue(" ", 1149, "background-size:100%;", 1150, 22, true);
            EndWriteAttribute();
            BeginContext(1172, 102, true);
            WriteLiteral("></div>\r\n                                <div class=\"postTitle\">\r\n                                    ");
            EndContext();
            BeginContext(1274, 167, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7db275e115548cb97078abf6e73c089", async() => {
                BeginContext(1346, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(1389, 10, false);
#line 28 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Home\Index.cshtml"
                                   Write(post.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1399, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-postId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 27 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Home\Index.cshtml"
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
            BeginContext(1441, 102, true);
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"postSubTitle\">\r\n");
            EndContext();
#line 32 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Home\Index.cshtml"
                                     if (post.RepliesCount == 0)
                                    {

#line default
#line hidden
            BeginContext(1648, 65, true);
            WriteLiteral("                                        <span>No Replies</span>\r\n");
            EndContext();
#line 35 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Home\Index.cshtml"
                                    }
                                    else if (post.RepliesCount == 1)
                                    {

#line default
#line hidden
            BeginContext(1861, 46, true);
            WriteLiteral("                                        <span>");
            EndContext();
            BeginContext(1908, 17, false);
#line 38 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Home\Index.cshtml"
                                         Write(post.RepliesCount);

#line default
#line hidden
            EndContext();
            BeginContext(1925, 15, true);
            WriteLiteral(" Reply</span>\r\n");
            EndContext();
#line 39 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Home\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(2060, 46, true);
            WriteLiteral("                                        <span>");
            EndContext();
            BeginContext(2107, 17, false);
#line 42 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Home\Index.cshtml"
                                         Write(post.RepliesCount);

#line default
#line hidden
            EndContext();
            BeginContext(2124, 17, true);
            WriteLiteral(" Replies</span>\r\n");
            EndContext();
#line 43 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2180, 151, true);
            WriteLiteral("                                    <span class=\"postUser\">\r\n                                        Post by:\r\n                                        ");
            EndContext();
            BeginContext(2331, 282, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c268b818833245e5b4698994fc77b697", async() => {
                BeginContext(2501, 48, true);
                WriteLiteral("\r\n\r\n                                            ");
                EndContext();
                BeginContext(2550, 15, false);
#line 50 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Home\Index.cshtml"
                                       Write(post.AuthorName);

#line default
#line hidden
                EndContext();
                BeginContext(2565, 44, true);
                WriteLiteral("\r\n\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Home\Index.cshtml"
                                                 WriteLiteral(post.AuthorId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2613, 153, true);
            WriteLiteral("\r\n                                    </span>\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 57 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2789, 273, true);
            WriteLiteral(@"                </tbody>
            </table>
        </div>
        <br />
        <div class=""row frontPageContent"">
            <h3 id=""latestsPosts"">Latest Forums</h3>
            <table class=""table table-hover"" id=""latestsPostsTable"">
                <tbody>
");
            EndContext();
#line 66 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Home\Index.cshtml"
                     foreach (var forum in Model.ForumViewModels)
                    {

#line default
#line hidden
            BeginContext(3152, 118, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <div class=\"forumLogo\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 3270, "\"", 3339, 5);
            WriteAttributeValue("", 3278, "background-image:", 3278, 17, true);
            WriteAttributeValue(" ", 3295, "url(", 3296, 5, true);
#line 70 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Home\Index.cshtml"
WriteAttributeValue("", 3300, forum.ImageUrl, 3300, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 3315, ");", 3315, 2, true);
            WriteAttributeValue(" ", 3317, "background-size:100%;", 3318, 22, true);
            EndWriteAttribute();
            BeginContext(3340, 102, true);
            WriteLiteral("></div>\r\n                                <div class=\"postTitle\">\r\n                                    ");
            EndContext();
            BeginContext(3442, 170, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dca57a0d57c24ca1b799dabfef023ae5", async() => {
                BeginContext(3517, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(3560, 10, false);
#line 73 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Home\Index.cshtml"
                                   Write(forum.Name);

#line default
#line hidden
                EndContext();
                BeginContext(3570, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-forumId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Home\Index.cshtml"
                                                                                        WriteLiteral(forum.Id);

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
            BeginContext(3612, 102, true);
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"postSubTitle\">\r\n");
            EndContext();
#line 77 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Home\Index.cshtml"
                                     if (forum.PostsCount == 0)
                                    {

#line default
#line hidden
            BeginContext(3818, 63, true);
            WriteLiteral("                                        <span>No posts</span>\r\n");
            EndContext();
#line 80 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Home\Index.cshtml"
                                    }
                                    else if (forum.PostsCount == 1)
                                    {

#line default
#line hidden
            BeginContext(4028, 46, true);
            WriteLiteral("                                        <span>");
            EndContext();
            BeginContext(4075, 16, false);
#line 83 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Home\Index.cshtml"
                                         Write(forum.PostsCount);

#line default
#line hidden
            EndContext();
            BeginContext(4091, 14, true);
            WriteLiteral(" post</span>\r\n");
            EndContext();
#line 84 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Home\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(4225, 46, true);
            WriteLiteral("                                        <span>");
            EndContext();
            BeginContext(4272, 16, false);
#line 87 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Home\Index.cshtml"
                                         Write(forum.PostsCount);

#line default
#line hidden
            EndContext();
            BeginContext(4288, 15, true);
            WriteLiteral(" posts</span>\r\n");
            EndContext();
#line 88 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4342, 158, true);
            WriteLiteral("\r\n\r\n\r\n                                    <span class=\"postUser\">\r\n                                        Forum by:\r\n                                        ");
            EndContext();
            BeginContext(4500, 296, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79bee2dfaf2a497e89fcf1414a47431d", async() => {
                BeginContext(4669, 46, true);
                WriteLiteral("\r\n                                            ");
                EndContext();
                BeginContext(4716, 14, false);
#line 97 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Home\Index.cshtml"
                                       Write(forum.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(4730, 2, true);
                WriteLiteral(" (");
                EndContext();
                BeginContext(4733, 16, false);
#line 97 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Home\Index.cshtml"
                                                        Write(forum.UserRating);

#line default
#line hidden
                EndContext();
                BeginContext(4749, 43, true);
                WriteLiteral(")\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 96 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Home\Index.cshtml"
                                                 WriteLiteral(forum.UserId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4796, 153, true);
            WriteLiteral("\r\n                                    </span>\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 103 "C:\Users\Dali\Desktop\ForumPlusPlus\ForumPlusPlus\ForumPlusPlus\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(4972, 74, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ForumIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
