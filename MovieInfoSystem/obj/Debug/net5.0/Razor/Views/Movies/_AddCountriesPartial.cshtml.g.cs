#pragma checksum "C:\Users\teodo\Source\Repos\ASP.NET-Core-Movie-Info-System1\MovieInfoSystem\Views\Movies\_AddCountriesPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24baadffa9450bb30754a412cd259f147ddfd623"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies__AddCountriesPartial), @"mvc.1.0.view", @"/Views/Movies/_AddCountriesPartial.cshtml")]
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
#line 1 "C:\Users\teodo\Source\Repos\ASP.NET-Core-Movie-Info-System1\MovieInfoSystem\Views\_ViewImports.cshtml"
using MovieInfoSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\teodo\Source\Repos\ASP.NET-Core-Movie-Info-System1\MovieInfoSystem\Views\_ViewImports.cshtml"
using MovieInfoSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\teodo\Source\Repos\ASP.NET-Core-Movie-Info-System1\MovieInfoSystem\Views\_ViewImports.cshtml"
using MovieInfoSystem.Models.Movies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\teodo\Source\Repos\ASP.NET-Core-Movie-Info-System1\MovieInfoSystem\Views\_ViewImports.cshtml"
using MovieInfoSystem.Models.Actors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\teodo\Source\Repos\ASP.NET-Core-Movie-Info-System1\MovieInfoSystem\Views\_ViewImports.cshtml"
using MovieInfoSystem.Models.Authors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\teodo\Source\Repos\ASP.NET-Core-Movie-Info-System1\MovieInfoSystem\Views\_ViewImports.cshtml"
using MovieInfoSystem.Models.Directors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\teodo\Source\Repos\ASP.NET-Core-Movie-Info-System1\MovieInfoSystem\Views\_ViewImports.cshtml"
using MovieInfoSystem.Models.Countries;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\teodo\Source\Repos\ASP.NET-Core-Movie-Info-System1\MovieInfoSystem\Views\_ViewImports.cshtml"
using MovieInfoSystem.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\teodo\Source\Repos\ASP.NET-Core-Movie-Info-System1\MovieInfoSystem\Views\_ViewImports.cshtml"
using MovieInfoSystem.Services.Movies.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\teodo\Source\Repos\ASP.NET-Core-Movie-Info-System1\MovieInfoSystem\Views\_ViewImports.cshtml"
using MovieInfoSystem.Services.Index.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\teodo\Source\Repos\ASP.NET-Core-Movie-Info-System1\MovieInfoSystem\Views\_ViewImports.cshtml"
using MovieInfoSystem.Services.Actors.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\teodo\Source\Repos\ASP.NET-Core-Movie-Info-System1\MovieInfoSystem\Views\_ViewImports.cshtml"
using MovieInfoSystem.Services.Directors.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\teodo\Source\Repos\ASP.NET-Core-Movie-Info-System1\MovieInfoSystem\Views\_ViewImports.cshtml"
using MovieInfoSystem.Services.Countries.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24baadffa9450bb30754a412cd259f147ddfd623", @"/Views/Movies/_AddCountriesPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e3e771e2d1598b9a28371e62df082f2ace7d5d0", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies__AddCountriesPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script>
    let countriesIndex = 0;

    $(""#add-country"").click(function (e) {
        e.preventDefault();
        $(""#countries-container"").append(`<div class=""form-group"">
        <label>Country Name</label>
        <input name='Countries[`+ [countriesIndex] + `].Name' class='form-control' placeholder='USA, Bulgarian, ect. '>
                                                              </div> `);

        countriesIndex++;
    });

</script>");
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
