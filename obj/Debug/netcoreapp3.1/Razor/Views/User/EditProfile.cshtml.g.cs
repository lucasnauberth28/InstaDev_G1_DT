#pragma checksum "C:\Users\Saga\Desktop\InstaDev Project\InstaDev_G1_DT\Views\User\EditProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbf783be99adb6b01dc005e12357d7761de70aaa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_EditProfile), @"mvc.1.0.view", @"/Views/User/EditProfile.cshtml")]
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
#line 1 "C:\Users\Saga\Desktop\InstaDev Project\InstaDev_G1_DT\Views\_ViewImports.cshtml"
using InstaDev_G1_DT;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbf783be99adb6b01dc005e12357d7761de70aaa", @"/Views/User/EditProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7afe5f71bdba8d0fbc4de4bd5381b2a5fc9e388", @"/Views/_ViewImports.cshtml")]
    public class Views_User_EditProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Saga\Desktop\InstaDev Project\InstaDev_G1_DT\Views\User\EditProfile.cshtml"
  
    ViewData["Title"] = "EditProfile";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbf783be99adb6b01dc005e12357d7761de70aaa4397", async() => {
                WriteLiteral(@"
        <meta charset=""UTF-8"">
        <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
        <title>Edição de Perfil</title>
        <link rel=""stylesheet"" href=""../css/EditProfile.css"">
        <script src=""https://kit.fontawesome.com/88f063c67b.js"" crossorigin=""anonymous""></script>
        <link href=""//maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css"" rel=""stylesheet"">

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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbf783be99adb6b01dc005e12357d7761de70aaa5815", async() => {
                WriteLiteral(@"
        <header class=""menu"">
            <section class=""nav"">
                <div class=""logo"">
                    <img src=""img/Instadev.svg"" alt=""Logo do Instadev"" >
                </div>

                <div class=""search""> 
                    <button class=""submit-lupa"" type=""submit"">
                        <i class=""fa fa-search""></i>
                    </button>
                    <input type=""text"" placeholder=""Pesquisar"" class=""search-input""/>
                   
                </div>

                <div class=""menu-btn"">
                        <i class=""fas fa-home""></i>
                        <i class=""far fa-paper-plane""></i>
                        <i class=""far fa-compass""></i>
                        <i class=""far fa-heart""></i>
                    <div class=""perfil"">
                        <img src=""img/thank-you 2.svg"" alt=""Foto de perfil"">
                    </div>
                </div>
            </section>
        </header>

        <main clas");
                WriteLiteral(@"s=""infos"">
            <section class=""container"">
                
                    <div class=""title"">
                        <p>Editar Perfil</p>
                    </div>

                    <div class=""opcoes"">
                        <div class=""perfilFoto"">
                            <img src=""img/thank-you 2.svg"" alt=""Foto de perfi"">
                            <div class=""textFoto"">
                                <p>yes_baby</p>
                                <label for=""files"" class=""btn-img"">Alterar foto de perfil</label>
                                <input id=""files"" style=""visibility:hidden;"" type=""file"">
                            </div>
                        </div>
                        <div class=""edicoes"">
                            <div class=""name"">
                                <h2>Nome</h2>
                                <div class=""text"">
                                    <input type=""text"" name=""Name"">
                                    <p>Aj");
                WriteLiteral(@"ude as pessoas a descobrir sua conta usando o nome pelo qual<br> 
                                        você é conhecido: seu nome completo, apelido ou nome comercial.</p>

                                    <h3>Você pode alterar o seu nome apenas duas vezes a cada 14 dias.</h3>
                                </div>
                            </div>
                            <div class=""nick"">
                                <h2>Nome de usuário</h2>
                                <div class=""text"">
                                    <input type=""text"" name=""Nick"">
                                    <p>Na maioria dos casos, você poderá alterar seu nome de usuário<br> 
                                        novamente para nascimento_tr por mais 14 dias.</p>
                                </div>
                            </div>
                            <div class=""email"">
                                <h2>Email</h2>
                                <div class=""text"">
          ");
                WriteLiteral("                          <input type=\"text\" name=\"Email\">\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"botao\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbf783be99adb6b01dc005e12357d7761de70aaa9594", async() => {
                    WriteLiteral("Enviar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            <a asp=""#"" class=""btn"">Sair</a>
                            <a href=""#"" class=""desative"">Desativar minha conta definitivamente</a>
                        </div>
                    </div>
            </section>
        </main>
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
            WriteLiteral("\r\n</html>");
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
