#pragma checksum "D:\NET\Fusion\HelloBlazorHybrid\UI\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "883be95c77ba70666674549f61a10b01ecafd4ba"
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
using HelloBlazorHybrid.Services;

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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazorise.Layout>(0);
            __builder.AddAttribute(1, "Sider", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 3 "D:\NET\Fusion\HelloBlazorHybrid\UI\Shared\MainLayout.razor"
               true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazorise.LayoutSider>(3);
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.LayoutSiderContent>(5);
                    __builder3.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<HelloBlazorHybrid.UI.Shared.LeftBar>(7);
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenComponent<Blazorise.Layout>(9);
                __builder2.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazorise.LayoutHeader>(11);
                    __builder3.AddAttribute(12, "Fixed", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "D:\NET\Fusion\HelloBlazorHybrid\UI\Shared\MainLayout.razor"
                             true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<HelloBlazorHybrid.UI.Shared.TopBar>(14);
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(15, "\r\n\r\n        ");
                    __builder3.OpenComponent<Blazorise.LayoutContent>(16);
                    __builder3.AddAttribute(17, "Padding", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.IFluentSpacing>(
#nullable restore
#line 14 "D:\NET\Fusion\HelloBlazorHybrid\UI\Shared\MainLayout.razor"
                                Padding.Is4

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(19, 
#nullable restore
#line 15 "D:\NET\Fusion\HelloBlazorHybrid\UI\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
