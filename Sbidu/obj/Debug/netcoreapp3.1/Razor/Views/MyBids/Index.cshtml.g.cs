#pragma checksum "C:\Users\Ceyhun\Desktop\Sbidu\Views\MyBids\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aea0867fd2011daa7b1ab3ed99dd756f45920b7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyBids_Index), @"mvc.1.0.view", @"/Views/MyBids/Index.cshtml")]
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
#line 1 "C:\Users\Ceyhun\Desktop\Sbidu\Views\_ViewImports.cshtml"
using Sbidu;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aea0867fd2011daa7b1ab3ed99dd756f45920b7d", @"/Views/MyBids/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52a7d2c28f49214b4094fa8331e98ead58070cc4", @"/Views/_ViewImports.cshtml")]
    public class Views_MyBids_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_UserMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
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
    <div class=""bg-image"" style=""background-image: url(assets/img/hero-bg.png);"">

    </div>
</section>
<!-- End Breadcrumb -->
<section id=""dashboard"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aea0867fd2011daa7b1ab3ed99dd756f45920b7d3867", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
                <div class=""my-bids start"">
                    <div class=""activity"">
                        <div class=""title"">
                            <h4>My Activity</h4>
                        </div>
                        <div class=""row"">
                            <div class=""col-lg-4"">
                                <div class=""item"">
                                    <div class=""image"">
                                        <img src=""assets/img/bid01.png"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 1309, "\"", 1315, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""content"">
                                        <div class=""timer"" data-to=""80"" data-speed=""5000""></div>
                                        <span>Active Bids</span>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-lg-4"">
                                <div class=""item"">
                                    <div class=""image"">
                                        <img src=""assets/img/bid02.png"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 1956, "\"", 1962, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""content"">
                                        <div class=""timer"" data-to=""15"" data-speed=""5000""></div>
                                        <span>Items Won</span>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-lg-4"">
                                <div class=""item"">
                                    <div class=""image"">
                                        <img src=""assets/img/bid03.png"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 2601, "\"", 2607, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                    </div>
                                    <div class=""content"">
                                        <div class=""timer"" data-to=""115"" data-speed=""5000""></div>
                                        <span>Favorites</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <ul class=""nav d-flex"">
                            <li class=""nav-item"">
                                <a href=""#upcoming"" data-toggle=""tab"" class=""upcoming nav-link active"">Upcoming</a>
                            </li>
                            <li class=""nav-item"">
                                <a href=""#past"" data-toggle=""tab"" class=""past nav-link"">Past</a>
                            </li>
                        </ul>
                    </div>
                    <div class=""tab-content"">
                        <div class=""tab-pane fade show active");
            WriteLiteral(@""" id=""upcoming"">
                            <div class=""row"">
                                <div class=""col-lg-6"">
                                    <div class=""auction-item"">
                                        <div class=""image"">
                                            <a href=""#"">
                                                <img src=""assets/img/car01.png""");
            BeginWriteAttribute("alt", " alt=\"", 4015, "\"", 4021, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            </a>
                                            <a href=""#"" class=""star"">
                                                <i class=""far fa-star""></i>
                                            </a>
                                            <a href=""#"" class=""hammer"">
                                                <i class=""flaticon-hammer""></i>
                                            </a>
                                        </div>
                                        <div class=""auction-content"">
                                            <h5>2020 Hyundai Elantra, Sel</h5>
                                            <div class=""bid d-flex justify-content-between"">
                                                <div class=""current-bid d-flex"">
                                                    <i class=""flaticon-hammer""></i>
                                                    <p class=""d-flex flex-column"">
                         ");
            WriteLiteral(@"                               Current Bid
                                                        <span>$876.00</span>
                                                    </p>
                                                </div>
                                                <div class=""buy-now-price d-flex"">
                                                    <i class=""flaticon-money""></i>
                                                    <p class=""d-flex flex-column"">
                                                        Buy Now
                                                        <span>$5000.00</span>
                                                    </p>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""time d-flex "">
                                            <div class=""countdown"" data-countdown=""10/31/2020 20:00""></div>
 ");
            WriteLiteral(@"                                           <span>30 Bids</span>
                                        </div>
                                        <div class=""button text-center"">
                                            <a href=""#"">Submit A Bid</a>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-lg-6"">
                                    <div class=""auction-item"">
                                        <div class=""image"">
                                            <a href=""#"">
                                                <img src=""assets/img/car03.png""");
            BeginWriteAttribute("alt", " alt=\"", 6781, "\"", 6787, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            </a>
                                            <a href=""#"" class=""star"">
                                                <i class=""far fa-star""></i>
                                            </a>
                                            <a href=""#"" class=""hammer"">
                                                <i class=""flaticon-hammer""></i>
                                            </a>
                                        </div>
                                        <div class=""auction-content"">
                                            <h5>2019 Mercedes-Benz C, 300</h5>
                                            <div class=""bid d-flex justify-content-between"">
                                                <div class=""current-bid d-flex"">
                                                    <i class=""flaticon-hammer""></i>
                                                    <p class=""d-flex flex-column"">
                         ");
            WriteLiteral(@"                               Current Bid
                                                        <span>$876.00</span>
                                                    </p>
                                                </div>
                                                <div class=""buy-now-price d-flex"">
                                                    <i class=""flaticon-money""></i>
                                                    <p class=""d-flex flex-column"">
                                                        Buy Now
                                                        <span>$5000.00</span>
                                                    </p>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""time d-flex "">
                                            <div class=""countdown"" data-countdown=""10/31/2020 20:00""></div>
 ");
            WriteLiteral(@"                                           <span>30 Bids</span>
                                        </div>
                                        <div class=""button text-center"">
                                            <a href=""#"">Submit A Bid</a>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-lg-6"">
                                    <div class=""auction-item"">
                                        <div class=""image"">
                                            <a href=""#"">
                                                <img src=""assets/img/car04.png""");
            BeginWriteAttribute("alt", " alt=\"", 9547, "\"", 9553, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            </a>
                                            <a href=""#"" class=""star"">
                                                <i class=""far fa-star""></i>
                                            </a>
                                            <a href=""#"" class=""hammer"">
                                                <i class=""flaticon-hammer""></i>
                                            </a>
                                        </div>
                                        <div class=""auction-content"">
                                            <h5>2014 KIA Sorento, LX</h5>
                                            <div class=""bid d-flex justify-content-between"">
                                                <div class=""current-bid d-flex"">
                                                    <i class=""flaticon-hammer""></i>
                                                    <p class=""d-flex flex-column"">
                              ");
            WriteLiteral(@"                          Current Bid
                                                        <span>$876.00</span>
                                                    </p>
                                                </div>
                                                <div class=""buy-now-price d-flex"">
                                                    <i class=""flaticon-money""></i>
                                                    <p class=""d-flex flex-column"">
                                                        Buy Now
                                                        <span>$5000.00</span>
                                                    </p>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""time d-flex "">
                                            <div class=""countdown"" data-countdown=""10/31/2020 20:00""></div>
      ");
            WriteLiteral(@"                                      <span>30 Bids</span>
                                        </div>
                                        <div class=""button text-center"">
                                            <a href=""#"">Submit A Bid</a>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-lg-6"">
                                    <div class=""auction-item"">
                                        <div class=""image"">
                                            <a href=""#"">
                                                <img src=""assets/img/car05.png""");
            BeginWriteAttribute("alt", " alt=\"", 12308, "\"", 12314, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            </a>
                                            <a href=""#"" class=""star"">
                                                <i class=""far fa-star""></i>
                                            </a>
                                            <a href=""#"" class=""hammer"">
                                                <i class=""flaticon-hammer""></i>
                                            </a>
                                        </div>
                                        <div class=""auction-content"">
                                            <h5>2019 Subaru Crosstrek, Premium</h5>
                                            <div class=""bid d-flex justify-content-between"">
                                                <div class=""current-bid d-flex"">
                                                    <i class=""flaticon-hammer""></i>
                                                    <p class=""d-flex flex-column"">
                    ");
            WriteLiteral(@"                                    Current Bid
                                                        <span>$876.00</span>
                                                    </p>
                                                </div>
                                                <div class=""buy-now-price d-flex"">
                                                    <i class=""flaticon-money""></i>
                                                    <p class=""d-flex flex-column"">
                                                        Buy Now
                                                        <span>$5000.00</span>
                                                    </p>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""time d-flex "">
                                            <div class=""countdown"" data-countdown=""10/31/2020 20:00""></di");
            WriteLiteral(@"v>
                                            <span>30 Bids</span>
                                        </div>
                                        <div class=""button text-center"">
                                            <a href=""#"">Submit A Bid</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""tab-pane fade"" id=""past"">
                            <div class=""row"">
                                <div class=""col-lg-6"">
                                    <div class=""auction-item"">
                                        <div class=""image"">
                                            <a href=""#"">
                                                <img src=""assets/img/jewelry-auction-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 15269, "\"", 15275, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            </a>
                                            <a href=""#"" class=""star"">
                                                <i class=""far fa-star""></i>
                                            </a>
                                            <a href=""#"" class=""hammer"">
                                                <i class=""flaticon-hammer""></i>
                                            </a>
                                        </div>
                                        <div class=""auction-content"">
                                            <h5>Gold Ring With Clear Stones</h5>
                                            <div class=""bid d-flex justify-content-between"">

                                                <div class=""buy-now-price d-flex"">
                                                    <i class=""flaticon-money""></i>
                                                    <p class=""d-flex flex-column"">
                    ");
            WriteLiteral(@"                                    Sold
                                                        <span>$5000.00</span>
                                                    </p>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-lg-6"">
                                    <div class=""auction-item"">
                                        <div class=""image"">
                                            <a href=""#"">
                                                <img src=""assets/img/jewelry-auction-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 17049, "\"", 17055, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            </a>
                                            <a href=""#"" class=""star"">
                                                <i class=""far fa-star""></i>
                                            </a>
                                            <a href=""#"" class=""hammer"">
                                                <i class=""flaticon-hammer""></i>
                                            </a>
                                        </div>
                                        <div class=""auction-content"">
                                            <h5>Ring With Clear Stone Accents</h5>
                                            <div class=""bid d-flex justify-content-between"">

                                                <div class=""buy-now-price d-flex"">
                                                    <i class=""flaticon-money""></i>
                                                    <p class=""d-flex flex-column"">
                  ");
            WriteLiteral(@"                                      Sold
                                                        <span>$5000.00</span>
                                                    </p>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-lg-6"">
                                    <div class=""auction-item"">
                                        <div class=""image"">
                                            <a href=""#"">
                                                <img src=""assets/img/jewelry-auction-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 18831, "\"", 18837, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            </a>
                                            <a href=""#"" class=""star"">
                                                <i class=""far fa-star""></i>
                                            </a>
                                            <a href=""#"" class=""hammer"">
                                                <i class=""flaticon-hammer""></i>
                                            </a>
                                        </div>
                                        <div class=""auction-content"">
                                            <h5>Gold Ring With Clear Stones</h5>
                                            <div class=""bid d-flex justify-content-between"">

                                                <div class=""buy-now-price d-flex"">
                                                    <i class=""flaticon-money""></i>
                                                    <p class=""d-flex flex-column"">
                    ");
            WriteLiteral(@"                                    Sold
                                                        <span>$5000.00</span>
                                                    </p>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

");
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
