#pragma checksum "C:\Users\celikkaleli\Desktop\Kod Antreman\izmirgas\IzmirGaz\IzmirGas.MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9aea99540b4201e78745bef8e85fc9ef21387797"
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
#line 1 "C:\Users\celikkaleli\Desktop\Kod Antreman\izmirgas\IzmirGaz\IzmirGas.MVC\Views\Home\Index.cshtml"
using IzmirGaz.Shared.Utilities.Results.ComplexTypes;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9aea99540b4201e78745bef8e85fc9ef21387797", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IzmirGaz.Entities.Dtos.CompanyListDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\celikkaleli\Desktop\Kod Antreman\izmirgas\IzmirGaz\IzmirGas.MVC\Views\Home\Index.cshtml"
  

    Layout = "_Layout";
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\celikkaleli\Desktop\Kod Antreman\izmirgas\IzmirGaz\IzmirGas.MVC\Views\Home\Index.cshtml"
 if (Model.ResultStatus == ResultStatus.Success)
{
    foreach (var company in Model.Companies)
    {


   

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""center d-flex p-2"">
        <div class=""text-center mt-4 top50"">
            <img src=""img/logo.png"" class=""rounded"" alt=""Logo"">
        </div>
        <div class=""clearfix""> </div>
        <div class=""container px-4 padding-xs Margin50 whiteArea  companyNameDiv"">
            <div class=""CompanyTitle""> ");
#nullable restore
#line 21 "C:\Users\celikkaleli\Desktop\Kod Antreman\izmirgas\IzmirGaz\IzmirGas.MVC\Views\Home\Index.cshtml"
                                  Write(company.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </div>\r\n        \r\n");
#nullable restore
#line 24 "C:\Users\celikkaleli\Desktop\Kod Antreman\izmirgas\IzmirGaz\IzmirGas.MVC\Views\Home\Index.cshtml"
         if (company.VisaDuration > DateTime.Now)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"container px-4 padding-xs Margin10 greenArea  companyVisaDuractionTrue\">\r\n                <div class=\"Authorise\">YETKİLİ FİRMA</div>\r\n            </div>\r\n");
#nullable restore
#line 29 "C:\Users\celikkaleli\Desktop\Kod Antreman\izmirgas\IzmirGaz\IzmirGas.MVC\Views\Home\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"container px-4 padding-xs Margin10   companyVisaDuractionFalse\">\r\n                <div class=\"Authorise\">YETKİLİ DEĞİL</div>\r\n            </div>\r\n");
#nullable restore
#line 35 "C:\Users\celikkaleli\Desktop\Kod Antreman\izmirgas\IzmirGaz\IzmirGas.MVC\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <div class=\"container px-4 top50\">\r\n            <div class=\"row gx-5\">\r\n                <div class=\"col beyaz\">\r\n                    <div class=\"p-3 beyaz\">\r\n                        <div class=\"point \">");
#nullable restore
#line 42 "C:\Users\celikkaleli\Desktop\Kod Antreman\izmirgas\IzmirGaz\IzmirGas.MVC\Views\Home\Index.cshtml"
                                       Write(company.CompanyPerformanceReport);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        <div class=""commant1 "">Firma</div>
                        <div class=""commant1 "">Performans Puanı</div>
                    </div>
                </div>
                <div class=""col"">
                    <div class=""p-3 beyaz"">
                        <div class=""point "">");
#nullable restore
#line 49 "C:\Users\celikkaleli\Desktop\Kod Antreman\izmirgas\IzmirGaz\IzmirGas.MVC\Views\Home\Index.cshtml"
                                       Write(company.PercentageOfGasFired);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        <div class=""commant1 "">İlk Seferde</div>
                        <div class=""commant1 "">Gaz Açma Yüzdesi</div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""container px-4"">
            <div class=""CompanyInfo"">FİRMA BİLGİLERİ</div>
        </div>
        <div class=""emptyDiv""></div>
        <div class=""white-div container"">
            <div class=""container px-4 conpanyInformation whiteArea"">
                <div class=""divTitle"">ADRES:</div>
                <div class=""divComment"">");
#nullable restore
#line 63 "C:\Users\celikkaleli\Desktop\Kod Antreman\izmirgas\IzmirGaz\IzmirGas.MVC\Views\Home\Index.cshtml"
                                   Write(company.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n            <div class=\"container px-4 conpanyInformation whiteArea\">\r\n                <div class=\"divTitle\">İLÇE</div>\r\n                <div class=\"divComment\">");
#nullable restore
#line 67 "C:\Users\celikkaleli\Desktop\Kod Antreman\izmirgas\IzmirGaz\IzmirGas.MVC\Views\Home\Index.cshtml"
                                   Write(company.CompanyCountry);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n            <div class=\"container px-4 conpanyInformation whiteArea\">\r\n                <div class=\"fl\">\r\n                    <div class=\"divTitle MinWidth\">TELEFON</div>\r\n                    <div class=\"divComment MinWidth\">");
#nullable restore
#line 72 "C:\Users\celikkaleli\Desktop\Kod Antreman\izmirgas\IzmirGaz\IzmirGas.MVC\Views\Home\Index.cshtml"
                                                Write(company.CompanyPhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                </div>
                <div class=""fr buttonStyle"">Ara</div>
            </div>
            <div class=""container px-4 conpanyInformation whiteArea"">
                <div class=""fl"">
                    <div class=""divTitle MinWidth"">E-POSTA</div>
                    <div class=""divComment MinWidth"">");
#nullable restore
#line 79 "C:\Users\celikkaleli\Desktop\Kod Antreman\izmirgas\IzmirGaz\IzmirGas.MVC\Views\Home\Index.cshtml"
                                                Write(company.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                </div>
                <div class=""fr buttonStyleEposta"">E-posta Gönder</div>
            </div>
            <div class=""container px-4 conpanyInformation whiteArea"">
                <div class=""divTitle"">SAHİBİ /ORTAGI</div>
                <div class=""divComment"">");
#nullable restore
#line 85 "C:\Users\celikkaleli\Desktop\Kod Antreman\izmirgas\IzmirGaz\IzmirGas.MVC\Views\Home\Index.cshtml"
                                   Write(company.CompanyManagerFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 85 "C:\Users\celikkaleli\Desktop\Kod Antreman\izmirgas\IzmirGaz\IzmirGas.MVC\Views\Home\Index.cshtml"
                                                                    Write(company.CompanyManagerLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
            </div>
            <div class=""container px-4 conpanyInformation whiteArea"">
                <div class=""fl"">
                    <div class=""divTitle MinWidth"">SAHİBİ /ORTAGI TELEFON</div>
                    <div class=""divComment MinWidth"">");
#nullable restore
#line 90 "C:\Users\celikkaleli\Desktop\Kod Antreman\izmirgas\IzmirGaz\IzmirGas.MVC\Views\Home\Index.cshtml"
                                                Write(company.CompanyManagerPhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                </div>
                <div class=""fr buttonStyle"">Ara</div>
            </div>
            <div class=""container px-4 conpanyInformation whiteArea"">
                <div class=""divTitle"">VİZE BİTİŞ TARİHİ</div>
                <div class=""divComment"">");
#nullable restore
#line 96 "C:\Users\celikkaleli\Desktop\Kod Antreman\izmirgas\IzmirGaz\IzmirGas.MVC\Views\Home\Index.cshtml"
                                   Write(company.VisaDuration.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n\r\n            <div class=\"container px-4 conpanyInformation whiteArea\">\r\n                <div class=\"divTitle\">SERTİFİKA BİTİŞ TARİHİ</div>\r\n                <div class=\"divComment\">");
#nullable restore
#line 101 "C:\Users\celikkaleli\Desktop\Kod Antreman\izmirgas\IzmirGaz\IzmirGas.MVC\Views\Home\Index.cshtml"
                                   Write(company.CompanyCertificateEndDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n        <div class=\"container px-4\">\r\n            <div class=\"CompanyInfo\">PERSONEL BİLGİLERİ</div>\r\n        </div>\r\n        <div class=\"emptyDiv\"></div>\r\n  \r\n\r\n        <div class=\"container px-4\">\r\n");
#nullable restore
#line 111 "C:\Users\celikkaleli\Desktop\Kod Antreman\izmirgas\IzmirGaz\IzmirGas.MVC\Views\Home\Index.cshtml"
             foreach (var cp in company.CompanyPersonnels)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"pictureBox fl\">\r\n                    <div class=\"card\">\r\n                        <img class=\"picture\"");
            BeginWriteAttribute("src", " src=\"", 4819, "\"", 4840, 1);
#nullable restore
#line 115 "C:\Users\celikkaleli\Desktop\Kod Antreman\izmirgas\IzmirGaz\IzmirGas.MVC\Views\Home\Index.cshtml"
WriteAttributeValue("", 4825, cp.PersonelImg, 4825, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n                        <div class=\"pictureName\">");
#nullable restore
#line 116 "C:\Users\celikkaleli\Desktop\Kod Antreman\izmirgas\IzmirGaz\IzmirGas.MVC\Views\Home\Index.cshtml"
                                            Write(cp.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 116 "C:\Users\celikkaleli\Desktop\Kod Antreman\izmirgas\IzmirGaz\IzmirGas.MVC\Views\Home\Index.cshtml"
                                                          Write(cp.LastName.ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"pictureJob\">");
#nullable restore
#line 117 "C:\Users\celikkaleli\Desktop\Kod Antreman\izmirgas\IzmirGaz\IzmirGas.MVC\Views\Home\Index.cshtml"
                                           Write(cp.PersonelType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"picturePhone\">");
#nullable restore
#line 118 "C:\Users\celikkaleli\Desktop\Kod Antreman\izmirgas\IzmirGaz\IzmirGas.MVC\Views\Home\Index.cshtml"
                                             Write(cp.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                </div> \r\n");
#nullable restore
#line 121 "C:\Users\celikkaleli\Desktop\Kod Antreman\izmirgas\IzmirGaz\IzmirGas.MVC\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 126 "C:\Users\celikkaleli\Desktop\Kod Antreman\izmirgas\IzmirGaz\IzmirGas.MVC\Views\Home\Index.cshtml"

}
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IzmirGaz.Entities.Dtos.CompanyListDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
