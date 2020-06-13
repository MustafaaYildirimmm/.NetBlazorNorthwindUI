using BlazorNorthwindUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorNorthwindUI.Services
{
    public class ProductService : IProductService
    {
        private HttpClient _httpClient;
        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task Add(ProductVM productVM)
        {
            await _httpClient.PostAsJsonAsync("https://localhost:44375/api/products/add", productVM);
        }

        public Task<ProductVM> GetProductById(int productId)
        {
            return _httpClient.GetFromJsonAsync<ProductVM>("https://localhost:44375/api/products/get?productId=" + productId);
        }

        public Task<ProductListVM[]> GetProducts()
        {
            return _httpClient.GetFromJsonAsync<ProductListVM[]>("https://localhost:44375/api/products/getall");
        }

        public async Task Save(ProductVM productVM)
        {
            await _httpClient.PostAsJsonAsync("https://localhost:44375/api/products/update", productVM);
        }

    }
}
