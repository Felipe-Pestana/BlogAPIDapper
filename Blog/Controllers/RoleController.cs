using Blog.API.Controllers.Interfaces;
using Blog.API.Models.DTOs.Role;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase, IRoleController
    {
        
        public ActionResult HeartBeat()
        {
            throw new NotImplementedException();
        }
        public Task<ActionResult<List<RoleResponseDTO>>> GetAllRolesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult> UpdateRole(int id, RoleRequestDTO role)
        {
            throw new NotImplementedException();
        }
        public Task<ActionResult> CreateRole(RoleRequestDTO role)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult> DeleteRole(int id)
        {
            throw new NotImplementedException();
        }

        
    }
}
