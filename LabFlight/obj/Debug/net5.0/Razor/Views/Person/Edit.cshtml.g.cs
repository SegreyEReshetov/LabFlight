#pragma checksum "C:\Users\sergr\Desktop\LabFlight\LabFlight\Views\Person\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "313217346e5298bd678cb6051dea2a56437d2854"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Edit), @"mvc.1.0.view", @"/Views/Person/Edit.cshtml")]
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
#line 1 "C:\Users\sergr\Desktop\LabFlight\LabFlight\Views\_ViewImports.cshtml"
using LabFlight;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sergr\Desktop\LabFlight\LabFlight\Views\_ViewImports.cshtml"
using LabFlight.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"313217346e5298bd678cb6051dea2a56437d2854", @"/Views/Person/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"660774fc26ba3a9871d61dee4e82178263971805", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Business.Interop.PersonDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Person", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sergr\Desktop\LabFlight\LabFlight\Views\Person\Edit.cshtml"
  
    ViewData["Title"] = "????????????????????";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "313217346e5298bd678cb6051dea2a56437d28544498", async() => {
                WriteLiteral("\r\n    <h4>???????????????????? ????????????????</h4>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "313217346e5298bd678cb6051dea2a56437d28544796", async() => {
                    WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\sergr\Desktop\LabFlight\LabFlight\Views\Person\Edit.cshtml"
         if(Model != null)
        {

#line default
#line hidden
#nullable disable
                    WriteLiteral("            <input type = \"hidden\" name = \"Id\"");
                    BeginWriteAttribute("value", " value = \"", 307, "\"", 326, 1);
#nullable restore
#line 15 "C:\Users\sergr\Desktop\LabFlight\LabFlight\Views\Person\Edit.cshtml"
WriteAttributeValue("", 317, Model.Id, 317, 9, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral("></input>\r\n");
#nullable restore
#line 16 "C:\Users\sergr\Desktop\LabFlight\LabFlight\Views\Person\Edit.cshtml"
        }

#line default
#line hidden
#nullable disable
                    WriteLiteral("        <table class = \"table\">\r\n            <tr>\r\n                <td>??????:</td>\r\n                <td><input type=\"text\" required name=\"Fio\"");
                    BeginWriteAttribute("value", " value=\"", 489, "\"", 508, 1);
#nullable restore
#line 20 "C:\Users\sergr\Desktop\LabFlight\LabFlight\Views\Person\Edit.cshtml"
WriteAttributeValue("", 497, Model?.Fio, 497, 11, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" /></td>\r\n            </tr>\r\n            <tr>\r\n                <td>??????????????:</td>\r\n                <td><input type=\"text\" placeholder=\"20** 93****\" required name=\"Passport\"");
                    BeginWriteAttribute("value", " value=\"", 680, "\"", 704, 1);
#nullable restore
#line 24 "C:\Users\sergr\Desktop\LabFlight\LabFlight\Views\Person\Edit.cshtml"
WriteAttributeValue("", 688, Model?.Passport, 688, 16, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" /></td>\r\n            </tr>\r\n            <tr>\r\n                <td>???????? ????????????????:</td>\r\n          \r\n                <td><input type=\"text\" pattern=\"[0-9]{2}.[0-9]{2}.[0-9]{4}\" placeholder=\"01.01.1999\" required name=\"Birthdate\"");
                    BeginWriteAttribute("value", " value=\"", 931, "\"", 956, 1);
#nullable restore
#line 29 "C:\Users\sergr\Desktop\LabFlight\LabFlight\Views\Person\Edit.cshtml"
WriteAttributeValue("", 939, Model?.Birthdate, 939, 17, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" /></td>\r\n            </tr>\r\n        </table>\r\n        <input type=\"submit\" value=\"??????????????????\" />\r\n    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Business.Interop.PersonDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
