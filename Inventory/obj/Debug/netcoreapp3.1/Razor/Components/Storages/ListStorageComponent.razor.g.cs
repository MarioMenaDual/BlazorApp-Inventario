#pragma checksum "C:\Users\Mario Mena\source\repos\inventary\Inventory\Components\Storages\ListStorageComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6120736f9c7c753eb68aaf5be50365f9727c580"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventory.Components.Storages
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
#line 1 "C:\Users\Mario Mena\source\repos\inventary\Inventory\Components\Storages\ListStorageComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mario Mena\source\repos\inventary\Inventory\Components\Storages\ListStorageComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class ListStorageComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<hr>\n");
            __builder.OpenElement(1, "select");
            __builder.AddAttribute(2, "class", "form-control");
            __builder.AddAttribute(3, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\Mario Mena\source\repos\inventary\Inventory\Components\Storages\ListStorageComponent.razor"
                                        WarehouseChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(4, "\n    ");
            __builder.OpenElement(5, "option");
            __builder.AddAttribute(6, "value", "n");
            __builder.AddContent(7, "Ver Todo el almacenamiento");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n");
#nullable restore
#line 7 "C:\Users\Mario Mena\source\repos\inventary\Inventory\Components\Storages\ListStorageComponent.razor"
     foreach (var warehouse in warehouses)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "option");
            __builder.AddAttribute(10, "value", 
#nullable restore
#line 9 "C:\Users\Mario Mena\source\repos\inventary\Inventory\Components\Storages\ListStorageComponent.razor"
                warehouse.WarehouseId

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 9 "C:\Users\Mario Mena\source\repos\inventary\Inventory\Components\Storages\ListStorageComponent.razor"
__builder.AddContent(11, warehouse.WarehouseName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n");
#nullable restore
#line 10 "C:\Users\Mario Mena\source\repos\inventary\Inventory\Components\Storages\ListStorageComponent.razor"
}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n<hr>\n\n");
            __builder.OpenElement(14, "table");
            __builder.AddAttribute(15, "class", "table table-hover table-bordered");
            __builder.AddMarkupContent(16, "\n    ");
            __builder.AddMarkupContent(17, @"<thead class=""table table-dark"">
        <tr>
            <th>Referencia</th>
            <th>Ultima actualizacion</th>
            <th>Cantidad parcial</th>
            <th>Producto</th>
            <th>Almacen</th>
            <th></th>
        </tr>
    </thead>
    ");
            __builder.OpenElement(18, "tbody");
            __builder.AddMarkupContent(19, "\n");
#nullable restore
#line 26 "C:\Users\Mario Mena\source\repos\inventary\Inventory\Components\Storages\ListStorageComponent.razor"
         foreach (var storage in tempStorages)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "tr");
            __builder.AddMarkupContent(21, "\n    ");
            __builder.OpenElement(22, "td");
#nullable restore
#line 29 "C:\Users\Mario Mena\source\repos\inventary\Inventory\Components\Storages\ListStorageComponent.razor"
__builder.AddContent(23, storage.StorageId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n    ");
            __builder.OpenElement(25, "td");
#nullable restore
#line 30 "C:\Users\Mario Mena\source\repos\inventary\Inventory\Components\Storages\ListStorageComponent.razor"
__builder.AddContent(26, storage.LastUpdate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\n    ");
            __builder.OpenElement(28, "td");
#nullable restore
#line 31 "C:\Users\Mario Mena\source\repos\inventary\Inventory\Components\Storages\ListStorageComponent.razor"
__builder.AddContent(29, storage.PartialQuantity);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n    ");
            __builder.OpenElement(31, "td");
#nullable restore
#line 32 "C:\Users\Mario Mena\source\repos\inventary\Inventory\Components\Storages\ListStorageComponent.razor"
__builder.AddContent(32, storage.ProductId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\n    ");
            __builder.OpenElement(34, "td");
#nullable restore
#line 33 "C:\Users\Mario Mena\source\repos\inventary\Inventory\Components\Storages\ListStorageComponent.razor"
__builder.AddContent(35, storage.WarehouseId);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n    ");
            __builder.OpenElement(37, "td");
            __builder.AddMarkupContent(38, "\n        ");
            __builder.OpenElement(39, "a");
            __builder.AddAttribute(40, "href", "storage/update/" + (
#nullable restore
#line 35 "C:\Users\Mario Mena\source\repos\inventary\Inventory\Components\Storages\ListStorageComponent.razor"
                                 storage.StorageId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "class", "btn btn-info btn-sm active");
            __builder.AddAttribute(42, "role", "button");
            __builder.AddAttribute(43, "aria-pressed", "true");
            __builder.AddMarkupContent(44, "\n            <span class=\"oi oi-pencil\" aria-hidden=\"true\"></span> Editar\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n");
#nullable restore
#line 40 "C:\Users\Mario Mena\source\repos\inventary\Inventory\Components\Storages\ListStorageComponent.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddContent(48, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\Mario Mena\source\repos\inventary\Inventory\Components\Storages\ListStorageComponent.razor"
        List<StorageEntity> storages = new List<StorageEntity>();

    List<StorageEntity> tempStorages = new List<StorageEntity>();

    List<WarehouseEntity> warehouses = new List<WarehouseEntity>();


    protected override async Task OnInitializedAsync()
    {
        storages = B_Storage.StorageList();
        tempStorages = storages;
        warehouses = B_Warehouse.WarehouseList();
    }

    private void WarehouseChanged(ChangeEventArgs e)
    {

        tempStorages = storages.Where(c => c.WarehouseId == e.Value.ToString()).ToList();


    }

    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591