#pragma checksum "D:\Projects\Seminar\WebApplication1\WebApplication1\Views\XuLy\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c53a63f79dc255b15d803803785d5dbb0ccfa9e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_XuLy_Index), @"mvc.1.0.view", @"/Views/XuLy/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/XuLy/Index.cshtml", typeof(AspNetCore.Views_XuLy_Index))]
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
#line 1 "D:\Projects\Seminar\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "D:\Projects\Seminar\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c53a63f79dc255b15d803803785d5dbb0ccfa9e7", @"/Views/XuLy/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_XuLy_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form-vatco"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Projects\Seminar\WebApplication1\WebApplication1\Views\XuLy\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Homepage.cshtml";

#line default
#line hidden
            BeginContext(90, 652, true);
            WriteLiteral(@"
<div class=""app-page-title"">
    <div class=""page-title-wrapper"">
        <div class=""page-title-heading"">
            <div class=""page-title-icon"">
                <i class=""pe-7s-shopbag icon-gradient bg-mean-fruit"">
                </i>
            </div>
            <div>
                Bài toán cái túi
                <div class=""page-title-subheading"">
                    Cách giải: quy hoạch động
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""row"">
    <div class=""tab-content"">
        <div class=""tab-pane tabs-animation fade show active"" id=""tab-content-0"" role=""tabpanel"">
");
            EndContext();
            BeginContext(765, 139, true);
            WriteLiteral("            <div class=\"main-card mb-3 card\">\r\n                <div class=\"card-body\">\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(904, 955, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0772c7139c104a8896099b6bea00c0aa", async() => {
                BeginContext(930, 689, true);
                WriteLiteral(@"
                            <div class=""mb-2 mr-sm-2 mb-sm-0 position-relative form-group"">
                                <label for=""exampleEmail22"" class=""mr-sm-2"">Trọng lượng túi</label><input id=""trongluong"" name=""txttrongluong"" placeholder=""Trọng lượng túi"" type=""number"" class=""form-control"" required>
                            </div>
                            <div class=""mb-2 mr-sm-2 mb-sm-0 position-relative form-group"">
                                <label for=""examplePassword22"" class=""mr-sm-2"">Số lượng vật</label><input id=""soluong"" name=""txtsoluong"" placeholder=""Số lượng vật"" type=""number"" class=""form-control"" required>
                            </div>
");
                EndContext();
                BeginContext(1739, 113, true);
                WriteLiteral("                            <button id=\"btnRandom\" class=\"btn btn-info\">Random</button>\r\n                        ");
                EndContext();
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
            EndContext();
            BeginContext(1859, 76, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n");
            EndContext();
            BeginContext(1960, 127, true);
            WriteLiteral("            <div class=\"main-card mb-3 card\" id=\"input-content\">\r\n                <div class=\"card-body\">\r\n                    ");
            EndContext();
            BeginContext(2087, 259, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7141d4957280433d83a63bfc566b3225", async() => {
                BeginContext(2118, 221, true);
                WriteLiteral("\r\n                        <div class=\"form-row vatco\" id=\"vatco\">\r\n\r\n                        </div>\r\n\r\n                        <button type=\"button\" class=\"btn btn-success\" id=\"submit\">Xử lý</button>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2346, 48, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n");
            EndContext();
            BeginContext(2418, 256, true);
            WriteLiteral(@"            <div class=""main-card mb-3 card"" id=""row-ketqua"">

            </div>

            <div class=""main-card mb-3 card"" id=""row-chart"">
                <canvas id=""myChart"" style=""width: '50%'; height:'50%'""></canvas>
            </div>


");
            EndContext();
            BeginContext(3041, 3646, true);
            WriteLiteral(@"        </div>
    </div>
</div>

<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.8.0/Chart.bundle.js"" integrity=""sha256-qSIshlknROr4J8GMHRlW3fGKrPki733tLq+qeMCR05Q="" crossorigin=""anonymous""></script>

<script>
    let listtrongluong = [];
    let listgiatri = [];
    let sldiv = 0;
    let mangtl;

    $(document).ready(function () {
        $(""#input-content"").hide();
        $(""#row-chart"").hide();
    });

    $(""#btnOK"").click(function (e) {
        e.preventDefault();

        let sl = $(""#soluong"").val();
        sldiv = parseInt(sl);

        for (let i = 0; i < sl; i++) {
            $(""#vatco"").append(`
                <div class=""col-md-6"">
                    <div class=""position-relative form-group""><label for=""trongLuongVatThuI"" class="""">Trọng lượng vật thứ ${i + 1}</label>
                    <input placeholder=""Trọng lượng vật thứ ${i + 1}"" type=""number"" class=""fo");
            WriteLiteral(@"rm-control tlvat${i}""></div>
                </div>`
            );

            $(""#vatco"").append(`
                <div class=""col-md-6"">
                    <div class=""position-relative form-group""><label for=""giaTriVatThuI"" class="""">Giá trị vật thứ ${i + 1}</label>
                    <input placeholder=""Giá trị vật thứ ${i + 1}"" type=""number"" class=""form-control giatri${i}""></div>
                </div>`
            );
        }

        $(""#input-content"").show();
    });

    $(""#submit"").click(function () {
        for (let i = 0; i < sldiv; i++) {
            listtrongluong.push(parseInt($(`.tlvat${i}`).val()));
            listgiatri.push(parseInt($(`.giatri${i}`).val()));
        };

        mangtl = JSON.stringify(listtrongluong);
        manggt = JSON.stringify(listgiatri);

        $.ajax({
            url: ""/XuLy/DynamicPlanningAlgorithm"",
            type: ""POST"",
            data: {
                ""mangtl"": mangtl,
                ""manggt"": manggt,
           ");
            WriteLiteral(@"     ""txttrongluong"": parseInt($(""#trongluong"").val()),
                ""txtsoluong"": parseInt($(""#soluong"").val())
            },
            success: function (data) {
                $(""#row-ketqua"").html(`
                    <div class=""card-body"" id=""table-ketqua"">
                        ${data}
                    </div>`);
            },
            error: function (data) {
                alert(""Error: "" + data);
            }
        });
    });

    $(""#btnRandom"").click(function (e) {
        e.preventDefault();

        $.ajax({
            url: ""/XuLy/RandomAllAlgorithm"",
            type: ""POST"",
            async: true,
            timeout: 100000000,
            success: function (data) {
                $(""#row-ketqua"").html(`
                    <div class=""card-body"" id=""table-ketqua"">
                        ${data}
                    </div>`);

                $(""#row-chart"").show();
            },
            error: function (data) {
                ale");
            WriteLiteral(@"rt(""Error: "" + data);
            }
        });

        //$.ajax({
        //    url: ""/XuLy/RandomDynamicPlanningAlgorithmResult"",
        //    type: ""POST"",
        //    data: {
        //        ""txttrongluong"": parseInt($(""#trongluong"").val()),
        //        ""txtsoluong"": parseInt($(""#soluong"").val())
        //    },
        //    success: function (data) {
        //        console.log(data);
        //    },
        //    error: function (data) {
        //        alert(""Error: "" + data);
        //    }
        //});
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
