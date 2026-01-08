using Drive.Dto.Response;
using Drive.Models.Entities;

namespace Drive.Services.Files
{
    public interface IFileInterface
    {
        Task<IEnumerable<FileResponse>> GetFiles();
        Task<FileModel> UploadFile(IFormFile file);
    }
}
