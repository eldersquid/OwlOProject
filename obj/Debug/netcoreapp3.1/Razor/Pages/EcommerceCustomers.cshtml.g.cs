#pragma checksum "C:\Users\Wonyoung\source\repos\OwlOProject\Pages\EcommerceCustomers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bde70e165386f9c3ee5a40247044b2e5c5943ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OwlProjectA.Pages.Pages_EcommerceCustomers), @"mvc.1.0.razor-page", @"/Pages/EcommerceCustomers.cshtml")]
namespace OwlProjectA.Pages
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
#line 1 "C:\Users\Wonyoung\source\repos\OwlOProject\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Wonyoung\source\repos\OwlOProject\Pages\_ViewImports.cshtml"
using OwlProjectA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Wonyoung\source\repos\OwlOProject\Pages\_ViewImports.cshtml"
using OwlProjectA.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bde70e165386f9c3ee5a40247044b2e5c5943ef", @"/Pages/EcommerceCustomers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fea053676192de4ad31ef740e4ccf934f852b19b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_EcommerceCustomers : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/bootstrap/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/metismenu/metisMenu.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/simplebar/simplebar.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/libs/node-waves/waves.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/app.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""row mb-2"">
                    <div class=""col-sm-4"">
                        <div class=""search-box me-2 mb-2 d-inline-block"">
                            <div class=""position-relative"">
                                <input type=""text"" class=""form-control"" placeholder=""Search..."">
                                <i class=""bx bx-search-alt search-icon""></i>
                            </div>
                        </div>
                    </div>
                    <div class=""col-sm-8"">
                        <div class=""text-sm-end"">
                            <button type=""button"" class=""btn btn-success btn-rounded waves-effect waves-light mb-2 me-2""><i class=""mdi mdi-plus me-1""></i> New Customers</button>
                        </div>
                    </div><!-- end col-->
                </div>

                <div class=""table-responsive"">");
            WriteLiteral(@"
                    <table class=""table align-middle table-nowrap"">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>Username</th>
                                <th>Phone / Email</th>
                                <th>Address</th>
                                <th>Rating</th>
                                <th>Wallet Balance</th>
                                <th>Joining Date</th>
                                <th>Action</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>
                                    <div class=""form-check font-size-16"">
                                        <input class=""form-check-input"" type=""checkbox"" id=""customerlistcheck01"">
                                        <label class=""form-check-label"" for=""customerlistcheck01""></label>
    ");
            WriteLiteral(@"                                </div>
                                </td>
                                <td>Stephen Rash</td>
                                <td>
                                    <p class=""mb-1"">325-250-1106</p>
                                    <p class=""mb-0"">StephenRash@teleworm.us</p>
                                </td>

                                <td>
                                    2470 Grove Street
                                    Bethpage, NY 11714
                                </td>
                                <td><span class=""badge bg-success font-size-12""><i class=""mdi mdi-star me-1""></i> 4.2</span></td>
                                <td>$5,412</td>
                                <td>07 Oct, 2019</td>
                                <td>
                                    <div class=""dropdown"">
                                        <a href=""#"" class=""dropdown-toggle card-drop"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
   ");
            WriteLiteral(@"                                         <i class=""mdi mdi-dots-horizontal font-size-18""></i>
                                        </a>
                                        <ul class=""dropdown-menu dropdown-menu-end"">
                                            <li><a href=""#"" class=""dropdown-item""><i class=""mdi mdi-pencil font-size-16 text-success me-1""></i> Edit</a></li>
                                            <li><a href=""#"" class=""dropdown-item""><i class=""mdi mdi-trash-can font-size-16 text-danger me-1""></i> Delete</a></li>
                                        </ul>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div class=""form-check font-size-16"">
                                        <input class=""form-check-input"" type=""checkbox"" id=""customerlistcheck02"">
                                        <label c");
            WriteLiteral(@"lass=""form-check-label"" for=""customerlistcheck02""></label>
                                    </div>
                                </td>
                                <td>Juan Mays</td>
                                <td>
                                    <p class=""mb-1"">443-523-4726</p>
                                    <p class=""mb-0"">JuanMays@armyspy.com</p>
                                </td>

                                <td>
                                    3755 Harron Drive
                                    Salisbury, MD 21875
                                </td>
                                <td><span class=""badge bg-success font-size-12""><i class=""mdi mdi-star me-1""></i> 4.0</span></td>
                                <td>$5,632</td>
                                <td>06 Oct, 2019</td>
                                <td>
                                    <div class=""dropdown"">
                                        <a href=""#"" class=""dropdown-toggle card-");
            WriteLiteral(@"drop"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                            <i class=""mdi mdi-dots-horizontal font-size-18""></i>
                                        </a>
                                        <ul class=""dropdown-menu dropdown-menu-end"">
                                            <li><a href=""#"" class=""dropdown-item""><i class=""mdi mdi-pencil font-size-16 text-success me-1""></i> Edit</a></li>
                                            <li><a href=""#"" class=""dropdown-item""><i class=""mdi mdi-trash-can font-size-16 text-danger me-1""></i> Delete</a></li>
                                        </ul>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div class=""form-check font-size-16"">
                                        <input class=""form-check-input"" type=""checkbox"" id=""customerlist");
            WriteLiteral(@"check03"">
                                        <label class=""form-check-label"" for=""customerlistcheck03""></label>
                                    </div>
                                </td>
                                <td>Scott Henry</td>
                                <td>
                                    <p class=""mb-1"">704-629-9535</p>
                                    <p class=""mb-0"">ScottHenry@jourrapide.com</p>
                                </td>

                                <td>
                                    3632 Snyder Avenue
                                    Bessemer City, NC 28016
                                </td>
                                <td><span class=""badge bg-success font-size-12""><i class=""mdi mdi-star me-1""></i> 4.4</span></td>
                                <td>$7,523</td>
                                <td>06 Oct, 2019</td>
                                <td>
                                    <div class=""dropdown"">
         ");
            WriteLiteral(@"                               <a href=""#"" class=""dropdown-toggle card-drop"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                            <i class=""mdi mdi-dots-horizontal font-size-18""></i>
                                        </a>
                                        <ul class=""dropdown-menu dropdown-menu-end"">
                                            <li><a href=""#"" class=""dropdown-item""><i class=""mdi mdi-pencil font-size-16 text-success me-1""></i> Edit</a></li>
                                            <li><a href=""#"" class=""dropdown-item""><i class=""mdi mdi-trash-can font-size-16 text-danger me-1""></i> Delete</a></li>
                                        </ul>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div class=""form-check font-size-16"">
                                 ");
            WriteLiteral(@"       <input class=""form-check-input"" type=""checkbox"" id=""customerlistcheck04"">
                                        <label class=""form-check-label"" for=""customerlistcheck04""></label>
                                    </div>
                                </td>
                                <td>Cody Menendez</td>
                                <td>
                                    <p class=""mb-1"">701-832-5838</p>
                                    <p class=""mb-0"">CodyMenendez@armyspy.com</p>
                                </td>

                                <td>
                                    4401 Findley Avenue
                                    Minot, ND 58701
                                </td>
                                <td><span class=""badge bg-success font-size-12""><i class=""mdi mdi-star me-1""></i> 4.1</span></td>
                                <td>$6,325</td>
                                <td>05 Oct, 2019</td>
                                <td>
    ");
            WriteLiteral(@"                                <div class=""dropdown"">
                                        <a href=""#"" class=""dropdown-toggle card-drop"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                            <i class=""mdi mdi-dots-horizontal font-size-18""></i>
                                        </a>
                                        <ul class=""dropdown-menu dropdown-menu-end"">
                                            <li><a href=""#"" class=""dropdown-item""><i class=""mdi mdi-pencil font-size-16 text-success me-1""></i> Edit</a></li>
                                            <li><a href=""#"" class=""dropdown-item""><i class=""mdi mdi-trash-can font-size-16 text-danger me-1""></i> Delete</a></li>
                                        </ul>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div cl");
            WriteLiteral(@"ass=""form-check font-size-16"">
                                        <input class=""form-check-input"" type=""checkbox"" id=""customerlistcheck05"">
                                        <label class=""form-check-label"" for=""customerlistcheck05""></label>
                                    </div>
                                </td>
                                <td>Jason Merino</td>
                                <td>
                                    <p class=""mb-1"">706-219-4095</p>
                                    <p class=""mb-0"">JasonMerino@dayrep.com</p>
                                </td>

                                <td>
                                    3159 Holly Street
                                    Cleveland, GA 30528
                                </td>
                                <td><span class=""badge bg-success font-size-12""><i class=""mdi mdi-star me-1""></i> 3.8</span></td>
                                <td>$4,523</td>
                                <");
            WriteLiteral(@"td>04 Oct, 2019</td>
                                <td>
                                    <div class=""dropdown"">
                                        <a href=""#"" class=""dropdown-toggle card-drop"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                            <i class=""mdi mdi-dots-horizontal font-size-18""></i>
                                        </a>
                                        <ul class=""dropdown-menu dropdown-menu-end"">
                                            <li><a href=""#"" class=""dropdown-item""><i class=""mdi mdi-pencil font-size-16 text-success me-1""></i> Edit</a></li>
                                            <li><a href=""#"" class=""dropdown-item""><i class=""mdi mdi-trash-can font-size-16 text-danger me-1""></i> Delete</a></li>
                                        </ul>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                 ");
            WriteLiteral(@"               <td>
                                    <div class=""form-check font-size-16"">
                                        <input class=""form-check-input"" type=""checkbox"" id=""customerlistcheck06"">
                                        <label class=""form-check-label"" for=""customerlistcheck06""></label>
                                    </div>
                                </td>
                                <td>Kyle Aquino</td>
                                <td>
                                    <p class=""mb-1"">415-232-5443</p>
                                    <p class=""mb-0"">KyleAquino@teleworm.us</p>
                                </td>

                                <td>
                                    4861 Delaware Avenue
                                    San Francisco, CA 94143
                                </td>
                                <td><span class=""badge bg-success font-size-12""><i class=""mdi mdi-star me-1""></i> 4.0</span></td>
            ");
            WriteLiteral(@"                    <td>$5,412</td>
                                <td>03 Oct, 2019</td>
                                <td>
                                    <div class=""dropdown"">
                                        <a href=""#"" class=""dropdown-toggle card-drop"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                            <i class=""mdi mdi-dots-horizontal font-size-18""></i>
                                        </a>
                                        <ul class=""dropdown-menu dropdown-menu-end"">
                                            <li><a href=""#"" class=""dropdown-item""><i class=""mdi mdi-pencil font-size-16 text-success me-1""></i> Edit</a></li>
                                            <li><a href=""#"" class=""dropdown-item""><i class=""mdi mdi-trash-can font-size-16 text-danger me-1""></i> Delete</a></li>
                                        </ul>
                                    </div>
                                </td>
                ");
            WriteLiteral(@"            </tr>
                            <tr>
                                <td>
                                    <div class=""form-check font-size-16"">
                                        <input class=""form-check-input"" type=""checkbox"" id=""customerlistcheck07"">
                                        <label class=""form-check-label"" for=""customerlistcheck07""></label>
                                    </div>
                                </td>
                                <td>David Gaul</td>
                                <td>
                                    <p class=""mb-1"">314-483-4679</p>
                                    <p class=""mb-0"">DavidGaul@teleworm.us</p>
                                </td>

                                <td>
                                    1207 Cottrill Lane
                                    Stlouis, MO 63101
                                </td>
                                <td><span class=""badge bg-success font-size-12""><i ");
            WriteLiteral(@"class=""mdi mdi-star me-1""></i> 4.2</span></td>
                                <td>$6,180</td>
                                <td>02 Oct, 2019</td>
                                <td>
                                    <div class=""dropdown"">
                                        <a href=""#"" class=""dropdown-toggle card-drop"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                            <i class=""mdi mdi-dots-horizontal font-size-18""></i>
                                        </a>
                                        <ul class=""dropdown-menu dropdown-menu-end"">
                                            <li><a href=""#"" class=""dropdown-item""><i class=""mdi mdi-pencil font-size-16 text-success me-1""></i> Edit</a></li>
                                            <li><a href=""#"" class=""dropdown-item""><i class=""mdi mdi-trash-can font-size-16 text-danger me-1""></i> Delete</a></li>
                                        </ul>
                                    </d");
            WriteLiteral(@"iv>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <div class=""form-check font-size-16"">
                                        <input class=""form-check-input"" type=""checkbox"" id=""customerlistcheck08"">
                                        <label class=""form-check-label"" for=""customerlistcheck08""></label>
                                    </div>
                                </td>
                                <td>John McCray</td>
                                <td>
                                    <p class=""mb-1"">253-661-7551</p>
                                    <p class=""mb-0"">JohnMcCray@armyspy.com</p>
                                </td>

                                <td>
                                    3309 Horizon Circle
                                    Tacoma, WA 98423
                                </td>
                     ");
            WriteLiteral(@"           <td><span class=""badge bg-success font-size-12""><i class=""mdi mdi-star me-1""></i> 4.1</span></td>
                                <td>$5,2870</td>
                                <td>02 Oct, 2019</td>
                                <td>
                                    <div class=""dropdown"">
                                        <a href=""#"" class=""dropdown-toggle card-drop"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                            <i class=""mdi mdi-dots-horizontal font-size-18""></i>
                                        </a>
                                        <ul class=""dropdown-menu dropdown-menu-end"">
                                            <li><a href=""#"" class=""dropdown-item""><i class=""mdi mdi-pencil font-size-16 text-success me-1""></i> Edit</a></li>
                                            <li><a href=""#"" class=""dropdown-item""><i class=""mdi mdi-trash-can font-size-16 text-danger me-1""></i> Delete</a></li>
                       ");
            WriteLiteral(@"                 </ul>
                                    </div>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <ul class=""pagination pagination-rounded justify-content-end mb-2"">
                    <li class=""page-item disabled"">
                        <a class=""page-link"" href=""javascript: void(0);"" aria-label=""Previous"">
                            <i class=""mdi mdi-chevron-left""></i>
                        </a>
                    </li>
                    <li class=""page-item active""><a class=""page-link"" href=""javascript: void(0);"">1</a></li>
                    <li class=""page-item""><a class=""page-link"" href=""javascript: void(0);"">2</a></li>
                    <li class=""page-item""><a class=""page-link"" href=""javascript: void(0);"">3</a></li>
                    <li class=""page-item""><a class=""page-link"" href=""javascript: void(0);"">4</a></li>
                 ");
            WriteLiteral(@"   <li class=""page-item""><a class=""page-link"" href=""javascript: void(0);"">5</a></li>
                    <li class=""page-item"">
                        <a class=""page-link"" href=""javascript: void(0);"" aria-label=""Next"">
                            <i class=""mdi mdi-chevron-right""></i>
                        </a>
                    </li>
                </ul>
            </div>
        </div>
    </div>
</div>
<!-- end row -->
<!-- JAVASCRIPT -->
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bde70e165386f9c3ee5a40247044b2e5c5943ef26523", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bde70e165386f9c3ee5a40247044b2e5c5943ef27563", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bde70e165386f9c3ee5a40247044b2e5c5943ef28603", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bde70e165386f9c3ee5a40247044b2e5c5943ef29643", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bde70e165386f9c3ee5a40247044b2e5c5943ef30683", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n<!-- App js -->\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bde70e165386f9c3ee5a40247044b2e5c5943ef31750", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OwlProjectA.Pages.EcommerceCustomersModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OwlProjectA.Pages.EcommerceCustomersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OwlProjectA.Pages.EcommerceCustomersModel>)PageContext?.ViewData;
        public OwlProjectA.Pages.EcommerceCustomersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
