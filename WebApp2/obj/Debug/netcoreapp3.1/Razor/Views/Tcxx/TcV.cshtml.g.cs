#pragma checksum "D:\dsadadas\WebApp2\WebApp2\Views\Tcxx\TcV.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d69d8d857ec4c20688082c8f45c4a30e59f08dd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tcxx_TcV), @"mvc.1.0.view", @"/Views/Tcxx/TcV.cshtml")]
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
#line 1 "D:\dsadadas\WebApp2\WebApp2\Views\_ViewImports.cshtml"
using WebApp2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dsadadas\WebApp2\WebApp2\Views\_ViewImports.cshtml"
using WebApp2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d69d8d857ec4c20688082c8f45c4a30e59f08dd8", @"/Views/Tcxx/TcV.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17a3e8230cdadded111162f1ff1bad1f7b3ff492", @"/Views/_ViewImports.cshtml")]
    public class Views_Tcxx_TcV : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "小型车", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "中型车", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "大型车", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ctl01"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\dsadadas\WebApp2\WebApp2\Views\Tcxx\TcV.cshtml"
  
    ViewData["Title"] = "AddUser";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d69d8d857ec4c20688082c8f45c4a30e59f08dd84934", async() => {
                WriteLiteral("\r\n    <div class=\"mt-2\">\r\n        <h2>车位停车</h2>\r\n        <hr>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <input name=\"cwbm\" type=\"hidden\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 230, "\"", 249, 1);
#nullable restore
#line 12 "D:\dsadadas\WebApp2\WebApp2\Views\Tcxx\TcV.cshtml"
WriteAttributeValue("", 238, Model.cwbm, 238, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <input name=\"tcid\" type=\"hidden\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 314, "\"", 333, 1);
#nullable restore
#line 13 "D:\dsadadas\WebApp2\WebApp2\Views\Tcxx\TcV.cshtml"
WriteAttributeValue("", 322, Model.tcid, 322, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <span id=\"ContentPlaceHolder1_Label1\" for=\"cwmc\">车位名称</span>\r\n        <input name=\"cwmc\" type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 508, "\"", 527, 1);
#nullable restore
#line 17 "D:\dsadadas\WebApp2\WebApp2\Views\Tcxx\TcV.cshtml"
WriteAttributeValue("", 516, Model.cwmc, 516, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""请输入车位名称"" readonly=""readonly"">
        <span id=""cwmctisi"" style=""color:Red;display:none;"">车位名称不能为空</span>
    </div>
    <div class=""form-group"">
        <span id=""ContentPlaceHolder1_Label3"" for=""mxsfy"">每小时收费</span>
        <input name=""mxsfy"" type=""text"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 824, "\"", 844, 1);
#nullable restore
#line 22 "D:\dsadadas\WebApp2\WebApp2\Views\Tcxx\TcV.cshtml"
WriteAttributeValue("", 832, Model.mxsfy, 832, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"请输入车位价格\" readonly=\"readonly\">\r\n        <span id=\"mxsfytishi\" style=\"color:Red;display:none;\">车位价格不能为空</span>\r\n    </div>\r\n");
#nullable restore
#line 25 "D:\dsadadas\WebApp2\WebApp2\Views\Tcxx\TcV.cshtml"
     if (Model.clxh == null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"form-group\">\r\n            <span for=\"clxh\">车型</span>\r\n            <select name=\"clxh\" id=\"clxh\" class=\"form-control\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d69d8d857ec4c20688082c8f45c4a30e59f08dd87852", async() => {
                    WriteLiteral("请选择车型");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d69d8d857ec4c20688082c8f45c4a30e59f08dd89090", async() => {
                    WriteLiteral("小型车");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d69d8d857ec4c20688082c8f45c4a30e59f08dd810326", async() => {
                    WriteLiteral("中型车");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d69d8d857ec4c20688082c8f45c4a30e59f08dd811563", async() => {
                    WriteLiteral("大型车");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </select>
            <span id=""clxhtishi"" style=""color:Red;display:none;"">车型类别不能为空</span>
        </div>
        <div class=""form-group"">
            <span id=""ContentPlaceHolder1_Label3"" for=""clbm"">车牌号</span>
            <input name=""clbm"" type=""text"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 1647, "\"", 1666, 1);
#nullable restore
#line 39 "D:\dsadadas\WebApp2\WebApp2\Views\Tcxx\TcV.cshtml"
WriteAttributeValue("", 1655, Model.clbm, 1655, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"请输入车牌号\">\r\n            <span id=\"clbmtishi\" style=\"color:Red;display:none;\">车牌号不能为空</span>\r\n        </div>\r\n");
#nullable restore
#line 42 "D:\dsadadas\WebApp2\WebApp2\Views\Tcxx\TcV.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"form-group\">\r\n            <span for=\"clxh\">车型</span>\r\n            <input name=\"clbm\" type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 1949, "\"", 1968, 1);
#nullable restore
#line 47 "D:\dsadadas\WebApp2\WebApp2\Views\Tcxx\TcV.cshtml"
WriteAttributeValue("", 1957, Model.clxh, 1957, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly=""readonly"" id=""clxh"">
            <span id=""clxhtishi"" style=""color:Red;display:none;"">车型类别不能为空</span>
        </div>
        <div class=""form-group"">
            <span id=""ContentPlaceHolder1_Label3"" for=""clbm"">车牌号</span>
            <input name=""clbm"" type=""text"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 2270, "\"", 2289, 1);
#nullable restore
#line 52 "D:\dsadadas\WebApp2\WebApp2\Views\Tcxx\TcV.cshtml"
WriteAttributeValue("", 2278, Model.clbm, 2278, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"请输入车牌号\" readonly=\"readonly\">\r\n            <span id=\"clbmtishi\" style=\"color:Red;display:none;\">车牌号不能为空</span>\r\n        </div>\r\n");
                WriteLiteral("        <div class=\"form-group\">\r\n            <span id=\"ContentPlaceHolder1_Label3\" for=\"clbm\">车费</span>\r\n            <input name=\"tcfy\" type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 2602, "\"", 2621, 1);
#nullable restore
#line 58 "D:\dsadadas\WebApp2\WebApp2\Views\Tcxx\TcV.cshtml"
WriteAttributeValue("", 2610, Model.tcfy, 2610, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" readonly=\"readonly\">\r\n            <span id=\"tcfytishi\" style=\"color:Red;display:none;\">车费</span>\r\n        </div>\r\n");
#nullable restore
#line 61 "D:\dsadadas\WebApp2\WebApp2\Views\Tcxx\TcV.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 63 "D:\dsadadas\WebApp2\WebApp2\Views\Tcxx\TcV.cshtml"
     if (Model.tcid == 0)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input type=\"button\" value=\"停车\" onclick=\"WebForm_OnSubmit(1)\" id=\"ContentPlaceHolder1_Button1\" class=\"btn btn-primary\">\r\n");
