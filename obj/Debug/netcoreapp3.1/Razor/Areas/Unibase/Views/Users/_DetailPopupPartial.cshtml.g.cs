#pragma checksum "E:\Project\FosselProject\ezeeagreementmobinbhai\Areas\Unibase\Views\Users\_DetailPopupPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4acdceaac7a797ba323b239f80a7695791fbb38a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Unibase_Views_Users__DetailPopupPartial), @"mvc.1.0.view", @"/Areas/Unibase/Views/Users/_DetailPopupPartial.cshtml")]
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
#line 1 "E:\Project\FosselProject\ezeeagreementmobinbhai\Areas\Unibase\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Project\FosselProject\ezeeagreementmobinbhai\Areas\Unibase\_ViewImports.cshtml"
using BasePackageModule1.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Project\FosselProject\ezeeagreementmobinbhai\Areas\Unibase\_ViewImports.cshtml"
using BasePackageModule1.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4acdceaac7a797ba323b239f80a7695791fbb38a", @"/Areas/Unibase/Views/Users/_DetailPopupPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c58acc8277793a53a0802f55ce7043ebd9530b8a", @"/Areas/Unibase/_ViewImports.cshtml")]
    public class Areas_Unibase_Views_Users__DetailPopupPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BasePackageModule1.Models.AgreementDetails>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""modal fade "" id=""OwnerModal"" tabindex=""-1"" aria-labelledby=""OwnerModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg modal-dialog-centered"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title text-center ml-auto"" id=""OwnerModalLabel"">File Details</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                Owner Deatils
                <hr />
                <div class=""form-row"">

                    <div class=""form-group col-md-4"">
                        <label for=""inputState""> First Name</label>
                        <input type=""text"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 927, "\"", 956, 1);
#nullable restore
#line 19 "E:\Project\FosselProject\ezeeagreementmobinbhai\Areas\Unibase\Views\Users\_DetailPopupPartial.cshtml"
WriteAttributeValue("", 935, Model.OwnerFirstName, 935, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"First Name\">\r\n\r\n                    </div>\r\n                    <div class=\"form-group col-md-4\">\r\n                        <label for=\"inputState\"> Middle Name</label>\r\n                        <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1203, "\"", 1233, 1);
#nullable restore
#line 24 "E:\Project\FosselProject\ezeeagreementmobinbhai\Areas\Unibase\Views\Users\_DetailPopupPartial.cshtml"
WriteAttributeValue("", 1211, Model.OwnerMiddleName, 1211, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" placeholder=\"Middle Name\">\r\n\r\n                    </div>\r\n                    <div class=\"form-group col-md-4\">\r\n                        <label for=\"inputState\"> Last Name</label>\r\n                        <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 1479, "\"", 1507, 1);
#nullable restore
#line 29 "E:\Project\FosselProject\ezeeagreementmobinbhai\Areas\Unibase\Views\Users\_DetailPopupPartial.cshtml"
WriteAttributeValue("", 1487, Model.OwnerLastName, 1487, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Last name"">

                    </div>
                </div>

                <div class=""form-row"">

                    <div class=""form-group col-md-4"">
                        <label for=""inputState""> Salutation</label>
                        <select id=""inputState"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 1825, "\"", 1855, 1);
#nullable restore
#line 38 "E:\Project\FosselProject\ezeeagreementmobinbhai\Areas\Unibase\Views\Users\_DetailPopupPartial.cshtml"
WriteAttributeValue("", 1833, Model.OwnerSalutation, 1833, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4acdceaac7a797ba323b239f80a7695791fbb38a6878", async() => {
                WriteLiteral("Mr.");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4acdceaac7a797ba323b239f80a7695791fbb38a7861", async() => {
                WriteLiteral("Miss.");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4acdceaac7a797ba323b239f80a7695791fbb38a8846", async() => {
                WriteLiteral("Mrs.");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </select>

                    </div>

                    <div class=""form-group col-md-4"">
                        <label for=""inputState""> Age</label>
                        <input type=""number"" class=""form-control"" placeholder=""Age""");
            BeginWriteAttribute("value", " value=\"", 2279, "\"", 2302, 1);
#nullable restore
#line 48 "E:\Project\FosselProject\ezeeagreementmobinbhai\Areas\Unibase\Views\Users\_DetailPopupPartial.cshtml"
WriteAttributeValue("", 2287, Model.OwnerAge, 2287, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                    </div>\r\n                    <div class=\"form-group col-md-4\">\r\n                        <label for=\"inputState\"> PAN</label>\r\n                        <input type=\"text\" class=\"form-control\" placeholder=\"PAN\"");
            BeginWriteAttribute("value", " value=\"", 2534, "\"", 2557, 1);
#nullable restore
#line 53 "E:\Project\FosselProject\ezeeagreementmobinbhai\Areas\Unibase\Views\Users\_DetailPopupPartial.cshtml"
WriteAttributeValue("", 2542, Model.OwnerPan, 2542, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">

                    </div>
                </div>
                <div class=""form-row"">
                    <div class=""form-group col-md-12"">
                        <div class=""form-group"">
                            <label for=""exampleFormControlTextarea1"">Address</label>
                            <textarea class=""form-control"" id=""exampleFormControlTextarea1"" rows=""3""");
            BeginWriteAttribute("value", " value=\"", 2947, "\"", 2974, 1);
