#pragma checksum "C:\Users\Eze\source\repos\Vapos2 - bueno\Vapos2\Views\Registroes\IndexFiltrado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b9da5563c38e52fd2610ec7c4409ba4ae7f0970"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Registroes_IndexFiltrado), @"mvc.1.0.view", @"/Views/Registroes/IndexFiltrado.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Registroes/IndexFiltrado.cshtml", typeof(AspNetCore.Views_Registroes_IndexFiltrado))]
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
#line 1 "C:\Users\Eze\source\repos\Vapos2 - bueno\Vapos2\Views\_ViewImports.cshtml"
using Vapos2;

#line default
#line hidden
#line 2 "C:\Users\Eze\source\repos\Vapos2 - bueno\Vapos2\Views\_ViewImports.cshtml"
using Vapos2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b9da5563c38e52fd2610ec7c4409ba4ae7f0970", @"/Views/Registroes/IndexFiltrado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef90d2964c7a6525a60455815bbf6965ad75a76e", @"/Views/_ViewImports.cshtml")]
    public class Views_Registroes_IndexFiltrado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Vapos2.Models.Registro>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Eze\source\repos\Vapos2 - bueno\Vapos2\Views\Registroes\IndexFiltrado.cshtml"
  
    ViewData["Title"] = "IndexFiltrado";
    var buscado = 2;
    

