#pragma checksum "/home/cannonjw/Projects/BlazorShop/Pages/Learn Blazor/LearnBlazor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d37622561315f46550543c1fadadb0f3bbdf6c41"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/learnBlazor")]
    public partial class LearnBlazor : LearnBlazorBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddAttribute(1, "class", "text-info pb-3");
            __builder.AddContent(2, 
#nullable restore
#line 4 "/home/cannonjw/Projects/BlazorShop/Pages/Learn Blazor/LearnBlazor.razor"
                            WelcomeText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\n\n");
            __builder.OpenElement(4, "p");
            __builder.AddContent(5, " On Change   ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "/home/cannonjw/Projects/BlazorShop/Pages/Learn Blazor/LearnBlazor.razor"
                                   name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => name = __value, name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(9, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n");
            __builder.OpenElement(11, "p");
            __builder.AddContent(12, " On Spontaneous   ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "/home/cannonjw/Projects/BlazorShop/Pages/Learn Blazor/LearnBlazor.razor"
                                        name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => name = __value, name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(16, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n\n");
            __builder.OpenElement(18, "p");
            __builder.AddContent(19, " I am ");
            __builder.AddContent(20, 
#nullable restore
#line 9 "/home/cannonjw/Projects/BlazorShop/Pages/Learn Blazor/LearnBlazor.razor"
           name!=null?name:"______"

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(21, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n");
            __builder.OpenElement(23, "p");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "/home/cannonjw/Projects/BlazorShop/Pages/Learn Blazor/LearnBlazor.razor"
                     getName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "Surprise Me!");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
