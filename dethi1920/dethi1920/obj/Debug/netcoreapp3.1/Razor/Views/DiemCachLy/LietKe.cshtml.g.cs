#pragma checksum "C:\Users\ASUS\Documents\Framework\dethi1920\dethi1920\Views\DiemCachLy\LietKe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6539056dfb7bd426923cb7739b753425df5af0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DiemCachLy_LietKe), @"mvc.1.0.view", @"/Views/DiemCachLy/LietKe.cshtml")]
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
#line 1 "C:\Users\ASUS\Documents\Framework\dethi1920\dethi1920\Views\_ViewImports.cshtml"
using dethi1920;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Documents\Framework\dethi1920\dethi1920\Views\_ViewImports.cshtml"
using dethi1920.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6539056dfb7bd426923cb7739b753425df5af0f", @"/Views/DiemCachLy/LietKe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1aa53bf95f09f64b3c2b52c23e816a7593485ac", @"/Views/_ViewImports.cshtml")]
    public class Views_DiemCachLy_LietKe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<dethi1920.Models.CongNhanModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/DiemCachLy/ListDiemCachLy"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6539056dfb7bd426923cb7739b753425df5af0f3942", async() => {
                WriteLiteral(@"
        <h2>Danh s??ch thi???t b??? c???a nh??n vi??n ???????c ch???n s???a </h2>

        <table class=""table table-bordered"">
            <thread>
                <tr>
                    <td>M?? c??ng nh??n</td>
                    <td>T??n C??ng nh??n</td>

                    <td>Ch???c n??ng</td>

                </tr>
            </thread>
            <tbody>
");
#nullable restore
#line 16 "C:\Users\ASUS\Documents\Framework\dethi1920\dethi1920\Views\DiemCachLy\LietKe.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n\r\n                        <td>");
#nullable restore
#line 20 "C:\Users\ASUS\Documents\Framework\dethi1920\dethi1920\Views\DiemCachLy\LietKe.cshtml"
                       Write(item.MaCongNhan);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 21 "C:\Users\ASUS\Documents\Framework\dethi1920\dethi1920\Views\DiemCachLy\LietKe.cshtml"
                       Write(item.TenCongNhan);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n\r\n                        <td><a");
                BeginWriteAttribute("href", " href=\"", 700, "\"", 741, 2);
                WriteAttributeValue("", 707, "Delete?MaCongNhan=", 707, 18, true);
#nullable restore
#line 24 "C:\Users\ASUS\Documents\Framework\dethi1920\dethi1920\Views\DiemCachLy\LietKe.cshtml"
WriteAttributeValue("", 725, item.MaCongNhan, 725, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Delete</a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 781, "\"", 820, 2);
                WriteAttributeValue("", 788, "View?MaCongNhan=", 788, 16, true);
#nullable restore
#line 25 "C:\Users\ASUS\Documents\Framework\dethi1920\dethi1920\Views\DiemCachLy\LietKe.cshtml"
WriteAttributeValue("", 804, item.MaCongNhan, 804, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">View</a></td>\r\n\r\n\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 30 "C:\Users\ASUS\Documents\Framework\dethi1920\dethi1920\Views\DiemCachLy\LietKe.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<dethi1920.Models.CongNhanModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
