#pragma checksum "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7680f14006f40c88bb8aeeb987fc40cb0327574"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Index), @"mvc.1.0.view", @"/Views/Students/Index.cshtml")]
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
#line 9 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Index.cshtml"
using UniversityRegistrar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7680f14006f40c88bb8aeeb987fc40cb0327574", @"/Views/Students/Index.cshtml")]
    public class Views_Students_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UniversityRegistrar.Models.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<header>\r\n  <h5>");
#nullable restore
#line 6 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Index.cshtml"
 Write(Html.ActionLink("ADD NEW STUDENT", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n</header>\r\n\r\n");
            WriteLiteral("\r\n<h1>Students</h1>\r\n");
#nullable restore
#line 13 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h4>\"There doesn\'t appear to be any students enrolled yet\"</h4>\r\n");
#nullable restore
#line 16 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 18 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Index.cshtml"
 foreach(Student student in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <li>");
#nullable restore
#line 20 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Index.cshtml"
 Write(Html.ActionLink($"{student.Name}", "Details", new { id = student.StudentId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 21 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UniversityRegistrar.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
