namespace Drive.Models.Entities
{
    public class FileModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Extension { get; set; }
        public string MimeTypes { get; set; }
        public long Size { get; set; }
        public DateTime UploadDate { get; set; }
        public byte[] FileBytes { get; set; }
    }
}
