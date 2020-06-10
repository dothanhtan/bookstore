#pragma checksum "D:\ASP.NET\BookStoreWebsite\BookStore\BookStore\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0afb8fbf53977eaffbfbc2f3675d667b46dca03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "D:\ASP.NET\BookStoreWebsite\BookStore\BookStore\Views\_ViewImports.cshtml"
using BookStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ASP.NET\BookStoreWebsite\BookStore\BookStore\Views\_ViewImports.cshtml"
using BookStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0afb8fbf53977eaffbfbc2f3675d667b46dca03", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"970ad2232b60c18355d1b72e2ff9366751045b67", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dictionary<Book, int>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/image/products/product-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Cart Page Start -->
<main class=""cart-page-main-block inner-page-sec-padding-bottom"">
    <div class=""cart_area cart-area-padding  "">
        <div class=""container"">
            <div class=""page-section-title"">
                <h1>Shopping Cart</h1>
            </div>
            <div class=""row"">
                <div class=""col-12"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0afb8fbf53977eaffbfbc2f3675d667b46dca035096", async() => {
                WriteLiteral(@"
                        <!-- Cart Table -->
                        <div class=""cart-table table-responsive mb--40"">
                            <table class=""table"">
                                <!-- Head Row -->
                                <thead>
                                    <tr>
                                        <th class=""pro-remove""></th>
                                        <th class=""pro-thumbnail"">Image</th>
                                        <th class=""pro-title"">Product</th>
                                        <th class=""pro-price"">Price</th>
                                        <th class=""pro-quantity"">Quantity</th>
                                        <th class=""pro-subtotal"">Total</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 27 "D:\ASP.NET\BookStoreWebsite\BookStore\BookStore\Views\Cart\Index.cshtml"
                                     foreach (KeyValuePair<Book, int> kv in Model)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <!-- Product Row -->\r\n                                        <tr>\r\n                                            <td class=\"pro-remove\">\r\n                                                <a");
                BeginWriteAttribute("href", " href=\"", 1672, "\"", 1724, 1);
#nullable restore
#line 32 "D:\ASP.NET\BookStoreWebsite\BookStore\BookStore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1679, Url.Action("RemoveProduct", new {kv.Key.Id}), 1679, 45, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"><i class=""far fa-trash-alt""></i></a>
                                            </td>
                                            <td class=""pro-thumbnail"">
                                                <a href=""#"">
                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d0afb8fbf53977eaffbfbc2f3675d667b46dca037483", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                </a>\r\n                                            </td>\r\n                                            <td class=\"pro-title\"><a href=\"#\">");
#nullable restore
#line 39 "D:\ASP.NET\BookStoreWebsite\BookStore\BookStore\Views\Cart\Index.cshtml"
                                                                         Write(kv.Key.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n                                            <td class=\"pro-price\"><span>$");
