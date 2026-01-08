using Drive.Models.Context;
using Drive.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace Drive.Services.Files
{
    public class FileService : IFileInterface
    {
        private readonly AppDbContext _context;

        public FileService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<FileModel>> GetFiles()
        {
            var files = await _context.Files.ToListAsync();

            return files;
        }
        public async Task<FileModel> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
                throw new ArgumentException("Arquivo inválido");

            using var ms = new MemoryStream();
            await file.CopyToAsync(ms);

            var fileModel = new FileModel
            {
                Id = Guid.NewGuid(),
                Name = Path.GetFileNameWithoutExtension(file.FileName),
                Extension = Path.GetExtension(file.FileName).TrimStart('.'),
                MimeTypes = file.ContentType,
                Size = file.Length,
                UploadDate = DateTime.UtcNow,
                FileBytes = ms.ToArray()
            };

            await _context.Files.AddAsync(fileModel);
            await _context.SaveChangesAsync();

            return fileModel;
        }
    }
}
