#pragma checksum "D:\asp_dotnet\aspboard\aspboard.mvc6\Views\Snack\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8b3c57ad78375d73d641e0f85ba3545cf9fa8cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Snack_Delete), @"mvc.1.0.view", @"/Views/Snack/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Snack/Delete.cshtml", typeof(AspNetCore.Views_Snack_Delete))]
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
#line 1 "D:\asp_dotnet\aspboard\aspboard.mvc6\Views\_ViewImports.cshtml"
using aspboard.mvc6;

#line default
#line hidden
#line 2 "D:\asp_dotnet\aspboard\aspboard.mvc6\Views\_ViewImports.cshtml"
using aspboard.mvc6.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8b3c57ad78375d73d641e0f85ba3545cf9fa8cc", @"/Views/Snack/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a9433bb4aff232fd4eef3a498dc02d0aea207bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Snack_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Snack", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\asp_dotnet\aspboard\aspboard.mvc6\Views\Snack\Delete.cshtml"
  

	var header = DateTime.Now.Month.ToString() + "월의 간식";

	List<string> most_s = new List<string>();
	var vote = 0;

	var Snack = Model;

	foreach (var snack in Snack)
	{
		if (snack.SnackVote >= vote && snack.SnackVote > 0)
		{
			vote = snack.SnackVote;
			most_s.Add(snack.SnackName);
		}
	}

#line default
#line hidden
            BeginContext(317, 145, true);
            WriteLiteral("\r\n<div class=\"container body-content\">\r\n\t<div class=\"row s_head\">\r\n\t\t<div class=\"col-lg-12 text-center\">\r\n\t\t\t<div class=\"s_info month_s header\"> ");
            EndContext();
            BeginContext(463, 6, false);
#line 23 "D:\asp_dotnet\aspboard\aspboard.mvc6\Views\Snack\Delete.cshtml"
                                           Write(header);

#line default
#line hidden
            EndContext();
            BeginContext(469, 49, true);
            WriteLiteral(" </div>\r\n\t\t\t<div class=\"s_info month_s most_s\">\r\n");
            EndContext();
#line 25 "D:\asp_dotnet\aspboard\aspboard.mvc6\Views\Snack\Delete.cshtml"
                 foreach (var msnack in most_s)
				{

#line default
#line hidden
            BeginContext(562, 12, true);
            WriteLiteral("\t\t\t\t\t<span> ");
            EndContext();
            BeginContext(575, 6, false);
#line 27 "D:\asp_dotnet\aspboard\aspboard.mvc6\Views\Snack\Delete.cshtml"
                      Write(msnack);

#line default
#line hidden
            EndContext();
            BeginContext(581, 10, true);
            WriteLiteral(" </span>\r\n");
            EndContext();
#line 28 "D:\asp_dotnet\aspboard\aspboard.mvc6\Views\Snack\Delete.cshtml"
				}

#line default
#line hidden
            BeginContext(598, 40, true);
            WriteLiteral("\t\t\t</div>\r\n\t\t\t<div class=\"s_info vote\"> ");
            EndContext();
            BeginContext(639, 15, false);