#line default
#line hidden
            BeginContext(123, 37, true);
            WriteLiteral("\r\n<h2>IndexFiltrado</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(160, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffe5e306c52e4950ad62cbdd537f3e1b", async() => {
                BeginContext(183, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(197, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(290, 41, false);
#line 18 "C:\Users\Eze\source\repos\Vapos2 - bueno\Vapos2\Views\Registroes\IndexFiltrado.cshtml"
           Write(Html.DisplayNameFor(model => model.fecha));

#line default
#line hidden
            EndContext();
            BeginContext(331, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(387, 47, false);
#line 21 "C:\Users\Eze\source\repos\Vapos2 - bueno\Vapos2\Views\Registroes\IndexFiltrado.cshtml"
           Write(Html.DisplayNameFor(model => model.vaporizator));

#line default
#line hidden
            EndContext();
            BeginContext(434, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(490, 47, false);
#line 24 "C:\Users\Eze\source\repos\Vapos2 - bueno\Vapos2\Views\Registroes\IndexFiltrado.cshtml"
           Write(Html.DisplayNameFor(model => model.responsable));

#line default
#line hidden
            EndContext();
            BeginContext(537, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(593, 53, false);
#line 27 "C:\Users\Eze\source\repos\Vapos2 - bueno\Vapos2\Views\Registroes\IndexFiltrado.cshtml"
           Write(Html.DisplayNameFor(model => model.Prueba_Hidráulica));

#line default
#line hidden
            EndContext();
            BeginContext(646, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(702, 55, false);
#line 30 "C:\Users\Eze\source\repos\Vapos2 - bueno\Vapos2\Views\Registroes\IndexFiltrado.cshtml"
           Write(Html.DisplayNameFor(model => model.Prueba_Estanqueidad));

#line default
#line hidden
            EndContext();
            BeginContext(757, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(813, 57, false);
#line 33 "C:\Users\Eze\source\repos\Vapos2 - bueno\Vapos2\Views\Registroes\IndexFiltrado.cshtml"
           Write(Html.DisplayNameFor(model => model.Prueba_Funcionamiento));

#line default
#line hidden
            EndContext();
            BeginContext(870, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(926, 44, false);
#line 36 "C:\Users\Eze\source\repos\Vapos2 - bueno\Vapos2\Views\Registroes\IndexFiltrado.cshtml"
           Write(Html.DisplayNameFor(model => model.Detalles));

#line default
#line hidden
            EndContext();
            BeginContext(970, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 42 "C:\Users\Eze\source\repos\Vapos2 - bueno\Vapos2\Views\Registroes\IndexFiltrado.cshtml"
         foreach (var item in Model)
        {
            

#line default
#line hidden
#line 44 "C:\Users\Eze\source\repos\Vapos2 - bueno\Vapos2\Views\Registroes\IndexFiltrado.cshtml"
             if (item.IdVapo.Equals(buscado))
            {

#line default
#line hidden
            BeginContext(1167, 74, true);
            WriteLiteral("                <tr>\r\n\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1242, 40, false);
#line 49 "C:\Users\Eze\source\repos\Vapos2 - bueno\Vapos2\Views\Registroes\IndexFiltrado.cshtml"
                   Write(Html.DisplayFor(modelItem => item.fecha));

#line default
#line hidden
            EndContext();
            BeginContext(1282, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1362, 53, false);
#line 52 "C:\Users\Eze\source\repos\Vapos2 - bueno\Vapos2\Views\Registroes\IndexFiltrado.cshtml"
                   Write(Html.DisplayFor(modelItem => item.vaporizator.IdVapo));

#line default
#line hidden
            EndContext();
            BeginContext(1415, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1495, 56, false);
#line 55 "C:\Users\Eze\source\repos\Vapos2 - bueno\Vapos2\Views\Registroes\IndexFiltrado.cshtml"
                   Write(Html.DisplayFor(modelItem => item.responsable.nombreApe));

#line default
#line hidden
            EndContext();
            BeginContext(1551, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1631, 52, false);
#line 58 "C:\Users\Eze\source\repos\Vapos2 - bueno\Vapos2\Views\Registroes\IndexFiltrado.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Prueba_Hidráulica));

#line default
#line hidden
            EndContext();
            BeginContext(1683, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1763, 54, false);
#line 61 "C:\Users\Eze\source\repos\Vapos2 - bueno\Vapos2\Views\Registroes\IndexFiltrado.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Prueba_Estanqueidad));

#line default
#line hidden
            EndContext();
            BeginContext(1817, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1897, 56, false);
#line 64 "C:\Users\Eze\source\repos\Vapos2 - bueno\Vapos2\Views\Registroes\IndexFiltrado.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Prueba_Funcionamiento));

#line default
#line hidden
            EndContext();
            BeginContext(1953, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2033, 43, false);
#line 67 "C:\Users\Eze\source\repos\Vapos2 - bueno\Vapos2\Views\Registroes\IndexFiltrado.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Detalles));

#line default
#line hidden
            EndContext();
            BeginContext(2076, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2155, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ccc1ba30fd2946d0b650f9e6362e1857", async() => {
                BeginContext(2208, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "C:\Users\Eze\source\repos\Vapos2 - bueno\Vapos2\Views\Registroes\IndexFiltrado.cshtml"
                                               WriteLiteral(item.IdRegistro);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2216, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(2244, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94c09fe1fe7c4fa4acba8a631ae40072", async() => {
                BeginContext(2300, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "C:\Users\Eze\source\repos\Vapos2 - bueno\Vapos2\Views\Registroes\IndexFiltrado.cshtml"
                                                  WriteLiteral(item.IdRegistro);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2311, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(2339, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25f66767a9b34e56b842f9d7d185c2f9", async() => {
                BeginContext(2394, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "C:\Users\Eze\source\repos\Vapos2 - bueno\Vapos2\Views\Registroes\IndexFiltrado.cshtml"
                                                 WriteLiteral(item.IdRegistro);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2404, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 75 "C:\Users\Eze\source\repos\Vapos2 - bueno\Vapos2\Views\Registroes\IndexFiltrado.cshtml"
            }

#line default
#line hidden
#line 75 "C:\Users\Eze\source\repos\Vapos2 - bueno\Vapos2\Views\Registroes\IndexFiltrado.cshtml"
             
        }

#line default
#line hidden
            BeginContext(2482, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Vapos2.Models.Registro>> Html { get; private set; }
    }
}
#pragma warning restore 1591