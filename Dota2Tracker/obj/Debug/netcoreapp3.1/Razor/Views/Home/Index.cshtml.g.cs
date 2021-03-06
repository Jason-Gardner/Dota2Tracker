#pragma checksum "C:\Users\Jason Gardner\source\repos\Dota2Tracker\Dota2Tracker\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8167e91bc3c2ed52147219364a138e1eab1eb68f"
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
#line 1 "C:\Users\Jason Gardner\source\repos\Dota2Tracker\Dota2Tracker\Views\_ViewImports.cshtml"
using Dota2Tracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jason Gardner\source\repos\Dota2Tracker\Dota2Tracker\Views\_ViewImports.cshtml"
using Dota2Tracker.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8167e91bc3c2ed52147219364a138e1eab1eb68f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99749ab103684392d6c6a1180e12b17cd5787be0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ng-repeat", new global::Microsoft.AspNetCore.Html.HtmlString("x in games"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ng-value", new global::Microsoft.AspNetCore.Html.HtmlString("{{x}}"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Jason Gardner\source\repos\Dota2Tracker\Dota2Tracker\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/angularjs/1.6.9/angular.min.js""></script>
<div class=""text-center"" ng-app=""list"" ng-controller=""matchList"">
    <h3>Recent Matches</h3>
    <select style=""margin-bottom: 10px"" ng-model=""yourGame"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8167e91bc3c2ed52147219364a138e1eab1eb68f4270", async() => {
                WriteLiteral("{{x.match_id}}");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </select>
    <p>You selected {{yourGame.match_id}}</p>
    <table align=""center"">
        <tr><td><b>Hero ID: </b></td><td ng-bind=""yourGame.hero_id""></td></tr>
        <tr><td><b>Kills: </b></td><td ng-bind=""yourGame.kills""></td></tr>
        <tr><td><b>Deaths: </b></td><td ng-bind=""yourGame.deaths""></td></tr>
        <tr><td><b>Assists: </b></td><td ng-bind=""yourGame.assists""></td></tr>
        <tr><td><b>Last Hits: </b></td><td ng-bind=""yourGame.last_hits""></td></tr>
        <tr><td><b>XPM: </b></td><td ng-bind=""yourGame.xp_per_min""></td></tr>
        <tr><td><b>GPM: </b></td><td ng-bind=""yourGame.gold_per_min""></td></tr>
    </table><br />
    <table width=""100%"">
        <thead>
            <tr>
                <th scope=""col"">Match ID</th>
                <th scope=""col"">Hero ID</th>
                <th scope=""col"">Kills</th>
                <th scope=""col"">Deaths</th>
                <th scope=""col"">Assists</th>
                <th scope=""col"">Last Hits</th>
                <");
            WriteLiteral(@"th scope=""col"">XPM</th>
                <th scope=""col"">GPM</th>
            </tr>
        </thead>
        <tbody>
            <tr ng-repeat=""x in games"">
                <td>{{x.match_id}}</td>
                <td>{{x.hero_id}}</td>
                <td>{{x.kills}}</td>
                <td>{{x.deaths}}</td>
                <td>{{x.assists}}</td>
                <td>{{x.last_hits}}</td>
                <td>{{x.xp_per_min}}</td>
                <td>{{x.gold_per_min}}</td>
            </tr>
        </tbody>
    </table>
</div>

<script>
    var app = angular.module(""list"", []);
    app.controller(""matchList"", function ($scope, $http) {
        $scope.games = [];
        $http.get(""https://api.opendota.com/api/players/248586332/recentMatches"").then(function (response) {
            $scope.games = response.data;
        });
    });
</script>
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
