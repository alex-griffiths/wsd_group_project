#pragma checksum "C:\Users\ahli\OneDrive\WSU - Computer Science\2nd Year\Web Sys dev\wsd_group_project\Pages\Admin\StatisticsPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c48ecf49229d1771ab401350c554847cc7f9d08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Three_Sisters_Hotel.Pages.Admin.Pages_Admin_StatisticsPage), @"mvc.1.0.razor-page", @"/Pages/Admin/StatisticsPage.cshtml")]
namespace Three_Sisters_Hotel.Pages.Admin
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
#line 1 "C:\Users\ahli\OneDrive\WSU - Computer Science\2nd Year\Web Sys dev\wsd_group_project\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ahli\OneDrive\WSU - Computer Science\2nd Year\Web Sys dev\wsd_group_project\Pages\_ViewImports.cshtml"
using Three_Sisters_Hotel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ahli\OneDrive\WSU - Computer Science\2nd Year\Web Sys dev\wsd_group_project\Pages\_ViewImports.cshtml"
using Three_Sisters_Hotel.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c48ecf49229d1771ab401350c554847cc7f9d08", @"/Pages/Admin/StatisticsPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93869f11894cfa3d1d9efcdd88196bc6b4e6ab6c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_StatisticsPage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ahli\OneDrive\WSU - Computer Science\2nd Year\Web Sys dev\wsd_group_project\Pages\Admin\StatisticsPage.cshtml"
  
    ViewData["Title"] = "Statistics";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Customer Distribution with Respect to Post Codes</h2>\r\n<br />\r\n\r\n<div>\r\n");
            WriteLiteral("    <table class=\"table\">\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\ahli\OneDrive\WSU - Computer Science\2nd Year\Web Sys dev\wsd_group_project\Pages\Admin\StatisticsPage.cshtml"
           Write(Html.DisplayNameFor(c => c.CustomerStats[0].PostCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\ahli\OneDrive\WSU - Computer Science\2nd Year\Web Sys dev\wsd_group_project\Pages\Admin\StatisticsPage.cshtml"
           Write(Html.DisplayNameFor(c => c.CustomerStats[0].PostCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n\r\n");
#nullable restore
#line 23 "C:\Users\ahli\OneDrive\WSU - Computer Science\2nd Year\Web Sys dev\wsd_group_project\Pages\Admin\StatisticsPage.cshtml"
         foreach (var item in Model.CustomerStats)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 27 "C:\Users\ahli\OneDrive\WSU - Computer Science\2nd Year\Web Sys dev\wsd_group_project\Pages\Admin\StatisticsPage.cshtml"
               Write(Html.DisplayFor(modelItem => item.PostCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 30 "C:\Users\ahli\OneDrive\WSU - Computer Science\2nd Year\Web Sys dev\wsd_group_project\Pages\Admin\StatisticsPage.cshtml"
               Write(Html.DisplayFor(modelItem => item.PostCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 33 "C:\Users\ahli\OneDrive\WSU - Computer Science\2nd Year\Web Sys dev\wsd_group_project\Pages\Admin\StatisticsPage.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n\r\n\r\n<h2>Booking distribution with respect to Rooms</h2>\r\n<br />\r\n<div>\r\n");
            WriteLiteral("    <table class=\"table\">\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 45 "C:\Users\ahli\OneDrive\WSU - Computer Science\2nd Year\Web Sys dev\wsd_group_project\Pages\Admin\StatisticsPage.cshtml"
           Write(Html.DisplayNameFor(r => r.RoomStats[0].RoomID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 48 "C:\Users\ahli\OneDrive\WSU - Computer Science\2nd Year\Web Sys dev\wsd_group_project\Pages\Admin\StatisticsPage.cshtml"
           Write(Html.DisplayNameFor(r => r.RoomStats[0].RoomBookCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n\r\n");
#nullable restore
#line 52 "C:\Users\ahli\OneDrive\WSU - Computer Science\2nd Year\Web Sys dev\wsd_group_project\Pages\Admin\StatisticsPage.cshtml"
         foreach (var item in Model.RoomStats)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\Users\ahli\OneDrive\WSU - Computer Science\2nd Year\Web Sys dev\wsd_group_project\Pages\Admin\StatisticsPage.cshtml"
               Write(Html.DisplayFor(modelItem => item.RoomID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "C:\Users\ahli\OneDrive\WSU - Computer Science\2nd Year\Web Sys dev\wsd_group_project\Pages\Admin\StatisticsPage.cshtml"
               Write(Html.DisplayFor(modelItem => item.RoomBookCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 62 "C:\Users\ahli\OneDrive\WSU - Computer Science\2nd Year\Web Sys dev\wsd_group_project\Pages\Admin\StatisticsPage.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Three_Sisters_Hotel.Pages.Admin.StatisticsPageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Three_Sisters_Hotel.Pages.Admin.StatisticsPageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Three_Sisters_Hotel.Pages.Admin.StatisticsPageModel>)PageContext?.ViewData;
        public Three_Sisters_Hotel.Pages.Admin.StatisticsPageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
