#pragma checksum "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\donationSave.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d47ab68910bd0af2b41901a077d970abe7bd8e95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_donationSave), @"mvc.1.0.view", @"/Views/Admin/donationSave.cshtml")]
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
#line 1 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\donationSave.cshtml"
using Microsoft.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\donationSave.cshtml"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d47ab68910bd0af2b41901a077d970abe7bd8e95", @"/Views/Admin/donationSave.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b67219f3c3438d8f117e7c545a13efe8c33a16b", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_donationSave : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return ask()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
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
#line 4 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\donationSave.cshtml"
  
    ViewData["Title"] = "Admin Home View Donation Request";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    


    SqlConnection con = new SqlConnection("Data Source=Ali-Shahid;Initial Catalog=CharityManagement;Integrated Security=True");
    con.Open();

    SqlCommand command = new SqlCommand("SELECT DA_Id, DA_Name, DA_IncomeSource, DA_Category, DA_Address, DA_ContactNo, DA_Isdeserving FROM DonationAcceptor WHERE DA_Isdeserving=1", con);

    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
    DataSet dataSet = new DataSet();
    dataAdapter.Fill(dataSet);

    DataTable table = dataSet.Tables[0];
    int rowCount = table.Rows.Count;
    con.Close();

   

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d47ab68910bd0af2b41901a077d970abe7bd8e956164", async() => {
                WriteLiteral("\r\n    <main id=\"main\">\r\n        <section class=\"inner-page\">\r\n            <div class=\"container text-center\">\r\n                <br /><br /><br /> <br /><br /><br /><br />\r\n");
#nullable restore
#line 31 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\donationSave.cshtml"
                 if (rowCount > 0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div");
                BeginWriteAttribute("class", " class=\"", 1025, "\"", 1033, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        <table class=""table table-hover table-responsive-md"">
                            <thead>
                                <tr>
                                    <th scope=""col"">Name</th>
                                    <th scope=""col"">Income Source</th>
                                    <th scope=""col"">Category</th>
                                    <th scope=""col"">Contact Number</th>
                                    <th scope=""col"">Address</th>
                                    <th scope=""col"">Amount</th>
                                   
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 47 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\donationSave.cshtml"
                                 for (var i = 0; i < table.Rows.Count; i++)
                                {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr>\r\n\r\n                                        <td>");
#nullable restore
#line 52 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\donationSave.cshtml"
                                       Write(table.Rows[i].ItemArray[1]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 53 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\donationSave.cshtml"
                                       Write(table.Rows[i].ItemArray[2]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 54 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\donationSave.cshtml"
                                       Write(table.Rows[i].ItemArray[3]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 55 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\donationSave.cshtml"
                                       Write(table.Rows[i].ItemArray[5]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 56 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\donationSave.cshtml"
                                       Write(table.Rows[i].ItemArray[4]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                        <td>\r\n                                            <div class=\"input-group mb-3\">\r\n                                                <input type=\"number\" name=\"amount\" class=\"form-control\"");
                BeginWriteAttribute("id", " id=\"", 2521, "\"", 2535, 2);
                WriteAttributeValue("", 2526, "amount_", 2526, 7, true);
#nullable restore
#line 59 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\donationSave.cshtml"
WriteAttributeValue("", 2533, i, 2533, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Amount\" aria-describedby=\"button-addon2\">\r\n                                                <div class=\"input-group-append\">\r\n                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d47ab68910bd0af2b41901a077d970abe7bd8e9511062", async() => {
                    WriteLiteral("\r\n                                                        <input type=\"hidden\"");
                    BeginWriteAttribute("id", "  id=\"", 2921, "\"", 2936, 2);
                    WriteAttributeValue("", 2927, "Amount_", 2927, 7, true);
#nullable restore
#line 62 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\donationSave.cshtml"
WriteAttributeValue("", 2934, i, 2934, 2, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" value=\"1\"name=\"_Amount\" />\r\n                                                        <button class=\"btn btn-outline-success\" type=\"submit\" id=\"button-addon2\"");
                    BeginWriteAttribute("onclick", "\r\n                                                                onclick=\"", 3094, "\"", 3204, 6);
                    WriteAttributeValue("", 3169, "getAmount(\'Amount_", 3169, 18, true);
#nullable restore
#line 64 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\donationSave.cshtml"
WriteAttributeValue("", 3187, i, 3187, 2, false);

#line default
#line hidden
#nullable disable
                    WriteAttributeValue("", 3189, "\',", 3189, 2, true);
                    WriteAttributeValue(" ", 3191, "\'amount_", 3192, 9, true);
#nullable restore
#line 64 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\donationSave.cshtml"
WriteAttributeValue("", 3200, i, 3200, 2, false);

#line default
#line hidden
#nullable disable
                    WriteAttributeValue("", 3202, "\')", 3202, 2, true);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                                            Give Donation\r\n                                                        </button>\r\n                                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2741, "~/Admin/save_done_give/", 2741, 23, true);
#nullable restore
#line 61 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\donationSave.cshtml"
AddHtmlAttributeValue("", 2764, table.Rows[i].ItemArray[0], 2764, 27, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                </div>\r\n                                            </div>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 72 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\donationSave.cshtml"
                                 }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n");
#nullable restore
#line 77 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\donationSave.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <h1 style=\"color:black;\">\r\n                        There is no deserving Donee <span class=\"bx bx-check-circle\"></span>\r\n                    </h1>\r\n");
#nullable restore
#line 83 "D:\Visual Studio Projects\Charity_Management_System\Charity_Management_System\Charity_Management_System\Views\Admin\donationSave.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                

            </div>
        </section>
        <script>
            function ask() {
                return confirm(""Do you want to Give Donation?"");
            }

            function getAmount(amountiD, amount2ID ) {
                
                document.getElementById(amountiD).value = document.getElementById(amount2ID).value;                
            }
        </script>
    </main><!-- End #main -->

");
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
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
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
