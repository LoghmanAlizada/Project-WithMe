#pragma checksum "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b201288227dd51b6e525580a6574a6be09799023"
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
#line 2 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\_ViewImports.cshtml"
using WithMe.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\_ViewImports.cshtml"
using WithMe.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b201288227dd51b6e525580a6574a6be09799023", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"811aa82eecfec33c8e45c145f09fc29b332d960f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <section style=\"height: 109.7vh;\" class=\"forhero\">\r\n        <div class=\"herotitle\">\r\n            <h1 data-aos=\"fade-down\" data-aos-duration=\"1500\">");
#nullable restore
#line 9 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                                                         Write(Model.pageintro.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <h6 data-aos=\"fade-up\" data-aos-duration=\"1500\">");
#nullable restore
#line 10 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                                                       Write(Model.pageintro.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
        </div> 
        <div class=""scrolltitle"">
            <span>Scroll Down</span>
        </div>
        <span class=""mouse"">
            <span class=""mouse-wheel""></span>
        </span>
    </section>
    <section class=""forourstory"">
        <div class=""title"">
            <h4 data-aos=""fade-right"" data-aos-duration=""1000"">");
#nullable restore
#line 21 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                                                          Write(Model.ourstory.SpanText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <h1 data-aos=\"fade-right\" data-aos-duration=\"1000\">");
#nullable restore
#line 22 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                                                          Write(Model.ourstory.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        </div>\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-6\" data-aos=\"fade-right\" data-aos-duration=\"1000\">\r\n                    <p>\r\n                        ");
#nullable restore
#line 28 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                   Write(Model.ourstory.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p> 
                </div>
                <div class=""col-6"">
                    <div class=""rightimage"" data-aos=""fade-left"" data-aos-duration=""1000"">
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section class=""forsentence"">
        <div class=""container"">
            <h1 data-aos=""fade-right"" data-aos-duration=""1000"">");
