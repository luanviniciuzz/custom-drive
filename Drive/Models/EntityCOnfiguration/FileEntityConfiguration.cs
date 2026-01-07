using Drive.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Drive.Models.EntityCOnfiguration
{
    public class FileEntityConfiguration :IEntityTypeConfiguration<FileModel>
    {
        public void Configure(EntityTypeBuilder<FileModel> builder)
        {
            builder.ToTable("Files");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Extension).IsRequired().HasMaxLength(50);
            builder.Property(x => x.MimeTypes).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Size).IsRequired();
            builder.Property(x => x.UploadDate).IsRequired().HasColumnType("datetime2");
            builder.Property(x => x.FileBytes).IsRequired().HasColumnType("varbinary(max)");
        }
    }
}
