#pragma checksum "C:\Users\LWXC\dns_employees\dns_employees\Views\Employee\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "989def84622cfae7571630b5dda26466b5877765"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Edit), @"mvc.1.0.view", @"/Views/Employee/Edit.cshtml")]
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
#line 1 "C:\Users\LWXC\dns_employees\dns_employees\Views\_ViewImports.cshtml"
using dns_employees;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LWXC\dns_employees\dns_employees\Views\_ViewImports.cshtml"
using dns_employees.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"989def84622cfae7571630b5dda26466b5877765", @"/Views/Employee/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61a91f7da7ec7eae5b0222bc96bf3748975566a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dns_employees.Models.Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\LWXC\dns_employees\dns_employees\Views\Employee\Edit.cshtml"
   Layout = null; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\LWXC\dns_employees\dns_employees\Views\Employee\Edit.cshtml"
Write(await Html.PartialAsync("_form", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\LWXC\dns_employees\dns_employees\Views\Employee\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dns_employees.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
