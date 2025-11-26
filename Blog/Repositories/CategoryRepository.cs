using Blog.API.Data;
using Blog.API.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Blog.API.Repositories
{
    public class CategoryRepository
    {
        private readonly SqlConnection _connection;

        public CategoryRepository(ConnectionDB connection)
        {
            _connection = connection.GetConnection();
        }

        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            var sql = "SELECT * FROM Category";

            return (await _connection.QueryAsync<Category>(sql)).ToList();
        }

        public async Task CreateCategoryAsync(Category category)
        {
            var sql = "INSERT INTO Category (Name, Slug) VALUES (@Name, @Slug)";

            await _connection.ExecuteAsync(sql, new { category.Name, category.Slug });
        }
    }
}
