using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Todo.Models;
using Todo.Profiles;

var builder = WebApplication.CreateBuilder(args);

// 添加数据库上下文
builder.Services.AddDbContext<TodoContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("TodoDatabase")));

// 添加 AutoMapper
builder.Services.AddAutoMapper(typeof(TodoListProfile), typeof(UploadFileProfile));

// 添加控制器
builder.Services.AddControllers().AddNewtonsoftJson();

var app = builder.Build();

// 配置 HTTP 请求管道
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
