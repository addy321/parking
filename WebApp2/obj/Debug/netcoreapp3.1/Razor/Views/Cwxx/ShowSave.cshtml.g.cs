#pragma checksum "D:\dsadadas\WebApp2\WebApp2\Views\Cwxx\ShowSave.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1610e78200da6189cc42137dad5521acfe2939e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cwxx_ShowSave), @"mvc.1.0.view", @"/Views/Cwxx/ShowSave.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1610e78200da6189cc42137dad5521acfe2939e9", @"/Views/Cwxx/ShowSave.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17a3e8230cdadded111162f1ff1bad1f7b3ff492", @"/Views/_ViewImports.cshtml")]
    public class Views_Cwxx_ShowSave : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ctl01"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\dsadadas\WebApp2\WebApp2\Views\Cwxx\ShowSave.cshtml"
  
    ViewData["Title"] = "AddUser";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1610e78200da6189cc42137dad5521acfe2939e93663", async() => {
                WriteLiteral("\r\n    <div class=\"mt-2\">\r\n        <h2>新增车位</h2>\r\n        <hr>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <input name=\"cwbmId\" type=\"hidden\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 232, "\"", 251, 1);
#nullable restore
#line 12 "D:\dsadadas\WebApp2\WebApp2\Views\Cwxx\ShowSave.cshtml"
WriteAttributeValue("", 240, Model.cwbm, 240, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <input name=\"cwzt\" type=\"hidden\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 316, "\"", 335, 1);
#nullable restore
#line 13 "D:\dsadadas\WebApp2\WebApp2\Views\Cwxx\ShowSave.cshtml"
WriteAttributeValue("", 324, Model.cwzt, 324, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <span id=\"ContentPlaceHolder1_Label1\" for=\"cwmc\">车位名称</span>\r\n        <input name=\"cwmc\" type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 510, "\"", 529, 1);
#nullable restore
#line 17 "D:\dsadadas\WebApp2\WebApp2\Views\Cwxx\ShowSave.cshtml"
WriteAttributeValue("", 518, Model.cwmc, 518, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""请输入车位名称"">
        <span id=""cwmctisi"" style=""color:Red;display:none;"">车位名称不能为空</span>
    </div>
    <div class=""form-group"">
        <span id=""ContentPlaceHolder1_Label3"" for=""mxsfy"">车位价格</span>
        <input name=""mxsfy"" type=""text"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 805, "\"", 825, 1);
#nullable restore
#line 22 "D:\dsadadas\WebApp2\WebApp2\Views\Cwxx\ShowSave.cshtml"
WriteAttributeValue("", 813, Model.mxsfy, 813, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""请输入车位价格"">
        <span id=""mxsfytishi"" style=""color:Red;display:none;"">车位价格不能为空</span>
    </div>
    <div class=""form-group"">
        <span id=""ContentPlaceHolder1_Label3"" for=""zsyh"">专属车主</span>
        <input name=""zsyh"" type=""text"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 1101, "\"", 1120, 1);
#nullable restore
#line 27 "D:\dsadadas\WebApp2\WebApp2\Views\Cwxx\ShowSave.cshtml"
WriteAttributeValue("", 1109, Model.zsyh, 1109, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""请输入专属车主"">
        <span id=""zsyhtishi"" style=""color:Red;display:none;"">专属车主不存在</span>
    </div>
    <div class=""form-group"">
        <span id=""ContentPlaceHolder1_Label3"" for=""zsyh"">专属价格</span>
        <input name=""zsjg"" type=""text"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 1394, "\"", 1413, 1);
