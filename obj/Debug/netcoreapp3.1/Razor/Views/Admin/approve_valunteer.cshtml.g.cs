#pragma checksum "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\approve_valunteer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7b2a2e710cac702d370c8cf2300e1d94308cec6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_approve_valunteer), @"mvc.1.0.view", @"/Views/Admin/approve_valunteer.cshtml")]
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
#line 1 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\approve_valunteer.cshtml"
using Microsoft.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\approve_valunteer.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7b2a2e710cac702d370c8cf2300e1d94308cec6", @"/Views/Admin/approve_valunteer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b67219f3c3438d8f117e7c545a13efe8c33a16b", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_approve_valunteer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/del_volunteer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return ask()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Admin/app_volunteer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\approve_valunteer.cshtml"
  
    ViewData["Title"] = "Admin Home Approve Valunteer";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    


    SqlConnection con = new SqlConnection("Data Source=Ali-Shahid;Initial Catalog=CharityManagement;Integrated Security=True");
    con.Open();

    SqlCommand command = new SqlCommand("SELECT V_Id, V_Name, V_ContactNo,V_Address,V_Age,V_Qualification,V_Gender,V_Email_Id,CONVERT(VARCHAR(11), V_CreationDate,106) " +
        "FROM Volunteer WHERE V_IsApproved=0", con);

    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
    DataSet dataSet = new DataSet();
    dataAdapter.Fill(dataSet);
    con.Close();
    DataTable table = dataSet.Tables[0];
    int rowCount = table.Rows.Count;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7b2a2e710cac702d370c8cf2300e1d94308cec66954", async() => {
                WriteLiteral("\r\n    <main id=\"main\">\r\n        <section class=\"inner-page\">\r\n            <div class=\"container text-center\">\r\n                <br /><br /><br /> <br /><br /><br /><br />\r\n");
#nullable restore
#line 30 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\approve_valunteer.cshtml"
                 if (rowCount > 0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div class=""table-responsive-md"">
                        <table class=""table table-hover"">
                            <thead>
                                <tr>
                                    <th scope=""col"">Name</th>
                                    <th scope=""col"">Age</th>
                                    <th scope=""col"">Gender</th>
                                    <th scope=""col"">Education</th>
                                    <th scope=""col"">Contact Number</th>
                                    <th scope=""col"">Email ID</th>
                                    <th scope=""col"">Delete</th>
                                    <th scope=""col"">Approve</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 47 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\approve_valunteer.cshtml"
                                 for (var i = 0; i < table.Rows.Count; i++)
                                {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr>\r\n\r\n                                        <td>");
#nullable restore
#line 52 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\approve_valunteer.cshtml"
                                       Write(table.Rows[i].ItemArray[1]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 53 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\approve_valunteer.cshtml"
                                       Write(table.Rows[i].ItemArray[4]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 54 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\approve_valunteer.cshtml"
                                       Write(table.Rows[i].ItemArray[6]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 55 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\approve_valunteer.cshtml"
                                       Write(table.Rows[i].ItemArray[5]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 56 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\approve_valunteer.cshtml"
                                       Write(table.Rows[i].ItemArray[2]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 57 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\approve_valunteer.cshtml"
                                       Write(table.Rows[i].ItemArray[7]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                                        <td>\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7b2a2e710cac702d370c8cf2300e1d94308cec611386", async() => {
                    WriteLiteral("\r\n                                                <input type=\"hidden\" name=\"id\"");
                    BeginWriteAttribute("value", " value=\"", 2744, "\"", 2779, 1);
#nullable restore
#line 61 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\approve_valunteer.cshtml"
WriteAttributeValue("", 2752, table.Rows[i].ItemArray[0], 2752, 27, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                                                <button type=\"submit\" class=\"btn\"><i class=\'bx bx-trash \' style=\'color:#f30606; font-size: 32px;\'></i></button>\r\n                                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7b2a2e710cac702d370c8cf2300e1d94308cec614362", async() => {
                    WriteLiteral("\r\n                                                <input type=\"hidden\" name=\"id\"");
                    BeginWriteAttribute("value", " value=\"", 3305, "\"", 3340, 1);
#nullable restore
#line 68 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\approve_valunteer.cshtml"
WriteAttributeValue("", 3313, table.Rows[i].ItemArray[0], 3313, 27, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" />\r\n                                                <button type=\"submit\" class=\"btn\"><i class=\'bx bx-check-circle \' style=\'color:#10c418; font-size: 32px;\'></i></button>\r\n                                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 74 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\approve_valunteer.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n");
#nullable restore
#line 79 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\approve_valunteer.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <h1 style=\"color:black;\">\r\n                        There is no pending request <span class=\"bx bx-check-circle\"></span>\r\n                    </h1>\r\n");
#nullable restore
#line 85 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\approve_valunteer.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n            </div>\r\n        </section>\r\n        <script>\r\n            function ask() {\r\n                return confirm(\"Do you want to delete this?\");\r\n            }\r\n        </script>\r\n    </main><!-- End #main -->\r\n\r\n");
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
            WriteLiteral("\r\n");
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