#pragma checksum "C:\Users\Fatih\Desktop\NET CORE\Work101\Work101\Views\Employee\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "065a11b88bbcc60bbabff4aaa6c28560c1017b7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Add), @"mvc.1.0.view", @"/Views/Employee/Add.cshtml")]
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
#line 1 "C:\Users\Fatih\Desktop\NET CORE\Work101\Work101\Views\_ViewImports.cshtml"
using Work101;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fatih\Desktop\NET CORE\Work101\Work101\Views\_ViewImports.cshtml"
using Work101.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"065a11b88bbcc60bbabff4aaa6c28560c1017b7b", @"/Views/Employee/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67b855d6cc6fafe1099f7bd1b56856e7c9ed1b32", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Fatih\Desktop\NET CORE\Work101\Work101\Views\Employee\Add.cshtml"
  
    ViewData["Title"] = "Add";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Çalışan Ekle</h1>\r\n\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Fatih\Desktop\NET CORE\Work101\Work101\Views\Employee\Add.cshtml"
 using (Html.BeginForm(FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container p-5 border border-dark\">\r\n\r\n        <div class=\"form-group row justify-content-md-center\">\r\n            ");
#nullable restore
#line 16 "C:\Users\Fatih\Desktop\NET CORE\Work101\Work101\Views\Employee\Add.cshtml"
       Write(Html.LabelFor(x => x.IdentityNumber, "TC", new { @class = "col-2 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 17 "C:\Users\Fatih\Desktop\NET CORE\Work101\Work101\Views\Employee\Add.cshtml"
       Write(Html.TextBoxFor(x => x.IdentityNumber, new { @class = "col-4" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group row justify-content-md-center\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Fatih\Desktop\NET CORE\Work101\Work101\Views\Employee\Add.cshtml"
       Write(Html.LabelFor(x => x.FirstName, "Ad", new { @class = "col-2 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 21 "C:\Users\Fatih\Desktop\NET CORE\Work101\Work101\Views\Employee\Add.cshtml"
       Write(Html.TextBoxFor(x => x.FirstName, new { @class = "col-4" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group row justify-content-md-center\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Fatih\Desktop\NET CORE\Work101\Work101\Views\Employee\Add.cshtml"
       Write(Html.LabelFor(x => x.LastName, "Soyad", new { @class = "col-2 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 25 "C:\Users\Fatih\Desktop\NET CORE\Work101\Work101\Views\Employee\Add.cshtml"
       Write(Html.TextBoxFor(x => x.LastName, new { @class = "col-4" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group row justify-content-md-center\">\r\n            ");
#nullable restore
#line 28 "C:\Users\Fatih\Desktop\NET CORE\Work101\Work101\Views\Employee\Add.cshtml"
       Write(Html.LabelFor(x => x.EmployeeNumber, "Çalışan Numarası", new { @class = "col-2 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 29 "C:\Users\Fatih\Desktop\NET CORE\Work101\Work101\Views\Employee\Add.cshtml"
       Write(Html.TextBoxFor(x => x.EmployeeNumber, new { @class = "col-4" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group row justify-content-md-center\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Fatih\Desktop\NET CORE\Work101\Work101\Views\Employee\Add.cshtml"
       Write(Html.LabelFor(x => x.PhoneNumber, "Telefon Numarası", new { @class = "col-2 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 33 "C:\Users\Fatih\Desktop\NET CORE\Work101\Work101\Views\Employee\Add.cshtml"
       Write(Html.TextBoxFor(x => x.PhoneNumber, new { @class = "col-4" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group row justify-content-md-center\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Fatih\Desktop\NET CORE\Work101\Work101\Views\Employee\Add.cshtml"
       Write(Html.LabelFor(x => x.Birthday, "Doğum Tarihi", new { @class = "col-2 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 37 "C:\Users\Fatih\Desktop\NET CORE\Work101\Work101\Views\Employee\Add.cshtml"
       Write(Html.TextBoxFor(x => x.Birthday, new { @class = "col-4" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"form-group row justify-content-md-center\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Fatih\Desktop\NET CORE\Work101\Work101\Views\Employee\Add.cshtml"
       Write(Html.LabelFor(x => x.Address, "Adres", new { @class = "col-2 col-form-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 42 "C:\Users\Fatih\Desktop\NET CORE\Work101\Work101\Views\Employee\Add.cshtml"
       Write(Html.TextAreaFor(x => x.Address, new { @class = "col-4" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group row justify-content-end mt-5\">\r\n            <button class=\"btn btn-success\" type=\"submit\">Kaydet</button>\r\n        </div>\r\n        <div class=\"form-group row justify-content-end\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "065a11b88bbcc60bbabff4aaa6c28560c1017b7b9154", async() => {
                WriteLiteral("Çalışan Listesine Geri Dön");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 51 "C:\Users\Fatih\Desktop\NET CORE\Work101\Work101\Views\Employee\Add.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
