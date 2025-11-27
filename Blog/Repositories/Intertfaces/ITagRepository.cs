using Blog.API.Models;
using Blog.API.Models.DTOs.Tag;

namespace Blog.API.Repositories.Intertfaces
{
    public interface ITagRespository
    {
        Task<List<TagResponseDTO>> GetAllCategoriesAsync();
        Task CreateTagAsync(Tag tag);
        Task UpdateTagAsync(Tag tag);
        Task<Tag?> GetTagByIdAsync(int id);
    }
}
