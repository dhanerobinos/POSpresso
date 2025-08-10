
using POSpresso.Domain.DTO;

namespace POSpresso.Interfaces
{
    public interface IManageCategoryService
    {
        Task<List<ProductCategoryDTO>> GetAllCategoriesAsync();
        Task AddCategoryAsync(ProductCategoryDTO dto);
    }
}
