#pragma checksum "C:\Users\Ceyhun\Desktop\Sbidu-FinalProjectBackEnd\Sbidu\Views\PersonalProfile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55f89a0890041ed9bcdd53e03f373278f5baa8a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PersonalProfile_Index), @"mvc.1.0.view", @"/Views/PersonalProfile/Index.cshtml")]
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
#line 1 "C:\Users\Ceyhun\Desktop\Sbidu-FinalProjectBackEnd\Sbidu\Views\_ViewImports.cshtml"
using Sbidu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ceyhun\Desktop\Sbidu-FinalProjectBackEnd\Sbidu\Views\_ViewImports.cshtml"
using Sbidu.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ceyhun\Desktop\Sbidu-FinalProjectBackEnd\Sbidu\Views\_ViewImports.cshtml"
using Sbidu.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55f89a0890041ed9bcdd53e03f373278f5baa8a5", @"/Views/PersonalProfile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c87a4807efa744515cee4589c2e8448ea4a51a18", @"/Views/_ViewImports.cshtml")]
    public class Views_PersonalProfile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::AspNetCore.Views_PersonalProfile_Index.__Generated__UserMenuComponentViewComponentTagHelper __UserMenuComponentViewComponentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Breadcrumb -->
<section id=""breadcrumb"">
    <div class=""container"">
        <ul class=""breadcrumb"">
            <li>
                <a href=""index.html"">
                    Home
                    <i class=""flaticon-right-arrow""></i>
                </a>
            </li>
            <li>
                <a href=""index.html"">
                    Auction
                </a>
            </li>
        </ul>
    </div>
    <div class=""bg-image"" style=""background-image: url(/uploads/hero-bg.png);"">

    </div>
</section>
<!-- End Breadcrumb -->
<section id=""dashboard"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:user-menu-component", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55f89a0890041ed9bcdd53e03f373278f5baa8a54060", async() => {
            }
            );
            __UserMenuComponentViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_PersonalProfile_Index.__Generated__UserMenuComponentViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__UserMenuComponentViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""col-lg-8"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <div class=""details"">
                            <div class=""header d-flex justify-content-between"">
                                <h3>Personal Details</h3>
                                <a href=""#"">
                                    <i class=""flaticon-edit""></i>
                                    Edit
                                </a>
                            </div>
                            <ul>
                                <li>
                                    <div class=""info"">
                                        Name
                                    </div>
                                    <div class=""info-value"">
                                        Percy Reed
                                    </div>
                                </li>
                                <li>
                 ");
            WriteLiteral(@"                   <div class=""info"">
                                        Date of Birth
                                    </div>
                                    <div class=""info-value"">
                                        15-03-1980
                                    </div>
                                </li>
                                <li>
                                    <div class=""info"">
                                        Address
                                    </div>
                                    <div class=""info-value"">
                                        8198 Fieldstone Dr.La Crosse, WI 54601
                                    </div>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class=""col-lg-12"">
                        <div class=""details"">
                            <div class=""header d-flex justify-content-between"">
         ");
            WriteLiteral(@"                       <h3>Account Settings</h3>
                                <a href=""#"">
                                    <i class=""flaticon-edit""></i>
                                    Edit
                                </a>
                            </div>
                            <ul>
                                <li>
                                    <div class=""info"">
                                        Language
                                    </div>
                                    <div class=""info-value"">
                                        English (United States)
                                    </div>
                                </li>
                                <li>
                                    <div class=""info"">
                                        Time Zone
                                    </div>
                                    <div class=""info-value"">
                                        (GMT-06:00) Central Am");
            WriteLiteral(@"erica
                                    </div>
                                </li>
                                <li>
                                    <div class=""info"">
                                        Status
                                    </div>
                                    <div class=""info-value"">
                                        <i class=""fas fa-check-circle""></i>
                                        Active
                                    </div>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class=""col-lg-12"">
                        <div class=""details"">
                            <div class=""header d-flex justify-content-between"">
                                <h3>Email Address</h3>
                                <a href=""#"">
                                    <i class=""flaticon-edit""></i>
                                    Edit");
            WriteLiteral(@"
                                </a>
                            </div>
                            <ul>
                                <li>
                                    <div class=""info"">
                                        Email
                                    </div>
                                    <div class=""info-value"">
                                        albert349@gmail.com
                                    </div>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class=""col-lg-12"">
                        <div class=""details"">
                            <div class=""header d-flex justify-content-between"">
                                <h3>Phone</h3>
                                <a href=""#"">
                                    <i class=""flaticon-edit""></i>
                                    Edit
                                </a>
               ");
            WriteLiteral(@"             </div>
                            <ul>
                                <li>
                                    <div class=""info"">
                                        Mobile
                                    </div>
                                    <div class=""info-value"">
                                        +1 234-567-8925
                                    </div>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class=""col-lg-12"">
                        <div class=""details"">
                            <div class=""header d-flex justify-content-between"">
                                <h3>Security</h3>
                                <a href=""#"">
                                    <i class=""flaticon-edit""></i>
                                    Edit
                                </a>
                            </div>
                            <ul>");
            WriteLiteral(@"
                                <li>
                                    <div class=""info"">
                                        Password
                                    </div>
                                    <div class=""info-value"">
                                        xxxxxxxxxxxxxxxx
                                    </div>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>");
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
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:user-menu-component")]
        public class __Generated__UserMenuComponentViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__UserMenuComponentViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("UserMenuComponent", new {  });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591
