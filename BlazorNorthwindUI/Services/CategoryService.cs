using BlazorNorthwindUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorNorthwindUI.Services
{
    public class CategoryService : ICategoryService
    {
        HttpClient _httpClient;
        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public Task<CategoryListVM[]> GetCategories()
        {
            return _httpClient.GetFromJsonAsync<CategoryListVM[]>("https://localhost:44375/api/categories/getall");
        }
    }
}
