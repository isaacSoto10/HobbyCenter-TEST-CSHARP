#pragma checksum "C:\Users\isaac\OneDrive\Desktop\Wos_files\WOS_algos\HobbyCenter-master\Views\Home\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be43abec3e836a63b77d131a598fc95f9637e557"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
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
#nullable restore
#line 1 "C:\Users\isaac\OneDrive\Desktop\Wos_files\WOS_algos\HobbyCenter-master\Views\_ViewImports.cshtml"
using HobbyCenter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\isaac\OneDrive\Desktop\Wos_files\WOS_algos\HobbyCenter-master\Views\_ViewImports.cshtml"
using HobbyCenter.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be43abec3e836a63b77d131a598fc95f9637e557", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1db0033c5ac55ade400cbcb1bbd36cb6bcb3bc7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Hobby>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "New", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 1 "C:\Users\isaac\OneDrive\Desktop\Wos_files\WOS_algos\HobbyCenter-master\Views\Home\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("    \n<h1> Hobbies </h1>\n\n<TABLE BORDER=2 FRAME=BOX RULES=ALL> \n    <thead>\n        <th>Name of Hobby</th>\n\n        <th>Enthusiasts</th>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 16 "C:\Users\isaac\OneDrive\Desktop\Wos_files\WOS_algos\HobbyCenter-master\Views\Home\Dashboard.cshtml"
         foreach(Hobby hobby in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td> <a");
            BeginWriteAttribute("href", " href=\"", 304, "\"", 334, 2);
            WriteAttributeValue("", 311, "/Details/", 311, 9, true);
#nullable restore
#line 18 "C:\Users\isaac\OneDrive\Desktop\Wos_files\WOS_algos\HobbyCenter-master\Views\Home\Dashboard.cshtml"
WriteAttributeValue("", 320, hobby.HobbyId, 320, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 18 "C:\Users\isaac\OneDrive\Desktop\Wos_files\WOS_algos\HobbyCenter-master\Views\Home\Dashboard.cshtml"
                                                   Write(hobby.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></td>\n                <td>");
#nullable restore
#line 19 "C:\Users\isaac\OneDrive\Desktop\Wos_files\WOS_algos\HobbyCenter-master\Views\Home\Dashboard.cshtml"
               Write(hobby.HobbyLiker.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 20 "C:\Users\isaac\OneDrive\Desktop\Wos_files\WOS_algos\HobbyCenter-master\Views\Home\Dashboard.cshtml"
                     if(ViewBag.Id == @hobby.HobbyOwner.UserId)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td> <a href=\"/deletehobby/hobby.HobbyId\">| Delete |</a></td>\n");
#nullable restore
#line 23 "C:\Users\isaac\OneDrive\Desktop\Wos_files\WOS_algos\HobbyCenter-master\Views\Home\Dashboard.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\n");
#nullable restore
#line 25 "C:\Users\isaac\OneDrive\Desktop\Wos_files\WOS_algos\HobbyCenter-master\Views\Home\Dashboard.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</Table>\n\n<div class=\"button\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be43abec3e836a63b77d131a598fc95f9637e5576424", async() => {
                WriteLiteral("Create a Hobby");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Hobby>> Html { get; private set; }
    }
}
#pragma warning restore 1591
