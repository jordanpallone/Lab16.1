#pragma checksum "C:\Users\jpallone\dev\baLtpircSavaJ\baLtpircSavaJ\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62ef5b9180a62b4954ec32a86e2de1800788abd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\jpallone\dev\baLtpircSavaJ\baLtpircSavaJ\Views\_ViewImports.cshtml"
using baLtpircSavaJ;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jpallone\dev\baLtpircSavaJ\baLtpircSavaJ\Views\_ViewImports.cshtml"
using baLtpircSavaJ.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62ef5b9180a62b4954ec32a86e2de1800788abd9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"995fef24b8c803ab342a4df76d9514b291901ab0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return validate()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<script>
    function validate() {
        // first name at least 2 char
        let fname = document.getElementById('firstname');
        if (fname.value.length <= 2) {
            message.innerHTML = 'First name must be at least 2 characters';
            return false;
        }

        // last name at least 2 char
        let lname = document.getElementById('lastname');
        if (fname.value.length < 2) {
            message.innerHTML = 'First name must be at least 2 characters';
            return false;
        }

        // valid email: use regex (at least 2 chars, at symbol, at least 2 chars, period, at least 2 chars)
        let email = document.getElementById('email');
        let re = /^[a-zA-Z0-9]{3,}");
            WriteLiteral(@"@[a-zA-Z0-9]{2,}\.[a-zA-z0-9]{2,}$/;
        if (email.value.match(re) == null) {
            message.innerHTML = 'Please enter a valid email';
            return false;
        }

        // password must have 1 capitol letter one lowercase letter one number and one symbol
        let pass = document.getElementById('password');
        let ree = /(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*\W)/;
        if (pass.value.match(ree) == null) {
            message.innerHTML = 'Password must contain an uppercase letter, a lowercase letter, a number, and a special character';
            return false;
        }

        // password.value.match(conpass) = true if match or null if not <-- issue if not
        let conpass = document.getElementById('conpass');
        if (conpass.value != pass.value) {
            message.innerHTML = 'Passwords don\'t match';
            return false;
        }

        message.innerHTML = '';
        return true;
    }
</script>

<h1>Sell Your Soul</h1>

<div class=");
            WriteLiteral("\"container\">\r\n\r\n    <div id=\"message\"></div>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62ef5b9180a62b4954ec32a86e2de1800788abd95752", async() => {
                WriteLiteral(@"
        <input type=""text"" name=""fn"" id=""firstname"" placeholder=""First Name"" /><br />
        <input type=""text"" name=""ln"" id=""lastname"" placeholder=""Last Name"" /><br />
        <input type=""text"" name=""em"" id=""email"" placeholder=""Email""/><br />
        <input type=""password"" name=""pw"" id=""password"" placeholder=""Password""/><br />
        <input type=""password"" name=""pw"" id=""conpass"" placeholder=""Confirm Password"" /><br />
        <input type=""submit"" class=""submit""/>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>");
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
