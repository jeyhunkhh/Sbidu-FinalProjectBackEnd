#pragma checksum "C:\Users\Ceyhun\Desktop\Sbidu\Views\Auction\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79ec7076fc4b96723abc8ebba68ae6be4ca71a6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auction_Index), @"mvc.1.0.view", @"/Views/Auction/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79ec7076fc4b96723abc8ebba68ae6be4ca71a6d", @"/Views/Auction/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52a7d2c28f49214b4094fa8331e98ead58070cc4", @"/Views/_ViewImports.cshtml")]
    public class Views_Auction_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AuctionPoster", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<!-- Breadcrumb -->
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

<!-- Featured Auctions -->
<section id=""featured-auctions"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""title"">
                    <h2>Bid On These Featured Auctions! </h2>
                </div>
            </div>
        </div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "79ec7076fc4b96723abc8ebba68ae6be4ca71a6d4072", async() => {
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
</section>
<!-- End Featured Auctions -->

<!-- Product Auction -->
<section id=""product-auction"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4"">
                <div class=""catagory"">
                    <div class=""title"">
                        <h4>Categories</h4>
                    </div>
                    <div class=""content"">
                        <ul>
                            <li class=""active"">
                                <a href=""#"">
                                    <span><i class=""fas fa-car""></i></span>
                                    Vehicles
                                </a>
                            </li>
                            <li>
                                <a href=""#"">
                                    <span><i class=""fas fa-gem""></i></span>
                                    Jewelry
                                </a>
                            </li>
                     ");
            WriteLiteral(@"       <li>
                                <a href=""#"">
                                    <span><i class=""flaticon-wristwatch""></i></span>
                                    Watches
                                </a>
                            </li>
                            <li>
                                <a href=""#"">
                                    <span><i class=""flaticon-camera""></i></span>
                                    Electronics
                                </a>
                            </li>
                            <li>
                                <a href=""#"">
                                    <span><i class=""flaticon-football-ball""></i></span>
                                    Sports
                                </a>
                            </li>
                            <li>
                                <a href=""#"">
                                    <span><i class=""flaticon-condominium""></i></span>
                        ");
            WriteLiteral(@"            Real Estate
                                </a>
                            </li>
                            <li>
                                <a href=""#"">
                                    <span><i class=""flaticon-paint-board-and-brush""></i></span>
                                    Arts
                                </a>
                            </li>
                            <li>
                                <a href=""#"">
                                    <span><i class=""flaticon-dollar""></i></span>
                                    Coins
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class=""col-lg-8"">
                <div class=""row"">
                    <div class=""col-lg-6"">
                        <div class=""auction-item"">
                            <div class=""image"">
                                <a hr");
            WriteLiteral("ef=\"auction-details.html\">\r\n                                    <img src=\"assets/img/car01.png\"");
            BeginWriteAttribute("alt", " alt=\"", 4107, "\"", 4113, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                                <a href=""#"" class=""star"">
                                    <i class=""far fa-star""></i>
                                </a>
                                <a href=""auction-details.html"" class=""hammer"">
                                    <i class=""flaticon-hammer""></i>
                                </a>
                            </div>
                            <div class=""auction-content"">
                                <h5>2020 Hyundai Elantra, Sel</h5>
                                <div class=""bid d-flex justify-content-between"">
                                    <div class=""current-bid d-flex"">
                                        <i class=""flaticon-hammer""></i>
                                        <p class=""d-flex flex-column"">
                                            Current Bid
                                            <span>$876.00</span>
                                        </p>
     ");
            WriteLiteral(@"                               </div>
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
                                <span>30 Bids</span>
                            </div>
                            <div class=""button text-center"">
                                <a href=""auction-details.html"">Submit A Bid</a>
                            </div>
                        </div>
                    </div>
 ");
            WriteLiteral(@"                   <div class=""col-lg-6"">
                        <div class=""auction-item"">
                            <div class=""image"">
                                <a href=""auction-details.html"">
                                    <img src=""assets/img/car03.png""");
            BeginWriteAttribute("alt", " alt=\"", 6438, "\"", 6444, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </a>
                                <a href=""#"" class=""star"">
                                    <i class=""far fa-star""></i>
                                </a>
                                <a href=""auction-details.html"" class=""hammer"">
                                    <i class=""flaticon-hammer""></i>
                                </a>
                            </div>
                            <div class=""auction-content"">
                                <h5>2019 Mercedes-Benz C, 300</h5>
                                <div class=""bid d-flex justify-content-between"">
                                    <div class=""current-bid d-flex"">
                                        <i class=""flaticon-hammer""></i>
                                        <p class=""d-flex flex-column"">
                                            Current Bid
                                            <span>$876.00</span>
                                        </p>
     ");
            WriteLiteral(@"                               </div>
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
                                <span>30 Bids</span>
                            </div>
                            <div class=""button text-center"">
                                <a href=""auction-details.html"">Submit A Bid</a>
                            </div>
                        </div>
                    </div>
 ");
            WriteLiteral(@"                   <div class=""col-lg-6"">
                        <div class=""auction-item"">
                            <div class=""image"">
                                <a href=""auction-details.html"">
                                    <img src=""assets/img/car04.png""");
            BeginWriteAttribute("alt", " alt=\"", 8769, "\"", 8775, 0);
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
                                            Current Bid
                                            <span>$876.00</span>
                                        </p>
                             ");
            WriteLiteral(@"       </div>
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
                                <span>30 Bids</span>
                            </div>
                            <div class=""button text-center"">
                                <a href=""auction-details.html"">Submit A Bid</a>
                            </div>
                        </div>
                    </div>
                    <div ");
            WriteLiteral("class=\"col-lg-6\">\r\n                        <div class=\"auction-item\">\r\n                            <div class=\"image\">\r\n                                <a href=\"auction-details.html\">\r\n                                    <img src=\"assets/img/car05.png\"");
            BeginWriteAttribute("alt", " alt=\"", 11076, "\"", 11082, 0);
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
                                            Current Bid
                                            <span>$876.00</span>
                                        </p>
                   ");
            WriteLiteral(@"                 </div>
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
                                <span>30 Bids</span>
                            </div>
                            <div class=""button text-center"">
                                <a href=""auction-details.html"">Submit A Bid</a>
                            </div>
                        </div>
                    </div>
               ");
            WriteLiteral(@"     <div class=""col-lg-6"">
                        <div class=""auction-item"">
                            <div class=""image"">
                                <a href=""auction-details.html"">
                                    <img src=""assets/img/car07.png""");
            BeginWriteAttribute("alt", " alt=\"", 13393, "\"", 13399, 0);
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
                                <h5>2019 Ford Expedition</h5>
                                <div class=""bid d-flex justify-content-between"">
                                    <div class=""current-bid d-flex"">
                                        <i class=""flaticon-hammer""></i>
                                        <p class=""d-flex flex-column"">
                                            Current Bid
                                            <span>$876.00</span>
                                        </p>
                             ");
            WriteLiteral(@"       </div>
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
                                <span>30 Bids</span>
                            </div>
                            <div class=""button text-center"">
                                <a href=""auction-details.html"">Submit A Bid</a>
                            </div>
                        </div>
                    </div>
                    <div ");
            WriteLiteral("class=\"col-lg-6\">\r\n                        <div class=\"auction-item\">\r\n                            <div class=\"image\">\r\n                                <a href=\"auction-details.html\">\r\n                                    <img src=\"assets/img/car09.png\"");
            BeginWriteAttribute("alt", " alt=\"", 15700, "\"", 15706, 0);
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
                                <h5>2018 Dodge Grand, Sxt</h5>
                                <div class=""bid d-flex justify-content-between"">
                                    <div class=""current-bid d-flex"">
                                        <i class=""flaticon-hammer""></i>
                                        <p class=""d-flex flex-column"">
                                            Current Bid
                                            <span>$876.00</span>
                                        </p>
                            ");
            WriteLiteral(@"        </div>
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
                                <span>30 Bids</span>
                            </div>
                            <div class=""button text-center"">
                                <a href=""auction-details.html"">Submit A Bid</a>
                            </div>
                        </div>
                    </div>
                    <ul ");
            WriteLiteral(@"class=""pagination"">
                        <li>
                            <a href=""#"">
                                <i class=""flaticon-left-arrow""></i>
                            </a>
                        </li>
                        <li><a href=""#"">1</a></li>
                        <li><a href=""#"" class=""active"">2</a></li>
                        <li><a href=""#"">3</a></li>
                        <li>
                            <a href=""#"">
                                <i class=""flaticon-right-arrow""></i>
                            </a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- End Product Auction -->
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
