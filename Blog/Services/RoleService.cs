using Blog.API.Models;
using Blog.API.Models.DTOs.Role;
using Blog.API.Repositories;
using Blog.API.Services.Interfaces;

namespace Blog.API.Services
{
    public class RoleService : IRoleService
    {
        private RoleRepository _roleRepository;

        public RoleService(RoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task CreateRoleAsync(RoleRequestDTO role)
        {
            try
            {
                var newRole = new Role(role.Name, role.Name.ToLower().Replace(" ", "-"));
                await _roleRepository.CreateRoleAsync(newRole);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.StackTrace);
            }
        }

        public Task DeleteRoleAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<RoleResponseDTO>> GetAllRolesAsync()
        {
            try
            {
                return await _roleRepository.GetAllRolesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.StackTrace);
            }
        }

        public Task UpdateRoleAsync(int id, RoleRequestDTO role)
        {
            throw new NotImplementedException();
        }
    }
}
