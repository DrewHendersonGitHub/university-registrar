#pragma checksum "C:\Users\DrewH\Desktop\university-registrar\Views\Students\AddCourse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d259a29d82cd0be607092162875f5d2b6004ad0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_AddCourse), @"mvc.1.0.view", @"/Views/Students/AddCourse.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d259a29d82cd0be607092162875f5d2b6004ad0e", @"/Views/Students/AddCourse.cshtml")]
    public class Views_Students_AddCourse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UniversityRegistrar.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\AddCourse.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<header>\r\n  <p><strong>");
#nullable restore
#line 6 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\AddCourse.cshtml"
        Write(Html.ActionLink("STUDENTS", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n</header>\r\n\r\n");
            WriteLiteral("\r\n<h1>Add a Course</h1>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\AddCourse.cshtml"
 using (@Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\AddCourse.cshtml"
Write(Html.HiddenFor(model => model.StudentId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\AddCourse.cshtml"
                                           ;

  

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\AddCourse.cshtml"
Write(Html.Label("Select Course: "));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\AddCourse.cshtml"
                                ;
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\AddCourse.cshtml"
Write(Html.DropDownList("CourseId"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\AddCourse.cshtml"
                                ;


#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"SAVE\" required/>\r\n");
#nullable restore
#line 21 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\AddCourse.cshtml"
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