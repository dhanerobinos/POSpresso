using Microsoft.EntityFrameworkCore;
using POSpresso.Data;
using POSpresso.Domain.DTO;
using POSpresso.Domain.Entities;
using POSpresso.Domain.Enums;
using POSpresso.Interfaces;

public class ProductService : IProductService
{
    private readonly IDbContextFactory<POSDbContext> _contextFactory;

    public ProductService(IDbContextFactory<POSDbContext> contextFactory)
    {
        _contextFactory = contextFactory;
    }

    public async Task<List<Products>> GetAllProductsAsync()
    {
        using var context = _contextFactory.CreateDbContext();
        return await context.Products
            .Include(p => p.ProductCategory)
            .ToListAsync();
    }

    public async Task AddProductAsync(ProductDTO productDto)
    {
        using var context = _contextFactory.CreateDbContext();

        var existingProduct = await context.Products
            .AsNoTracking()
            .FirstOrDefaultAsync(u => u.ProductName == productDto.ProductName);

        if (existingProduct != null)
            throw new InvalidOperationException("Product already exists.");

        var product = new Products
        {
            ProductName = productDto.ProductName,
            ProductDescription = productDto.ProductDescription,
            ProductPrice = productDto.ProductPrice,
            ProductStatus = productDto.ProductStatus,
            ProductImage = productDto.ProductImage,
            CategoryId = productDto.CategoryID
        };

        context.Products.Add(product);
        await context.SaveChangesAsync();
    }

    public async Task UpdateProductAsync(ProductDTO productDto)
    {
        using var context = _contextFactory.CreateDbContext();

        var product = await context.Products.FindAsync(productDto.ProductId);
        if (product == null)
            throw new Exception("Product not found");

        product.ProductName = productDto.ProductName;
        product.ProductDescription = productDto.ProductDescription;
        product.ProductPrice = productDto.ProductPrice;
        product.ProductStatus = productDto.ProductStatus;
        product.ProductImage = productDto.ProductImage;
        product.CategoryId = productDto.CategoryID;

        context.Products.Update(product);
        await context.SaveChangesAsync();
    }

    public async Task<List<ProductCategoryDTO>> GetAllCategoriesAsync()
    {
        using var context = _contextFactory.CreateDbContext();

        return await context.ProductCategories
            .OrderBy(c => c.CategoryName)
            .Select(c => new ProductCategoryDTO
            {
                CategoryID = c.CategoryID,
                CategoryName = c.CategoryName,
                CategoryStatus = c.CategoryStatus,
                CategoryImage = c.CategoryImage
            })
            .ToListAsync();
    }

    public ProductDTO GetProductDTO(Products product)
    {
        return new ProductDTO
        {
            ProductId = product.ProductId,
            ProductName = product.ProductName,
            ProductDescription = product.ProductDescription,
            ProductPrice = product.ProductPrice,
            ProductStatus = product.ProductStatus,
            ProductCreatedAt = product.ProductCreatedAt,
            ProductImage = product.ProductImage,
            CategoryID = product.CategoryId
        };
    }

    public async Task<bool> DeleteProductAsync(int productId)
    {
        using var context = _contextFactory.CreateDbContext();

        var product = await context.Products.FindAsync(productId);
        if (product == null)
            return false;

        context.Products.Remove(product);
        await context.SaveChangesAsync();
        return true;
    }

    public async Task<List<ProductDTO>> GetProductsByCategoryAsync(int categoryId)
    {
        using var context = _contextFactory.CreateDbContext();

        return await context.Products
            .Where(p => p.CategoryId == categoryId && p.ProductStatus == ProductStatus.Available)
            .Select(p => new ProductDTO
            {
                ProductId = p.ProductId,
                ProductName = p.ProductName,
                ProductPrice = p.ProductPrice,
                ProductImage = p.ProductImage,
                ProductDescription = p.ProductDescription,
                ProductCreatedAt = p.ProductCreatedAt,
                ProductStatus = p.ProductStatus,
                CategoryID = p.CategoryId
            })
            .ToListAsync();
    }
}
