// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Inventory.Components.InOuts
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
#nullable restore
#line 1 "C:\Users\Mario Mena\source\repos\inventary\Inventory\Components\InOuts\ListInOutsComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mario Mena\source\repos\inventary\Inventory\Components\InOuts\ListInOutsComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class ListInOutsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\Mario Mena\source\repos\inventary\Inventory\Components\InOuts\ListInOutsComponent.razor"
        List<InOutEntity> inouts = new List<InOutEntity>();
    List<InOutEntity> tempInouts = new List<InOutEntity>();
    List<StorageEntity> storages = new List<StorageEntity>();



    protected override async Task OnInitializedAsync()
    {
        inouts = B_InputOutput.InOutList();
        tempInouts = inouts;
        storages = B_Storage.StorageList();
    }

    private void StorageChanged(ChangeEventArgs e)
    {

        tempInouts = inouts.Where(c => c.StorageId == e.Value.ToString()).ToList();


    } 

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
