using Blog.API.Data;
using Blog.API.Models;
using Blog.API.Models.DTOs.Role;
using Blog.API.Repositories.Intertfaces;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Blog.API.Repositories
{
    public class RoleRepository : IRoleRespository
    {
        private readonly SqlConnection _connection;

        private readonly ILogger<RoleRepository> _logger;

        public RoleRepository(ConnectionDB connection, ILogger<RoleRepository> logger)
        {
            _connection = connection.GetConnection();
            _logger = logger;
        }

        public async Task CreateRoleAsync(Role role)
        {
            try
            {
                var sql = "INSERT INTO Roles (Name, Slug) VALUES (@Name, @Slug)";

                await _connection.ExecuteAsync(sql, new { role.Name, role.Slug });

            }
            catch (SqlException sqlEx)
            {
                throw new Exception(sqlEx.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.StackTrace);
            }
        }

        public async Task<List<RoleResponseDTO>> GetAllRolesAsync()
        {
            try
            {
                var sql = "SELECT Name, Slug FROM Roles";

                return (await _connection.QueryAsync<RoleResponseDTO>(sql)).ToList();
            }
            catch (SqlException sqlEx)
            {
                throw new Exception(sqlEx.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.StackTrace);

            }
        }
    }
}
