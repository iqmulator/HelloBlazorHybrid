#pragma checksum "D:\NET\Fusion\HelloBlazorHybrid\UI\Shared\BlazorModeSwitch.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "452e717f88723fe9958135994da8f3b01b072c0c"
// <auto-generated/>
#pragma warning disable 1591
namespace HelloBlazorHybrid.UI.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\NET\Fusion\HelloBlazorHybrid\UI\_Imports.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\NET\Fusion\HelloBlazorHybrid\UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\NET\Fusion\HelloBlazorHybrid\UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\NET\Fusion\HelloBlazorHybrid\UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\NET\Fusion\HelloBlazorHybrid\UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\NET\Fusion\HelloBlazorHybrid\UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\NET\Fusion\HelloBlazorHybrid\UI\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\NET\Fusion\HelloBlazorHybrid\UI\_Imports.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\NET\Fusion\HelloBlazorHybrid\UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\NET\Fusion\HelloBlazorHybrid\UI\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\NET\Fusion\HelloBlazorHybrid\UI\_Imports.razor"
using Blazorise.DataGrid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\NET\Fusion\HelloBlazorHybrid\UI\_Imports.razor"
using Blazorise.Icons.FontAwesome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\NET\Fusion\HelloBlazorHybrid\UI\_Imports.razor"
using Blazorise.Sidebar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\NET\Fusion\HelloBlazorHybrid\UI\_Imports.razor"
using HelloBlazorHybrid.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\NET\Fusion\HelloBlazorHybrid\UI\_Imports.razor"
using HelloBlazorHybrid.UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\NET\Fusion\HelloBlazorHybrid\UI\_Imports.razor"
using HelloBlazorHybrid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\NET\Fusion\HelloBlazorHybrid\UI\_Imports.razor"
using Stl.Fusion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\NET\Fusion\HelloBlazorHybrid\UI\_Imports.razor"
using Stl.Fusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\NET\Fusion\HelloBlazorHybrid\UI\_Imports.razor"
using Stl.Fusion.Blazor.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\NET\Fusion\HelloBlazorHybrid\UI\_Imports.razor"
using Stl.Fusion.Bridge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "D:\NET\Fusion\HelloBlazorHybrid\UI\_Imports.razor"
using Stl.Fusion.Bridge.Messages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\NET\Fusion\HelloBlazorHybrid\UI\_Imports.razor"
using Stl.Fusion.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\NET\Fusion\HelloBlazorHybrid\UI\_Imports.razor"
using Stl.Serialization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\NET\Fusion\HelloBlazorHybrid\UI\Shared\BlazorModeSwitch.razor"
using Stl.OS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\NET\Fusion\HelloBlazorHybrid\UI\Shared\BlazorModeSwitch.razor"
using System.Web;

#line default
#line hidden
#nullable disable
    public partial class BlazorModeSwitch : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazorise.RadioGroup<bool>>(0);
            __builder.AddAttribute(1, "Class", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 5 "D:\NET\Fusion\HelloBlazorHybrid\UI\Shared\BlazorModeSwitch.razor"
                    CssClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Name", "BlazorMode");
            __builder.AddAttribute(3, "CheckedValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 7 "D:\NET\Fusion\HelloBlazorHybrid\UI\Shared\BlazorModeSwitch.razor"
                            BlazorModeHelper.IsServerSideBlazor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "CheckedValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<bool>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<bool>(this, 
#nullable restore
#line 8 "D:\NET\Fusion\HelloBlazorHybrid\UI\Shared\BlazorModeSwitch.razor"
                                   v => BlazorModeHelper.ChangeMode(v)

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.Radio<bool>>(6);
                __builder2.AddAttribute(7, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 9 "D:\NET\Fusion\HelloBlazorHybrid\UI\Shared\BlazorModeSwitch.razor"
                                 true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(9, "Server-Side Blazor");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n    ");
                __builder2.OpenComponent<Blazorise.Radio<bool>>(11);
                __builder2.AddAttribute(12, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<bool>(
#nullable restore
#line 10 "D:\NET\Fusion\HelloBlazorHybrid\UI\Shared\BlazorModeSwitch.razor"
                                 false

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(14, "Blazor WebAssembly");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "D:\NET\Fusion\HelloBlazorHybrid\UI\Shared\BlazorModeSwitch.razor"
       
    [Parameter]
    public string CssClass { get; set; } = "";

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorModeHelper BlazorModeHelper { get; set; }
    }
}
#pragma warning restore 1591
