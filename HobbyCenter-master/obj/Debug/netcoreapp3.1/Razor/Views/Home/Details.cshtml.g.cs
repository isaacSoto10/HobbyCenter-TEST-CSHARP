#pragma checksum "C:\Users\isaac\OneDrive\Desktop\Wos_files\WOS_algos\HobbyCenter-master\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "312f474e3c4e0ec62cb0e7f4027c5aa55579abb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"312f474e3c4e0ec62cb0e7f4027c5aa55579abb8", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1db0033c5ac55ade400cbcb1bbd36cb6bcb3bc7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Hobby>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\isaac\OneDrive\Desktop\Wos_files\WOS_algos\HobbyCenter-master\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Hobby Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"headder\">\n    <h1> ");
#nullable restore
#line 7 "C:\Users\isaac\OneDrive\Desktop\Wos_files\WOS_algos\HobbyCenter-master\Views\Home\Details.cshtml"
    Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\n    <br>\n    <br>\n    <h3>Description:</h3>\n    <br>\n    <p> ");
#nullable restore
#line 12 "C:\Users\isaac\OneDrive\Desktop\Wos_files\WOS_algos\HobbyCenter-master\Views\Home\Details.cshtml"
   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n    <br>\n    <hr>\n\n</div>\n<div class=\"leftside\">\n    <h3> All the ");
#nullable restore
#line 18 "C:\Users\isaac\OneDrive\Desktop\Wos_files\WOS_algos\HobbyCenter-master\Views\Home\Details.cshtml"
            Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Enthusiasts:</h3>\n    <div class=\"box\">\n        <table>\n");
#nullable restore
#line 21 "C:\Users\isaac\OneDrive\Desktop\Wos_files\WOS_algos\HobbyCenter-master\Views\Home\Details.cshtml"
         foreach(Enthusiast liker in Model.HobbyLiker)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td> ");
#nullable restore
#line 24 "C:\Users\isaac\OneDrive\Desktop\Wos_files\WOS_algos\HobbyCenter-master\Views\Home\Details.cshtml"
                    Write(liker.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 24 "C:\Users\isaac\OneDrive\Desktop\Wos_files\WOS_algos\HobbyCenter-master\Views\Home\Details.cshtml"
                                          Write(liker.User.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                </tr>\n");
#nullable restore
#line 26 "C:\Users\isaac\OneDrive\Desktop\Wos_files\WOS_algos\HobbyCenter-master\Views\Home\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\n    </div>\n    <hr>\n</div>\n<div class=\"rightside\">\n    <h3>Click below to be an Enthusiast</h3>\n    \n    <div class=\"button\">\n        <a");
            BeginWriteAttribute("href", " href=\"", 681, "\"", 712, 2);
            WriteAttributeValue("", 688, "/AddHobby/", 688, 10, true);
#nullable restore
#line 35 "C:\Users\isaac\OneDrive\Desktop\Wos_files\WOS_algos\HobbyCenter-master\Views\Home\Details.cshtml"
WriteAttributeValue("", 698, Model.HobbyId, 698, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">| Add to Hobbies |</a>\n    </div>\n    <hr>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hobby> Html { get; private set; }
    }
}
#pragma warning restore 1591