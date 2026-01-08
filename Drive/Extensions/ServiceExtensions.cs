using Drive.Models.Context;
using Drive.Services.Files;
using Microsoft.EntityFrameworkCore;

namespace EstruturaMinimalApi.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddOpenApi();

            builder.Services.AddScoped<IFileInterface, FileService>();

            builder.Services.AddDbContext<AppDbContext>(options => {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });
        }
    }
}