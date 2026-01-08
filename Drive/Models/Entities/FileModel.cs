namespace Drive.Models.Entities
{
    public class FileModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string Extension { get; set; } = null!;
        public string MimeTypes { get; set; } = null!;
        public long Size { get; set; }
        public DateTime UploadDate { get; set; }
        public byte[] FileBytes { get; set; } = null!;
    }
}
