#pragma checksum "D:\NET\Fusion\HelloBlazorHybrid\UI\Pages\SimpleChat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad4fc7db5976bdf30341bb7bd091688d174a135c"
// <auto-generated/>
#pragma warning disable 1591
namespace HelloBlazorHybrid.UI.Pages
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
#nullable restore
#line 2 "D:\NET\Fusion\HelloBlazorHybrid\UI\Pages\SimpleChat.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\NET\Fusion\HelloBlazorHybrid\UI\Pages\SimpleChat.razor"
using HelloBlazorHybrid.Abstractions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\NET\Fusion\HelloBlazorHybrid\UI\Pages\SimpleChat.razor"
using Stl.Async;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\NET\Fusion\HelloBlazorHybrid\UI\Pages\SimpleChat.razor"
using Stl.Fusion.Extensions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/simpleChat")]
    public partial class SimpleChat : ComputedStateComponent<(string Name, string Message, string Time)[]>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 11 "D:\NET\Fusion\HelloBlazorHybrid\UI\Pages\SimpleChat.razor"
  
    var state = State.LatestNonErrorValue ?? Array.Empty<(string, string, string)>();
    var error = State.Error;

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<h1>Simple Chat</h1>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "alert alert-primary");
            __builder.AddMarkupContent(3, "\r\n    Open this page in ");
            __builder.OpenElement(4, "a");
            __builder.AddAttribute(5, "href", 
#nullable restore
#line 19 "D:\NET\Fusion\HelloBlazorHybrid\UI\Pages\SimpleChat.razor"
                                Navigator.Uri

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "target", "_blank");
            __builder.AddContent(7, "another window");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, " to see it updates in sync.\r\n");
            __builder.CloseElement();
#nullable restore
#line 21 "D:\NET\Fusion\HelloBlazorHybrid\UI\Pages\SimpleChat.razor"
 if (error != null) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "alert alert-warning");
            __builder.AddAttribute(11, "role", "alert");
            __builder.AddContent(12, "Update error: ");
            __builder.AddContent(13, 
#nullable restore
#line 22 "D:\NET\Fusion\HelloBlazorHybrid\UI\Pages\SimpleChat.razor"
                                                                 error.Message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 23 "D:\NET\Fusion\HelloBlazorHybrid\UI\Pages\SimpleChat.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "table");
            __builder.AddAttribute(15, "class", "table table-sm table-striped");
            __builder.AddMarkupContent(16, "<thead><tr><th scope=\"col\">Name</th>\r\n        <th scope=\"col\">Message</th>\r\n        <th scope=\"col\">Time</th></tr></thead>\r\n    ");
            __builder.OpenElement(17, "tbody");
#nullable restore
#line 34 "D:\NET\Fusion\HelloBlazorHybrid\UI\Pages\SimpleChat.razor"
         foreach (var (name, message, time) in state) {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "tr");
            __builder.OpenElement(19, "td");
            __builder.AddAttribute(20, "style", "width: 15%; max-width: 20%");
            __builder.AddContent(21, 
#nullable restore
#line 36 "D:\NET\Fusion\HelloBlazorHybrid\UI\Pages\SimpleChat.razor"
                                                        name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "td");
            __builder.AddAttribute(24, "style", "width: auto; min-width: 60%");
            __builder.AddContent(25, 
#nullable restore
#line 37 "D:\NET\Fusion\HelloBlazorHybrid\UI\Pages\SimpleChat.razor"
                                                         message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.OpenElement(27, "td");
            __builder.AddAttribute(28, "style", "width: 15%; max-width: 20%");
            __builder.AddContent(29, 
#nullable restore
#line 38 "D:\NET\Fusion\HelloBlazorHybrid\UI\Pages\SimpleChat.razor"
                                                        time

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "D:\NET\Fusion\HelloBlazorHybrid\UI\Pages\SimpleChat.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n");
            __builder.OpenElement(31, "form");
            __builder.AddAttribute(32, "onsubmit", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 44 "D:\NET\Fusion\HelloBlazorHybrid\UI\Pages\SimpleChat.razor"
                  Post

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "input-group pb-3");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "input-group-prepend");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "class", "form-control");
            __builder.AddAttribute(39, "placeholder", "Name");
            __builder.AddAttribute(40, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "D:\NET\Fusion\HelloBlazorHybrid\UI\Pages\SimpleChat.razor"
                                              Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Name = __value, Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "class", "form-control");
            __builder.AddAttribute(45, "placeholder", "Message");
            __builder.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "D:\NET\Fusion\HelloBlazorHybrid\UI\Pages\SimpleChat.razor"
                                          Message

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Message = __value, Message));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
            __builder.AddMarkupContent(49, "<div class=\"input-group-append\"><button type=\"submit\" class=\"btn btn-primary\">Post</button></div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "D:\NET\Fusion\HelloBlazorHybrid\UI\Pages\SimpleChat.razor"
       
    private string Name { get; set; } = "Neo";
    private string Message { get; set; } = "Red, please.";

    protected override async Task OnInitializedAsync()
        => await State.Update();

    protected override async Task<(string Name, string Message, string Time)[]> ComputeState(CancellationToken cancellationToken)
    {
        var messages = await Chat.GetMessagesAsync(20, cancellationToken);
        var result = new List<(string Name, string Message, string Time)>();
        foreach (var message in messages) {
            var momentsAgo = await Time.GetMomentsAgo(message.Time);
            result.Add((message.Name, message.Message, momentsAgo));
        }
        return result.ToArray();
    }

    private async Task Post()
    {
        if (Message == "")
            return;
        await Chat.PostMessageAsync(new(Name, Message));
        Message = "";
        await State.ApplyUserCausedUpdate();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigator { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFusionTime Time { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ChatService Chat { get; set; }
    }
}
#pragma warning restore 1591
