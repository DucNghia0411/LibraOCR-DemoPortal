#pragma checksum "D:\OCR-Libra\WebOCR\WebOCR\Views\VehicleRegis\Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a59a2aaa5505046127731902abbabaa1c28dddf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VehicleRegis_Info), @"mvc.1.0.view", @"/Views/VehicleRegis/Info.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a59a2aaa5505046127731902abbabaa1c28dddf", @"/Views/VehicleRegis/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a809702604a870cb2b029515769f904b3573e6a7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_VehicleRegis_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebOCR.Models.FileForm>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "file", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("inputFile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("accept", new global::Microsoft.AspNetCore.Html.HtmlString("image/*"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("showPreview(event);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Return"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "VehicleRegis", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\OCR-Libra\WebOCR\WebOCR\Views\VehicleRegis\Info.cshtml"
  
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
                    <li class=""breadcrumb-item""><a href=""#"">Vehicle Regstration</a></li>
                    <li class=""breadcrumb-item active"">Expect Information</li>
                </ol>
            </div>
        </div>
    </div>
</div>
<!-- end page title end breadcrumb -->
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a59a2aaa5505046127731902abbabaa1c28dddf8971", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-12"">
            <div class=""card m-b-10"">
                <div class=""card-body p-t-5"">

                    <div class=""row"">
                        <div class=""col-sm-6 file-upload"">
                            <label for=""example-text-input"" class=""col-form-label""><b>1:</b> SELECT FILE NEED TO EXPECT INFORMATION: </label>
                            <div class=""file-select"">
                                <div class=""file-select-button"" id=""fileName"">Choose File</div>
                                <div class=""file-select-name"" id=""noFile"">No file chosen...</div>
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0a59a2aaa5505046127731902abbabaa1c28dddf9920", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 44 "D:\OCR-Libra\WebOCR\WebOCR\Views\VehicleRegis\Info.cshtml"
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
                WriteLiteral(" </button>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"col-sm-2 text-center   m-t-36\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a59a2aaa5505046127731902abbabaa1c28dddf13132", async() => {
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
                        <img id=""image_input"" class=""img-fluid center mh-350"">
                    </div>
                </div>
            </div>
        </div>

        <div class=""col-md-6"">
            <div class=""card mini-stat"">
                <div class=""p-l-r-20 bg-primary text-white"">
                    <div class=""mini-stat-icon"">
                        <i class=""m");
                WriteLiteral(@"di mdi-file-check float-right mb-0""></i>
                    </div>
                    <h6 class=""text-uppercase mb-0"">OCR Result</h6>
                </div>
                <div class=""btn-group btn-group-toggle"">
                    <a  class=""btn btn-outline-primary tab"">HTML</a>
                    <a  class=""btn btn-outline-primary tab"">Json</a>
                </div>
                <div class=""card-body p-1r"">
                    <div class=""text-muted"">
                        <div id=""HTMLVal"">
                            <pre id=""textocr"" class=""tab-content show-content mh-299""></pre>
                        </div>
                        <div id=""JsonVal"">
                            <pre id=""jsonocr"" class=""tab-content mh-299""></pre>
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

    //$(document).ready(function() {
    //    var fileName = ""myfile.txt"";
    //    const jsonValue = document.getElementById('jsonocr');
    //    const htmlValue = document.getElementById('textocr');
    //    var fileContent = ""'"" + jsonValue + ""'"";


    //    console.log(jsonValue);
    //    console.log(htmlValue);

    //    var myFile = new Blob([");
            WriteLiteral(@"fileContent], {type: 'text/plain'});
    //    window.URL = window.URL || window.webkitURL;
    //    var dlBtn = document.getElementById(""download"");

    //    dlBtn.setAttribute(""href"", window.URL.createObjectURL(myFile));
    //    dlBtn.setAttribute(""download"", fileName);
    //})

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

        if(document.getElementById('inputFile').files.length == 0)
        {
            alertify.error(""NO FILES SELECTED!!!"");
        }

        var input = document.getElementById('inputFile');
        var formData = new FormData(this);

        $('#submit').html("""");
        jQuery('<span>', {
            id: 'loader',
            class: 'spinner-border spinner-border-sm',
       ");
            WriteLiteral(@"     role: 'status'
        }).appendTo('#submit');
        $('#submit').append(""...Loading"");
        $('#submit').prop(""disabled"", true);
        $.ajax({
            type: 'POST',
            url: '/VehicleRegis/GetInfo',
            dataType: 'json',
            cache: false,
            contentType: false,
            processData: false,
            data: formData,
            success: function(response) {
                try {
                    $('#loader').hide();
                    if (response == """") {
                        $('#submit').html(""<i class='fa fa-mouse-pointer'></i>  Submit"");
                        $('#submit').prop(""disabled"", false);
                        $('#result').val(""Empty"");
                        return false;
                    }
                    $('#submit').html(""<i class='fa fa-mouse-pointer'></i>  Submit"");
                    $('#submit').prop(""disabled"", false);
                    $('#result').text("""");
                    document.g");
            WriteLiteral(@"etElementById(""jsonocr"").innerHTML = JSON.stringify(response, undefined, 1);
                    let html = """";
                    html += ""<div id='htmlResult' class='textocr'>"";
                    html += ""<p>"" + ""<strong>Lo???i v??n b???n: </strong>"" + (getSafe(() => response[0].value.loai_hinh_dang_ky, '')) + ""</p>""
                    html += ""<p>-------------------M???t tr?????c------------------</p>""
                    html += ""<p>"" + ""<strong>Lo???i h??nh ????ng k??: </strong>"" + (getSafe(() => response[0].value.loai_vb, '')) + ""</p>""
                    html += ""<p>"" + ""<strong>N??i c???p: </strong>"" + (getSafe(() => response[0].value.noi_cap, '')) + ""</p>""
                    html += ""<p>"" + ""<strong>S???: </strong>"" + (getSafe(() => response[0].value.so, '')) + ""</p>""
                    html += ""<p>-------------------M???t sau------------------</p>""
                    html += ""<p>"" + ""<strong>T??n ch??? xe: </strong>"" + (getSafe(() => response[0].value.ten_nguoi, '')) + ""</p>""
                    html += ""<p>");
            WriteLiteral(@""" + ""<strong>Bi???n s??? xe: </strong>"" + (getSafe(() => response[0].value.bien_so_xe, '')) + ""</p>""
                    html += ""<p>"" + ""<strong>?????a ch???: </strong>"" + (getSafe(() => response[0].value.dia_chi, '')) + ""</p>""
                    html += ""<p>"" + ""<strong>Dung t??ch: </strong>"" + (getSafe(() => response[0].value.dung_tich, '')) + ""</p>""
                    html += ""<p>"" + ""<strong>Lo???i v??n b???n: </strong>"" + (getSafe(() => response[0].value.loai_vb, '')) + ""</p>""
                    html += ""<p>"" + ""<strong>Lo???i xe: </strong>"" + (getSafe(() => response[0].value.loai_xe, '')) + ""</p>""
                    html += ""<p>"" + ""<strong>M??u s??n: </strong>"" + (getSafe(() => response[0].value.mau_son, '')) + ""</p>""
                    html += ""<p>"" + ""<strong>Ng??y c???p: </strong>"" + (getSafe(() => response[0].value.ngay_cap.ngay, ''))  + (getSafe(() => response[0].value.ngay_cap.thang, ''))  + (getSafe(() => response[0].value.ngay_cap.nam, '')) + ""</p>""
                    html += ""<p>"" + ""<strong>Nh??n hi???u");
            WriteLiteral(@": </strong>"" + (getSafe(() => response[0].value.nhan_hieu, '')) + ""</p>""
                    html += ""<p>"" + ""<strong>S??? ch??? ng???i: </strong>"" + (getSafe(() => response[0].value.so_cho_ngoi, '')) + ""</p>""
                    html += ""<p>"" + ""<strong>S??? khung: </strong>"" + (getSafe(() => response[0].value.so_khung, '')) + ""</p>""
                    html += ""<p>"" + ""<strong>S??? m??y: </strong>"" + (getSafe(() => response[0].value.so_may, '')) + ""</p>""
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
        e.prevent");
            WriteLiteral(@"Default();
        var input = document.getElementById('inputFile');
        var size = Math.round(input.files[0].size / 1024);
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
            url: ""/VehicleRegis/Save"",
            cache: false,
            contentType: false,
            processData: false,
            data: formData,
            success: function(e) {
                alertify.success(""SAVE SUCCESSFULLY!"");
                console.log(e);
            },
            erro");
            WriteLiteral(@"r: function(err) {
                console.log(err);
            }
        });
        }
    });

    function showPreview(event) {
        if (event.target.files.length > 0) {
            var src = URL.createObjectURL(event.target.files[0]);
            var preview = document.getElementById(""image_input"");
            preview.src = src;
            preview.style.display = ""block"";
        }
    };

    $('#ClearResult').click(function(e) {
        e.preventDefault();
        $('#ipImageSize').val("""");
        $('#ipCreateDate').val("""");
        $('#ipImageName').val("""");
        var input = document.getElementById('inputFile');
        $(""#image_input"").attr('src', '');
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
