#pragma checksum "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3b4168a76de1505bfc0943f719db2a333616de1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Details), @"mvc.1.0.view", @"/Views/Contact/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Contact/Details.cshtml", typeof(AspNetCore.Views_Contact_Details))]
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
#line 1 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\_ViewImports.cshtml"
using PhoneBook;

#line default
#line hidden
#line 2 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\_ViewImports.cshtml"
using PhoneBook.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3b4168a76de1505bfc0943f719db2a333616de1", @"/Views/Contact/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fbb05f7de09e8b1f95508d0f0dc068b7ff16d71", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PhoneBook.Models.Contacts.Contact>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "/Views/Phone/_IndexPhone.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(71, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c433eff185348c18a6da83ec95d936b", async() => {
                BeginContext(77, 102, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Подробная информация</title>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(186, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(188, 3767, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed478a68a9374f4c916d819610b6f2ee", async() => {
                BeginContext(194, 238, true);
                WriteLiteral("\r\n\r\n    <div id=\"modDialog\" class=\"modal fade\">\r\n        <div id=\"dialogContent\" class=\"modal-dialog\"></div>\r\n    </div>\r\n\r\n    <br />\r\n    <div>\r\n        <h4>Основная информация:</h4>\r\n        <hr />\r\n        <dl class=\"dl-horizontal\">\r\n");
                EndContext();
#line 21 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
             if (Model.Surname != null)
            {

#line default
#line hidden
                BeginContext(488, 42, true);
                WriteLiteral("                <dt>\r\n                    ");
                EndContext();
                BeginContext(531, 43, false);
#line 24 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Surname));

#line default
#line hidden
                EndContext();
                BeginContext(574, 67, true);
                WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
                EndContext();
                BeginContext(642, 39, false);
#line 27 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
               Write(Html.DisplayFor(model => model.Surname));

#line default
#line hidden
                EndContext();
                BeginContext(681, 25, true);
                WriteLiteral("\r\n                </dd>\r\n");
                EndContext();
#line 29 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
            }

#line default
#line hidden
                BeginContext(721, 12, true);
                WriteLiteral("            ");
                EndContext();
#line 30 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
             if (Model.Name != null)
            {

#line default
#line hidden
                BeginContext(774, 42, true);
                WriteLiteral("                <dt>\r\n                    ");
                EndContext();
                BeginContext(817, 40, false);
#line 33 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(857, 67, true);
                WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
                EndContext();
                BeginContext(925, 36, false);
#line 36 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
               Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(961, 25, true);
                WriteLiteral("\r\n                </dd>\r\n");
                EndContext();
#line 38 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
            }

#line default
#line hidden
                BeginContext(1001, 12, true);
                WriteLiteral("            ");
                EndContext();
#line 39 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
             if (Model.Patronymic != null)
            {

#line default
#line hidden
                BeginContext(1060, 42, true);
                WriteLiteral("                <dt>\r\n                    ");
                EndContext();
                BeginContext(1103, 46, false);
#line 42 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Patronymic));

#line default
#line hidden
                EndContext();
                BeginContext(1149, 67, true);
                WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
                EndContext();
                BeginContext(1217, 42, false);
#line 45 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
               Write(Html.DisplayFor(model => model.Patronymic));

#line default
#line hidden
                EndContext();
                BeginContext(1259, 25, true);
                WriteLiteral("\r\n                </dd>\r\n");
                EndContext();
#line 47 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
            }

#line default
#line hidden
                BeginContext(1299, 41, true);
                WriteLiteral("        </dl>\r\n        <hr />\r\n\r\n        ");
                EndContext();
                BeginContext(1340, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "66df15df041b4e188cd1cb73a231ec82", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 51 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Phones);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1403, 20, true);
                WriteLiteral("\r\n\r\n        <hr />\r\n");
                EndContext();
#line 54 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
         if (Model.Address != null || Model.Job != null || Model.Position != null
           || Model.Email != null || Model.Skype != null || Model.Group != null)
        {

#line default
#line hidden
                BeginContext(1599, 89, true);
                WriteLiteral("            <h4>Дополнительная информация:</h4>\r\n            <dl class=\"dl-horizontal\">\r\n");
                EndContext();
#line 59 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
                 if (Model.Address != null)
                {

#line default
#line hidden
                BeginContext(1752, 50, true);
                WriteLiteral("                    <dt>\r\n                        ");
                EndContext();
                BeginContext(1803, 43, false);
#line 62 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
                EndContext();
                BeginContext(1846, 79, true);
                WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
                EndContext();
                BeginContext(1926, 39, false);
#line 65 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
                EndContext();
                BeginContext(1965, 29, true);
                WriteLiteral("\r\n                    </dd>\r\n");
                EndContext();
#line 67 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
                }

#line default
#line hidden
                BeginContext(2013, 16, true);
                WriteLiteral("                ");
                EndContext();
#line 68 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
                 if (Model.Job != null)
                {

#line default
#line hidden
                BeginContext(2073, 50, true);
                WriteLiteral("                    <dt>\r\n                        ");
                EndContext();
                BeginContext(2124, 39, false);
#line 71 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Job));

#line default
#line hidden
                EndContext();
                BeginContext(2163, 79, true);
                WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
                EndContext();
                BeginContext(2243, 35, false);
#line 74 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Job));

#line default
#line hidden
                EndContext();
                BeginContext(2278, 29, true);
                WriteLiteral("\r\n                    </dd>\r\n");
                EndContext();
#line 76 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
                }

#line default
#line hidden
                BeginContext(2326, 16, true);
                WriteLiteral("                ");
                EndContext();
#line 77 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
                 if (Model.Position != null)
                {

#line default
#line hidden
                BeginContext(2391, 50, true);
                WriteLiteral("                    <dt>\r\n                        ");
                EndContext();
                BeginContext(2442, 44, false);
#line 80 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Position));

#line default
#line hidden
                EndContext();
                BeginContext(2486, 79, true);
                WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
                EndContext();
                BeginContext(2566, 40, false);
#line 83 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Position));

#line default
#line hidden
                EndContext();
                BeginContext(2606, 29, true);
                WriteLiteral("\r\n                    </dd>\r\n");
                EndContext();
#line 85 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
                }

#line default
#line hidden
                BeginContext(2654, 16, true);
                WriteLiteral("                ");
                EndContext();
#line 86 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
                 if (Model.Email != null)
                {

#line default
#line hidden
                BeginContext(2716, 50, true);
                WriteLiteral("                    <dt>\r\n                        ");
                EndContext();
                BeginContext(2767, 41, false);
#line 89 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
                EndContext();
                BeginContext(2808, 81, true);
                WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=", 2889, "", 2932, 1);
#line 92 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
WriteAttributeValue("", 2895, String.Concat("mailto:",Model.Email), 2895, 37, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2932, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2934, 37, false);
#line 92 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
                                                                 Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
                EndContext();
                BeginContext(2971, 33, true);
                WriteLiteral("</a>\r\n                    </dd>\r\n");
                EndContext();
#line 94 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
                }

#line default
#line hidden
                BeginContext(3023, 16, true);
                WriteLiteral("                ");
                EndContext();
#line 95 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
                 if (Model.Skype != null)
                {

#line default
#line hidden
                BeginContext(3085, 50, true);
                WriteLiteral("                    <dt>\r\n                        ");
                EndContext();
                BeginContext(3136, 41, false);
#line 98 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Skype));

#line default
#line hidden
                EndContext();
                BeginContext(3177, 81, true);
                WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        <a");
                EndContext();
                BeginWriteAttribute("href", " href=", 3258, "", 3308, 1);
#line 101 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
WriteAttributeValue("", 3264, String.Concat("skype:",Model.Skype,"?call"), 3264, 44, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3308, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(3310, 37, false);
#line 101 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
                                                                        Write(Html.DisplayFor(model => model.Skype));

#line default
#line hidden
                EndContext();
                BeginContext(3347, 33, true);
                WriteLiteral("</a>\r\n                    </dd>\r\n");
                EndContext();
#line 103 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
                }

#line default
#line hidden
                BeginContext(3399, 16, true);
                WriteLiteral("                ");
                EndContext();
#line 104 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
                 if (Model.Group != null)
                {

#line default
#line hidden
                BeginContext(3461, 50, true);
                WriteLiteral("                    <dt>\r\n                        ");
                EndContext();
                BeginContext(3512, 41, false);
#line 107 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Group));

#line default
#line hidden
                EndContext();
                BeginContext(3553, 79, true);
                WriteLiteral("\r\n                    </dt>\r\n                    <dd>\r\n                        ");
                EndContext();
                BeginContext(3633, 42, false);
#line 110 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Group.Name));

#line default
#line hidden
                EndContext();
                BeginContext(3675, 29, true);
                WriteLiteral("\r\n                    </dd>\r\n");
                EndContext();
#line 112 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
                }

#line default
#line hidden
                BeginContext(3723, 19, true);
                WriteLiteral("            </dl>\r\n");
                EndContext();
#line 114 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
        }

#line default
#line hidden
                BeginContext(3753, 31, true);
                WriteLiteral("    </div>\r\n    <div>\r\n        ");
                EndContext();
                BeginContext(3784, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f29ccc05f754105b02b840d7e213355", async() => {
                    BeginContext(3830, 14, true);
                    WriteLiteral("Редактирование");
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
#line 117 "C:\Users\Юля\Desktop\Курсовая\Программа\PhoneBook\PhoneBook\Views\Contact\Details.cshtml"
                               WriteLiteral(Model.Id);

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
                BeginContext(3848, 12, true);
                WriteLiteral(" |\r\n        ");
                EndContext();
                BeginContext(3860, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7b9215714f94d9b99decdb08d9ea9ad", async() => {
                    BeginContext(3916, 14, true);
                    WriteLiteral("Назад к списку");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3934, 14, true);
                WriteLiteral("\r\n    </div>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(3955, 15, true);
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3993, 419, true);
                WriteLiteral(@"
    <script type=""text/javascript"">

        $(function () {
            $.ajaxSetup({ cache: false });
           $("".compItem"").click(function (e) {

                e.preventDefault();
                $.get(this.href, function (data) {
                    $('#dialogContent').html(data);
                    $('#modDialog').modal('show');
                });
            });
        })
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PhoneBook.Models.Contacts.Contact> Html { get; private set; }
    }
}
#pragma warning restore 1591