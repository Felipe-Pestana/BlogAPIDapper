using Blog.API.Controllers.Interfaces;
using Blog.API.Models.DTOs.Tag;
using Blog.API.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagController : ControllerBase, ITagController
    {
        private TagService _tagService;
        private ILogger _logger;

        public TagController(TagService service, ILogger logger)
        {
            _tagService = service;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult HeartBeat()
        {
            _logger.LogInformation("TagController HeartBeat checked");
            return Ok();
        }


        [HttpPost]
        public async Task<ActionResult> CreateTag(TagRequestDTO tag)
        {
            await _tagService.CreateTagAsync(tag);

            return Created();
        }
        [HttpGet]
        public async Task<ActionResult<List<TagResponseDTO>>> GetAllTagsAsync()
        {
            var tags = await _tagService.GetAllTagsAsync();

            return Ok(tags);
        }
        
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateTag(int id, TagRequestDTO tag)
        {
            await _tagService.UpdateTagAsync(id, tag);

            return NoContent();
        }
        [HttpDelete("{id}")]
        public Task<ActionResult> DeleteTag(int id)
        {
            throw new NotImplementedException();
        }
    }
}