#nullable restore
#line 40 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                                                          Write(Model.forsentence.TopSentence);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <h1 data-aos=\"fade-left\" data-aos-duration=\"1000\">");
#nullable restore
#line 41 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                                                         Write(Model.forsentence.BottomSentence);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        </div>\r\n    </section>\r\n    <section class=\"forspecail\">\r\n        <div class=\"ourspecials\">\r\n            <div class=\"title\">\r\n                <div class=\"title\">\r\n                    <h4 data-aos=\"fade-right\" data-aos-duration=\"1000\">");
#nullable restore
#line 48 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                                                                        foreach (var item in Model.forspeacial.Take(1))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                   Write(item.SpanText);

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                                      
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <h1 data-aos=\"fade-right\" data-aos-duration=\"1000\" data-aos-delay=\"700\">");
#nullable restore
#line 52 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                                                                                             foreach (var item in Model.forspeacial.Take(1))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                                   
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                </div>\r\n            </div>\r\n            <div class=\"specialcards\">\r\n                <div class=\"firstcard\" data-aos=\"fade-up\" data-aos-duration=\"1000\" data-aos-delay=\"500\">\r\n");
#nullable restore
#line 60 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                     foreach (var item in Model.forspeacial.Take(1))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
               Write(Html.Raw(item.IconURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h2>");
#nullable restore
#line 63 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                       Write(item.CardTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <p>\r\n                            ");
#nullable restore
#line 65 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                       Write(item.CardDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n");
#nullable restore
#line 67 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"secondcard\" data-aos=\"fade-up\" data-aos-duration=\"1000\" data-aos-delay=\"700\">\r\n");
#nullable restore
#line 70 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                     foreach (var item in Model.forspeacial.Skip(1).Take(1))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
               Write(Html.Raw(item.IconURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h2>");
#nullable restore
#line 73 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                       Write(item.CardTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <p>\r\n                            ");
#nullable restore
#line 75 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                       Write(item.CardDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n");
#nullable restore
#line 77 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"thirdcard\" data-aos=\"fade-up\" data-aos-duration=\"1000\" data-aos-delay=\"900\">\r\n");
#nullable restore
#line 80 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                     foreach (var item in Model.forspeacial.Skip(2).Take(1))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
               Write(Html.Raw(item.IconURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h2>");
#nullable restore
#line 83 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                       Write(item.CardTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <p>\r\n                            ");
#nullable restore
#line 85 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                       Write(item.CardDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n");
#nullable restore
#line 87 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <section class=\"forbetweensection\">\r\n        <div class=\"container\" style=\"padding-left: 5%; padding-right: 5%;\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 95 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                 foreach (var item in Model.forbetweensection)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-3\">\r\n                    <div class=\"counter\" data-aos=\"fade-up\" data-aos-duration=\"1000\">\r\n                        <h1>");
#nullable restore
#line 99 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                       Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("+</h1>\r\n                        <span>");
#nullable restore
#line 100 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                         Write(item.SpanText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 103 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </section>
    <section class=""homepagemenu"">
        <div class=""title"">
            <h4 data-aos=""fade-right"" data-aos-duration=""1000"">Service</h4>
            <h1 data-aos=""fade-right"" data-aos-duration=""1000"" data-aos-delay=""700"">Our Menu</h1>
        </div>
        <div class=""container"">
            <div class=""row"">
");
#nullable restore
#line 114 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                 foreach (var item in Model.homepagemenu)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-4\" id=\"card\">\r\n                    <div class=\"face front\"");
            BeginWriteAttribute("style", "  \r\n                    style=\"", 4741, "\"", 4972, 15);
            WriteAttributeValue("", 4772, "background-image:", 4772, 17, true);
            WriteAttributeValue("\r\n                    ", 4789, "linear-gradient(", 4811, 38, true);
            WriteAttributeValue(" ", 4827, "rgba(0,", 4828, 8, true);
            WriteAttributeValue(" ", 4835, "0,", 4836, 3, true);
            WriteAttributeValue(" ", 4838, "0,", 4839, 3, true);
            WriteAttributeValue(" ", 4841, "0.7),", 4842, 6, true);
            WriteAttributeValue(" ", 4847, "rgba(0,", 4848, 8, true);
            WriteAttributeValue(" ", 4855, "0,", 4856, 3, true);
            WriteAttributeValue(" ", 4858, "0,", 4859, 3, true);
            WriteAttributeValue(" ", 4861, "0.7)),", 4862, 7, true);
            WriteAttributeValue("\r\n                    ", 4868, "url(./assets/images/", 4890, 42, true);
#nullable restore
#line 120 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
WriteAttributeValue("", 4910, item.ImageURL, 4910, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4924, ");", 4924, 2, true);
            WriteAttributeValue(" \r\n                    ", 4926, "background-size:", 4949, 39, true);
            WriteAttributeValue(" ", 4965, "cover;", 4966, 7, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <h2>");
#nullable restore
#line 122 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    </div>\r\n                    <div class=\"face back\">\r\n                        <a href=\"./menu.html\">");
#nullable restore
#line 125 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                                         Write(item.ButtonText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 128 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </section>\r\n    <section class=\"forbetweensection2\">\r\n        <div class=\"container\">\r\n            <h1 data-aos=\"fade-right\" data-aos-duration=\"1000\">");
#nullable restore
#line 134 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                                                          Write(Model.forsecondbetweensection.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <h5 data-aos=\"fade-left\" data-aos-duration=\"1000\">");
#nullable restore
#line 135 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                                                         Write(Model.forsecondbetweensection.WeekDaysTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <h5 data-aos=\"fade-right\" data-aos-duration=\"1000\">");
#nullable restore
#line 136 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                                                          Write(Model.forsecondbetweensection.WeekEndTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        </div>\r\n    </section>\r\n    <section class=\"forpartners\">\r\n        <div class=\"title\">\r\n            <h4 data-aos=\"fade-right\" data-aos-duration=\"1000\">");
#nullable restore
#line 141 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                                                          Write(Model.forpartner.SpanText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <h1 data-aos=\"fade-right\" data-aos-duration=\"1000\" data-aos-delay=\"700\">");
#nullable restore
#line 142 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                                                                               Write(Model.forpartner.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        </div>\r\n        <div class=\"partners\">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-3\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 6182, "\"", 6242, 2);
            WriteAttributeValue("", 6188, "./assets/images/", 6188, 16, true);
#nullable restore
#line 148 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
WriteAttributeValue("", 6204, Model.forpartner.FirstPartnerImageURl, 6204, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 6243, "\"", 6249, 0);
            EndWriteAttribute();
            WriteLiteral(" data-aos=\"fade-right\" data-aos-duration=\"1000\" data-aos-delay=\"1000\">\r\n                    </div>\r\n                    <div class=\"col-3\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 6419, "\"", 6480, 2);
            WriteAttributeValue("", 6425, "./assets/images/", 6425, 16, true);
#nullable restore
#line 151 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
WriteAttributeValue("", 6441, Model.forpartner.SecondPartnerImageURL, 6441, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 6481, "\"", 6487, 0);
            EndWriteAttribute();
            WriteLiteral(" data-aos=\"fade-right\" data-aos-duration=\"1000\" data-aos-delay=\"500\">\r\n                    </div>\r\n                    <div class=\"col-3\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 6656, "\"", 6716, 2);
            WriteAttributeValue("", 6662, "./assets/images/", 6662, 16, true);
#nullable restore
#line 154 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
WriteAttributeValue("", 6678, Model.forpartner.ThirdPartnerImageURL, 6678, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 6717, "\"", 6723, 0);
            EndWriteAttribute();
            WriteLiteral(" data-aos=\"fade-left\" data-aos-duration=\"1000\" data-aos-delay=\"500\">\r\n                    </div>\r\n                    <div class=\"col-3\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 6891, "\"", 6952, 2);
            WriteAttributeValue("", 6897, "./assets/images/", 6897, 16, true);
#nullable restore
#line 157 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
WriteAttributeValue("", 6913, Model.forpartner.FourthPartnerImageURL, 6913, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 6953, "\"", 6959, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-aos=""fade-left"" data-aos-duration=""1000"" data-aos-delay=""1000"">
                    </div>
                </div>
            </div>
        </div>
    </section>
    <section class=""forbetweensection3"">
        <div class=""container"">
            <h1 data-aos=""fade-right"" data-aos-duration=""1000"">");
#nullable restore
#line 165 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                                                          Write(Model.forthirdbetweensection.TopSentence);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <h1 data-aos=\"fade-left\" data-aos-duration=\"1000\">");
#nullable restore
#line 166 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Home\Index.cshtml"
                                                         Write(Model.forthirdbetweensection.BottomSentence);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        </div>\r\n    </section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591