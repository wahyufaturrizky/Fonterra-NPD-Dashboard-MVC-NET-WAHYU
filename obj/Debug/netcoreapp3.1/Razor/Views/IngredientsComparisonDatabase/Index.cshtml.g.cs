#pragma checksum "C:\ASPNetProject\fonterra-npd-dashboard-mvc-net\Views\IngredientsComparisonDatabase\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5c69cd43ab82353f1f49a7a77c7a987b4443a72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_IngredientsComparisonDatabase_Index), @"mvc.1.0.view", @"/Views/IngredientsComparisonDatabase/Index.cshtml")]
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
#line 1 "C:\ASPNetProject\fonterra-npd-dashboard-mvc-net\Views\_ViewImports.cshtml"
using hera;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ASPNetProject\fonterra-npd-dashboard-mvc-net\Views\_ViewImports.cshtml"
using hera.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5c69cd43ab82353f1f49a7a77c7a987b4443a72", @"/Views/IngredientsComparisonDatabase/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c9d1f956446b6194dc1f4f62d64ba91194c0519", @"/Views/_ViewImports.cshtml")]
    public class Views_IngredientsComparisonDatabase_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
#line 1 "C:\ASPNetProject\fonterra-npd-dashboard-mvc-net\Views\IngredientsComparisonDatabase\Index.cshtml"
  
