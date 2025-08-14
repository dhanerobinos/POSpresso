
using POSpresso.Domain.DTO;
using POSpresso.Domain.Enums;

namespace POSpresso.Interfaces
{
    public interface IManageCategoryService
    {
        Task<List<ProductCategoryDTO>> GetAllCategoriesAsync();
        Task AddCategoryAsync(ProductCategoryDTO dto);
        Task UpdateCategoryAsync(ProductCategoryDTO categoryDTO);
        Task SetCategoryStatusAsync(int categoryId, ProductCategoryStatusEnum status);
    }
}
