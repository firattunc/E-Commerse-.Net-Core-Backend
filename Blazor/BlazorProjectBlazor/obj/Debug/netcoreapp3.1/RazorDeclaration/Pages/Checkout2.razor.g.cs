#pragma checksum "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Checkout2.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "745d16c0b1666347ecf87af3c460b73b4c20dd3c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorProjectBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using BlazorProjectBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using BlazorProjectBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using Northwİnd.Blazor.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using BlazorProjectBlazor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using BlazorProjectBlazor.Services.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Checkout2.razor"
using Northwİnd.Blazor.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Checkout2.razor"
using Northwİnd.Blazor.Services.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Checkout2.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/checkout2")]
    public partial class Checkout2 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 85 "C:\Users\lenovo\Desktop\BlazorProjectBlazorFrontend\BlazorProjectBlazor\Pages\Checkout2.razor"
       
    List<Cargo> Cargos = new List<Cargo>();
    OrderModel orderModel = new OrderModel();
    public decimal SubTotal { get; set; }
    public decimal Total { get; set; }
    public int CargoId { get; set; }
    protected override async Task OnInitializedAsync()
    {
        var result = await sessionStorage.GetItemAsync<OrderModel>("order");
        if (result != null)
        {
            orderModel = result;
        }
        SubTotal = await sessionStorage.GetItemAsync<decimal>("subtotal");
        Cargos = await CargoService.GetCargos();
        Total = SubTotal + 10;
    }
    void SetCargoId(int cargoId)
    {
        CargoId = cargoId;
        Console.WriteLine(CargoId);
    }
    async Task SetCargo()
    {
        orderModel.CargoId = CargoId;
        await sessionStorage.SetItemAsync("order", orderModel);
        NavigationManager.NavigateTo("/checkout3");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICargoService CargoService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591