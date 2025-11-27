using Blog.API.Data;
using Blog.API.Models;
using Blog.API.Models.DTOs.Tag;
using Blog.API.Repositories.Intertfaces;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Blog.API.Repositories
{
    public class TagRepository : ITagRespository
    {
        private SqlConnection _connection;

        public TagRepository(ConnectionDB connection)
        {
            _connection = connection.GetConnection();
        }

        public async Task CreateTagAsync(Tag tag)
        {
            var sql = "INSERT INTO Tags (Name, Slug) VALUES (@Name, @Slug)";

            try
            {
                await _connection.ExecuteAsync(sql, new { tag.Name, tag.Slug });
            }
            catch (SqlException sqlEx)
            {
                throw new Exception(sqlEx.StackTrace);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.StackTrace);
            }

        }

        public async Task<List<TagResponseDTO>> GetAllCategoriesAsync()
        {
            try
            {
                var sql = "SELECT Name, Slug FROM Tags";

                var tags = (await _connection.QueryAsync<TagResponseDTO>(sql)).ToList();

                return tags;
            }
            catch (SqlException sqlEx)
            {
                throw new Exception(sqlEx.StackTrace);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.StackTrace);
            }

        }

        public async Task<Tag?> GetTagByIdAsync(int id)
        {
            try
            {
                var sql = "SELECT Id, Name, Slug FROM Tags WHERE Id = @Id";

                return await _connection.QueryFirstOrDefaultAsync<Tag>(sql, new { Id = id });
            }
            catch (SqlException sqlEx)
            {
                throw new Exception(sqlEx.StackTrace);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.StackTrace);
            }
        }

        public async Task UpdateTagAsync(Tag tag)
        {
            try
            {
                var sql = "UPDATE Tags SET Name = @Name, Slug = @Slug WHERE Id = @Id";

                await _connection.ExecuteAsync(sql, new { tag.Name, tag.Slug, tag.Id });
            }
            catch (SqlException sqlEx)
            {
                throw new Exception(sqlEx.StackTrace);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.StackTrace);
            }
        }
    }
}
