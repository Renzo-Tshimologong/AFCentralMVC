#pragma checksum "/home/sylvorenzo/dotnet_Projects/AfCentral_MVC/Views/Home/form1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c922528c21bdd59ffa46aae28e3e87cbeea2844e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_form1), @"mvc.1.0.view", @"/Views/Home/form1.cshtml")]
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
#line 1 "/home/sylvorenzo/dotnet_Projects/AfCentral_MVC/Views/_ViewImports.cshtml"
using AfCentral_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/sylvorenzo/dotnet_Projects/AfCentral_MVC/Views/_ViewImports.cshtml"
using AfCentral_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c922528c21bdd59ffa46aae28e3e87cbeea2844e", @"/Views/Home/form1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54c9a02a5d1017f19a695b3d36ddbb2020670d90", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_form1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AfCentral_MVC.Models.Facilitator>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<table>\n    <thead>\n        <tr>\n            <th>Id</th>\n            <th>Name</th>\n            <th>Surname</th>\n            <th>Email</th>\n            <th>Contact</th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 14 "/home/sylvorenzo/dotnet_Projects/AfCentral_MVC/Views/Home/form1.cshtml"
     foreach(var item in Model)
    { 

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 17 "/home/sylvorenzo/dotnet_Projects/AfCentral_MVC/Views/Home/form1.cshtml"
           Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 18 "/home/sylvorenzo/dotnet_Projects/AfCentral_MVC/Views/Home/form1.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 19 "/home/sylvorenzo/dotnet_Projects/AfCentral_MVC/Views/Home/form1.cshtml"
           Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 20 "/home/sylvorenzo/dotnet_Projects/AfCentral_MVC/Views/Home/form1.cshtml"
           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 21 "/home/sylvorenzo/dotnet_Projects/AfCentral_MVC/Views/Home/form1.cshtml"
           Write(item.Contact);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>  \n");
#nullable restore
#line 23 "/home/sylvorenzo/dotnet_Projects/AfCentral_MVC/Views/Home/form1.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AfCentral_MVC.Models.Facilitator>> Html { get; private set; }
    }
}
#pragma warning restore 1591
