#pragma checksum "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\viewCases.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6a3075bb0758d65e43675ae155638cf3cb30728"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_viewCases), @"mvc.1.0.view", @"/Views/Admin/viewCases.cshtml")]
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
#line 1 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\_ViewImports.cshtml"
using Charity_Management_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\_ViewImports.cshtml"
using Charity_Management_System.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\viewCases.cshtml"
using Microsoft.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\viewCases.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6a3075bb0758d65e43675ae155638cf3cb30728", @"/Views/Admin/viewCases.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b67219f3c3438d8f117e7c545a13efe8c33a16b", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_viewCases : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\viewCases.cshtml"
  
    ViewData["Title"] = "Admin Home View Cases";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    

    SqlConnection con = new SqlConnection("Data Source=Ali-Shahid;Initial Catalog=CharityManagement;Integrated Security=True");
    con.Open();

    SqlCommand command = new SqlCommand("SELECT C_Id, C_Title,CONVERT(VARCHAR(11), C_CreationDate,106), C_Amount_Require, C_Amount_collected, C_Desceiption, C_Type, V_IsCompleted FROM Cases", con);

    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
    DataSet dataSet = new DataSet();
    dataAdapter.Fill(dataSet);
    con.Close();
    DataTable table = dataSet.Tables[0];


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6a3075bb0758d65e43675ae155638cf3cb307284667", async() => {
                WriteLiteral(@"
    <main id=""main"" data-aos=""fade-up"">

        <!-- ======= Breadcrumbs ======= -->
        <section class=""breadcrumbs"">
            <div class=""container"">

                <div class=""d-flex justify-content-between align-items-center"">
                    <h2>View Cases</h2>

                </div>

            </div>
        </section><!-- End Breadcrumbs -->

        <section class=""inner-page"">
            <section class=""container"">
                <div class=""table-responsive-md"">
                    <table class=""table table-hover"">
                        <thead>
                            <tr>
                                <th scope=""col"">Case ID</th>
                                <th scope=""col"">Case Title</th>
                                <th scope=""col"">Funds Require</th>
                                <th scope=""col"">Funds Collected</th>
                                <th scope=""col"">Case Type</th>
                                <th scope=""col"">Case Descr");
                WriteLiteral(@"iption</th>
                                <th scope=""col"">Is Completed</th>
                                <th scope=""col"">Date Added</th>
                            </tr>
                        </thead>
                        <tbody>
                             
");
#nullable restore
#line 57 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\viewCases.cshtml"
                             for (var i = 0; i < table.Rows.Count; i++)
                            {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n                                    <th scope=\"row\">");
#nullable restore
#line 61 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\viewCases.cshtml"
                                               Write(table.Rows[i].ItemArray[0]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                    <td>");
#nullable restore
#line 62 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\viewCases.cshtml"
                                   Write(table.Rows[i].ItemArray[1]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 63 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\viewCases.cshtml"
                                   Write(table.Rows[i].ItemArray[3]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 64 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\viewCases.cshtml"
                                   Write(table.Rows[i].ItemArray[4]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 65 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\viewCases.cshtml"
                                   Write(table.Rows[i].ItemArray[6]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 66 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\viewCases.cshtml"
                                   Write(table.Rows[i].ItemArray[5]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 67 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\viewCases.cshtml"
                                   Write(table.Rows[i].ItemArray[7]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 68 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\viewCases.cshtml"
                                   Write(table.Rows[i].ItemArray[2]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 70 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\viewCases.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                          \r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n\r\n            </section>\r\n\r\n        </section>\r\n\r\n        \r\n\r\n    </main><!-- End #main -->\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
