#pragma checksum "C:\Users\emipat\Documents\Training\Bookish\Views\Books\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24f1093fbd5f021a5f0e358bf6c58fa6507d9e2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Index), @"mvc.1.0.view", @"/Views/Books/Index.cshtml")]
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
#line 2 "C:\Users\emipat\Documents\Training\Bookish\Views\Books\Index.cshtml"
using Bookish.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24f1093fbd5f021a5f0e358bf6c58fa6507d9e2a", @"/Views/Books/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e05004d587bb18274aac2c03503e22cb8bcb75b", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookCatalogueViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\emipat\Documents\Training\Bookish\Views\Books\Index.cshtml"
  
    ViewData["Title"] = "Book Catalogue";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">");
#nullable restore
#line 9 "C:\Users\emipat\Documents\Training\Bookish\Views\Books\Index.cshtml"
                     Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 10 "C:\Users\emipat\Documents\Training\Bookish\Views\Books\Index.cshtml"
     if (Model.BookCatalogue.Count > 0 ) {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""dropdown"">
            <button class=""btn btn-secondary dropdown-toggle"" type=""button"" id=""dropdownMenu2"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                Sort by:
            </button>
            <div class=""dropdown-menu"" aria-labelledby=""dropdownMenu2"">
                <a class=""dropdown-item"" type=""button"" href=""/Books?sortOrder=Title"" >Title (asc.)</a>
                <a class=""dropdown-item"" type=""button"" href=""/Books?sortOrder=Title_desc"" >Title (desc.)</a>
                <a class=""dropdown-item"" type=""button"" href=""#"" >Author (asc.)</a>
                <a class=""dropdown-item"" type=""button"" href=""#"" >Author (desc.)</a>
                <a class=""dropdown-item"" type=""button"" href=""/Books?sortOrder=Year"">Year (asc.)</a>
                <a class=""dropdown-item"" type=""button"" href=""/Books?sortOrder=Year_desc"">Year (desc.)</a>
            </div>
        </div>
");
#nullable restore
#line 25 "C:\Users\emipat\Documents\Training\Bookish\Views\Books\Index.cshtml"
         using (Html.BeginForm())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>\r\n                Search library: ");
#nullable restore
#line 28 "C:\Users\emipat\Documents\Training\Bookish\Views\Books\Index.cshtml"
                           Write(Html.TextBox("SearchString"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n                <input type=\"submit\" value=\"Search\" />\r\n            </p>\r\n");
#nullable restore
#line 31 "C:\Users\emipat\Documents\Training\Bookish\Views\Books\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"table table-striped table-bordered\">\r\n            <tr> \r\n                <th>ID</th>\r\n                <th>Title</th>\r\n                <th>Author</th>\r\n                <th>Year</th>\r\n                <th></th>\r\n            </tr>\r\n");
#nullable restore
#line 41 "C:\Users\emipat\Documents\Training\Bookish\Views\Books\Index.cshtml"
             foreach (var book in Model.BookCatalogue) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td> ");
#nullable restore
#line 43 "C:\Users\emipat\Documents\Training\Bookish\Views\Books\Index.cshtml"
                    Write(book.BookId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> ");
#nullable restore
#line 44 "C:\Users\emipat\Documents\Training\Bookish\Views\Books\Index.cshtml"
                    Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> ");
#nullable restore
#line 45 "C:\Users\emipat\Documents\Training\Bookish\Views\Books\Index.cshtml"
                    Write(book.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td> ");
#nullable restore
#line 46 "C:\Users\emipat\Documents\Training\Bookish\Views\Books\Index.cshtml"
                    Write(book.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                    <td> \r\n                        ");
#nullable restore
#line 48 "C:\Users\emipat\Documents\Training\Bookish\Views\Books\Index.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { id=book.BookId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 49 "C:\Users\emipat\Documents\Training\Bookish\Views\Books\Index.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { id=book.BookId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 50 "C:\Users\emipat\Documents\Training\Bookish\Views\Books\Index.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { id=book.BookId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>                \r\n");
#nullable restore
#line 53 "C:\Users\emipat\Documents\Training\Bookish\Views\Books\Index.cshtml"
            }  

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n");
#nullable restore
#line 55 "C:\Users\emipat\Documents\Training\Bookish\Views\Books\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookCatalogueViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
