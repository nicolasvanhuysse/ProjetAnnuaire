#pragma checksum "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Admin\AddEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "deb6169cda67b962ab84c740461b1fd46b7b2e80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AddEmployee), @"mvc.1.0.view", @"/Views/Admin/AddEmployee.cshtml")]
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
#line 1 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\_ViewImports.cshtml"
using ProjetAnnuaire;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\_ViewImports.cshtml"
using ProjetAnnuaire.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"deb6169cda67b962ab84c740461b1fd46b7b2e80", @"/Views/Admin/AddEmployee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a81e7c2d2afa9d6f24defcd80597f6ceb229e91", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AddEmployee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SubmitEditFormEmployee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SubmitAddFormEmployee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Admin\AddEmployee.cshtml"
 if (ViewBag.Employee != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Modification</h1>\r\n");
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "deb6169cda67b962ab84c740461b1fd46b7b2e805039", async() => {
                WriteLiteral("\r\n        <div>\r\n            <input class=\"form-control\" type=\"text\" name=\"id\" hidden placeholder=\"id\"");
                BeginWriteAttribute("value", " value=\"", 263, "\"", 291, 1);
#nullable restore
#line 9 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Admin\AddEmployee.cshtml"
WriteAttributeValue("", 271, ViewBag.Employee.Id, 271, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-6\">\r\n                <input class=\"form-control\" type=\"text\" name=\"lastName\" placeholder=\"Nom\"");
                BeginWriteAttribute("value", " value=\"", 462, "\"", 496, 1);
#nullable restore
#line 13 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Admin\AddEmployee.cshtml"
WriteAttributeValue("", 470, ViewBag.Employee.Lastname, 470, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </div>\r\n            <div class=\"col-6\">\r\n                <input class=\"form-control\" type=\"text\" name=\"firstname\" placeholder=\"Prénom\"");
                BeginWriteAttribute("value", " value=\"", 648, "\"", 683, 1);
#nullable restore
#line 16 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Admin\AddEmployee.cshtml"
WriteAttributeValue("", 656, ViewBag.Employee.Firstname, 656, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n        <br />\r\n        <div class=\"row\">\r\n            <div class=\"col-6\">\r\n                <input class=\"form-control\" type=\"text\" name=\"phone\" placeholder=\"Téléphone fixe\"");
                BeginWriteAttribute("value", " value=\"", 898, "\"", 929, 1);
#nullable restore
#line 22 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Admin\AddEmployee.cshtml"
WriteAttributeValue("", 906, ViewBag.Employee.Phone, 906, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </div>\r\n            <div class=\"col-6\">\r\n                <input class=\"form-control\" type=\"text\" name=\"cellphone\" placeholder=\"Téléphone portable\"");
                BeginWriteAttribute("value", " value=\"", 1093, "\"", 1128, 1);
#nullable restore
#line 25 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Admin\AddEmployee.cshtml"
WriteAttributeValue("", 1101, ViewBag.Employee.Cellphone, 1101, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n        <br />\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <input class=\"form-control\" type=\"text\" name=\"mail\" placeholder=\"Addresse mail\"");
                BeginWriteAttribute("value", " value=\"", 1342, "\"", 1372, 1);
#nullable restore
#line 31 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Admin\AddEmployee.cshtml"
WriteAttributeValue("", 1350, ViewBag.Employee.Mail, 1350, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n        <br />\r\n        <div class=\"row\">\r\n            <div class=\"col-6\">\r\n                <select class=\"form-control\" name=\"idSite\" aria-label=\"Site\">\r\n");
#nullable restore
#line 38 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Admin\AddEmployee.cshtml"
                     foreach (Site s in ViewBag.Site)
                    {
                        if (ViewBag.Employee.Site.IdSite == s.IdSite)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "deb6169cda67b962ab84c740461b1fd46b7b2e809594", async() => {
#nullable restore
#line 42 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Admin\AddEmployee.cshtml"
                                                          Write(s.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Admin\AddEmployee.cshtml"
                                        WriteLiteral(s.IdSite);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Admin\AddEmployee.cshtml"

                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "deb6169cda67b962ab84c740461b1fd46b7b2e8012217", async() => {
#nullable restore
#line 47 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Admin\AddEmployee.cshtml"
                                                 Write(s.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Admin\AddEmployee.cshtml"
                               WriteLiteral(s.IdSite);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 48 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Admin\AddEmployee.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </select>\r\n            </div>\r\n            <div class=\"col-6\">\r\n                <select class=\"form-control\" name=\"idService\" aria-label=\"Service\">\r\n");
#nullable restore
#line 54 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Admin\AddEmployee.cshtml"
                     foreach (Service s in ViewBag.Service)
                    {
                        if (ViewBag.Employee.Service.IdService == s.IdService)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "deb6169cda67b962ab84c740461b1fd46b7b2e8015066", async() => {
#nullable restore
#line 58 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Admin\AddEmployee.cshtml"
                                                             Write(s.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Admin\AddEmployee.cshtml"
                                        WriteLiteral(s.IdService);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 59 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Admin\AddEmployee.cshtml"

                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "deb6169cda67b962ab84c740461b1fd46b7b2e8017696", async() => {
#nullable restore
#line 63 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Admin\AddEmployee.cshtml"
                                                    Write(s.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Admin\AddEmployee.cshtml"
                               WriteLiteral(s.IdService);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 64 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Admin\AddEmployee.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </select>
            </div>
        </div>
        <br />
        <div class=""row justify-content-center"">
            <div class=""col-6"">
                <button type=""submit"" class=""btn btn-primary btn-block"">Enregistrer</button>
            </div>
        </div>
    ");
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
#nullable restore
#line 76 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Admin\AddEmployee.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Ajout</h1>\r\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "deb6169cda67b962ab84c740461b1fd46b7b2e8022098", async() => {
                WriteLiteral(@"
        <div class=""row"">
            <div class=""col-6"">
                <input class=""form-control"" type=""text"" name=""lastName"" placeholder=""Nom"" />
            </div>
            <div class=""col-6"">
                <input class=""form-control"" type=""text"" name=""firstname"" placeholder=""Prénom"" />
            </div>
        </div>
        <br />
        <div class=""row"">
            <div class=""col-6"">
                <input class=""form-control"" type=""text"" name=""phone"" placeholder=""Téléphone fixe"" />
            </div>
            <div class=""col-6"">
                <input class=""form-control"" type=""text"" name=""cellphone"" placeholder=""Téléphone portable"" />
            </div>
        </div>
        <br />
        <div class=""row"">
            <div class=""col-12"">
                <input class=""form-control"" type=""text"" name=""mail"" placeholder=""Addresse mail"" />
            </div>
        </div>
        <br />
        <div class=""row"">
            <div class=""col-6"">
               ");
                WriteLiteral(" <select class=\"form-control\" name=\"idSite\" aria-label=\"Site\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "deb6169cda67b962ab84c740461b1fd46b7b2e8023565", async() => {
                    WriteLiteral("Tous les sites");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 110 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Admin\AddEmployee.cshtml"
                     foreach (Site s in ViewBag.Site)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "deb6169cda67b962ab84c740461b1fd46b7b2e8025244", async() => {
#nullable restore
#line 112 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Admin\AddEmployee.cshtml"
                                             Write(s.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 112 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Admin\AddEmployee.cshtml"
                           WriteLiteral(s.IdSite);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 113 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Admin\AddEmployee.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </select>\r\n            </div>\r\n            <div class=\"col-6\">\r\n                <select class=\"form-control\" name=\"idService\" aria-label=\"Service\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "deb6169cda67b962ab84c740461b1fd46b7b2e8027632", async() => {
                    WriteLiteral("Tous les services");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 119 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Admin\AddEmployee.cshtml"
                     foreach (Service s in ViewBag.Service)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "deb6169cda67b962ab84c740461b1fd46b7b2e8029320", async() => {
#nullable restore
#line 121 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Admin\AddEmployee.cshtml"
                                                Write(s.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 121 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Admin\AddEmployee.cshtml"
                           WriteLiteral(s.IdService);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 122 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Admin\AddEmployee.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </select>
            </div>
        </div>
        <br />
        <div class=""row justify-content-center"">
            <div class=""col-6"">
                <button type=""submit"" class=""btn btn-primary btn-block"">Enregistrer</button>
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
#nullable restore
#line 133 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Admin\AddEmployee.cshtml"
}

#line default
#line hidden
#nullable disable
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