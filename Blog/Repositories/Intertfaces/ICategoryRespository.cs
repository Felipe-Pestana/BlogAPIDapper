using Blog.API.Models;
using Blog.API.Models.DTOs.Category;

namespace Blog.API.Repositories.Intertfaces
{
    public interface ICategoryRespository
    {
        Task<List<CategoryResponseDTO>> GetAllCategoriesAsync();
        Task CreateCategoryAsync(Category category);
        Task<Category?> GetCategoryByIdAsync(int id);
        Task UpdateCategoryAsync(int id, Category category);
    }
}
