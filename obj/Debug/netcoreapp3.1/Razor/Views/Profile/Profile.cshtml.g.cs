#pragma checksum "/home/robert/Projects/EKnjiznica/Views/Profile/Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e46eb527b414fc73ee5f36191fe1827fc2820ef4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Profile), @"mvc.1.0.view", @"/Views/Profile/Profile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e46eb527b414fc73ee5f36191fe1827fc2820ef4", @"/Views/Profile/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7348b2845bf1ad1c7615cd9f56ab1cb22b976403", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EKnjiznica.Dtos.ProfileViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangePassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("    \n");
#nullable restore
#line 3 "/home/robert/Projects/EKnjiznica/Views/Profile/Profile.cshtml"
      
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
#line 18 "/home/robert/Projects/EKnjiznica/Views/Profile/Profile.cshtml"
                                                  Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\n              <p class=\"text-muted text-center\">");
#nullable restore
#line 20 "/home/robert/Projects/EKnjiznica/Views/Profile/Profile.cshtml"
                                           Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n              <ul class=\"list-group list-group-unbordered\">\n                <li class=\"list-group-item\">\n                  <b>Account Balance</b> <a class=\"pull-right\">");
#nullable restore
#line 24 "/home/robert/Projects/EKnjiznica/Views/Profile/Profile.cshtml"
                                                          Write(Model.AccountBalance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                </li>\n                <li class=\"list-group-item\">\n                  <b>Email</b> <a class=\"pull-right\">");
#nullable restore
#line 27 "/home/robert/Projects/EKnjiznica/Views/Profile/Profile.cshtml"
                                                Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                </li>\n              </ul>\n\n              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e46eb527b414fc73ee5f36191fe1827fc2820ef45735", async() => {
                WriteLiteral("<b>Change Password</b>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
#line 57 "/home/robert/Projects/EKnjiznica/Views/Profile/Profile.cshtml"
                       foreach (var item in Model.Books)
                      {                

#line default
#line hidden
#nullable disable
            WriteLiteral("                          <tr>\n                            <td>");
#nullable restore
#line 60 "/home/robert/Projects/EKnjiznica/Views/Profile/Profile.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 61 "/home/robert/Projects/EKnjiznica/Views/Profile/Profile.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 62 "/home/robert/Projects/EKnjiznica/Views/Profile/Profile.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 63 "/home/robert/Projects/EKnjiznica/Views/Profile/Profile.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("$</td>\n                          </tr>                \n");
#nullable restore
#line 65 "/home/robert/Projects/EKnjiznica/Views/Profile/Profile.cshtml"
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
#line 81 "/home/robert/Projects/EKnjiznica/Views/Profile/Profile.cshtml"
                       foreach (var item in Model.Payments)
                      {                

#line default
#line hidden
#nullable disable
            WriteLiteral("                          <tr>\n                            <td>");
#nullable restore
#line 84 "/home/robert/Projects/EKnjiznica/Views/Profile/Profile.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 85 "/home/robert/Projects/EKnjiznica/Views/Profile/Profile.cshtml"
                           Write(Html.DisplayFor(modelItem => item.BookName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 86 "/home/robert/Projects/EKnjiznica/Views/Profile/Profile.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 87 "/home/robert/Projects/EKnjiznica/Views/Profile/Profile.cshtml"
                           Write(Html.DisplayFor(modelItem => item.OldBallance));

#line default
#line hidden
#nullable disable
            WriteLiteral("$</td>\n                            <td>");
#nullable restore
#line 88 "/home/robert/Projects/EKnjiznica/Views/Profile/Profile.cshtml"
                           Write(Html.DisplayFor(modelItem => item.NewBallance));

#line default
#line hidden
#nullable disable
            WriteLiteral("$</td>\n                          </tr>                \n");
#nullable restore
#line 90 "/home/robert/Projects/EKnjiznica/Views/Profile/Profile.cshtml"
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
#line 107 "/home/robert/Projects/EKnjiznica/Views/Profile/Profile.cshtml"
                       foreach (var item in Model.Transactions)
                      {                

#line default
#line hidden
#nullable disable
            WriteLiteral("                          <tr>\n                            <td>");
#nullable restore
#line 110 "/home/robert/Projects/EKnjiznica/Views/Profile/Profile.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 111 "/home/robert/Projects/EKnjiznica/Views/Profile/Profile.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 112 "/home/robert/Projects/EKnjiznica/Views/Profile/Profile.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("$</td>\n                            <td>");
#nullable restore
#line 113 "/home/robert/Projects/EKnjiznica/Views/Profile/Profile.cshtml"
                           Write(Html.DisplayFor(modelItem => item.OldBallance));

#line default
#line hidden
#nullable disable
            WriteLiteral("$</td>\n                            <td>");
#nullable restore
#line 114 "/home/robert/Projects/EKnjiznica/Views/Profile/Profile.cshtml"
                           Write(Html.DisplayFor(modelItem => item.NewBallance));

#line default
#line hidden
#nullable disable
            WriteLiteral("$</td>\n                          </tr>                \n");
#nullable restore
#line 116 "/home/robert/Projects/EKnjiznica/Views/Profile/Profile.cshtml"
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
