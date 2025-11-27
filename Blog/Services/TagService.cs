using Blog.API.Models;
using Blog.API.Models.DTOs.Tag;
using Blog.API.Repositories;
using Blog.API.Services.Interfaces;
using Microsoft.Data.SqlClient;

namespace Blog.API.Services
{
    public class TagService : ITagService
    {
        private TagRepository _tagRepository;
        
        public TagService(TagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

        public async Task CreateTagAsync(TagRequestDTO tag)
        {
            try
            {
                var newTag = new Tag(tag.Name, tag.Slug);

                await _tagRepository.CreateTagAsync(newTag);
            }
            catch (SqlException sqlEx)
            {
                throw new Exception(sqlEx.StackTrace);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.StackTrace);
            }
        }

        public Task DeleteTagAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TagResponseDTO>> GetAllTagsAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateTagAsync(int id, TagRequestDTO tag)
        {
            throw new NotImplementedException();
        }
    }
}
