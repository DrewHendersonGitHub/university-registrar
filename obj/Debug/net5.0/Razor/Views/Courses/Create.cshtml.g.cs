#pragma checksum "C:\Users\DrewH\Desktop\university-registrar\Views\Courses\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e80c693e789a05135ce2196d5f6b98a7902a42f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Create), @"mvc.1.0.view", @"/Views/Courses/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e80c693e789a05135ce2196d5f6b98a7902a42f", @"/Views/Courses/Create.cshtml")]
    public class Views_Courses_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UniversityRegistrar.Models.Course>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\DrewH\Desktop\university-registrar\Views\Courses\Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Add new course</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\DrewH\Desktop\university-registrar\Views\Courses\Create.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\DrewH\Desktop\university-registrar\Views\Courses\Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\DrewH\Desktop\university-registrar\Views\Courses\Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\DrewH\Desktop\university-registrar\Views\Courses\Create.cshtml"
Write(Html.LabelFor(model => model.CourseNumber));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\DrewH\Desktop\university-registrar\Views\Courses\Create.cshtml"
Write(Html.TextBoxFor(model => model.CourseNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Add new Course\">\r\n");
#nullable restore
#line 18 "C:\Users\DrewH\Desktop\university-registrar\Views\Courses\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UniversityRegistrar.Models.Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
