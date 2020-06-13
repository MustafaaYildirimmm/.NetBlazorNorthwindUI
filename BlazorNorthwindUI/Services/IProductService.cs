using BlazorNorthwindUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorNorthwindUI.Services
{
    public interface IProductService
    {
        Task<ProductListVM[]> GetProducts();
        Task Add(ProductVM productVM);
        Task Save(ProductVM productVM);
        Task<ProductVM> GetProductById(int productId);
    }
}
