#pragma checksum "C:\Users\emipat\Documents\Training\Bookish\Views\Members\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0eb0e75dfdb21c098eaa50e2f0c30cbab39e3177"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Members_Index), @"mvc.1.0.view", @"/Views/Members/Index.cshtml")]
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
#line 1 "C:\Users\emipat\Documents\Training\Bookish\Views\_ViewImports.cshtml"
using Bookish;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\emipat\Documents\Training\Bookish\Views\Members\Index.cshtml"
using Bookish.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0eb0e75dfdb21c098eaa50e2f0c30cbab39e3177", @"/Views/Members/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e05004d587bb18274aac2c03503e22cb8bcb75b", @"/Views/_ViewImports.cshtml")]
    public class Views_Members_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MemberCatalogueViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\emipat\Documents\Training\Bookish\Views\Members\Index.cshtml"
  
    ViewData["Title"] = "Member Catalogue";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">");
#nullable restore
#line 8 "C:\Users\emipat\Documents\Training\Bookish\Views\Members\Index.cshtml"
                     Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n<div class=\"text-left\">\r\n");
#nullable restore
#line 11 "C:\Users\emipat\Documents\Training\Bookish\Views\Members\Index.cshtml"
     if (Model.MemberCatalogue.Count > 0 ) 
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-striped table-bordered"">
            <tr> 
                <th>ID</th>
                <th>First Name</th>
                <th>Surname</th>
                <th>Email Address</th>
                <th>Contact Number</th>
                <th></th>
            </tr>
");
#nullable restore
#line 22 "C:\Users\emipat\Documents\Training\Bookish\Views\Members\Index.cshtml"
             foreach (var member in Model.MemberCatalogue) 
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td> ");
#nullable restore
#line 25 "C:\Users\emipat\Documents\Training\Bookish\Views\Members\Index.cshtml"
                    Write(member.MemberId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 26 "C:\Users\emipat\Documents\Training\Bookish\Views\Members\Index.cshtml"
                    Write(member.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> ");
#nullable restore
#line 27 "C:\Users\emipat\Documents\Training\Bookish\Views\Members\Index.cshtml"
                    Write(member.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> ");
#nullable restore
#line 28 "C:\Users\emipat\Documents\Training\Bookish\Views\Members\Index.cshtml"
                    Write(member.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 29 "C:\Users\emipat\Documents\Training\Bookish\Views\Members\Index.cshtml"
                    Write(member.ContactNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> \r\n                        ");
#nullable restore
#line 31 "C:\Users\emipat\Documents\Training\Bookish\Views\Members\Index.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { id=member.MemberId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 32 "C:\Users\emipat\Documents\Training\Bookish\Views\Members\Index.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { id=member.MemberId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 33 "C:\Users\emipat\Documents\Training\Bookish\Views\Members\Index.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { id=member.MemberId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>                \r\n");
#nullable restore
#line 36 "C:\Users\emipat\Documents\Training\Bookish\Views\Members\Index.cshtml"
            }  

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n");
#nullable restore
#line 38 "C:\Users\emipat\Documents\Training\Bookish\Views\Members\Index.cshtml"
    }      

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MemberCatalogueViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
