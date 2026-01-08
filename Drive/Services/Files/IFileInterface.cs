using Drive.Models.Entities;

namespace Drive.Services.Files
{
    public interface IFileInterface
    {
        Task<IEnumerable<FileModel>> GetFiles();
        Task<FileModel> UploadFile(IFormFile file);
    }
}