#nullable restore
#line 32 "D:\dsadadas\WebApp2\WebApp2\Views\Cwxx\ShowSave.cshtml"
WriteAttributeValue("", 1402, Model.zsjg, 1402, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""请输入专属价格"">
        <span id=""zsjgtishi"" style=""color:Red;display:none;"">专属价格</span>
    </div>
    <div class=""form-group"">
        <span id=""ContentPlaceHolder1_Label3"" for=""zsyh"">专属到期日期</span>
        <!--指定 date标记-->
        <div class='input-group date' id='datetimepicker2' style=""width:280px;"">
            <input type='text' class=""form-control"" name=""yxsc"" />
            <span class=""input-group-addon"">
                <span class=""glyphicon glyphicon-calendar""></span>
            </span>
        </div>
        <span id=""yxsctishi"" style=""color:Red;display:none;"">请输入专属到期日期</span>
    </div>

    <input type=""button"" name=""ctl00$ContentPlaceHolder1$Button1"" value=""保存"" onclick=""WebForm_OnSubmit()"" id=""ContentPlaceHolder1_Button1"" class=""btn btn-primary"">
    <a href=""/Cwxx/CwxxPlaceV"" class=""btn btn-light ml-1"">返回车位管理</a>


    <script type=""text/javascript"">
        $(function () {
            $('#datetimepicker2').datetimepicker({
                format: 'YYYY-MM-DD',");
                WriteLiteral(@"
                locale: moment.locale('zh-cn')
            });
            /*$('#datetimepicker2').datetimepicker({
                format: 'YYYY-MM-DD hh:mm',
                locale: moment.locale('zh-cn')
            });*/
        });

        function WebForm_OnSubmit() {
            var cwmc = $(""input[name=cwmc]"").val().trim()
            var mxsfy = $(""input[name=mxsfy]"").val().trim()
            var zsyh = $(""input[name=zsyh]"").val().trim()
            var yxsc = $(""input[name=yxsc]"").val().trim()
            var zsjg = $(""input[name=zsjg]"").val().trim()

            if (cwmc == """") {
                $(""#cwmctisi"").css('display', 'block')
                return
            } else {
                $(""#yhzhtisi"").css('display', 'none')
            }
            if (mxsfy == """") {
                $(""#mxsfytishi"").css('display', 'block')
                return
            } else {
                $(""#mxsfytishi"").css('display', 'none')
            }

            var cwbmId = $");
                WriteLiteral(@"(""input[name=cwbmId]"").val()
            if (cwbmId == """" || cwbmId == ""0"") {
                $.ajax({
                    type: 'post',
                    url: ""/Cwxx/AddData"",
                    data: { ""cwmc"": cwmc, ""mxsfy"": mxsfy, ""cwzt"": 0, ""zsyh"": zsyh, ""yxsc"": yxsc, ""zsjg"": zsjg },
                    datatype: 'json',
                    success: function (res) {
                        if (res == 1) {
                            alert(""操作成功"")
                            $(""input[name=cwmc]"").val("""")
                            $(""input[name=mxsfy]"").val("""")
                            $(""input[name=zsyh]"").val("""")
                            $(""#zsyhtishi"").css('display', 'node')
                        } else {
                            //$(""#zsyhtishi"").css('display', 'block')
                            alert(res.res)
                        }
                    }, error: function (err) {
                        console.log(err)
                        alert(""请求异常"")
     ");
                WriteLiteral(@"               }
                });

            } else {
                var cwzt = $(""input[name=cwzt]"").val()
                $.ajax({
                    type: 'post',
                    url: ""/Cwxx/UpdateData"",
                    data: { ""cwmc"": cwmc, ""mxsfy"": mxsfy, ""cwzt"": cwzt, ""cwbm"": cwbmId, ""zsyh"": zsyh, ""yxsc"": yxsc, ""zsjg"": zsjg  },
                    datatype: 'json',
                    success: function (res) {
                        console.log(res)
                        if (res == 1) {
                            alert(""操作成功"")
                            $(""#zsyhtishi"").css('display', 'node')
                        } else {
                            //$(""#zsyhtishi"").css('display', 'block')
                            alert(res.res)
                        }
                    }, error: function (err) {
                        console.log(err)
                        alert(""请求异常"")
                    }
                });
            }



        }
   ");
                WriteLiteral(" </script>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
