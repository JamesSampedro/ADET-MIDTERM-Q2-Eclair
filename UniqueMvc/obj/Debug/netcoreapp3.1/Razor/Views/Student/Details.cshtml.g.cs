#pragma checksum "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31700b03472abe0f03f1ca34c47f8a74cf43ea14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Details), @"mvc.1.0.view", @"/Views/Student/Details.cshtml")]
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
#line 1 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\_ViewImports.cshtml"
using UniqueMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\_ViewImports.cshtml"
using UniqueMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31700b03472abe0f03f1ca34c47f8a74cf43ea14", @"/Views/Student/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"634517aaa8ffaa2f1e65a25e30b5b59e586af9ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UniqueMvc.Models.Grade>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n<div class=\"container\">\n    <h1 class=\"page-title\">Details</h1>\n    <div class=\"student-details\">\n        <div class=\"student-details--container\">\n            <p class=\"student-details--label\">Name:</p>\n            <p class=\"student-details--info\">");
#nullable restore
#line 9 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                                        Write(Model.ApplicationUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        </div>\n        <div class=\"student-details--container\">\n            <p class=\"student-details--label\">Address:</p>\n            <p class=\"student-details--info\">");
#nullable restore
#line 13 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                                        Write(Model.ApplicationUser.HomeAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        </div>\n    </div>\n\n    <h1 class=\"page-title\">Grades</h1>\n    <div class=\"grades--container\">\n        <h3 class=\"grades--subheadings\">Hello ");
#nullable restore
#line 19 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                                         Write(Model.ApplicationUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
        <h3 class=""grades--subheadings"">Here's the progress of your grades!</h3>
        <div class=""grade-table--container"">
            <h3 class=""grades--subheadings"">Grades Per Term</h3>
            <table class=""table table-hover"">
                <thead>
                    < <tr class=""table-light"">
                        <th>Term</th>
                        <th>Quiz1</th>
                        <th>Quiz2</th>
                        <th>Quiz3</th>
                        <th>Assignment1</th>
                        <th>Assignment2</th>
                        <th>Assignment3</th>
                        <th>Grades</th>
                    </tr>
                </thead>
                <tbody>
                    <tr class=""table-danger"">
                        <td>Prelim</td>
                        <td>");
#nullable restore
#line 39 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                       Write(Model.Prelim.Quiz1.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                        <td>");
#nullable restore
#line 40 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                       Write(Model.Prelim.Quiz2.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                        <td>");
#nullable restore
#line 41 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                       Write(Model.Prelim.Quiz3.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                        <td>");
#nullable restore
#line 42 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                       Write(Model.Prelim.Assignment1.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                        <td>");
#nullable restore
#line 43 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                       Write(Model.Prelim.Assignment2.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                        <td>");
#nullable restore
#line 44 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                       Write(Model.Prelim.Assignment3.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                        <td>");
#nullable restore
#line 45 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                       Write(Model.Prelim.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr class=\"table-danger\">\n                        <td>Midterm</td>\n                        <td>");
#nullable restore
#line 49 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                       Write(Model.Midterm.Quiz1.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                        <td>");
#nullable restore
#line 50 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                       Write(Model.Midterm.Quiz2.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                        <td>");
#nullable restore
#line 51 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                       Write(Model.Midterm.Quiz3.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                        <td>");
#nullable restore
#line 52 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                       Write(Model.Midterm.Assignment1.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                        <td>");
#nullable restore
#line 53 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                       Write(Model.Midterm.Assignment2.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                        <td>");
#nullable restore
#line 54 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                       Write(Model.Midterm.Assignment3.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                        <td>");
#nullable restore
#line 55 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                       Write(Model.Midterm.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr class=\"table-danger\">\n                        <td>Prefinal</td>\n                        <td>");
#nullable restore
#line 59 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                       Write(Model.Prefinal.Quiz1.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                        <td>");
#nullable restore
#line 60 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                       Write(Model.Prefinal.Quiz2.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                        <td>");
#nullable restore
#line 61 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                       Write(Model.Prefinal.Quiz3.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                        <td>");
#nullable restore
#line 62 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                       Write(Model.Prefinal.Assignment1.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                        <td>");
#nullable restore
#line 63 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                       Write(Model.Prefinal.Assignment2.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                        <td>");
#nullable restore
#line 64 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                       Write(Model.Prefinal.Assignment3.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                        <td>");
#nullable restore
#line 65 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                       Write(Model.Prefinal.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                    <tr class=\"table-danger\">\n                        <td>Final</td>\n                        <td>");
#nullable restore
#line 69 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                       Write(Model.Final.Quiz1.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                        <td>");
#nullable restore
#line 70 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                       Write(Model.Final.Quiz2.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                        <td>");
#nullable restore
#line 71 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                       Write(Model.Final.Quiz3.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                        <td>");
#nullable restore
#line 72 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                       Write(Model.Final.Assignment1.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                        <td>");
#nullable restore
#line 73 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                       Write(Model.Final.Assignment2.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                        <td>");
#nullable restore
#line 74 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                       Write(Model.Final.Assignment3.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n                        <td>");
#nullable restore
#line 75 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                       Write(Model.Final.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    </tr>
                </tbody>
            </table>
            <table>
                <thead>
                    <tr class=""table-light"">
                        <th>Prelim Grade</th>
                        <th>Midterm Grade</th>
                        <th>Prefinal Grade</th>
                        <th>Final Grade</th>
                        <th>Subject Grade</th>
                    </tr>
                </thead>
                <tbody>
                    <tr class=""table-light"">
                        <td>");
#nullable restore
#line 91 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                       Write(Model.Prelim.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 92 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                       Write(Model.Midterm.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 93 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                       Write(Model.Prefinal.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 94 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                       Write(Model.Final.Grade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 95 "C:\Users\jamez\Desktop\real\UniqueMvc-master-updated\UniqueMvc-master\UniqueMvc\Views\Student\Details.cshtml"
                       Write(Model.SubjectGrade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n                </tbody>\n            </table>\n        </div>\n    </div>\n\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UniqueMvc.Models.Grade> Html { get; private set; }
    }
}
#pragma warning restore 1591