#nullable restore
#line 66 "D:\dsadadas\WebApp2\WebApp2\Views\Tcxx\TcV.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input type=\"button\" value=\"结束停车\" onclick=\"WebForm_OnSubmit(2)\" id=\"ContentPlaceHolder1_Button1\" class=\"btn btn-primary\">\r\n");
#nullable restore
#line 70 "D:\dsadadas\WebApp2\WebApp2\Views\Tcxx\TcV.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <a href=""/Tcxx/TcxxPlaceV"" class=""btn btn-light ml-1"">返回停车管理</a>

    <script type=""text/javascript"">
        function WebForm_OnSubmit(type) {
            var cwbm = $(""input[name=cwbm]"").val().trim()
            var tcid = $(""input[name=tcid]"").val().trim()
            var clxh = $(""#clxh"").val().trim()
            var clbm = $(""input[name=clbm]"").val().trim()
            if (cwbm == """") {
                $(""#cwbmtisi"").css('display', 'block')
                return
            } else {
                $(""#cwbmtisi"").css('display', 'none')
            }
            if (tcid == """") {
                $(""#tcidtishi"").css('display', 'block')
                return
            } else {
                $(""#tcidtishi"").css('display', 'none')
            }
            if (clxh == """") {
                $(""#clxhtishi"").css('display', 'block')
                return
            } else {
                $(""#clxhtishi"").css('display', 'none')
            }
            if (clbm == """") {
   ");
                WriteLiteral(@"             $(""#clbmtishi"").css('display', 'block')
                return
            } else {
                $(""#clbmtishi"").css('display', 'none')
            }

            var cwbmId = $(""input[name=cwbm]"").val()
            if (type == 1) {
                $.ajax({
                    type: 'post',
                    url: ""/Tcxx/AddTcxx"",
                    data: { ""cwxx_bm"": cwbmId, ""clbm"": clbm, ""clxh"": clxh },
                    datatype: 'json',
                    success: function (res) {
                        if (res == 1) {
                            alert(""操作成功"")
                            window.location.href = ""/Tcxx/TcxxPlaceV""
                        } else {
                            alert(res.res)
                        }
                    }, error: function (err) {
                        console.log(err)
                        alert(""请求异常"")
                    }
                });

            } else {
                $.ajax({
                ");
                WriteLiteral(@"    type: 'post',
                    url: ""/Tcxx/UpdateTcxx"",
                    data: { ""cwbm"": cwbm, ""tcid"": tcid },
                    datatype: 'json',
                    success: function (res) {
                        console.log(res)
                        if (res == 1) {
                            alert(""操作成功"")
                            window.location.href = ""/Tcxx/TcxxPlaceV""
                        }
                    }, error: function (err) {
                        console.log(err)
                        alert(""请求异常"")
                    }
                });
            }



        }
    </script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591