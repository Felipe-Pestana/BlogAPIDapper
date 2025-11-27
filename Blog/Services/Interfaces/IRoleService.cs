using Blog.API.Models.DTOs.Role;

namespace Blog.API.Services.Interfaces
{
    public interface IRoleService
    {
        Task<List<RoleResponseDTO>> GetAllRolesAsync();
        Task CreateRoleAsync(RoleRequestDTO role);
        Task UpdateRoleAsync(int id, RoleRequestDTO role);
        Task DeleteRoleAsync(int id);
    }
}
