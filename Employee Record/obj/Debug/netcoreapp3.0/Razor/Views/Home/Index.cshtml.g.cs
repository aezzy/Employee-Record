#pragma checksum "C:\Users\Lexicon\source\repos\Employee Record\Employee Record\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2d0e801dcff894c2ccad8b001c7b949242cd016"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Lexicon\source\repos\Employee Record\Employee Record\Views\_ViewImports.cshtml"
using Employee_Record;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lexicon\source\repos\Employee Record\Employee Record\Views\_ViewImports.cshtml"
using Employee_Record.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2d0e801dcff894c2ccad8b001c7b949242cd016", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21b08e1cf9f4d0a56d071e6b6cad848fd8ec2ace", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Lexicon\source\repos\Employee Record\Employee Record\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>
<table>
    <thead>
        <tr> <th>Method</th>  <th>Action</th></tr>
    </thead>
    <tbody>
        <tr>
            <td>Http Get</td>
            <td><a href=""javascript:;"" onclick=""GetData();"">Click to Get</a></td>
        </tr>
        <tr>
            <td>Http Post</td>
            <td><a href=""javascript:;"" onclick=""PostData();"">Click to Post</a></td>
        </tr>
    </tbody>
</table>



<script type=""text/javascript"">
    function GetData() {
        $.ajax({
            type: 'GET',
            contentType: ""application/json; charset=utf-8"",
            dataType: 'json',
            url: ""../Home/GetData"" + ""?test=1"",
            success: function (data) { alert('Successfully get method executed.') },
            error: function (a, jqXHR, exception) { }
        });
    }
    func");
            WriteLiteral(@"tion PostData() {
        $.ajax({
            type: 'POST',
            contentType: ""application/json; charset=utf-8"",
            dataType: 'json',
            url: ""../Home/PostData"",
            data: ""{ 'test': '2'}"",
            success: function (data) { alert(data) },
            error: function (a, jqXHR, exception) { }
        });
    }
</script>

<style type=""text/css"">
    table {
        width: 100%;
        border-collapse: collapse;
    }

    tr:nth-of-type(odd) {
        background: #eee;
    }

    th {
        background: #333;
        color: white;
        font-weight: bold;
    }

    td, th {
        padding: 6px;
        border: 1px solid #ccc;
        text-align: left;
    }
</style>
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