using Drive.Services.Files;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.IdentityModel.Tokens;

namespace Drive.Endpoints
{
    public static class FileEndpoints
    {
        public static void MapFileEndPoints(this WebApplication app)
        { 
            app.MapGroup("/files");
            app.MapGet("/", async (IFileInterface fileInterface) =>
            {
                return Results.Ok(await fileInterface.GetFiles());
            });
            app.MapPost("/", async (IFormFile file, IFileInterface fileInterface) =>
            {
                return Results.Ok(await fileInterface.UploadFile(file));
            }).DisableAntiforgery();
        }
    }
}
