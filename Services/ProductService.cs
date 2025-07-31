using Microsoft.EntityFrameworkCore;
using POSpresso.Data;
using POSpresso.Domain.Entities;
using POSpresso.Domain.DTO;
using System.Windows.Media.Effects;


namespace POSpresso.Services
{
    public class ProductService
    {
        private readonly POSDbContext _context;
        public ProductService(POSDbContext context)
        {
            _context = context;
        }

        public async Task<List<Products>> GetAllProductsAsync()
        {
            return await _context.Products
                .Include(p => p.ProductCategory)
                .ToListAsync();
        }

        public async Task AddProductAsync(ProductDTO productDto)
        {
            var product = new Products
            {
                ProductName = productDto.ProductName,
                ProductDescription = productDto.ProductDescription,
                ProductPrice = productDto.ProductPrice,
                ProductStatus = productDto.ProductStatus,
                ProductImage = productDto.ProductImage,
                CategoryId = productDto.CategoryID
            };
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateProductAsync(ProductDTO productDto)
        {
            var product = await _context.Products.FindAsync(productDto.ProductId);
            if (product == null)
                throw new Exception("Product not found");

            product.ProductName = productDto.ProductName;
            product.ProductDescription = productDto.ProductDescription;
            product.ProductPrice = productDto.ProductPrice;
            product.ProductStatus = productDto.ProductStatus;
            product.ProductImage = productDto.ProductImage;
            product.CategoryId = productDto.CategoryID;
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }
        public async Task<List<ProductCategory>> GetAllCategoriesAsync()
        {
            return await _context.ProductCategories
                                 .OrderBy(c => c.CategoryName)
                                 .ToListAsync();
        }

        public async Task<bool> DeleteProductAsync(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
                return false;
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
