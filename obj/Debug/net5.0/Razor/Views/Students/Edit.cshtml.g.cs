#pragma checksum "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb5c77391fbbec3e1bb8c20d52ebe47d64d0d5d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Edit), @"mvc.1.0.view", @"/Views/Students/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb5c77391fbbec3e1bb8c20d52ebe47d64d0d5d7", @"/Views/Students/Edit.cshtml")]
    public class Views_Students_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UniversityRegistrar.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<header>\r\n  <p><strong>");
#nullable restore
#line 6 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Edit.cshtml"
        Write(Html.ActionLink("STUDENTS", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n</header>\r\n\r\n");
            WriteLiteral("\r\n<h2>Edit</h2>\r\n\r\n<h4>Edit this student profile: ");
#nullable restore
#line 13 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Edit.cshtml"
                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Edit.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Edit.cshtml"
Write(Html.HiddenFor(model => model.StudentId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Edit.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Edit.cshtml"
Write(Html.EditorFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Edit.cshtml"
Write(Html.LabelFor(model => model.DateOfEnrollment));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Edit.cshtml"
                                                 ;
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Edit.cshtml"
Write(Html.TextBoxFor(model => model.DateOfEnrollment, new { type = "date"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Edit.cshtml"
                                                                         ;


#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Save\" />\r\n");
#nullable restore
#line 26 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UniversityRegistrar.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
