using Blog.API.Controllers.Interfaces;
using Blog.API.Models.DTOs.Role;
using Blog.API.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase, IRoleController
    {
        private readonly ILogger<RoleController> _logger;
        private RoleService _roleService;

        public RoleController(ILogger<RoleController> logger, RoleService roleService)
        {
            _logger = logger;
            _roleService = roleService;
        }

        [HttpGet]
        public ActionResult HeartBeat()
        {
            return Ok();
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<RoleResponseDTO>>> GetAllRolesAsync()
        {
            try
            {
                var roles = await _roleService.GetAllRolesAsync();

                if (roles is null)
                    return NoContent();

                return Ok(roles);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving categories at {time}", DateTime.UtcNow);

                return Problem(ex.Message);
            }
        }

        [HttpPut("Update/{id}")]
        public Task<ActionResult> UpdateRole(int id, RoleRequestDTO role)
        {
            throw new NotImplementedException();
        }
        [HttpPost("Create")]
        public Task<ActionResult> CreateRole(RoleRequestDTO role)
        {
            throw new NotImplementedException();
        }
        [HttpDelete("Delete/{id}")]
        public Task<ActionResult> DeleteRole(int id)
        {
            throw new NotImplementedException();
        }

        
    }
}
