using Blog.API.Controllers.Interfaces;
using Blog.API.Models.DTOs.User;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase, IUserController
    {
        public ActionResult HeartBeat()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult> CreateUser(UserRequestDTO user)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult<List<UserResponseDTO>>> GetAllCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult> UpdateUser(int id, UserRequestDTO user)
        {
            throw new NotImplementedException();
        }

        public Task<ActionResult> DeleteUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}
