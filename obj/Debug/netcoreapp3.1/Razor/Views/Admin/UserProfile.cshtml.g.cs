#pragma checksum "/home/robert/Projects/EKnjiznica/Views/Admin/UserProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5456e526f590dcb3e9838312be9a1e3688970460"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UserProfile), @"mvc.1.0.view", @"/Views/Admin/UserProfile.cshtml")]
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
#line 1 "/home/robert/Projects/EKnjiznica/Views/_ViewImports.cshtml"
using EKnjiznica;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/robert/Projects/EKnjiznica/Views/_ViewImports.cshtml"
using EKnjiznica.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5456e526f590dcb3e9838312be9a1e3688970460", @"/Views/Admin/UserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7348b2845bf1ad1c7615cd9f56ab1cb22b976403", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UserProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EKnjiznica.Dtos.ProfileViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "number", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("step", new global::Microsoft.AspNetCore.Html.HtmlString("0.01"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddCredit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    \n");
#nullable restore
#line 3 "/home/robert/Projects/EKnjiznica/Views/Admin/UserProfile.cshtml"
      
        ViewData["Title"] = "Profile";
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    
    <!-- Main content -->
    <section class=""content"">

      <div class=""row"">
        <div class=""col-md-3"">

          <!-- Profile Image -->
          <div class=""box box-primary"">
            <div class=""box-body box-profile"">
              <img class=""profile-user-img img-responsive img-circle"" src=""../../dist/img/user4-128x128.jpg"" alt=""User profile picture"">

              <h3 class=""profile-username text-center"">");
#nullable restore
#line 18 "/home/robert/Projects/EKnjiznica/Views/Admin/UserProfile.cshtml"
                                                  Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\n              <p class=\"text-muted text-center\">");
#nullable restore
#line 20 "/home/robert/Projects/EKnjiznica/Views/Admin/UserProfile.cshtml"
                                           Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n              <ul class=\"list-group list-group-unbordered\">\n                <li class=\"list-group-item\">\n                  <b>Account Balance</b> <a class=\"pull-right\">");
#nullable restore
#line 24 "/home/robert/Projects/EKnjiznica/Views/Admin/UserProfile.cshtml"
                                                          Write(Model.AccountBalance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                </li>\n                <li class=\"list-group-item\">\n                  <b>Email</b> <a class=\"pull-right\">");
