#pragma checksum "C:\Users\celikkaleli\Desktop\Kod Antreman\izmirgas\IzmirGaz\IzmirGas.MVC\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90189c20dd868eb02d2a472b9ae87cb4d9a607aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90189c20dd868eb02d2a472b9ae87cb4d9a607aa", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/main.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"tr\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90189c20dd868eb02d2a472b9ae87cb4d9a607aa3783", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>");
#nullable restore
#line 7 "C:\Users\celikkaleli\Desktop\Kod Antreman\izmirgas\IzmirGaz\IzmirGas.MVC\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "90189c20dd868eb02d2a472b9ae87cb4d9a607aa4427", async() => {
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
                WriteLiteral(@"
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-giJF6kkoqNQ00vy+HMDP7azOuL0xtbfIcaT9wjKHr8RbDVddVHyTfAAsrekwKmP1"" crossorigin=""anonymous"">
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-ygbV9kiqUc6oa4msXn9868pTtWMgiQaeYH7/t7LECLbyPA2x65Kgf80OJFdroafW"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/js/bootstrap.min.js"" integrity=""sha384-pQQkAEnwaBkjpqZ8RU1fF1AKtTcHJwFl3pblpTlHXybJjHpMYo79HY3hIi4NKxyj"" crossorigin=""anonymous""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90189c20dd868eb02d2a472b9ae87cb4d9a607aa6987", async() => {
                WriteLiteral("\r\n    <div>\r\n        ");
#nullable restore
#line 16 "C:\Users\celikkaleli\Desktop\Kod Antreman\izmirgas\IzmirGaz\IzmirGas.MVC\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    </div>
    <!--
    <div class=""center d-flex p-2"">
        <div class=""text-center mt-4 top50"">
            <img src=""img/logo.png"" class=""rounded"" alt=""Logo"">
        </div>
        <div class=""clearfix""> </div>
        <div class=""container px-4 padding-xs Margin50 whiteArea  companyNameDiv"">
            <div class=""CompanyTitle"">Damoğlu Sıhhi tesisat</div>
        </div>
        <div class=""container px-4 padding-xs Margin10 greenArea  companyVisaDuractionTrue"">
            <div class=""Authorise"">YETKİLİ FİRMA</div>
        </div>
        <div class=""container px-4 padding-xs Margin10   companyVisaDuractionFalse"">
            <div class=""Authorise"">YETKİLİ DEĞİL</div>
        </div>
        <div class=""container px-4 top50"">
            <div class=""row gx-5"">
                <div class=""col beyaz"">
                    <div class=""p-3 beyaz"">
                        <div class=""point "">98,78</div>
                        <div class=""commant1 "">Firma</div>
                       ");
                WriteLiteral(@" <div class=""commant1 "">Performans Puanı</div>
                    </div>
                </div>
                <div class=""col"">
                    <div class=""p-3 beyaz"">
                        <div class=""point "">98,78</div>
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
                <div class=""divComment"">Anafartalar Mah. cebeci Sok. No:11 Kat:4</div>
            </div>
            <div class=""container px-4 conpanyInformation whiteArea"">
                <div class=""divTitle"">İLÇE</div>
               ");
                WriteLiteral(@" <div class=""divComment"">Ödemiş</div>
            </div>
            <div class=""container px-4 conpanyInformation whiteArea"">
                <div class=""fl"">
                    <div class=""divTitle MinWidth"">TELEFON</div>
                    <div class=""divComment MinWidth"">506 384 11 29</div>
                </div>
                <div class=""fr buttonStyle"">Ara</div>
            </div>
            <div class=""container px-4 conpanyInformation whiteArea"">
                <div class=""fl"">
                    <div class=""divTitle MinWidth"">E-POSTA</div>
                    <div class=""divComment MinWidth"">mevrend@gmail.com</div>
                </div>
                <div class=""fr buttonStyleEposta"">E-posta Gönder</div>
            </div>
            <div class=""container px-4 conpanyInformation whiteArea"">
                <div class=""divTitle"">SAHİBİ /ORTAGI</div>
                <div class=""divComment"">Murat Evren DAMOĞLU</div>
            </div>
            <div class=""container px-4");
                WriteLiteral(@" conpanyInformation whiteArea"">
                <div class=""fl"">
                    <div class=""divTitle MinWidth"">SAHİBİ /ORTAGI TELEFON</div>
                    <div class=""divComment MinWidth""></div>
                </div>
                <div class=""fr buttonStyle"">Ara</div>
            </div>
            <div class=""container px-4 conpanyInformation whiteArea"">
                <div class=""divTitle"">VİZE BİTİŞ TARİHİ</div>
                <div class=""divComment"">05.11.2021</div>
            </div>
        </div>
        <div class=""container px-4"">
            <div class=""CompanyInfo"">PERSONEL BİLGİLERİ</div>
        </div>
        <div class=""emptyDiv""></div>


        <div class=""container px-4"">
            <div class=""pictureBox fl"">
                <div class=""card"">
                    <img class=""picture"" src=""https://icons.iconarchive.com/icons/paomedia/small-n-flat/48/profile-icon.png"" alt=""Card image cap"">
                    <div class=""pictureName"">Murat Evren DAMOĞLU</");
                WriteLiteral(@"div>
                    <div class=""pictureJob"">Mühendis</div>
                    <div class=""picturePhone"">5063 384 1129</div>
                </div>
            </div>
            <div class=""pictureBox fl"">
                <div class=""card"">
                    <img class=""picture"" src=""https://icons.iconarchive.com/icons/paomedia/small-n-flat/48/profile-icon.png"" alt=""Card image cap"">
                    <div class=""pictureName"">Murat Evren DAMOĞLU</div>
                    <div class=""pictureJob"">Usta</div>
                    <div class=""picturePhone""></div>
                </div>
            </div>
            <div class=""pictureBox fl"">
                <div class=""card"">
                    <img class=""picture"" src=""https://icons.iconarchive.com/icons/paomedia/small-n-flat/48/profile-icon.png"" alt=""Card image cap"">
                    <div class=""pictureName"">Murat Evren DAMOĞLU</div>
                    <div class=""pictureJob"">Usta</div>
                    <div class=""picturePhon");
                WriteLiteral(@"e""></div>
                </div>
            </div>
            <div class=""pictureBox fl"">
                <div class=""card"">
                    <img class=""picture"" src=""https://icons.iconarchive.com/icons/paomedia/small-n-flat/48/profile-icon.png"" alt=""Card image cap"">
                    <div class=""pictureName"">Murat Evren DAMOĞLU</div>
                    <div class=""pictureJob""></div>
                    <div class=""picturePhone"">5063 384 1129</div>
                </div>
            </div>

        </div>
    </div>-->
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n</html>");
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