ViewData["Title"] = "Recipe Ingredients Database";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<div class=""content"">
	<div class=""row"">
		<div class=""col-md-12"">
			<div class=""card "">
				<div class=""card-header"">
					<h4 class=""card-title""> Ingredients Comparison Table</h4>
					<div class=""row"">
						<div class=""col-md-12"">
							<button type=""button"" data-toggle=""modal"" data-target="".add-data"" class=""btn btn-primary float-right ml-5"">
								Add Data
							</button>
							<div class=""float-right"">
								<input type=""text"" class=""btn form-control border border-light"" placeholder=""Search data here"">
							</div>
						</div>
					</div>
				</div>
				<div class=""card-body"">
					<div class=""table-responsive"">
						<table class=""table tablesorter """);
            BeginWriteAttribute("id", " id=\"", 781, "\"", 786, 0);
            EndWriteAttribute();
            WriteLiteral(@">
							<thead class="" text-primary"">
								<tr>
									<th>
										No
									</th>
									<th>
										Name
									</th>
									<th>
										Unit of Measurement
									</th>
									<th>
										Group
									</th>
									<th class=""text-center"" colspan=""2"">
										Recipe A
									</th>
									<th class=""text-center"" colspan=""2"">
										Recipe B
									</th>
									<th>
										Competitor X
									</th>
									<th>
										Action
									</th>
								</tr>
							</thead>
							<tbody>
								<tr>
									<td>
										1
									</td>
									<td>
										Lorem Ipsum
									</td>
									<td>
										Lorem Ipsum
									</td>
									<td>
										Lorem Ipsum
									</td>
									<td>
										Lorem Ipsum
									</td>
									<td>
										Lorem Ipsum
									</td>
									<td>
										Lorem Ipsum
									</td>
									<td>
										Lorem Ipsum
									</td>
									<td>");
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\tLorem Ipsum\r\n\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t<td class=\"td-actions text-left\">\r\n\t\t\t\t\t\t\t\t\t\t<button type=\"button\" data-toggle=\"modal\" data-target=\".view-data\" rel=\"tooltip\"");
            BeginWriteAttribute("title", " title=\"", 1986, "\"", 1994, 0);
            EndWriteAttribute();
            WriteLiteral(@"
											class=""btn btn-link"" data-original-title=""Edit Task"">
											<i class=""tim-icons icon-zoom-split text-white""></i>
										</button>
									</td>
									<td class=""td-actions text-left"">
										<button data-toggle=""modal"" data-target="".edit-data"" type=""button"" rel=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 2299, "\"", 2307, 0);
            EndWriteAttribute();
            WriteLiteral(@"
											class=""btn btn-link"" data-original-title=""Edit Task"">
											<i class=""tim-icons icon-pencil text-white""></i>
										</button>
									</td>
									<td class=""td-actions text-left"">
										<button type=""button"" data-toggle=""modal"" data-target="".delete-data"" rel=""tooltip""");
            BeginWriteAttribute("title", " title=\"", 2610, "\"", 2618, 0);
            EndWriteAttribute();
            WriteLiteral(@"
											class=""btn btn-link"" data-original-title=""Edit Task"">
											<i class=""tim-icons icon-trash-simple text-white""></i>
										</button>
									</td>
								</tr>
							</tbody>
						</table>
					</div>
				</div>
			</div>
		</div>
	</div>
</div>
");
            WriteLiteral("\r\n");
            WriteLiteral(@"<div class=""modal fade add-data"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myLargeModalLabel"" aria-hidden=""true"">
	<div class=""modal-dialog modal-lg"">
		<div class=""card"">
			<div class=""card-header"">
				<h5 class=""title"">Add Data</h5>
			</div>
			<div class=""card-body"">
				");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5c69cd43ab82353f1f49a7a77c7a987b4443a727465", async() => {
                WriteLiteral("\r\n\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t<div class=\"col-md-5 pr-md-1\">\r\n\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t<label>Company (disabled)</label>\r\n\t\t\t\t\t\t\t\t<input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("disabled", " disabled=\"", 3437, "\"", 3448, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Company"" value=""Creative Code Inc."">
							</div>
						</div>
						<div class=""col-md-3 px-md-1"">
							<div class=""form-group"">
								<label>Username</label>
								<input type=""text"" class=""form-control"" placeholder=""Username"" value=""michael23"">
							</div>
						</div>
						<div class=""col-md-4 pl-md-1"">
							<div class=""form-group"">
								<label for=""exampleInputEmail1"">Email address</label>
								<input type=""email"" class=""form-control"" placeholder=""mike@email.com"">
							</div>
						</div>
					</div>
					<div class=""row"">
						<div class=""col-md-6 pr-md-1"">
							<div class=""form-group"">
								<label>First Name</label>
								<input type=""text"" class=""form-control"" placeholder=""Company"" value=""Mike"">
							</div>
						</div>
						<div class=""col-md-6 pl-md-1"">
							<div class=""form-group"">
								<label>Last Name</label>
								<input type=""text"" class=""form-control"" placeholder=""Last Name"" value=""Andrew"">
							</div>
						</di");
                WriteLiteral(@"v>
					</div>
					<div class=""row"">
						<div class=""col-md-12"">
							<div class=""form-group"">
								<label>Address</label>
								<input type=""text"" class=""form-control"" placeholder=""Home Address""
									value=""Bld Mihail Kogalniceanu, nr. 8 Bl 1, Sc 1, Ap 09"">
							</div>
						</div>
					</div>
					<div class=""row"">
						<div class=""col-md-4 pr-md-1"">
							<div class=""form-group"">
								<label>City</label>
								<input type=""text"" class=""form-control"" placeholder=""City"" value=""Mike"">
							</div>
						</div>
						<div class=""col-md-4 px-md-1"">
							<div class=""form-group"">
								<label>Country</label>
								<input type=""text"" class=""form-control"" placeholder=""Country"" value=""Andrew"">
							</div>
						</div>
						<div class=""col-md-4 pl-md-1"">
							<div class=""form-group"">
								<label>Postal Code</label>
								<input type=""number"" class=""form-control"" placeholder=""ZIP Code"">
							</div>
						</div>
					</div>
					<div class=""row"">");
                WriteLiteral(@"
						<div class=""col-md-8"">
							<div class=""form-group"">
								<label>About Me</label>
								<textarea rows=""4"" cols=""80"" class=""form-control"" placeholder=""Here can be your description""
									value=""Mike"">Lamborghini Mercy, Your chick she so thirsty, I'm in that two seat Lambo.</textarea>
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t\t<div class=\"card-footer\">\r\n\t\t\t\t<button type=\"submit\" class=\"btn btn-fill btn-primary float-right\">Add Data</button>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"<div class=""modal fade edit-data"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myLargeModalLabel"" aria-hidden=""true"">
	<div class=""modal-dialog modal-lg"">
		<div class=""card"">
			<div class=""card-header"">
				<h5 class=""title"">Edit Data</h5>
			</div>
			<div class=""card-body"">
				");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5c69cd43ab82353f1f49a7a77c7a987b4443a7212273", async() => {
                WriteLiteral("\r\n\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t<div class=\"col-md-5 pr-md-1\">\r\n\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t<label>Company (disabled)</label>\r\n\t\t\t\t\t\t\t\t<input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("disabled", " disabled=\"", 6570, "\"", 6581, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Company"" value=""Creative Code Inc."">
							</div>
						</div>
						<div class=""col-md-3 px-md-1"">
							<div class=""form-group"">
								<label>Username</label>
								<input type=""text"" class=""form-control"" placeholder=""Username"" value=""michael23"">
							</div>
						</div>
						<div class=""col-md-4 pl-md-1"">
							<div class=""form-group"">
								<label for=""exampleInputEmail1"">Email address</label>
								<input type=""email"" class=""form-control"" placeholder=""mike@email.com"">
							</div>
						</div>
					</div>
					<div class=""row"">
						<div class=""col-md-6 pr-md-1"">
							<div class=""form-group"">
								<label>First Name</label>
								<input type=""text"" class=""form-control"" placeholder=""Company"" value=""Mike"">
							</div>
						</div>
						<div class=""col-md-6 pl-md-1"">
							<div class=""form-group"">
								<label>Last Name</label>
								<input type=""text"" class=""form-control"" placeholder=""Last Name"" value=""Andrew"">
							</div>
						</di");
                WriteLiteral(@"v>
					</div>
					<div class=""row"">
						<div class=""col-md-12"">
							<div class=""form-group"">
								<label>Address</label>
								<input type=""text"" class=""form-control"" placeholder=""Home Address""
									value=""Bld Mihail Kogalniceanu, nr. 8 Bl 1, Sc 1, Ap 09"">
							</div>
						</div>
					</div>
					<div class=""row"">
						<div class=""col-md-4 pr-md-1"">
							<div class=""form-group"">
								<label>City</label>
								<input type=""text"" class=""form-control"" placeholder=""City"" value=""Mike"">
							</div>
						</div>
						<div class=""col-md-4 px-md-1"">
							<div class=""form-group"">
								<label>Country</label>
								<input type=""text"" class=""form-control"" placeholder=""Country"" value=""Andrew"">
							</div>
						</div>
						<div class=""col-md-4 pl-md-1"">
							<div class=""form-group"">
								<label>Postal Code</label>
								<input type=""number"" class=""form-control"" placeholder=""ZIP Code"">
							</div>
						</div>
					</div>
					<div class=""row"">");
                WriteLiteral(@"
						<div class=""col-md-8"">
							<div class=""form-group"">
								<label>About Me</label>
								<textarea rows=""4"" cols=""80"" class=""form-control"" placeholder=""Here can be your description""
									value=""Mike"">Lamborghini Mercy, Your chick she so thirsty, I'm in that two seat Lambo.</textarea>
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t\t<div class=\"card-footer\">\r\n\t\t\t\t<button type=\"submit\" class=\"btn btn-fill btn-primary float-right\">Save Data</button>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"<div class=""modal fade view-data"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myLargeModalLabel"" aria-hidden=""true"">
	<div class=""modal-dialog modal-lg"">
		<div class=""card"">
			<div class=""card-header"">
				<h5 class=""title"">Detail Data</h5>
			</div>
			<div class=""card-body"">
				");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5c69cd43ab82353f1f49a7a77c7a987b4443a7217081", async() => {
                WriteLiteral("\r\n\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t<div class=\"col-md-5 pr-md-1\">\r\n\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t<label>Company (disabled)</label>\r\n\t\t\t\t\t\t\t\t<input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("disabled", " disabled=\"", 9705, "\"", 9716, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Company"" value=""Creative Code Inc."">
							</div>
						</div>
						<div class=""col-md-3 px-md-1"">
							<div class=""form-group"">
								<label>Username</label>
								<input type=""text"" class=""form-control"" placeholder=""Username"" value=""michael23"">
							</div>
						</div>
						<div class=""col-md-4 pl-md-1"">
							<div class=""form-group"">
								<label for=""exampleInputEmail1"">Email address</label>
								<input type=""email"" class=""form-control"" placeholder=""mike@email.com"">
							</div>
						</div>
					</div>
					<div class=""row"">
						<div class=""col-md-6 pr-md-1"">
							<div class=""form-group"">
								<label>First Name</label>
								<input type=""text"" class=""form-control"" placeholder=""Company"" value=""Mike"">
							</div>
						</div>
						<div class=""col-md-6 pl-md-1"">
							<div class=""form-group"">
								<label>Last Name</label>
								<input type=""text"" class=""form-control"" placeholder=""Last Name"" value=""Andrew"">
							</div>
						</di");
                WriteLiteral(@"v>
					</div>
					<div class=""row"">
						<div class=""col-md-12"">
							<div class=""form-group"">
								<label>Address</label>
								<input type=""text"" class=""form-control"" placeholder=""Home Address""
									value=""Bld Mihail Kogalniceanu, nr. 8 Bl 1, Sc 1, Ap 09"">
							</div>
						</div>
					</div>
					<div class=""row"">
						<div class=""col-md-4 pr-md-1"">
							<div class=""form-group"">
								<label>City</label>
								<input type=""text"" class=""form-control"" placeholder=""City"" value=""Mike"">
							</div>
						</div>
						<div class=""col-md-4 px-md-1"">
							<div class=""form-group"">
								<label>Country</label>
								<input type=""text"" class=""form-control"" placeholder=""Country"" value=""Andrew"">
							</div>
						</div>
						<div class=""col-md-4 pl-md-1"">
							<div class=""form-group"">
								<label>Postal Code</label>
								<input type=""number"" class=""form-control"" placeholder=""ZIP Code"">
							</div>
						</div>
					</div>
					<div class=""row"">");
                WriteLiteral(@"
						<div class=""col-md-8"">
							<div class=""form-group"">
								<label>About Me</label>
								<textarea rows=""4"" cols=""80"" class=""form-control"" placeholder=""Here can be your description""
									value=""Mike"">Lamborghini Mercy, Your chick she so thirsty, I'm in that two seat Lambo.</textarea>
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t\t<div class=\"card-footer\">\r\n\t\t\t\t<button type=\"submit\" class=\"btn btn-fill btn-primary float-right\">Cancel</button>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"<div class=""modal fade delete-data"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myLargeModalLabel"" aria-hidden=""true"">
	<div class=""modal-dialog modal-lg"">
		<div class=""card"">
			<div class=""card-header"">
				<h5 class=""title"">Delete Data</h5>
			</div>
			<div class=""card-body"">
				<div class=""text-center"">
					<h2>Are you sure you want to delete this data? </h2>
					<h4 class=""text-muted"">You not be able to recover it</h4>
				</div>
			</div>
			<div class=""card-footer"">
				<button type=""submit"" class=""btn btn-fill btn-primary float-right ml-4"">Yes, Delete it</button>
				<button type=""submit"" class=""btn btn-fill btn-secondary float-right"">Cancel</button>
			</div>
		</div>
	</div>
</div>
");
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