#nullable restore
#line 27 "/home/robert/Projects/EKnjiznica/Views/Admin/UserProfile.cshtml"
                                                Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                </li>\n              </ul>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5456e526f590dcb3e9838312be9a1e36889704607801", async() => {
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5456e526f590dcb3e9838312be9a1e36889704608075", async() => {
                    WriteLiteral("<b>Delete User</b>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "/home/robert/Projects/EKnjiznica/Views/Admin/UserProfile.cshtml"
                              WriteLiteral(Model.UserId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                <br>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5456e526f590dcb3e9838312be9a1e368897046011697", async() => {
                WriteLiteral("\n                  <div class=\"form-group\">\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5456e526f590dcb3e9838312be9a1e368897046012018", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#nullable restore
#line 36 "/home/robert/Projects/EKnjiznica/Views/Admin/UserProfile.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AddedCredit);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5456e526f590dcb3e9838312be9a1e368897046013877", async() => {
                    WriteLiteral("<b>Add Credit</b>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "/home/robert/Projects/EKnjiznica/Views/Admin/UserProfile.cshtml"
                              WriteLiteral(Model.UserId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                  </div>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <!-- /.box-body -->
          </div>
          <!-- /.box -->

        </div>
        <!-- /.col -->
        <div class=""col-md-9"">
          <div class=""nav-tabs-custom"">
            <ul class=""nav nav-tabs"">
              <li class=""active""><a href=""#books"" data-toggle=""tab"">Books</a></li>
              <li><a href=""#payments"" data-toggle=""tab"">Payments</a></li>
              <li><a href=""#transactions"" data-toggle=""tab"">Transactions</a></li>
            </ul>
            <div class=""tab-content"">
              <div class=""active tab-pane"" id=""books"">
                <!-- Post -->
                <div class=""box-body table-responsive no-padding"">
                    <table class=""table table-hover"">
                      <tbody><tr>
                        <th>Title</th>
                        <th>Author</th>
                        <th>Category</th>
                        <th>Price</th>
                      </tr>
");
#nullable restore
#line 65 "/home/robert/Projects/EKnjiznica/Views/Admin/UserProfile.cshtml"
                       foreach (var item in Model.Books)
                      {                

#line default
#line hidden
#nullable disable
            WriteLiteral("                          <tr>\n                            <td>");
#nullable restore
#line 68 "/home/robert/Projects/EKnjiznica/Views/Admin/UserProfile.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 69 "/home/robert/Projects/EKnjiznica/Views/Admin/UserProfile.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 70 "/home/robert/Projects/EKnjiznica/Views/Admin/UserProfile.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 71 "/home/robert/Projects/EKnjiznica/Views/Admin/UserProfile.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("$</td>\n                          </tr>                \n");
#nullable restore
#line 73 "/home/robert/Projects/EKnjiznica/Views/Admin/UserProfile.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody></table>
                </div>
              </div>
              <!-- /.tab-pane -->
              <div class=""tab-pane"" id=""payments"">
                <!-- The timeline -->
                <div class=""box-body table-responsive no-padding"">
                    <table class=""table table-hover"">
                      <tbody><tr>
                        <th>Id</th>
                        <th>Book</th>
                        <th>Date</th>
                        <th>Old Balance</th>
                        <th>New Balance</th>
                      </tr>
");
#nullable restore
#line 89 "/home/robert/Projects/EKnjiznica/Views/Admin/UserProfile.cshtml"
                       foreach (var item in Model.Payments)
                      {                

#line default
#line hidden
#nullable disable
            WriteLiteral("                          <tr>\n                            <td>");
#nullable restore
#line 92 "/home/robert/Projects/EKnjiznica/Views/Admin/UserProfile.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 93 "/home/robert/Projects/EKnjiznica/Views/Admin/UserProfile.cshtml"
                           Write(Html.DisplayFor(modelItem => item.BookName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 94 "/home/robert/Projects/EKnjiznica/Views/Admin/UserProfile.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 95 "/home/robert/Projects/EKnjiznica/Views/Admin/UserProfile.cshtml"
                           Write(Html.DisplayFor(modelItem => item.OldBallance));

#line default
#line hidden
#nullable disable
            WriteLiteral("$</td>\n                            <td>");
#nullable restore
#line 96 "/home/robert/Projects/EKnjiznica/Views/Admin/UserProfile.cshtml"
                           Write(Html.DisplayFor(modelItem => item.NewBallance));

#line default
#line hidden
#nullable disable
            WriteLiteral("$</td>\n                          </tr>                \n");
#nullable restore
#line 98 "/home/robert/Projects/EKnjiznica/Views/Admin/UserProfile.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                      </tbody>
                    </table>
                </div>
              </div>
              <!-- /.tab-pane -->

              <div class=""tab-pane"" id=""transactions"">
                <div class=""box-body table-responsive no-padding"">
                    <table class=""table table-hover"">
                      <tbody><tr>
                        <th>Id</th>
                        <th>Date</th>
                        <th>Value</th>
                        <th>Old Balance</th>
                        <th>New Balance</th>
                      </tr>
");
#nullable restore
#line 115 "/home/robert/Projects/EKnjiznica/Views/Admin/UserProfile.cshtml"
                       foreach (var item in Model.Transactions)
                      {                

#line default
#line hidden
#nullable disable
            WriteLiteral("                          <tr>\n                            <td>");
#nullable restore
#line 118 "/home/robert/Projects/EKnjiznica/Views/Admin/UserProfile.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 119 "/home/robert/Projects/EKnjiznica/Views/Admin/UserProfile.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 120 "/home/robert/Projects/EKnjiznica/Views/Admin/UserProfile.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("$</td>\n                            <td>");
#nullable restore
#line 121 "/home/robert/Projects/EKnjiznica/Views/Admin/UserProfile.cshtml"
                           Write(Html.DisplayFor(modelItem => item.OldBallance));

#line default
#line hidden
#nullable disable
            WriteLiteral("$</td>\n                            <td>");
#nullable restore
#line 122 "/home/robert/Projects/EKnjiznica/Views/Admin/UserProfile.cshtml"
                           Write(Html.DisplayFor(modelItem => item.NewBallance));

#line default
#line hidden
#nullable disable
            WriteLiteral("$</td>\n                          </tr>                \n");
#nullable restore
#line 124 "/home/robert/Projects/EKnjiznica/Views/Admin/UserProfile.cshtml"
                      }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                      </tbody>
                    </table>
                </div>
              </div>
              <!-- /.tab-pane -->
            </div>
            <!-- /.tab-content -->
          </div>
          <!-- /.nav-tabs-custom -->
        </div>
        <!-- /.col -->
      </div>
      <!-- /.row -->

    </section>
    <!-- /.content -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EKnjiznica.Dtos.ProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
