using LibraryDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryDb.Configurations
{
    public class PublisherConfigurations : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.HasKey(t => t.Id);

            builder
                .HasMany<Book>()
                .WithOne()
                .HasForeignKey(b => b.PublisherId);
        }
    }
}
