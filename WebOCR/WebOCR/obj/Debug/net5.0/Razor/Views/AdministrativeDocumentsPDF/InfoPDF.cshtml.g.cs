#pragma checksum "D:\OCR-Libra\WebOCR\WebOCR\Views\AdministrativeDocumentsPDF\InfoPDF.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdd057cc69517e9aa31e73248291ce369ad181fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdministrativeDocumentsPDF_InfoPDF), @"mvc.1.0.view", @"/Views/AdministrativeDocumentsPDF/InfoPDF.cshtml")]
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
#line 1 "D:\OCR-Libra\WebOCR\WebOCR\Views\_ViewImports.cshtml"
using WebOCR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OCR-Libra\WebOCR\WebOCR\Views\_ViewImports.cshtml"
using WebOCR.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdd057cc69517e9aa31e73248291ce369ad181fa", @"/Views/AdministrativeDocumentsPDF/InfoPDF.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a809702604a870cb2b029515769f904b3573e6a7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdministrativeDocumentsPDF_InfoPDF : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebOCR.Models.FileForm>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "file", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("inputFile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("accept", new global::Microsoft.AspNetCore.Html.HtmlString("application/pdf"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("showPreviewPDF(event);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Return"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AdministrativeDocumentsPDF", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("upload"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\OCR-Libra\WebOCR\WebOCR\Views\AdministrativeDocumentsPDF\InfoPDF.cshtml"
  
    ViewData["Title"] = "Expect Information";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Page-Title -->
<div class=""row"">
    <div class=""col-sm-12"">
        <div class=""page-title-box"">
            <div class=""btn-group float-left m-t-b-10"">
                <ul class=""des hide-phone p-0 m-0"">
                    <li><img src=""/assets/icons/file.png"" class=""center"" /><p><b>Step 1:</b> Upload File</p></li>
                    <li><img src=""/assets/icons/right-arrows.png"" class=""center m-b-10"" /></li>
                    <li><img src=""/assets/icons/submit.png"" class=""center"" /><p><b>Step 2:</b> Start OCR</p></li>
                    <li><img src=""/assets/icons/right-arrows.png"" class=""center m-b-10"" /></li>
                    <li><img src=""/assets/icons/result.png"" class=""center"" /><p><b>Step 3:</b> Get Result</p></li>
                    <li><img src=""/assets/icons/right-arrows.png"" class=""center m-b-10"" /></li>
                    <li><img src=""/assets/icons/diskette.png"" class=""center"" /><p><b>Step 4:</b> Save</p></li>
                </ul>
            </div>
            <di");
            WriteLiteral(@"v class=""btn-group float-right m-t-b-10 p-t-15"">
                <ol class=""breadcrumb hide-phone p-0 m-0"">
                    <li class=""breadcrumb-item""><a href=""#"">Libra</a></li>
                    <li class=""breadcrumb-item""><a href=""#"">Administrative Documents</a></li>
                    <li class=""breadcrumb-item active"">Expect Information</li>
                </ol>
            </div>
        </div>
    </div>
</div>
<!-- end page title end breadcrumb -->
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdd057cc69517e9aa31e73248291ce369ad181fa9103", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-12"">
            <div class=""card m-b-10"">
                <div class=""card-body p-t-5"">

                    <div class=""row"">
                        <div class=""col-sm-6 file-upload"">
                            <label for=""example-text-input"" class=""col-form-label""><b>1:</b> SELECT FILE NEED TO EXPECT INFORMATION </label>
                            <div class=""file-select"">
                                <div class=""file-select-button"" id=""fileName"">Choose File</div>
                                <div class=""file-select-name"" id=""noFile"">No file chosen...</div>
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cdd057cc69517e9aa31e73248291ce369ad181fa10051", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 44 "D:\OCR-Libra\WebOCR\WebOCR\Views\AdministrativeDocumentsPDF\InfoPDF.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.File);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
                        <div class=""col-sm-2 text-center m-t-36"">
                            <div class=""row"">
                                <label class=""col-sm-2 m-t-10""><b>2:</b></label>
                                <button name=""send"" type=""submit"" id=""submit"" runat=""server"" class=""col-sm-10 btn btn-primary btn-lg btn-block"">
                                    <i class=""fa fa-mouse-pointer""></i>  <b>Submit</b>
                                </button>
                            </div>
                        </div>
                        <div class=""col-sm-2 text-center m-t-36"">
                            <div class=""row"">
                                <label class=""col-sm-2 m-t-10""><b>4:</b></label>
                                <button id=""SaveResult"" class=""col-sm-10 btn btn-primary btn-lg btn-block"">
                                    <i class=""fa fa-save""></i>  <b>Save</b>
                               ");
                WriteLiteral(" </button>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-sm-2 text-center m-t-36\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdd057cc69517e9aa31e73248291ce369ad181fa13279", async() => {
                    WriteLiteral("\r\n                                <i class=\"fa fa-rotate-left\"></i>  Return\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        </div>\r\n");
                WriteLiteral(@"                    </div>
                </div>
            </div>
        </div> <!-- end col -->
    </div> <!-- end row -->

    <div class=""row"">
        <div class=""col-md-6"">
            <div class=""card mini-stat"">
                <div class=""p-l-r-20 bg-primary text-white"">
                    <div class=""mini-stat-icon"">
                        <i class=""mdi mdi-image float-right mb-0""></i>
                    </div>
                    <h6 class=""text-uppercase mb-0"">Image Preview</h6>
                </div>
                <div class=""card-body p-1r"">
                    <div class=""text-muted"">
                        <canvas id=""pdfViewer"" class=""img-fluid center max-height""></canvas>
                    </div>
                </div>
            </div>
        </div>

        <div class=""col-md-6"">
            <div class=""card mini-stat"">
                <div class=""p-l-r-20 bg-primary text-white"">
                    <div class=""mini-stat-icon"">
                     ");
                WriteLiteral(@"   <i class=""mdi mdi-file-check float-right mb-0""></i>
                    </div>
                    <h6 class=""text-uppercase mb-0"">OCR Result</h6>
                </div>
                <div class=""btn-group btn-group-toggle"">
                    <a class=""btn btn-outline-primary tab"">HTML</a>
                    <a class=""btn btn-outline-primary tab"">Json</a>
                </div>
                <div class=""card-body p-1r"">
                    <div class=""text-muted"">
                        <div id=""HTMLVal"">
                            <pre id=""textocr"" class=""tab-content mh-299""></pre>
                        </div>
                        <div id=""JsonVal"">
                            <pre id=""jsonocr"" class=""tab-content show-content mh-299""></pre>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    $('#inputFile').bind('change', function() {
        var filename = $(""#inputFile"").val();
        if (/^\s*$/.test(filename)) {
            $("".file-upload"").removeClass('active');
            $(""#noFile"").text(""No file chosen..."");
        }
        else {
            $("".file-upload"").addClass('active');
            $(""#noFile"").text(filename.replace(""C:\\fakepath\\"", """"));
        }
    });

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

        const index = Array.prototype.slice.call(e.target.parentElement.chi");
            WriteLiteral(@"ldren).indexOf(e.target)

        e.target.classList.add(""active"");
        tabContents[index].classList.add(""show-content"");
    }

    $(document).ready(function() {
        $('#inputFile').on('change', function(evt) {
            var input = document.getElementById('inputFile');

            if (input.files && input.files[0]) {
                let reader = new FileReader();
                reader.onload = (e) => {
                    let imgData = e.target.result;
                    let imgName = input.files[0].name;
                }
                reader.readAsDataURL(input.files[0]);
            }
        });
    });

    function getSafe(fn, defaultVal) {
      try {
          if (fn() == null) {
              return ''; 
          }
          else {        
              return fn();
          }
      } catch (e) {
        return defaultVal;
      }
    }

    $('#upload').submit(function(e) {
        e.preventDefault();

        if(document.getElementById('input");
            WriteLiteral(@"File').files.length == 0)
        {
            alertify.error(""NO FILES SELECTED!!!"");
        }

        var input = document.getElementById('inputFile');
        var formData = new FormData(this);

        $('#submit').html("""");
        jQuery('<span>', {
            id: 'loader',
            class: 'spinner-border spinner-border-sm',
            role: 'status'
        }).appendTo('#submit');
        $('#submit').append(""...Loading"");
        $('#submit').prop(""disabled"", true);
        $.ajax({
            type: 'POST',
            url: '/AdministrativeDocumentsPDF/GetInfoPDF',
            dataType: 'json',
            cache: false,
            contentType: false,
            processData: false,
            data: formData,
            success: function(response) {
                try {
                    $('#loader').hide();
                    if (response == """") {
                        $('#submit').html(""Submit"");
                        $('#submit').prop(""disabled"", fals");
            WriteLiteral(@"e);
                        $('#result').val(""Empty"");
                        return false;
                    }
                    $('#submit').html(""Submit"");
                    $('#submit').prop(""disabled"", false);
                    $('#result').text("""");
                    document.getElementById(""jsonocr"").innerHTML = JSON.stringify(response, undefined, 1);
                    let keys = Object.keys(response.value.noi_nhan_ben_trong);
                    let html = """";
                    html += ""<div class='textocr'>"";
                    html += ""<p>"" + ""<strong>S??? k?? hi???u: </strong>"" + (getSafe(() => response.value.so_ky_hieu, '')) + ""</p>""
                    html += ""<p>"" + ""<strong>S??? trang: </strong>"" + (getSafe(() => response.value.so_trang, '')) + ""</p>""
                    html += ""<p>"" + ""<strong>T??n v??n b???n: </strong>"" + (getSafe(() => response.value.ten_van_ban, '')) + ""</p>""
                    html += ""<p>"" + ""<strong>Tr??ch y???u: </strong>"" + (getSafe(() => response.va");
            WriteLiteral(@"lue.trich_yeu, '')) + ""</p>""
                    html += ""<p>"" + ""<strong>Ng?????i k??: </strong>"" + (getSafe(() => response.value.nguoi_ky, '')) + ""</p>""
                    html += ""<p>"" + ""<strong>Ch???c v???: </strong>"" + (getSafe(() => response.value.chuc_vu, '')) + ""</p>""
                    html += ""<p>"" + ""<strong>C?? quan ban h??nh: </strong>"" + (getSafe(() => response.value.co_quan_ban_hanh, '')) + ""</p>""
                    html += ""<p>"" + ""<strong>Lo???i v??n b???n: </strong>"" + (getSafe(() => response.value.doc_type, '')) + ""</p>""
                    html += ""<p>"" + ""<strong>Ng??n ng???: </strong>"" + (getSafe(() => response.value.lang, '')) + ""</p>""
                    html += ""<p>"" + ""<strong>Ng??y ban h??nh: </strong>"" + (getSafe(() => response.value.ngay_ban_hanh.ngay, ''))  + (getSafe(() => response.value.ngay_ban_hanh.thang, ''))  + (getSafe(() => response.value.ngay_ban_hanh.nam, '')) + ""</p>""
                    html += '<div class=""row"">'
                    html += '<label for=""insideReceiver"" class");
            WriteLiteral(@"=""m-l-15"" ><strong>N??i nh???n b??n trong: </strong></label>'
                        html += '<select name=""insideReceiver"" class=""m-b-10"">'
                        keys.forEach((key) => {
                            html += ""<option>"" + response.value.noi_nhan_ben_trong[key] + ""</option>""
                        })
                        html += ""</select>""
                    html += ""</div>"";
                    document.getElementById(""textocr"").innerHTML = html;
                    alertify.success(""DONE!!"");
                } catch (err) {
                    console.log('Error: ', err.message);
                    alertify.error(""ERROR!!!"");
                }
            },
            error: function(e) {
                $('#submit').html(""Submit"");
                $('#submit').prop(""disabled"", false);
            }
        });
    });

    $('#SaveResult').click(function(e) {
        e.preventDefault();
        var input = document.getElementById('inputFile');
        var size =");
            WriteLiteral(@" Math.round(input.files[0].size / 1024);
        const jsonValue = document.getElementById('jsonocr').innerHTML;
        const htmlValue = document.getElementById('textocr').innerHTML;
        var formData = new FormData();
        formData.append('file', input.files[0]);
        formData.append('imageSize', size);
        formData.append('jsonValue', jsonValue);
        formData.append('htmlValue', htmlValue);

        if (htmlValue.length == 0 || jsonValue.length == 0) {
            alertify.error(""PLEASE SUBMIT BEFORE SAVE!!"");
        } else {
            $.ajax({
                type: ""POST"",
                url: ""/AdministrativeDocumentsPDF/SavePDF"",
                cache: false,
                contentType: false,
                processData: false,
                data: formData,
                success: function(e) {
                    alertify.success(""SAVE SUCCESSFULLY!"");
                },
                error: function(err) {
                    console.log(err);
      ");
            WriteLiteral(@"          }
            });
        }
    });

    function showPreviewPDF(e)
    {
        // Loaded via <script> tag, create shortcut to access PDF.js exports.
        var pdfjsLib = window['pdfjs-dist/build/pdf'];
        // The workerSrc property shall be specified.
        pdfjsLib.GlobalWorkerOptions.workerSrc = 'https://mozilla.github.io/pdf.js/build/pdf.worker.js';

        var file = e.target.files[0]
        if (file.type == ""application/pdf"") {
            var fileReader = new FileReader();
            fileReader.onload = function () {
                var pdfData = new Uint8Array(this.result);
                // Using DocumentInitParameters object to load binary data.
                var loadingTask = pdfjsLib.getDocument({ data: pdfData });
                loadingTask.promise.then(function (pdf) {

                    // Fetch the first page
                    var pageNumber = 1;
                    pdf.getPage(pageNumber).then(function (page) {

                        v");
            WriteLiteral(@"ar scale = 1.5;
                        var viewport = page.getViewport({ scale: scale });

                        // Prepare canvas using PDF page dimensions
                        var canvas = $(""#pdfViewer"")[0];
                        var context = canvas.getContext('2d');
                        canvas.height = viewport.height;
                        canvas.width = viewport.width;

                        // Render PDF page into canvas context
                        var renderContext = {
                            canvasContext: context,
                            viewport: viewport
                        };
                        var renderTask = page.render(renderContext);
                    });
                }, function (reason) {
                    // PDF loading error
                    console.error(reason);
                });
            };
            fileReader.readAsArrayBuffer(file);
        }
    }

    $('#ClearResult').click(function(e) {
        e.pr");
            WriteLiteral(@"eventDefault();
        $('#ipImageSize').val("""");
        $('#ipCreateDate').val("""");
        $('#ipImageName').val("""");
        var input = document.getElementById('inputFile');
        var canvas = $(""#pdfViewer"")[0];
        const context = canvas.getContext('2d');
        context.clearRect(0, 0, canvas.width, canvas.height);
        $("".file-upload"").removeClass('active');
        $(""#noFile"").text(""No file chosen..."");
        document.getElementById(""jsonocr"").innerHTML = """";
        document.getElementById(""textocr"").innerHTML = """";
        alertify.success(""ALL CLEAR!!"");
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebOCR.Models.FileForm> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
