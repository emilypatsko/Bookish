#pragma checksum "C:\users\chljon\training\bookish\bookish\Views\Books\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b30c00e65bfd2dfa20ba2ed1f68325f96a58af5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Checkout), @"mvc.1.0.view", @"/Views/Books/Checkout.cshtml")]
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
#line 1 "C:\users\chljon\training\bookish\bookish\Views\_ViewImports.cshtml"
using Bookish;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\users\chljon\training\bookish\bookish\Views\Books\Checkout.cshtml"
using Bookish.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b30c00e65bfd2dfa20ba2ed1f68325f96a58af5", @"/Views/Books/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e05004d587bb18274aac2c03503e22cb8bcb75b", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CheckoutCatalogueViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""text-center"">
    <h1 class=""display-4"">Checkouts</h1>

    <table class=""table table-striped table-bordered""
        <tr> 
            <th>Copy Id</th>
            <th>Book Title</th>
            <th>Still Checked Out? </th>
            <th>Member First Name</th>
            <th>Member Surname</th>
            <th>Checkout Date</th>
            <th>Due Date</th>
            <th>Returned?</th>
        </tr>
");
#nullable restore
#line 17 "C:\users\chljon\training\bookish\bookish\Views\Books\Checkout.cshtml"
     foreach (var checkout in Model.CheckoutCatalogue) 
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td> ");
#nullable restore
#line 20 "C:\users\chljon\training\bookish\bookish\Views\Books\Checkout.cshtml"
            Write(checkout.CheckoutId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td> ");
#nullable restore
#line 21 "C:\users\chljon\training\bookish\bookish\Views\Books\Checkout.cshtml"
            Write(checkout.Copy.CopyId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 22 "C:\users\chljon\training\bookish\bookish\Views\Books\Checkout.cshtml"
            Write(checkout.Copy.Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 23 "C:\users\chljon\training\bookish\bookish\Views\Books\Checkout.cshtml"
            Write(checkout.Copy.CheckedOut);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 24 "C:\users\chljon\training\bookish\bookish\Views\Books\Checkout.cshtml"
            Write(checkout.Member.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 25 "C:\users\chljon\training\bookish\bookish\Views\Books\Checkout.cshtml"
            Write(checkout.Member.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 26 "C:\users\chljon\training\bookish\bookish\Views\Books\Checkout.cshtml"
            Write(checkout.CheckoutDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            <td> ");
#nullable restore
#line 27 "C:\users\chljon\training\bookish\bookish\Views\Books\Checkout.cshtml"
            Write(checkout.DueDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 28 "C:\users\chljon\training\bookish\bookish\Views\Books\Checkout.cshtml"
            Write(checkout.Returned);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 30 "C:\users\chljon\training\bookish\bookish\Views\Books\Checkout.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CheckoutCatalogueViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
