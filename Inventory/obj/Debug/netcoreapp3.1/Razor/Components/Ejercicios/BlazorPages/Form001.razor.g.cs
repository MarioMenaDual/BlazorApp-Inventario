#pragma checksum "C:\Users\Mario Mena\source\repos\inventary\Inventory\Components\Ejercicios\BlazorPages\Form001.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7118021233ec5a3d0888a1201ac2269688e409e5"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventory.Components.Ejercicios.BlazorPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Mario Mena\source\repos\inventary\Inventory\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mario Mena\source\repos\inventary\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mario Mena\source\repos\inventary\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mario Mena\source\repos\inventary\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mario Mena\source\repos\inventary\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mario Mena\source\repos\inventary\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mario Mena\source\repos\inventary\Inventory\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Mario Mena\source\repos\inventary\Inventory\_Imports.razor"
using Inventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Mario Mena\source\repos\inventary\Inventory\_Imports.razor"
using Inventory.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Mario Mena\source\repos\inventary\Inventory\_Imports.razor"
using Inventory.Components.Ejercicios.BlazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Mario Mena\source\repos\inventary\Inventory\_Imports.razor"
using Inventory.Components.Ejercicios.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Mario Mena\source\repos\inventary\Inventory\_Imports.razor"
using Inventory.Components.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Mario Mena\source\repos\inventary\Inventory\_Imports.razor"
using Inventory.Components.Categories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Mario Mena\source\repos\inventary\Inventory\_Imports.razor"
using Inventory.Components.Warehouses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Mario Mena\source\repos\inventary\Inventory\_Imports.razor"
using Inventory.Components.Storages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Mario Mena\source\repos\inventary\Inventory\_Imports.razor"
using Inventory.Components.InOuts;

#line default
#line hidden
#nullable disable
    public partial class Form001 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "input");
            __builder.AddAttribute(1, "type", "text");
            __builder.AddAttribute(2, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 1 "C:\Users\Mario Mena\source\repos\inventary\Inventory\Components\Ejercicios\BlazorPages\Form001.razor"
                                 message

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => message = __value, message));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\n");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 2 "C:\Users\Mario Mena\source\repos\inventary\Inventory\Components\Ejercicios\BlazorPages\Form001.razor"
                                 text

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => text = __value, text));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "button");
            __builder.AddAttribute(12, "value", "Haga clic aqui");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "C:\Users\Mario Mena\source\repos\inventary\Inventory\Components\Ejercicios\BlazorPages\Form001.razor"
                                                      ChangeText

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n");
            __builder.OpenElement(15, "div");
            __builder.AddMarkupContent(16, "\n    ");
#nullable restore
#line 5 "C:\Users\Mario Mena\source\repos\inventary\Inventory\Components\Ejercicios\BlazorPages\Form001.razor"
__builder.AddContent(17, message);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(18, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\Mario Mena\source\repos\inventary\Inventory\Components\Ejercicios\BlazorPages\Form001.razor"
      
    [Parameter]
    public string Message { get; set; }

    string message = "Un contenido";
    string text;

    protected override async Task OnInitializedAsync()
    {
        message = Message;
    }

    private void ChangeText()
    {
        message = text;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591