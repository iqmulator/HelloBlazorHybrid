#pragma checksum "D:\NET\Fusion\HelloBlazorHybrid\UI\Shared\WhenException.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee33024571e4c219d00fe522204b0ae74afa2fdd"
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
    public partial class WhenException : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "D:\NET\Fusion\HelloBlazorHybrid\UI\Shared\WhenException.razor"
 if (Exception != null) {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<HelloBlazorHybrid.UI.Shared.Error>(0);
            __builder.AddAttribute(1, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 2 "D:\NET\Fusion\HelloBlazorHybrid\UI\Shared\WhenException.razor"
                   Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(3, 
#nullable restore
#line 2 "D:\NET\Fusion\HelloBlazorHybrid\UI\Shared\WhenException.razor"
                           Exception.Message

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 3 "D:\NET\Fusion\HelloBlazorHybrid\UI\Shared\WhenException.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "D:\NET\Fusion\HelloBlazorHybrid\UI\Shared\WhenException.razor"
       
    [Parameter]
    public string Title { get; set; } = "Error:";
    [Parameter]
    public Exception? Exception { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591