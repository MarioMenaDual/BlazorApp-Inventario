#pragma checksum "C:\Users\Mario Mena\source\repos\inventary\Inventory\Components\Categories\UpdateCategoryComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad1e7198725888f7dc5d2a452dde5511adfca17e"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventory.Components.Categories
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
#line 1 "C:\Users\Mario Mena\source\repos\inventary\Inventory\Components\Categories\UpdateCategoryComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mario Mena\source\repos\inventary\Inventory\Components\Categories\UpdateCategoryComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class UpdateCategoryComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\Mario Mena\source\repos\inventary\Inventory\Components\Categories\UpdateCategoryComponent.razor"
                     oCategory

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\n\n        ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "form-group");
                __builder2.AddMarkupContent(8, "\n            ");
                __builder2.AddMarkupContent(9, "<label>Nombre de la categoria:</label>\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "class", "form-control");
                __builder2.AddAttribute(12, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\Mario Mena\source\repos\inventary\Inventory\Components\Categories\UpdateCategoryComponent.razor"
                                    oCategory.CategoryName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oCategory.CategoryName = __value, oCategory.CategoryName))));
                __builder2.AddAttribute(14, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => oCategory.CategoryName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\n\n        ");
                __builder2.OpenElement(17, "input");
                __builder2.AddAttribute(18, "type", "button");
                __builder2.AddAttribute(19, "value", "Actualizar Categoria");
                __builder2.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Mario Mena\source\repos\inventary\Inventory\Components\Categories\UpdateCategoryComponent.razor"
                                                                    UpdateCategory

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\Mario Mena\source\repos\inventary\Inventory\Components\Categories\UpdateCategoryComponent.razor"
        
    [Parameter]
    public string CategoryId { get; set; }


    CategoryEntity oCategory = new CategoryEntity();

    protected override async Task OnInitializedAsync()
    {

        oCategory = B_Category.CategoryById(CategoryId);
    }

    private void UpdateCategory()
    {
        B_Category.UpdateCategory(oCategory);

        NavManager.NavigateTo("categories/list");

    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591