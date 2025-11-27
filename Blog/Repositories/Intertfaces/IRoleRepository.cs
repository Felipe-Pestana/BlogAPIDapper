using Blog.API.Models;
using Blog.API.Models.DTOs.Role;

namespace Blog.API.Repositories.Intertfaces
{
    public interface IRoleRespository
    {
        Task<List<RoleResponseDTO>> GetAllRolesAsync();
        Task CreateRoleAsync(Role role);
    }
}
