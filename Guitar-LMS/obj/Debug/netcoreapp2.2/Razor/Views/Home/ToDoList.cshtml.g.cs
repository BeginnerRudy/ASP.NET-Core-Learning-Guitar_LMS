#pragma checksum "/Users/rudy/Documents/Personal Docs/Study&Work/SDE/Code/Lab/Guitar-LMS/Guitar-LMS/Views/Home/ToDoList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16847abc870425856b097fec4a20d30ae1247898"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ToDoList), @"mvc.1.0.view", @"/Views/Home/ToDoList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ToDoList.cshtml", typeof(AspNetCore.Views_Home_ToDoList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16847abc870425856b097fec4a20d30ae1247898", @"/Views/Home/ToDoList.cshtml")]
    public class Views_Home_ToDoList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Guitar_LMS.ViewModels.TodoListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin: 20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 24, true);
            WriteLiteral("<!DOCTYPE html>\n\n<html>\n");
            EndContext();
            BeginContext(71, 270, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16847abc870425856b097fec4a20d30ae12478983348", async() => {
                BeginContext(77, 257, true);
                WriteLiteral(@"
    <title>Guitar Practice Card</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(341, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(342, 2972, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16847abc870425856b097fec4a20d30ae12478984771", async() => {
                BeginContext(370, 15, true);
                WriteLiteral("\n    <h1>Date: ");
                EndContext();
                BeginContext(386, 13, false);
#line 10 "/Users/rudy/Documents/Personal Docs/Study&Work/SDE/Code/Lab/Guitar-LMS/Guitar-LMS/Views/Home/ToDoList.cshtml"
         Write(Model.DateStr);

#line default
#line hidden
                EndContext();
                BeginContext(399, 53, true);
                WriteLiteral("</h1>\n    <input type=\"button\" value=\"Go to Calendar\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 452, "\"", 506, 3);
                WriteAttributeValue("", 462, "location.href=\'", 462, 15, true);
#line 11 "/Users/rudy/Documents/Personal Docs/Study&Work/SDE/Code/Lab/Guitar-LMS/Guitar-LMS/Views/Home/ToDoList.cshtml"
WriteAttributeValue("", 477, Url.Action("Index", "Home"), 477, 28, false);

#line default
#line hidden
                WriteAttributeValue("", 505, "\'", 505, 1, true);
                EndWriteAttribute();
                BeginContext(507, 158, true);
                WriteLiteral(" />\n\n    <h1>TODO</h1>\n    <table class=\"table table-striped table-bordered table-hover\" style=\"max-width: 500px;\">\n        <tr>\n            <td colspan=\"3\">\n");
                EndContext();
#line 17 "/Users/rudy/Documents/Personal Docs/Study&Work/SDE/Code/Lab/Guitar-LMS/Guitar-LMS/Views/Home/ToDoList.cshtml"
                 using (var form = Html.BeginForm("CreateUpdate", "Home", FormMethod.Post))
                {
                    

#line default
#line hidden
                BeginContext(796, 46, false);
#line 19 "/Users/rudy/Documents/Personal Docs/Study&Work/SDE/Code/Lab/Guitar-LMS/Guitar-LMS/Views/Home/ToDoList.cshtml"
               Write(Html.HiddenFor(model => model.EditableItem.Id));

#line default
#line hidden
                EndContext();
                BeginContext(864, 38, false);
#line 20 "/Users/rudy/Documents/Personal Docs/Study&Work/SDE/Code/Lab/Guitar-LMS/Guitar-LMS/Views/Home/ToDoList.cshtml"
               Write(Html.HiddenFor(model => model.DateStr));

#line default
#line hidden
                EndContext();
                BeginContext(903, 116, true);
                WriteLiteral("                    <div class=\"input-group\">\n                        <div>\n                            Task Title: ");
                EndContext();
                BeginContext(1020, 83, false);
#line 23 "/Users/rudy/Documents/Personal Docs/Study&Work/SDE/Code/Lab/Guitar-LMS/Guitar-LMS/Views/Home/ToDoList.cshtml"
                                   Write(Html.TextBoxFor(model => model.EditableItem.Title, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1103, 116, true);
                WriteLiteral("\n                        </div>\n                        <div>\n                            Task Duration in minutes: ");
                EndContext();
                BeginContext(1220, 94, false);
#line 26 "/Users/rudy/Documents/Personal Docs/Study&Work/SDE/Code/Lab/Guitar-LMS/Guitar-LMS/Views/Home/ToDoList.cshtml"
                                                 Write(Html.TextBoxFor(model => model.EditableItem.DurationInMinute, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(1314, 163, true);
                WriteLiteral("\n                        </div>\n                        <div class=\"input-group-append\">\n                            <button type=\"submit\" class=\"btn btn-success\">");
                EndContext();
                BeginContext(1479, 44, false);
#line 29 "/Users/rudy/Documents/Personal Docs/Study&Work/SDE/Code/Lab/Guitar-LMS/Guitar-LMS/Views/Home/ToDoList.cshtml"
                                                                      Write(Model.EditableItem.Id > 0 ? "Update" : "Add");

#line default
#line hidden
                EndContext();
                BeginContext(1524, 68, true);
                WriteLiteral("</button>\n                        </div>\n                    </div>\n");
                EndContext();
                BeginContext(1613, 24, false);
#line 32 "/Users/rudy/Documents/Personal Docs/Study&Work/SDE/Code/Lab/Guitar-LMS/Guitar-LMS/Views/Home/ToDoList.cshtml"
               Write(Html.ValidationSummary());

#line default
#line hidden
                EndContext();
#line 32 "/Users/rudy/Documents/Personal Docs/Study&Work/SDE/Code/Lab/Guitar-LMS/Guitar-LMS/Views/Home/ToDoList.cshtml"
                                             
                }

#line default
#line hidden
                BeginContext(1656, 32, true);
                WriteLiteral("            </td>\n        </tr>\n");
                EndContext();
                BeginContext(1737, 250, true);
                WriteLiteral("        <tr>\n            <td>\n                Task\n            </td>\n            <td class=\"text-right\">\n                Duration in Minutes\n            </td>\n            <td class=\"text-right\">\n                Action\n            </td>\n        </tr>\n");
                EndContext();
#line 48 "/Users/rudy/Documents/Personal Docs/Study&Work/SDE/Code/Lab/Guitar-LMS/Guitar-LMS/Views/Home/ToDoList.cshtml"
         foreach (var item in Model.TodoItems)
        {

#line default
#line hidden
                BeginContext(2044, 80, true);
                WriteLiteral("            <tr>\n                <td>\n                    <input type=\"checkbox\"");
                EndContext();
                BeginWriteAttribute("checked", " checked=\"", 2124, "\"", 2146, 1);
#line 52 "/Users/rudy/Documents/Personal Docs/Study&Work/SDE/Code/Lab/Guitar-LMS/Guitar-LMS/Views/Home/ToDoList.cshtml"
WriteAttributeValue("", 2134, item.IsDone, 2134, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("onclick", " onclick=\"", 2147, "\"", 2225, 7);
                WriteAttributeValue("", 2157, "window.location.href", 2157, 20, true);
                WriteAttributeValue(" ", 2177, "=", 2178, 2, true);
                WriteAttributeValue(" ", 2179, "\'/Home/ToggleIsDone/", 2180, 21, true);
#line 52 "/Users/rudy/Documents/Personal Docs/Study&Work/SDE/Code/Lab/Guitar-LMS/Guitar-LMS/Views/Home/ToDoList.cshtml"
WriteAttributeValue("", 2200, Model.DateStr, 2200, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 2214, "/", 2214, 1, true);
#line 52 "/Users/rudy/Documents/Personal Docs/Study&Work/SDE/Code/Lab/Guitar-LMS/Guitar-LMS/Views/Home/ToDoList.cshtml"
WriteAttributeValue("", 2215, item.Id, 2215, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 2223, "\';", 2223, 2, true);
                EndWriteAttribute();
                BeginContext(2226, 4, true);
                WriteLiteral(" />\n");
                EndContext();
                BeginContext(2300, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(2321, 10, false);
#line 54 "/Users/rudy/Documents/Personal Docs/Study&Work/SDE/Code/Lab/Guitar-LMS/Guitar-LMS/Views/Home/ToDoList.cshtml"
               Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(2331, 1, true);
                WriteLiteral("\n");
                EndContext();
                BeginContext(2361, 82, true);
                WriteLiteral("                </td>\n                <td class=\"text-right\">\n                    ");
                EndContext();
                BeginContext(2444, 21, false);
#line 58 "/Users/rudy/Documents/Personal Docs/Study&Work/SDE/Code/Lab/Guitar-LMS/Guitar-LMS/Views/Home/ToDoList.cshtml"
               Write(item.DurationInMinute);

#line default
#line hidden
                EndContext();
                BeginContext(2465, 85, true);
                WriteLiteral("\n                </td>\n                <td class=\"text-right\">\n                    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2550, "\"", 2593, 4);
                WriteAttributeValue("", 2557, "/Home/Delete/", 2557, 13, true);
#line 61 "/Users/rudy/Documents/Personal Docs/Study&Work/SDE/Code/Lab/Guitar-LMS/Guitar-LMS/Views/Home/ToDoList.cshtml"
WriteAttributeValue("", 2570, Model.DateStr, 2570, 14, false);

#line default
#line hidden
                WriteAttributeValue("", 2584, "/", 2584, 1, true);
#line 61 "/Users/rudy/Documents/Personal Docs/Study&Work/SDE/Code/Lab/Guitar-LMS/Guitar-LMS/Views/Home/ToDoList.cshtml"
WriteAttributeValue("", 2585, item.Id, 2585, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2594, 125, true);
                WriteLiteral(" onclick=\"return confirm(\'Are you sure?\');\" class=\"btn btn-sm btn-danger\">Delete</a>\n                </td>\n            </tr>\n");
                EndContext();
#line 64 "/Users/rudy/Documents/Personal Docs/Study&Work/SDE/Code/Lab/Guitar-LMS/Guitar-LMS/Views/Home/ToDoList.cshtml"
        }

#line default
#line hidden
                BeginContext(2729, 15, true);
                WriteLiteral("    </table>\n\n\n");
                EndContext();
#line 69 "/Users/rudy/Documents/Personal Docs/Study&Work/SDE/Code/Lab/Guitar-LMS/Guitar-LMS/Views/Home/ToDoList.cshtml"
     using (var form = Html.BeginForm("SaveSummary", "Home", FormMethod.Post))
    {
        

#line default
#line hidden
                BeginContext(2872, 38, false);
#line 71 "/Users/rudy/Documents/Personal Docs/Study&Work/SDE/Code/Lab/Guitar-LMS/Guitar-LMS/Views/Home/ToDoList.cshtml"
   Write(Html.HiddenFor(model => model.DateStr));

#line default
#line hidden
                EndContext();
                BeginContext(2911, 76, true);
                WriteLiteral("        <div>\n            Summary:\n        </div>\n        <div>\n            ");
                EndContext();
                BeginContext(2988, 88, false);
#line 76 "/Users/rudy/Documents/Personal Docs/Study&Work/SDE/Code/Lab/Guitar-LMS/Guitar-LMS/Views/Home/ToDoList.cshtml"
       Write(Html.TextAreaFor(model => model.Summary, new { style = "width: 400px; height: 200px;" }));

#line default
#line hidden
                EndContext();
                BeginContext(3076, 125, true);
                WriteLiteral("\n        </div>\n        <div>\n            <button type=\"submit\" class=\"btn btn-success\">Save Summary</button>\n        </div>\n");
                EndContext();
#line 81 "/Users/rudy/Documents/Personal Docs/Study&Work/SDE/Code/Lab/Guitar-LMS/Guitar-LMS/Views/Home/ToDoList.cshtml"
    }

#line default
#line hidden
                BeginContext(3222, 85, true);
                WriteLiteral("    <div asp-validation-summary=\"All\" class=\"text-danger\" style=\"color:red;\"></div>\n\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3314, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Guitar_LMS.ViewModels.TodoListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
