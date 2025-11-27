using Blog.API.Models.DTOs.Category;
using Microsoft.AspNetCore.Mvc;

namespace Blog.API.Controllers.Interfaces
{
    public interface ICategoryController
    {
        ActionResult HeartBeat();
        Task<ActionResult<List<CategoryResponseDTO>>> GetAllCategoriesAsync();
        Task<ActionResult> CreateCategory(CategoryRequestDTO category);
        Task<ActionResult> UpdateCategory(int id, CategoryRequestDTO category);
        Task<ActionResult> DeleteCategory(int id);

    }
}
