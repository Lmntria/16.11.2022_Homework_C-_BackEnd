#pragma checksum "/Users/seymur/Desktop/BackEnd/16.11.2022_Homework/Second_Task/Views/Services/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "501f7e6a567d918ad8886af42ae4fccb691913ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Services_Index), @"mvc.1.0.view", @"/Views/Services/Index.cshtml")]
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
#line 1 "/Users/seymur/Desktop/BackEnd/16.11.2022_Homework/Second_Task/Views/Services/Index.cshtml"
using Second_Task.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"501f7e6a567d918ad8886af42ae4fccb691913ae", @"/Views/Services/Index.cshtml")]
    #nullable restore
    public class Views_Services_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Service>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"    

    <main id=""main"">

        <!-- ======= Breadcrumbs ======= -->
        <section id=""breadcrumbs"" class=""breadcrumbs"">
            <div class=""container"">

                <ol>
                    <li><a href=""../Home/Index"">Home</a></li>
                    <li>Services</li>
                </ol>
                <h2>Services</h2>

            </div>
        </section><!-- End Breadcrumbs -->
        <!-- ======= Services Section ======= -->
        <section id=""services"" class=""services"">
            <div class=""container"">

                <div class=""row"">
");
#nullable restore
#line 26 "/Users/seymur/Desktop/BackEnd/16.11.2022_Homework/Second_Task/Views/Services/Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""col-lg-4 col-md-6 d-flex align-items-stretch"">
                            <div class=""icon-box w-100"">
                                <div class=""icon""><i class=""bx bxl-dribbble""></i></div>
                                <h4><a");
            BeginWriteAttribute("href", " href=\"", 992, "\"", 999, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "/Users/seymur/Desktop/BackEnd/16.11.2022_Homework/Second_Task/Views/Services/Index.cshtml"
                                          Write(item.heading);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                <p>");
#nullable restore
#line 32 "/Users/seymur/Desktop/BackEnd/16.11.2022_Homework/Second_Task/Views/Services/Index.cshtml"
                              Write(item.info);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 35 "/Users/seymur/Desktop/BackEnd/16.11.2022_Homework/Second_Task/Views/Services/Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>

            </div>
        </section><!-- End Services Section -->
        <!-- ======= Our Skills Section ======= -->
        <section id=""skills"" class=""skills"">
            <div class=""container"">

                <div class=""section-title"">
                    <h2>Our Skills</h2>
                    <p>Magnam dolores commodi suscipit. Necessitatibus eius consequatur ex aliquid fuga eum quidem. Sit sint consectetur velit. Quisquam quos quisquam cupiditate. Et nemo qui impedit suscipit alias ea. Quia fugiat sit in iste officiis commodi quidem hic quas.</p>
                </div>

                <div class=""row"">
                    <div class=""col-lg-6"">
                        <img src=""assets/img/skills-img.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 1950, "\"", 1956, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""col-lg-6 pt-4 pt-lg-0 content"">
                        <h3>Voluptatem dignissimos provident quasi corporis voluptates</h3>
                        <p class=""fst-italic"">
                            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt direna past reda
                        </p>

                        <div class=""skills-content"">

                            <div class=""progress"">
                                <span class=""skill"">HTML <i class=""val"">100%</i></span>
                                <div class=""progress-bar-wrap"">
                                    <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                </div>
                            </div>

                            <div class=""progress"">
                                <span class=""skill"">CSS <i class=""val"">90%</i></");
            WriteLiteral(@"span>
                                <div class=""progress-bar-wrap"">
                                    <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""90"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                </div>
                            </div>

                            <div class=""progress"">
                                <span class=""skill"">JavaScript <i class=""val"">75%</i></span>
                                <div class=""progress-bar-wrap"">
                                    <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                </div>
                            </div>

                            <div class=""progress"">
                                <span class=""skill"">Photoshop <i class=""val"">55%</i></span>
                                <div class=""progress-bar-wrap"">
                                    <div class=""progress-bar"" role=""progressbar"" ar");
            WriteLiteral(@"ia-valuenow=""55"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                                </div>
                            </div>

                        </div>

                    </div>
                </div>

            </div>
        </section><!-- End Our Skills Section -->

    </main><!-- End #main -->
    <!-- ======= Footer ======= -->
    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Service>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
