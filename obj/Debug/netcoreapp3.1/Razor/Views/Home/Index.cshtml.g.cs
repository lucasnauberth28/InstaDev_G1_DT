#pragma checksum "C:\Users\User\Desktop\SENAI\ATVIDADES\InstaDev\InstaDev_G1_DT\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9587379e48904cdb0b691898baae2a539085e552"
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
#line 1 "C:\Users\User\Desktop\SENAI\ATVIDADES\InstaDev\InstaDev_G1_DT\Views\_ViewImports.cshtml"
using InstaDev_G1_DT;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9587379e48904cdb0b691898baae2a539085e552", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7afe5f71bdba8d0fbc4de4bd5381b2a5fc9e388", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
#nullable restore
#line 1 "C:\Users\User\Desktop\SENAI\ATVIDADES\InstaDev\InstaDev_G1_DT\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Cadastro";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""form-section""> <!-- essa é a sessão da página || a classe ""formulário"" é pra ajudar na parte do css (deu o nome formulário porque o usuário terá que preencher esse ""formulário"" com os seus dados) -->
    
    <div class=""box-main"">
        <h1 class=""title"">InstaDev</h1> <!-- esse será o título ""InstaDev"" que fica em cima do formulário || tem essa classe ""titulo"" para conseguir chamar no css -->
        <div class=""pre-form"">
            <p>Cadastre-se para ver fotos e</p>
            <p>vídeos dos seus amigos.</p>
        </div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9587379e48904cdb0b691898baae2a539085e5523835", async() => {
                WriteLiteral(@" <!-- esse será o formulário sem si || aqui ficará os ""inputs"" para o usuário preencher -->
            
            <!-- começo da parte dos inputs -->
            <div class=""register"">
                <input type=""email"" id=""cadastro-email"" placeholder=""Email"" class=""input""> <!-- o ""type"" será sobre o que vai ser preenchido nesse input || o ""id"" || o ""placeholder"" será o texto dentro do input que indica para o usuário sobre o que será preenchido dentro || a classe ""input"" é para conseguir puxar os inputs para o css e editá-los -->
            </div>

            <div class=""register"">
                <input type=""text"" id=""cadastro-nome"" placeholder=""Nome completo"" class=""input""> <!-- o ""type"" será sobre o que vai ser preenchido nesse input || o ""id"" || o ""placeholder"" será o texto dentro do input que indica para o usuário sobre o que será preenchido dentro || a classe ""input"" é para conseguir puxar os inputs para o css e editá-los -->
            </div>

            <div class=""register"">
    ");
                WriteLiteral(@"            <input type=""text"" id=""cadastro-nick"" placeholder=""Nome de usuário"" class=""input""> <!-- o ""type"" será sobre o que vai ser preenchido nesse input || o ""id"" || o ""placeholder"" será o texto dentro do input que indica para o usuário sobre o que será preenchido dentro || a classe ""input"" é para conseguir puxar os inputs para o css e editá-los -->
            </div>
            
            <div class=""register"">
                <input type=""password"" id=""cadastro-senha"" placeholder=""Senha"" class=""input""> <!-- o ""type"" será sobre o que vai ser preenchido nesse input || o ""id"" || o ""placeholder"" será o texto dentro do input que indica para o usuário sobre o que será preenchido dentro || a classe ""input"" é para conseguir puxar os inputs para o css e editá-los -->
            </div>
            <!-- fim da parte dos inputs -->

            <!-- começo do botão para cadastrar -->
            <button class=""register-btn"">Cadastre-se</button>
            <!-- fim do botão para cadastrar -->

     ");
                WriteLiteral("   ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

        <div class=""pos-form"">
            <p>Ao se cadastrar, você concorda com nossos</p>
            <p><a href=""index.html"">Termos</a>,&nbsp<a href=""index.html"">Política de Dados</a>&nbspe&nbsp<a href=""index.html"">Política de Cookies</a>.</p>
        </div>
    </div>

    <section class=""extra-section"">
        <div class=""connect"">
            <p>Tem uma conta?&nbsp<a href=""#"">Conecte-se</a></p>
        </div>

        <div class=""app"">
            <p>Obtenha o aplicativo.</p>
            <div class=""images-app"">
                <a href=""https://apps.apple.com/br/app/instagram/id389801252""><img src=""img/app_store 1.png"" alt=""Obter o aplicativo pela App Store""></a> <!-- o ""scr"" é onde colocamos a imagem || o ""alt"" é onde descrevemos a imagem -->
                <a href=""https://play.google.com/store/apps/details?id=com.instagram.android&hl=pt_BR&gl=US""><img src=""img/google_play 1.png"" alt=""Obter o aplicativo pela Google Play""></a><!-- o ""scr"" é onde colocamos a imagem || o ""alt"" é onde");
            WriteLiteral(" descrevemos a imagem -->\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n</section>");
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
