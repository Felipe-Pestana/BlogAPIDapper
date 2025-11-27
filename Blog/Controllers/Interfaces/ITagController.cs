using Blog.API.Models.DTOs.Tag;
using Microsoft.AspNetCore.Mvc;

namespace Blog.API.Controllers.Interfaces
{
    public interface ITagController
    {
        ActionResult HeartBeat();
        Task<ActionResult<List<TagResponseDTO>>> GetAllTagsAsync();
        Task<ActionResult> CreateTag(TagRequestDTO tag);
        Task<ActionResult> UpdateTag(int id, TagRequestDTO tag);
        Task<ActionResult> DeleteTag(int id);
    }
}