#nullable restore
#line 61 "E:\Project\FosselProject\ezeeagreementmobinbhai\Areas\Unibase\Views\Users\_DetailPopupPartial.cshtml"
WriteAttributeValue("", 2955, Model.OwnerAddress, 2955, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></textarea>\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            WriteLiteral(@"                <br />
                Tenant Deatils
                <hr />
                <div class=""form-row"">

                    <div class=""form-group col-md-4"">
                        <label for=""inputState""> First Name</label>
                        <input type=""text"" class=""form-control"" placeholder=""First Name""");
            BeginWriteAttribute("value", " value=\"", 3470, "\"", 3500, 1);
#nullable restore
#line 74 "E:\Project\FosselProject\ezeeagreementmobinbhai\Areas\Unibase\Views\Users\_DetailPopupPartial.cshtml"
WriteAttributeValue("", 3478, Model.TenantFirstName, 3478, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""AgreementDetailsFileData.TenantFirstName"">

                    </div>
                    <div class=""form-group col-md-4"">
                        <label for=""inputState""> Middle Name</label>
                        <input type=""text"" class=""form-control"" placeholder=""Middle Name""");
            BeginWriteAttribute("value", " value=\"", 3796, "\"", 3827, 1);
#nullable restore
#line 79 "E:\Project\FosselProject\ezeeagreementmobinbhai\Areas\Unibase\Views\Users\_DetailPopupPartial.cshtml"
WriteAttributeValue("", 3804, Model.TenantMiddleName, 3804, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""AgreementDetailsFileData.TenantMiddleName"">

                    </div>
                    <div class=""form-group col-md-4"">
                        <label for=""inputState""> Last Name</label>
                        <input type=""text"" class=""form-control"" placeholder=""Last name""");
            BeginWriteAttribute("value", " value=\"", 4120, "\"", 4149, 1);
#nullable restore
#line 84 "E:\Project\FosselProject\ezeeagreementmobinbhai\Areas\Unibase\Views\Users\_DetailPopupPartial.cshtml"
WriteAttributeValue("", 4128, Model.TenantLastName, 4128, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""AgreementDetailsFileData.TenantLastName"">

                    </div>
                </div>
                <div class=""form-row"">

                    <div class=""form-group col-md-4"">
                        <label for=""inputState""> Salutation</label>
                        <select id=""inputState"" class=""form-control""");
            BeginWriteAttribute("value", " value=\"", 4488, "\"", 4519, 1);
#nullable restore
#line 92 "E:\Project\FosselProject\ezeeagreementmobinbhai\Areas\Unibase\Views\Users\_DetailPopupPartial.cshtml"
WriteAttributeValue("", 4496, Model.TenantSalutation, 4496, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"AgreementDetailsFileData.TenantSalutation\">\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4acdceaac7a797ba323b239f80a7695791fbb38a15029", async() => {
                WriteLiteral("Mr.");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4acdceaac7a797ba323b239f80a7695791fbb38a16013", async() => {
                WriteLiteral("Miss.");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4acdceaac7a797ba323b239f80a7695791fbb38a16999", async() => {
                WriteLiteral("Mrs.");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </select>

                    </div>
                    <div class=""form-group col-md-4"">
                        <label for=""inputState""> Age</label>
                        <input type=""number"" class=""form-control"" placeholder=""Age""");
            BeginWriteAttribute("value", " value=\"", 4992, "\"", 5016, 1);
#nullable restore
#line 102 "E:\Project\FosselProject\ezeeagreementmobinbhai\Areas\Unibase\Views\Users\_DetailPopupPartial.cshtml"
WriteAttributeValue("", 5000, Model.TenantAge, 5000, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""AgreementDetailsFileData.TenantAge"">

                    </div>
                    <div class=""form-group col-md-4"">
                        <label for=""inputState""> PAN</label>
                        <input type=""text"" class=""form-control"" placeholder=""PAN""");
            BeginWriteAttribute("value", " value=\"", 5290, "\"", 5314, 1);
#nullable restore
#line 107 "E:\Project\FosselProject\ezeeagreementmobinbhai\Areas\Unibase\Views\Users\_DetailPopupPartial.cshtml"
WriteAttributeValue("", 5298, Model.TenantPan, 5298, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""AgreementDetailsFileData.TenantPan"">

                    </div>
                </div>
                <div class=""form-row"">
                    <div class=""form-group col-md-12"">
                        <div class=""form-group"">
                            <label for=""exampleFormControlTextarea1"">Address</label>
                            <textarea class=""form-control"" id=""exampleFormControlTextarea1"" rows=""3""");
            BeginWriteAttribute("value", " value=\"", 5746, "\"", 5774, 1);
#nullable restore
#line 115 "E:\Project\FosselProject\ezeeagreementmobinbhai\Areas\Unibase\Views\Users\_DetailPopupPartial.cshtml"
WriteAttributeValue("", 5754, Model.TenantAddress, 5754, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""AgreementDetailsFileData.TenantAddress""></textarea>
                        </div>
                    </div>
                </div>



            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>

            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BasePackageModule1.Models.AgreementDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591