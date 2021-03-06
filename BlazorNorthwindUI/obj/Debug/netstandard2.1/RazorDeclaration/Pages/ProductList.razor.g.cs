#pragma checksum "C:\Users\msft_\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d41bfb549e9fd38cd1d0d1a70c80e4cb2203d2a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorNorthwindUI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\msft_\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\msft_\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\msft_\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\msft_\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\msft_\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\msft_\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\msft_\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\msft_\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\_Imports.razor"
using BlazorNorthwindUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\msft_\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\_Imports.razor"
using BlazorNorthwindUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\msft_\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductList.razor"
using BlazorNorthwindUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\msft_\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductList.razor"
using BlazorNorthwindUI.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/productlist")]
    public partial class ProductList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\msft_\source\repos\BlazorNorthwindUI\BlazorNorthwindUI\Pages\ProductList.razor"
        
    ProductListVM[] products;

    protected override async Task OnInitializedAsync()
    {
        products = await ProductService.GetProducts();
    }

    void GoToDetail(int productId)
    {
        NavigationManager.NavigateTo("/productdetail/" + productId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
