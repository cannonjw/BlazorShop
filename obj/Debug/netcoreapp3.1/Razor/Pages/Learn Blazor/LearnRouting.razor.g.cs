#pragma checksum "/home/cannonjw/Projects/BlazorShop/Pages/Learn Blazor/LearnRouting.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57e022aa61cdae2aa5aff74e4a12999164f3ce26"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorShop.Pages.Learn_Blazor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/cannonjw/Projects/BlazorShop/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/cannonjw/Projects/BlazorShop/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/cannonjw/Projects/BlazorShop/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/cannonjw/Projects/BlazorShop/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/cannonjw/Projects/BlazorShop/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/cannonjw/Projects/BlazorShop/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/cannonjw/Projects/BlazorShop/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/cannonjw/Projects/BlazorShop/_Imports.razor"
using BlazorShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/cannonjw/Projects/BlazorShop/_Imports.razor"
using BlazorShop.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/learnNewRouting/{parameter1}/{parameter2}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/learnNewRouting/{parameter1}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/learnRouting/{parameter1}/{parameter2}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/learnRouting")]
    public partial class LearnRouting : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Learn Routing</h3>\n\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "First Parameter : ");
            __builder.AddContent(3, 
#nullable restore
#line 8 "/home/cannonjw/Projects/BlazorShop/Pages/Learn Blazor/LearnRouting.razor"
                      Parameter1

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n");
            __builder.OpenElement(6, "p");
            __builder.AddContent(7, "Second Parameter : ");
            __builder.AddContent(8, 
#nullable restore
#line 9 "/home/cannonjw/Projects/BlazorShop/Pages/Learn Blazor/LearnRouting.razor"
                       Parameter2

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(9, " ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "/home/cannonjw/Projects/BlazorShop/Pages/Learn Blazor/LearnRouting.razor"
       
    [Parameter]
    public string Parameter1 { get; set; }
    [Parameter]
    public string Parameter2 { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
