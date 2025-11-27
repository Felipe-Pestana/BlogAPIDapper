using Blog.API.Models.DTOs.Tag;

namespace Blog.API.Services.Interfaces
{
    public interface ITagService
    {
        Task<List<TagResponseDTO>> GetAllTagsAsync();
        Task CreateTagAsync(TagRequestDTO tag);
        Task UpdateTagAsync(int id, TagRequestDTO tag);
        Task DeleteTagAsync(int id);
    }
}
