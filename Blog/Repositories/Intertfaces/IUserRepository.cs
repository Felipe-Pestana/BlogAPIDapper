using Blog.API.Models;
using Blog.API.Models.DTOs.User;

namespace Blog.API.Repositories.Intertfaces
{
    public interface IUserRespository
    {
        Task<List<UserResponseDTO>> GetAllCategoriesAsync();
        Task CreateUserAsync(User User);
    }
}
