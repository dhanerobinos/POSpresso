using Microsoft.EntityFrameworkCore;
using POSpresso.Data;
using POSpresso.Domain.DTO;
using POSpresso.Domain.Entities;
using POSpresso.Domain.Enums;
using POSpresso.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSpresso.Services
{
    public class ManageCategoryService : IManageCategoryService
    {
        private readonly POSDbContext _context;

        public ManageCategoryService(POSDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProductCategoryDTO>> GetAllCategoriesAsync()
        {
            return await _context.ProductCategories
                 .Select(c => new ProductCategoryDTO
                 {
                     CategoryID = c.CategoryID,
                     CategoryName = c.CategoryName,
                     CategoryImage = c.CategoryImage,
                     CategoryStatus = c.CategoryStatus
                 })
                .ToListAsync();
        }

        public async Task AddCategoryAsync(ProductCategoryDTO dto)
        {
            var existingCategory = await _context.ProductCategories
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.CategoryName.ToLower() == dto.CategoryName.ToLower());

            if (existingCategory != null)
                throw new InvalidOperationException("Category already exists.");

            var category = new ProductCategory
            {
                CategoryName = dto.CategoryName,
                CategoryImage = dto.CategoryImage,
            };

            _context.ProductCategories.Add(category);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCategoryAsync(ProductCategoryDTO categoryDTO)
        {
            var categories = await _context.ProductCategories.FindAsync(categoryDTO.CategoryID);
            if (categories == null)
                throw new Exception("Category not found");

            categories.CategoryName = categoryDTO.CategoryName;
            categories.CategoryImage = categoryDTO.CategoryImage;
            categories.CategoryStatus = categoryDTO.CategoryStatus;
            _context.ProductCategories.Update(categories);
            await _context.SaveChangesAsync();
        }

        public async Task SetCategoryStatusAsync(int categoryId, ProductCategoryStatusEnum status)
        {
            var category = await _context.ProductCategories.FindAsync(categoryId);
            if (category == null)
                throw new InvalidOperationException("Category not found.");

            category.CategoryStatus = status;
            await _context.SaveChangesAsync();
        }

        public async Task<ProductCategoryDTO?> GetCategoryByIdAsync(int categoryId)
        {
            return await _context.ProductCategories
                .Where(c => c.CategoryID == categoryId)
                .Select(c => new ProductCategoryDTO
                {
                    CategoryID = c.CategoryID,
                    CategoryName = c.CategoryName,
                    CategoryImage = c.CategoryImage,
                    CategoryStatus = c.CategoryStatus
                })
                .FirstOrDefaultAsync();
        }
    }
}
