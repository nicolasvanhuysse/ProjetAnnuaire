#pragma checksum "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Home\showEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da39e8743a701812e95c4d97996aa0e65a65fc21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_showEmployee), @"mvc.1.0.view", @"/Views/Home/showEmployee.cshtml")]
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
#nullable restore
#line 3 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\_ViewImports.cshtml"
using ProjetAnnuaire.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da39e8743a701812e95c4d97996aa0e65a65fc21", @"/Views/Home/showEmployee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b15ebe5ec6ecca2a4149517765a8bf280b64f9b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_showEmployee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Home\showEmployee.cshtml"
  
    ViewData["Title"] = "Salarié";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1> Information sur le salarié : </h1>\r\n\r\n<div class=\"col\">\r\n    <p>Nom : ");
#nullable restore
#line 9 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Home\showEmployee.cshtml"
        Write(Model.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n</div>\r\n<div class=\"col\">\r\n    <p>Prénom : ");
#nullable restore
#line 12 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Home\showEmployee.cshtml"
           Write(Model.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n</div>\r\n<div class=\"col\">\r\n    <p>Téléphone fixe : ");
#nullable restore
#line 15 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Home\showEmployee.cshtml"
                   Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n</div>\r\n<div class=\"col\">\r\n    <p>Téléphone portable : ");
#nullable restore
#line 18 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Home\showEmployee.cshtml"
                       Write(Model.Cellphone);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n</div>\r\n<div class=\"col\"> \r\n    <p>Addresse mail : ");
#nullable restore
#line 21 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Home\showEmployee.cshtml"
                  Write(Model.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n</div>\r\n<div class=\"col\"> \r\n    <p>Service : ");
#nullable restore
#line 24 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Home\showEmployee.cshtml"
            Write(Model.Service.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n</div>\r\n<div class=\"col\"> \r\n    <p>Site : ");
#nullable restore
#line 27 "C:\Users\yuuma\Desktop\Projet Individuel Cube 4 .net\ProjetAnnuaire\ProjetAnnuaire\Views\Home\showEmployee.cshtml"
         Write(Model.Site.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
