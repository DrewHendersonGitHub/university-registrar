#pragma checksum "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abe532e278fb34209d6be7ffa1a5ad6b10166926"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Details), @"mvc.1.0.view", @"/Views/Students/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abe532e278fb34209d6be7ffa1a5ad6b10166926", @"/Views/Students/Details.cshtml")]
    public class Views_Students_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UniversityRegistrar.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\nli{\r\nlist-style: none;\r\n}\r\n</style>\r\n\r\n<header>\r\n  <p id=\"course-list\"><strong>");
#nullable restore
#line 12 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Details.cshtml"
                         Write(Html.ActionLink("ADD A COURSE", "AddCourse", new { id = Model.StudentId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n  <p id=\"student-list\"><strong>");
#nullable restore
#line 13 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Details.cshtml"
                          Write(Html.ActionLink("STUDENTS", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n    <p id=\"edit\"><strong>");
#nullable restore
#line 14 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Details.cshtml"
                    Write(Html.ActionLink("EDIT", "Edit", new { id = Model.StudentId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n<p id=\"delete\"><strong>");
#nullable restore
#line 15 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Details.cshtml"
                  Write(Html.ActionLink("DELETE", "Delete", new { id = Model.StudentId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n</header>\r\n\r\n");
            WriteLiteral("\r\n<h1>Student Details</h1>\r\n<hr />\r\n<h3>Name:</h3>\r\n<p><strong>");
#nullable restore
#line 23 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Details.cshtml"
      Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n<h3>Date of Enrollment:</h3>\r\n<p><strong>");
#nullable restore
#line 25 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Details.cshtml"
      Write(Html.DisplayFor(model => model.DateOfEnrollment));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n\r\n");
#nullable restore
#line 27 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Details.cshtml"
 if(@Model.JoinEntities.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>This student is not enrolled in any courses</p>\r\n");
#nullable restore
#line 30 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h3>Courses Enrolled in:</h3>\r\n  <ul>\r\n");
#nullable restore
#line 35 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Details.cshtml"
   foreach(var join in Model.JoinEntities)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 37 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Details.cshtml"
   Write(Html.ActionLink($"{@join.Course.Name}", "Details", "Courses", new { id = join.Course.CourseId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 38 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Details.cshtml"
     using (Html.BeginForm("DeleteCourse", "Students"))
    {
      

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Details.cshtml"
 Write(Html.Hidden("joinId", @join.EnrollmentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("      <input type=\"submit\" value=\"Delete\"/>\r\n");
#nullable restore
#line 42 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Details.cshtml"
     
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </ul>\r\n");
#nullable restore
#line 45 "C:\Users\DrewH\Desktop\university-registrar\Views\Students\Details.cshtml"
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
