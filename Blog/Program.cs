using Blog.API.Data;
using Blog.API.Repositories;
using Blog.API.Services;

using Blog.API.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddSingleton<ConnectionDB>();

builder.Services.AddSingleton<CategoryRepository>();
builder.Services.AddSingleton<RoleRepository>();
builder.Services.AddSingleton<TagRepository>();

builder.Services.AddSingleton<ITagService, TagService>();
builder.Services.AddSingleton<IRoleService, RoleService>();
builder.Services.AddSingleton<ICategoryService, CategoryService>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
