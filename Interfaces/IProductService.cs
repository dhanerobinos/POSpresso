using POSpresso.Domain.DTO;
using POSpresso.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSpresso.Interfaces
{
    public interface IProductService
    {
        Task<List<Products>> GetAllProductsAsync();
        Task<List<ProductCategoryDTO>> GetAllCategoriesAsync();
        Task<List<ProductDTO>> GetProductsByCategoryAsync(int categoryId);
        Task AddProductAsync(ProductDTO productDto);
        Task UpdateProductAsync(ProductDTO productDto);
        Task<bool> DeleteProductAsync(int productId);
        ProductDTO GetProductDTO(Products product);

    }
}
