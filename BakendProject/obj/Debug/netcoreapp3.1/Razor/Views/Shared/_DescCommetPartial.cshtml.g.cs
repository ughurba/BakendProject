#pragma checksum "C:\Users\Clean__Laptop\Desktop\BakendProject\BakendProject\Views\Shared\_DescCommetPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae81c35525e8349c6292d4d89b4dbf4984c2a87c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__DescCommetPartial), @"mvc.1.0.view", @"/Views/Shared/_DescCommetPartial.cshtml")]
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
#line 1 "C:\Users\Clean__Laptop\Desktop\BakendProject\BakendProject\Views\_ViewImports.cshtml"
using BakendProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Clean__Laptop\Desktop\BakendProject\BakendProject\Views\_ViewImports.cshtml"
using BakendProject.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae81c35525e8349c6292d4d89b4dbf4984c2a87c", @"/Views/Shared/_DescCommetPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"660a035cbfdd8bc190284b7642210544650f1481", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__DescCommetPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"tab-content\" id=\"myTabContent\">\r\n                <div class=\"tab-pane fade show active\" id=\"description\" role=\"tabpanel\" aria-labelledby=\"description-tab\">\r\n                    <div class=\"description\">\r\n                       <p>");
#nullable restore
#line 5 "C:\Users\Clean__Laptop\Desktop\BakendProject\BakendProject\Views\Shared\_DescCommetPartial.cshtml"
                     Write(Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div> <!-- Description -->
                </div>
                <div class=""tab-pane fade"" id=""review"" role=""tabpanel"" aria-labelledby=""review-tab"">
                    <div class=""product-rating-content"">
                        <div class=""average-rating"">
                            <h4 class=""rating-overall"">4.5 <span>(Overall)</span></h4>
                            <p>Based on 9 Comments</p>
                        </div>
                        <div class=""rating-list d-flex flex-wrap"">
                            <div class=""single-rating"">
                                <i class=""fas fa-star""></i>
                                <i class=""fas fa-star""></i>
                                <i class=""fas fa-star""></i>
                                <i class=""fas fa-star""></i>
                                <i class=""fas fa-star""></i>
                                <span>(5)</span>
                            </div>
                            <div class=");
            WriteLiteral(@"""single-rating"">
                                <i class=""fas fa-star""></i>
                                <i class=""fas fa-star""></i>
                                <i class=""fas fa-star""></i>
                                <i class=""fa fa-star""></i>
                                <i class=""far fa-star""></i>
                                <span>(3)</span>
                            </div>
                            <div class=""single-rating"">
                                <i class=""fas fa-star""></i>
                                <i class=""fas fa-star""></i>
                                <i class=""fas fa-star""></i>
                                <i class=""far fa-star""></i>
                                <i class=""far fa-star""></i>
                                <span>(1)</span>
                            </div>
                            <div class=""single-rating"">
                                <i class=""fas fa-star""></i>
                                <i class=""fas fa-s");
            WriteLiteral(@"tar""></i>
                                <i class=""far fa-star""></i>
                                <i class=""far fa-star""></i>
                                <i class=""far fa-star""></i>
                                <span>(0)</span>
                            </div>
                            <div class=""single-rating"">
                                <i class=""fas fa-star""></i>
                                <i class=""far fa-star""></i>
                                <i class=""far fa-star""></i>
                                <i class=""far fa-star""></i>
                                <i class=""far fa-star""></i>
                                <span>(0)</span>
                            </div>
                        </div>
                        <div class=""rating-items"">
                            <div class=""single-rating-item"">
                                <div class=""rating-author d-flex flex-wrap"">
                                    <h4 class=""author-name"">Cristopher L");
            WriteLiteral(@"ee</h4>
                                    <ul class=""rating-star"">
                                        <li><i class=""fas fa-star""></i></li>
                                        <li><i class=""fas fa-star""></i></li>
                                        <li><i class=""fas fa-star""></i></li>
                                        <li><i class=""fas fa-star""></i></li>
                                        <li><i class=""fas fa-star""></i></li>
                                        <li><span>(5)</span></li>
                                    </ul>
                                </div>
                                <p>enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia res eos qui ratione voluptatem sequi Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci veli enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia res eos qui ratione voluptatem sequi Neque porro quisquam est, qui dolorem ipsum quia dol");
            WriteLiteral(@"or sit amet, consectetur, adipisci veli</p>
                            </div>
                            <div class=""single-rating-item"">
                                <div class=""rating-author d-flex flex-wrap"">
                                    <h4 class=""author-name"">Hasan Mubarak</h4>
                                    <ul class=""rating-star"">
                                        <li><i class=""fas fa-star""></i></li>
                                        <li><i class=""fas fa-star""></i></li>
                                        <li><i class=""fas fa-star""></i></li>
                                        <li><i class=""fas fa-star""></i></li>
                                        <li><i class=""fas fa-star""></i></li>
                                        <li><span>(5)</span></li>
                                    </ul>
                                </div>
                                <p>enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia res eo");
            WriteLiteral(@"s qui ratione voluptatem sequi Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci veli enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia res eos qui ratione voluptatem sequi Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci veli</p>
                            </div>
                            <div class=""single-rating-item"">
                                <div class=""rating-author d-flex flex-wrap"">
                                    <h4 class=""author-name"">Rashed Mahmud</h4>
                                    <ul class=""rating-star"">
                                        <li><i class=""fas fa-star""></i></li>
                                        <li><i class=""fas fa-star""></i></li>
                                        <li><i class=""fas fa-star""></i></li>
                                        <li><i class=""fas fa-star""></i></li>
                                        <li><i class=""fas");
            WriteLiteral(@" fa-star""></i></li>
                                        <li><span>(5)</span></li>
                                    </ul>
                                </div>
                                <p>enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia res eos qui ratione voluptatem sequi Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci veli enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia res eos qui ratione voluptatem sequi Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci veli</p>
                            </div>
                        </div>
                        
                        <div class=""rating-form"">
                            <h4 class=""form-title"">Add your Comments</h4>
                            
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae81c35525e8349c6292d4d89b4dbf4984c2a87c11594", async() => {
                WriteLiteral(@"
                                <div class=""rating-star d-flex"">
                                     <span class=""title"">Rating:</span>
                                    <ul>
                                        <li><i class=""fas fa-star""></i></li>
                                        <li><i class=""fas fa-star""></i></li>
                                        <li><i class=""fas fa-star""></i></li>
                                        <li><i class=""fas fa-star""></i></li>
                                        <li><i class=""fas fa-star""></i></li>
                                    </ul>
                                </div>
                                <div class=""row"">
                                    <div class=""col-md-6"">
                                        <div class=""single-form"">
                                            <label>Name:</label>
                                            <input type=""text"" placeholder=""Name"">
                                        ");
                WriteLiteral(@"</div>
                                    </div>
                                    <div class=""col-md-6"">
                                        <div class=""single-form"">
                                            <label>Email:</label>
                                            <input type=""email"" placeholder=""Email"">
                                        </div>
                                    </div>
                                    <div class=""col-md-12"">
                                        <div class=""single-form"">
                                            <label>Your Review:</label>
                                            <textarea placeholder=""Write a review""></textarea>
                                        </div>
                                    </div>
                                    <div class=""col-md-12"">
                                        <div class=""single-form"">
                                            <button class=""main-btn"">Add Review</bu");
                WriteLiteral("tton>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div> <!-- Rating Content -->\r\n                </div>\r\n            </div> ");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
