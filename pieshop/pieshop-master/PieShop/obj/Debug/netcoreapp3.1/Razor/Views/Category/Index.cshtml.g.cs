#pragma checksum "D:\Collage\Research\3 _ Database\pieshop\pieshop-master\PieShop\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f611e8b1cc3ef1d100f405449883ed1819d80afb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#line 1 "D:\Collage\Research\3 _ Database\pieshop\pieshop-master\PieShop\Views\_ViewImports.cshtml"
using PieShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Collage\Research\3 _ Database\pieshop\pieshop-master\PieShop\Views\_ViewImports.cshtml"
using PieShop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Collage\Research\3 _ Database\pieshop\pieshop-master\PieShop\Views\_ViewImports.cshtml"
using PieShop.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f611e8b1cc3ef1d100f405449883ed1819d80afb", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6e4e4445503966fb40bbe9e84c5e586bea8da8b", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DesertViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 4 "D:\Collage\Research\3 _ Database\pieshop\pieshop-master\PieShop\Views\Category\Index.cshtml"
 foreach (var category in Model.Categories)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 6 "D:\Collage\Research\3 _ Database\pieshop\pieshop-master\PieShop\Views\Category\Index.cshtml"
Write(category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
#nullable restore
#line 6 "D:\Collage\Research\3 _ Database\pieshop\pieshop-master\PieShop\Views\Category\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DesertViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
