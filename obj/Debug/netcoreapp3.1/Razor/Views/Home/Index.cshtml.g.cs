#pragma checksum "C:\Users\288\Desktop\InstaDev\InstaDev_G1_DT\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40cba8da758d71019fff08997ff8853f8417ad17"
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
#line 1 "C:\Users\288\Desktop\InstaDev\InstaDev_G1_DT\Views\_ViewImports.cshtml"
using InstaDev_G1_DT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\288\Desktop\InstaDev\InstaDev_G1_DT\Views\_ViewImports.cshtml"
using InstaDev_G1_DT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40cba8da758d71019fff08997ff8853f8417ad17", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f11fc6001ebbcc71acb7d851385a27546fd9d68b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\288\Desktop\InstaDev\InstaDev_G1_DT\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html lang=\"pt-br\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40cba8da758d71019fff08997ff8853f8417ad173987", async() => {
                WriteLiteral("\r\n\r\n\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40cba8da758d71019fff08997ff8853f8417ad174965", async() => {
                WriteLiteral(@"
    <header class=""menu"">
        <section class=""nav"">
            <div class=""logo"">
                <img src=""imagens/Instadev (1).svg"" alt=""Logo do Instadev"" >
            </div>

            <div class=""search"">
                <i class=""fas fa-search""></i>
                <p>Pesquisar</p>
            </div>

            <div class=""menu-btn"">
                    <i class=""fas fa-home""></i>
                    <i class=""far fa-paper-plane""></i>
                    <i class=""far fa-compass""></i>
                    <i class=""far fa-heart""></i>
                <div class=""perfil"">
                    <img src=""imagens/thank-you 1.png"" alt=""Foto de perfil"">
                </div>
            </div>
        </section>
    
    </div>
    <section>
        <div class=""storiesperfil"">
            <div class=""stories"">
                <div class=""stories1"">
                    <img src=""imagens/vin-diesel 1.svg"" alt=""stories 2"">
                    <p>
                        vin_");
                WriteLiteral(@"diesel
                    </p>
                </div>
                <div class=""stories1"">
                    <img src=""imagens/gabigordo 1.svg"" alt=""stories 2"">
                    <p>
                        gabigordo
                    </p>
                </div>
                <div class=""stories1"">
                    <img src=""imagens/will-baiano 1.svg"" alt=""stories 3"">
                    <p>
                        will_baiano
                    </p>
                </div>
                <div class=""stories1"">
                    <img src=""imagens/tony_stark 1.svg"" alt=""stories 4"">
                    <p>
                        adriano_stark
                    </p>
                </div>
                <div class=""stories1"">
                    <img src=""imagens/pele 1.svg"" alt=""stories 5"">
                    <p>
                        King_pelé
                    </p>
                </div>
                <div class=""stories1"">
                    <img src=""");
                WriteLiteral(@"imagens/samuel-rosa-bebê 1.svg"" alt=""stories 6"">
                    <p>
                        samuel_rosa
                    </p>
                </div>
                <div class=""stories1"">
                    <img src=""imagens/chaves_metal 1.svg"" alt=""stories 7"">
                    <p>
                        chaves_metal
                    </p>
                </div>
            </div>
            <div class=""perfil2"">
                <div class=""photo"">
                    <img src=""imagens/thank-you 2.svg"" alt=""Foto de perfil"">
                </div>
                <div class=""texto-perfil"">
                    <h2>
                        Yes_baby
                    </h2>
                    <p>
                        Marcos Jeeves
                    </p>
                </div>
            </div>
        </div>
    </section>
    <section class=""Posts"">
        <div class=""postar"">
            <div class=""foto-postar"">
                <img src=""imagens/thank-you ");
                WriteLiteral("3.svg\" alt=\"Foto de perfil\">\r\n                <h1>\r\n                    Postar\r\n                </h1>\r\n            </div>\r\n            <div class=\"botoes-postar\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40cba8da758d71019fff08997ff8853f8417ad178689", async() => {
                    WriteLiteral("\r\n                    <div class=\"desc\">\r\n                        <input type=\"text\" name=\"Subtitle\"");
                    BeginWriteAttribute("id", " id=\"", 3504, "\"", 3509, 0);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                    </div>\r\n\r\n                    <input type=\"file\" value=\"Escolha a imagem\" nome=\"Image\" class=\"b-img\">\r\n                    <input type=\"submit\" name=\"Image\" class=\"b-img2\">Postar</input>\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 106 "C:\Users\288\Desktop\InstaDev\InstaDev_G1_DT\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3379, Url.Action("Publicar"), 3379, 23, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </section>\r\n");
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
            WriteLiteral("\r\n");
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