#line 30 "D:\asp_dotnet\aspboard\aspboard.mvc6\Views\Snack\Delete.cshtml"
                                 Write(vote.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(654, 254, true);
            WriteLiteral("표 </div>\r\n\t\t</div>\r\n\t\t<div class=\"col-sm-6 col-lg-6 text-left\">\r\n\t\t\t<a class=\"btn btn-info s_add\" href=\"#s_add\" data-toggle=\"modal\"> + </a>\r\n\t\t\t<label style=\"font-size:15px\">새 항목 추가하기</label>\r\n\t\t</div>\r\n\t\t<div class=\"col-sm-6 col-lg-6 text-right\">\r\n\t\t\t<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 908, "\"", 944, 1);
#line 37 "D:\asp_dotnet\aspboard\aspboard.mvc6\Views\Snack\Delete.cshtml"
WriteAttributeValue("", 915, Url.Action("Delete","Snack"), 915, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(945, 90, true);
            WriteLiteral(" class=\"btn btn-danger\"> delete </a>\r\n\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n\r\n<div class=\"row\">\r\n");
            EndContext();
#line 45 "D:\asp_dotnet\aspboard\aspboard.mvc6\Views\Snack\Delete.cshtml"
     foreach (var snack in Model)
	{

#line default
#line hidden
            BeginContext(1071, 128, true);
            WriteLiteral("\t\t<div class=\"col-sm-12 col-lg-6 text-center snack_list\">\r\n\t\t\t<div class=\"col-sm-8 col-lg-8 snack_info\">\r\n\t\t\t\t<div>\r\n\t\t\t\t\t<span>");
            EndContext();
            BeginContext(1200, 15, false);
#line 50 "D:\asp_dotnet\aspboard\aspboard.mvc6\Views\Snack\Delete.cshtml"
                     Write(snack.SnackName);

#line default
#line hidden
            EndContext();
            BeginContext(1215, 44, true);
            WriteLiteral("</span>\r\n\t\t\t\t\t<span style=\"color: #e73b63;\">");
            EndContext();
            BeginContext(1260, 26, false);
#line 51 "D:\asp_dotnet\aspboard\aspboard.mvc6\Views\Snack\Delete.cshtml"
                                             Write(snack.SnackVote.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1286, 31, true);
            WriteLiteral("표</span>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div>");
            EndContext();
            BeginContext(1318, 27, false);
#line 53 "D:\asp_dotnet\aspboard\aspboard.mvc6\Views\Snack\Delete.cshtml"
                Write(snack.SnackPrice.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1345, 60, true);
            WriteLiteral("원</div>\r\n\t\t\t</div>\r\n\t\t\t<div class=\"col-sm-4 col-lg-4\">\r\n\t\t\t\t");
            EndContext();
            BeginContext(1405, 225, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9ded8b694874e3f9f9ed4b589942790", async() => {
                BeginContext(1492, 38, true);
                WriteLiteral("\r\n\t\t\t\t\t<input type=\"hidden\" name=\"Sno\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1530, "\"", 1552, 1);
#line 57 "D:\asp_dotnet\aspboard\aspboard.mvc6\Views\Snack\Delete.cshtml"
WriteAttributeValue("", 1538, snack.SnackNo, 1538, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1553, 70, true);
                WriteLiteral(" />\r\n\t\t\t\t\t<button class=\"btn btn-default btn-vote\"> 삭제 </button>\r\n\t\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1630, 23, true);
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t</div>\r\n");
            EndContext();
#line 62 "D:\asp_dotnet\aspboard\aspboard.mvc6\Views\Snack\Delete.cshtml"
	}

#line default
#line hidden
            BeginContext(1657, 469, true);
            WriteLiteral(@"</div>

<!-- modal -->

<div class=""modal fade"" id=""s_add"">
	<div class=""modal-dialog modal-sm"">
		<div class=""modal-content"">
			<div class=""modal-header"">
				<button type=""button"" class=""close"" data-dismiss=""modal"">
					<span aria-hidden=""true"">x</span>
				</button>
				<div class=""mtitle"">
					<h4 class=""text-center""> 새롭게 추가하고 싶은 간식의</h4>
					<h4 class=""text-center""> 이름과 가격을 입력하세요. </h4>
				</div>
			</div>
			<div class=""modal-body"">
				");
            EndContext();
            BeginContext(2126, 511, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "552d6e6ad979420fa600a078311767f3", async() => {
                BeginContext(2210, 420, true);
                WriteLiteral(@"
					<div class=""form-group  text-center"">
						<input type=""text"" name=""Sname"" class=""form-control text-center"" placeholder=""이름을 입력하세요."" />
					</div>
					<div class=""form-group "">
						<input type=""number"" name=""Sprice"" class=""form-control text-center"" placeholder=""가격을 입력하세요."" />
					</div>
					<div class=""form-group"">
						<button type=""submit"" class=""btn btn-primary"">확인</button>
					</div>
				");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2637, 38, true);
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>");
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
