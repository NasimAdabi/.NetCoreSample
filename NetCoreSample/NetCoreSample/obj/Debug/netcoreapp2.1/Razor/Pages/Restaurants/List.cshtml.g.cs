#pragma checksum "C:\Users\nadabi\source\repos\.NetCoreSample\NetCoreSample\NetCoreSample\Pages\Restaurants\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7227cdbb79a9d049c71f50a8fee2880d06ba992"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(NetCoreSample.Pages.Restaurants.Pages_Restaurants_List), @"mvc.1.0.razor-page", @"/Pages/Restaurants/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Restaurants/List.cshtml", typeof(NetCoreSample.Pages.Restaurants.Pages_Restaurants_List), null)]
namespace NetCoreSample.Pages.Restaurants
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\nadabi\source\repos\.NetCoreSample\NetCoreSample\NetCoreSample\Pages\_ViewImports.cshtml"
using NetCoreSample;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7227cdbb79a9d049c71f50a8fee2880d06ba992", @"/Pages/Restaurants/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d10fc8b14a99cca00d98c4ba1c5a96c2cde8d74", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Restaurants_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 24, true);
            WriteLiteral("\r\n<h1>Restaurants</h1>\r\n");
            EndContext();
            BeginContext(89, 13, false);
#line 7 "C:\Users\nadabi\source\repos\.NetCoreSample\NetCoreSample\NetCoreSample\Pages\Restaurants\List.cshtml"
Write(Model.Message);

#line default
#line hidden
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NetCoreSample.Pages.Restaurants.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NetCoreSample.Pages.Restaurants.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<NetCoreSample.Pages.Restaurants.ListModel>)PageContext?.ViewData;
        public NetCoreSample.Pages.Restaurants.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
