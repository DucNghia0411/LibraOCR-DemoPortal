#pragma checksum "D:\Libra\OCR\WebOCR\WebOCR\Views\VehicleRegis\_Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d1cbb02b3fcee51b2d465d51abfddc2e0f3f66b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VehicleRegis__Details), @"mvc.1.0.view", @"/Views/VehicleRegis/_Details.cshtml")]
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
#line 1 "D:\Libra\OCR\WebOCR\WebOCR\Views\_ViewImports.cshtml"
using WebOCR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Libra\OCR\WebOCR\WebOCR\Views\_ViewImports.cshtml"
using WebOCR.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Libra\OCR\WebOCR\WebOCR\Views\VehicleRegis\_Details.cshtml"
using CoreOCR.Model.VehicleRegistrations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Libra\OCR\WebOCR\WebOCR\Views\VehicleRegis\_Details.cshtml"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d1cbb02b3fcee51b2d465d51abfddc2e0f3f66b", @"/Views/VehicleRegis/_Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a809702604a870cb2b029515769f904b3573e6a7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_VehicleRegis__Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreOCR.Model.VehicleRegistrations.VehicleRegistrationVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("imageValue"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid center mh-325"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Libra\OCR\WebOCR\WebOCR\Views\VehicleRegis\_Details.cshtml"
  
    VehicleRegistrationVM i = ViewData["Info"] as VehicleRegistrationVM;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-xl-6"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-sm-12 p-b-10 border-bottom"">
                        <h4 class=""header-title float-left"">Image Preview</h4>
                        <div class=""btn-group btn-group-toggle float-right"">
                            <button href=""#"" class=""btn btn-outline-primary btn-icon"" onclick=""zoomin()""><div><i class=""fa fa-search-plus""></i></div></button>
                            <button href=""#"" class=""btn btn-outline-primary btn-icon"" onclick=""zoomout()""><div><i class=""fa fa-search-minus""></i></div></button>
                            <button href=""#"" class=""btn btn-outline-primary btn-icon"" onclick=""fullscreen()""><div><i class=""fa fa-arrows-alt""></i></div></button>
                        </div>
                    </div>
                    <div class=""col-sm-12"">
                        <div class=""card-body"">
              ");
            WriteLiteral("              <div class=\"text-muted\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1d1cbb02b3fcee51b2d465d51abfddc2e0f3f66b5641", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1342, "~/", 1342, 2, true);
#nullable restore
#line 24 "D:\Libra\OCR\WebOCR\WebOCR\Views\VehicleRegis\_Details.cshtml"
AddHtmlAttributeValue("", 1344, Url.Content(i.ImagePath), 1344, 25, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div> <!-- end col -->
    <div class=""col-xl-6"">
        <div class=""card"">
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-sm-12 p-b-10 border-bottom"">
                        <h4 class=""header-title float-left"">Results</h4>
                        <div class=""btn-group btn-group-toggle float-right"">
                            <a href=""#"" class=""btn btn-outline-primary tab"">HTML</a>
                            <a href=""#"" class=""btn btn-outline-primary tab"">Json</a>
                        </div>
                    </div>
                    <div class=""col-sm-12"">
                        <div class=""card-body"">
                            <div class=""text-muted"">
                                <div id=""HTMLVal"">
                                    <pre id=""textocr"" class");
            WriteLiteral("=\"tab-content show-content mh-325\">");
#nullable restore
#line 47 "D:\Libra\OCR\WebOCR\WebOCR\Views\VehicleRegis\_Details.cshtml"
                                                                                         Write(Html.Raw(i.HTMLValue));

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre>\r\n                                </div>\r\n                                <div id=\"JsonVal\">\r\n");
#nullable restore
#line 50 "D:\Libra\OCR\WebOCR\WebOCR\Views\VehicleRegis\_Details.cshtml"
                                      
                                        List<char> charsToRemove = new List<char>() { '[', ']' };
                                        string str = @i.Value;
                                        foreach(char c in charsToRemove)
                                        {
                                            str = str.Replace(c.ToString(), String.Empty);
                                        }
                                        JObject json = JObject.Parse(str);
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <pre id=\"jsonocr\" class=\"tab-content mh-325\">");
#nullable restore
#line 59 "D:\Libra\OCR\WebOCR\WebOCR\Views\VehicleRegis\_Details.cshtml"
                                                                            Write(json);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</pre>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div> <!-- end col -->
</div> <!-- end row -->

<script>
    const tabs = document.querySelectorAll("".tab"");
    const tabContents = document.querySelectorAll("".tab-content"");

    for (let i = 0; i < tabs.length; i++) {
        const tab = tabs[i];
        tab.addEventListener(""click"", switchClass);
    }

    function switchClass(e) {
        e.preventDefault();
        for (let i = 0; i < tabs.length; i++) {
            const tab = tabs[i];
            tab.classList.remove(""active"");
            tabContents[i].classList.remove(""show-content"");
        }

        const index = Array.prototype.slice.call(e.target.parentElement.children).indexOf(e.target)

        e.target.classList.add(""active"");
        tabContents[index].classList.add(""show-content"");
    }

    function zoom");
            WriteLiteral(@"in() {
        var myImg = document.getElementById(""imageValue"");
        var currWidth = myImg.clientWidth;
        if (currWidth == 1000) return false;
        else {
            myImg.style.width = (currWidth + 100) + ""px"";
        }
    }

    function zoomout() {
        var myImg = document.getElementById(""imageValue"");
        var currWidth = myImg.clientWidth;
        if (currWidth == 100) return false;
        else {
            myImg.style.width = (currWidth - 100) + ""px"";
        }
    }

    function fullscreen() {
        var myImg = document.getElementById(""imageValue"");
        myImg.requestFullscreen();
    }

    let rotation = 0;
    function rotate() {
        rotation += 90;
        if (rotation === 360) {
            rotation = 0;
        }
        document.querySelector(""#imageValue"").style.transform = `rotate(${rotation}deg)`;
    }
</script>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreOCR.Model.VehicleRegistrations.VehicleRegistrationVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
