using Blog.API.Models.DTOs.Role;
using Microsoft.AspNetCore.Mvc;

namespace Blog.API.Controllers.Interfaces
{
    public interface IRoleController
    {
        ActionResult HeartBeat();
        Task<ActionResult<List<RoleResponseDTO>>> GetAllRolesAsync();
        Task<ActionResult> CreateRole(RoleRequestDTO role);
        Task<ActionResult> UpdateRole(int id, RoleRequestDTO role);
        Task<ActionResult> DeleteRole(int id);
    }
}
