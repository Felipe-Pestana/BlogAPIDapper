using Blog.API.Models.DTOs.User;
using Microsoft.AspNetCore.Mvc;

namespace Blog.API.Controllers.Interfaces
{
    public interface IUserController
    {
        ActionResult HeartBeat();
        Task<ActionResult<List<UserResponseDTO>>> GetAllCategoriesAsync();
        Task<ActionResult> CreateUser(UserRequestDTO User);
        Task<ActionResult> UpdateUser(int id, UserRequestDTO User);
        Task<ActionResult> DeleteUser(int id);
    }
}