#nullable restore
#line 40 "D:\ASP.NET\BookStoreWebsite\BookStore\BookStore\Views\Cart\Index.cshtml"
                                                                    Write(kv.Key.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span></td>
                                            <td class=""pro-quantity"">
                                                <div class=""pro-qty"">
                                                    <div class=""count-input-block"">
                                                        <input type=""number""");
                BeginWriteAttribute("name", " name=\"", 2669, "\"", 2693, 3);
                WriteAttributeValue("", 2676, "books[", 2676, 6, true);
#nullable restore
#line 44 "D:\ASP.NET\BookStoreWebsite\BookStore\BookStore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2682, kv.Key.Id, 2682, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2692, "]", 2692, 1, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control text-center\"");
                BeginWriteAttribute("value", "\r\n                                                               value=\"", 2727, "\"", 2808, 1);
#nullable restore
#line 45 "D:\ASP.NET\BookStoreWebsite\BookStore\BookStore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2799, kv.Value, 2799, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                    </div>\r\n                                                </div>\r\n                                            </td>\r\n                                            <td class=\"pro-subtotal\"><span>$");
#nullable restore
#line 49 "D:\ASP.NET\BookStoreWebsite\BookStore\BookStore\Views\Cart\Index.cshtml"
                                                                        Write(kv.Value * kv.Key.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></td>\r\n                                        </tr>\r\n");
#nullable restore
#line 51 "D:\ASP.NET\BookStoreWebsite\BookStore\BookStore\Views\Cart\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    <tr>
                                        <td colspan=""6"" class=""actions"">
                                            <div class=""coupon-block"">
                                                <div class=""coupon-text"">
                                                    <label for=""coupon_code"">Coupon:</label>
                                                    <input type=""text"" name=""coupon_code"" class=""input-text""
                                                           id=""coupon_code""");
                BeginWriteAttribute("value", " value=\"", 3725, "\"", 3733, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Coupon code"">
                                                </div>
                                                <div class=""coupon-btn"">
                                                    <input type=""submit"" class=""btn btn-outlined""
                                                           name=""apply_coupon"" value=""Apply coupon"">
                                                </div>
                                            </div>
                                            <div class=""update-block text-right"">
                                                <a");
                BeginWriteAttribute("href", " href=\"", 4335, "\"", 4364, 1);
#nullable restore
#line 67 "D:\ASP.NET\BookStoreWebsite\BookStore\BookStore\Views\Cart\Index.cshtml"
WriteAttributeValue("", 4342, ViewData["returnurl"], 4342, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""btn btn-outlined"">Continue Shopping</a>
                                                <input type=""submit"" class=""btn btn-outlined"" name=""update_cart""
                                                       value=""Update cart"">
                                                <input type=""hidden"" id=""_wpnonce"" name=""_wpnonce""
                                                       value=""05741b501f"">
                                                <input type=""hidden""
                                                       name=""_wp_http_referer"" value=""/petmark/cart/"">
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
    <div class=""cart-section-2"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-6 col-12 mb--30 mb-lg--0"">
                    <!-- slide Block 5 / Normal Slider -->
                    <div class=""cart-block-title"">
                        <h2>YOU MAY BE INTERESTED IN…</h2>
                    </div>
                    <div class=""product-slider sb-slick-slider"" data-slick-setting='{
							          ""autoplay"": true,
							          ""autoplaySpeed"": 8000,
							          ""slidesToShow"": 2
									  }' data-slick-responsive='[
                {""breakpoint"":992, ""settings"": {""slidesToShow"": 2} },
                {""breakpoint"":768, ""settings"": {""slidesToShow"": 3} },
                {""breakpoint"":575, ""settings"": {""slidesToShow"": 2} },
                {""breakpoint"":480, ""settings"": {""slidesToShow"": 1} },
                {""breakpoint"":320, ""settings"": {""slidesToShow"": 1");
            WriteLiteral(@"} }
            ]'>
                        <div class=""single-slide"">
                            <div class=""product-card"">
                                <div class=""product-header"">
                                    <span class=""author"">
                                        Lpple
                                    </span>
                                    <h3>
                                        <a href=""product-details.html"">
                                            Revolutionize Your BOOK With These
                                            Easy-peasy Tips
                                        </a>
                                    </h3>
                                </div>
                                <div class=""product-card--body"">
                                    <div class=""card-image"">
                                        <img src=""image/products/product-10.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7196, "\"", 7202, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        <div class=""hover-contents"">
                                            <a href=""product-details.html"" class=""hover-image"">
                                                <img src=""image/products/product-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7460, "\"", 7466, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            </a>
                                            <div class=""hover-btns"">
                                                <a href=""cart.html"" class=""single-btn"">
                                                    <i class=""fas fa-shopping-basket""></i>
                                                </a>
                                                <a href=""wishlist.html"" class=""single-btn"">
                                                    <i class=""fas fa-heart""></i>
                                                </a>
                                                <a href=""compare.html"" class=""single-btn"">
                                                    <i class=""fas fa-random""></i>
                                                </a>
                                                <a href=""#"" data-toggle=""modal"" data-target=""#quickModal""
                                                   class=""single-btn"">
                             ");
            WriteLiteral(@"                       <i class=""fas fa-eye""></i>
                                                </a>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""price-block"">
                                        <span class=""price"">£51.20</span>
                                        <del class=""price-old"">£51.20</del>
                                        <span class=""price-discount"">20%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""single-slide"">
                            <div class=""product-card"">
                                <div class=""product-header"">
                                    <span class=""author"">
                                        Jpple
                                    </span>
      ");
            WriteLiteral(@"                              <h3><a href=""product-details.html"">Turn Your BOOK Into High Machine</a></h3>
                                </div>
                                <div class=""product-card--body"">
                                    <div class=""card-image"">
                                        <img src=""image/products/product-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 9870, "\"", 9876, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        <div class=""hover-contents"">
                                            <a href=""product-details.html"" class=""hover-image"">
                                                <img src=""image/products/product-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 10134, "\"", 10140, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            </a>
                                            <div class=""hover-btns"">
                                                <a href=""cart.html"" class=""single-btn"">
                                                    <i class=""fas fa-shopping-basket""></i>
                                                </a>
                                                <a href=""wishlist.html"" class=""single-btn"">
                                                    <i class=""fas fa-heart""></i>
                                                </a>
                                                <a href=""compare.html"" class=""single-btn"">
                                                    <i class=""fas fa-random""></i>
                                                </a>
                                                <a href=""#"" data-toggle=""modal"" data-target=""#quickModal""
                                                   class=""single-btn"">
                             ");
            WriteLiteral(@"                       <i class=""fas fa-eye""></i>
                                                </a>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""price-block"">
                                        <span class=""price"">£51.20</span>
                                        <del class=""price-old"">£51.20</del>
                                        <span class=""price-discount"">20%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""single-slide"">
                            <div class=""product-card"">
                                <div class=""product-header"">
                                    <span class=""author"">
                                        Wpple
                                    </span>
      ");
            WriteLiteral(@"                              <h3><a href=""product-details.html"">3 Ways Create Better BOOK With</a></h3>
                                </div>
                                <div class=""product-card--body"">
                                    <div class=""card-image"">
                                        <img src=""image/products/product-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 12542, "\"", 12548, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        <div class=""hover-contents"">
                                            <a href=""product-details.html"" class=""hover-image"">
                                                <img src=""image/products/product-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 12806, "\"", 12812, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            </a>
                                            <div class=""hover-btns"">
                                                <a href=""cart.html"" class=""single-btn"">
                                                    <i class=""fas fa-shopping-basket""></i>
                                                </a>
                                                <a href=""wishlist.html"" class=""single-btn"">
                                                    <i class=""fas fa-heart""></i>
                                                </a>
                                                <a href=""compare.html"" class=""single-btn"">
                                                    <i class=""fas fa-random""></i>
                                                </a>
                                                <a href=""#"" data-toggle=""modal"" data-target=""#quickModal""
                                                   class=""single-btn"">
                             ");
            WriteLiteral(@"                       <i class=""fas fa-eye""></i>
                                                </a>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""price-block"">
                                        <span class=""price"">£51.20</span>
                                        <del class=""price-old"">£51.20</del>
                                        <span class=""price-discount"">20%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""single-slide"">
                            <div class=""product-card"">
                                <div class=""product-header"">
                                    <span class=""author"">
                                        Epple
                                    </span>
      ");
            WriteLiteral(@"                              <h3>
                                        <a href=""product-details.html"">What You Can Learn From Bill Gates</a>
                                    </h3>
                                </div>
                                <div class=""product-card--body"">
                                    <div class=""card-image"">
                                        <img src=""image/products/product-5.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 15298, "\"", 15304, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        <div class=""hover-contents"">
                                            <a href=""product-details.html"" class=""hover-image"">
                                                <img src=""image/products/product-4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 15562, "\"", 15568, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            </a>
                                            <div class=""hover-btns"">
                                                <a href=""cart.html"" class=""single-btn"">
                                                    <i class=""fas fa-shopping-basket""></i>
                                                </a>
                                                <a href=""wishlist.html"" class=""single-btn"">
                                                    <i class=""fas fa-heart""></i>
                                                </a>
                                                <a href=""compare.html"" class=""single-btn"">
                                                    <i class=""fas fa-random""></i>
                                                </a>
                                                <a href=""#"" data-toggle=""modal"" data-target=""#quickModal""
                                                   class=""single-btn"">
                             ");
            WriteLiteral(@"                       <i class=""fas fa-eye""></i>
                                                </a>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""price-block"">
                                        <span class=""price"">£51.20</span>
                                        <del class=""price-old"">£51.20</del>
                                        <span class=""price-discount"">20%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""single-slide"">
                            <div class=""product-card"">
                                <div class=""product-header"">
                                    <span class=""author"">
                                        Hpple
                                    </span>
      ");
            WriteLiteral(@"                              <h3><a href=""product-details.html"">Simple Things You To Save BOOK</a></h3>
                                </div>
                                <div class=""product-card--body"">
                                    <div class=""card-image"">
                                        <img src=""image/products/product-6.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 17970, "\"", 17976, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                        <div class=""hover-contents"">
                                            <a href=""product-details.html"" class=""hover-image"">
                                                <img src=""image/products/product-4.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 18234, "\"", 18240, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                            </a>
                                            <div class=""hover-btns"">
                                                <a href=""cart.html"" class=""single-btn"">
                                                    <i class=""fas fa-shopping-basket""></i>
                                                </a>
                                                <a href=""wishlist.html"" class=""single-btn"">
                                                    <i class=""fas fa-heart""></i>
                                                </a>
                                                <a href=""compare.html"" class=""single-btn"">
                                                    <i class=""fas fa-random""></i>
                                                </a>
                                                <a href=""#"" data-toggle=""modal"" data-target=""#quickModal""
                                                   class=""single-btn"">
                             ");
            WriteLiteral(@"                       <i class=""fas fa-eye""></i>
                                                </a>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""price-block"">
                                        <span class=""price"">£51.20</span>
                                        <del class=""price-old"">£51.20</del>
                                        <span class=""price-discount"">20%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- Cart Summary -->
                <div class=""col-lg-6 col-12 d-flex"">
                    <div class=""cart-summary"">
                        <div class=""cart-summary-wrap"">
                            <h4><span>Cart Summary</span></h4>
             ");
            WriteLiteral(@"               <p>Sub Total <span class=""text-primary"">$1250.00</span></p>
                            <p>Shipping Cost <span class=""text-primary"">$00.00</span></p>
                            <h2>Grand Total <span class=""text-primary"">$1250.00</span></h2>
                        </div>
                        <div class=""cart-summary-button"">
                            <a href=""checkout.html"" class=""checkout-btn c-btn btn--primary"">Checkout</a>
                            <button class=""update-btn c-btn btn-outlined"">Update Cart</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</main>
<!-- Cart Page End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dictionary<Book, int>> Html { get; private set; }
    }
}
#pragma warning restore 1591