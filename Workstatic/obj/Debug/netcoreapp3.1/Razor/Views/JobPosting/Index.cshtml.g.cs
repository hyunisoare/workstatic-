#pragma checksum "D:\C#Projects\Workstatic\Workstatic\Views\JobPosting\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b85b09853557d5a759c4cc09f7e809accb71682"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_JobPosting_Index), @"mvc.1.0.view", @"/Views/JobPosting/Index.cshtml")]
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
#line 1 "D:\C#Projects\Workstatic\Workstatic\Views\_ViewImports.cshtml"
using Workstatic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#Projects\Workstatic\Workstatic\Views\_ViewImports.cshtml"
using Workstatic.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b85b09853557d5a759c4cc09f7e809accb71682", @"/Views/JobPosting/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4f82b31743efb5ecd42cb29d611c28dd5e5ce1e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_JobPosting_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<JobPosting>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "JobPosting", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateEditJobPosting", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\C#Projects\Workstatic\Workstatic\Views\JobPosting\Index.cshtml"
  
	ViewData["Title"] = "Deine Inserate";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b85b09853557d5a759c4cc09f7e809accb716824651", async() => {
                WriteLiteral("Neues Inserat anlegen");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<hr />\r\n\r\n<table id=\"jobPostingTable\" class=\"table table-bordered table-striped table-hover\">\r\n\t<thead class=\"thead-dark\">\r\n\t\t<tr>\r\n\t\t\t<th>Job Title</th>\r\n\t\t\t<th>Ort</th>\r\n\t\t\t<th>Firmenname</th>\r\n\t\t\t<th>Aktionen</th>\r\n\t\t</tr>\r\n\t</thead>\r\n\r\n\t<tbody>\r\n");
#nullable restore
#line 21 "D:\C#Projects\Workstatic\Workstatic\Views\JobPosting\Index.cshtml"
          
			foreach (JobPosting jobPosting in Model)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 25 "D:\C#Projects\Workstatic\Workstatic\Views\JobPosting\Index.cshtml"
                       Write(jobPosting.JobTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 26 "D:\C#Projects\Workstatic\Workstatic\Views\JobPosting\Index.cshtml"
                       Write(jobPosting.JobLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td>");
#nullable restore
#line 27 "D:\C#Projects\Workstatic\Workstatic\Views\JobPosting\Index.cshtml"
                       Write(jobPosting.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td> \r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b85b09853557d5a759c4cc09f7e809accb716827476", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "D:\C#Projects\Workstatic\Workstatic\Views\JobPosting\Index.cshtml"
                                 WriteLiteral(jobPosting.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t<button");
            BeginWriteAttribute("onclick", " onclick=\"", 790, "\"", 835, 3);
            WriteAttributeValue(" ", 800, "onClickedDeleteBtn(", 801, 20, true);
#nullable restore
#line 30 "D:\C#Projects\Workstatic\Workstatic\Views\JobPosting\Index.cshtml"
WriteAttributeValue("", 820, jobPosting.Id, 820, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 834, ")", 834, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</button>\r\n\t\t\t\t\t \t</td>\r\n\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 33 "D:\C#Projects\Workstatic\Workstatic\Views\JobPosting\Index.cshtml"
			}
		

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</tbody>\r\n</table>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
			<script> // for DataTable 
				$(document).ready( function () {
				$('#jobPostingTable').DataTable();
				} );

				// for Delete-Dialog
				function onClickedDeleteBtn(id){
									Swal.fire({
					title: 'Möchtest du das Inserat wirklich löschen?',
					icon: 'error',
					showCloseButton: true,
					focusConfirm: false,
					confirmButtonText:
						'Ja, löschen!',
				}).then((result) => {
					if (result.isConfirmed) {

						// Backend call to delete job posting by id
						$.ajax({
							type: ""POST"",
							url: """);
#nullable restore
#line 59 "D:\C#Projects\Workstatic\Workstatic\Views\JobPosting\Index.cshtml"
                             Write(Url.Action("DeleteJobPostingById"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
							data: { id: id },
							success: function (msg) {
								Swal.fire('Wurde gelöscht!', '', 'success').then((result) => {
									location.reload();                                
								});
							},
							error: function (msg) {
								Swal.fire('Ups, etwas ist schief gelaufen!', '', 'error')
							}
						});
					}
				})
			}	

		</script>
");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<JobPosting>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
