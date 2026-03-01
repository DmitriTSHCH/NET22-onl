using LibraryDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryDb.Configurations
{
    public class AuthorConfigurations : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(t => t.Id);

            builder
                .HasMany<Book>()
                .WithOne()
                .HasForeignKey(b => b.AuthorId);

            builder
                .HasOne<AuthorBiography>()
                .WithOne()
                .HasForeignKey<AuthorBiography>(b => b.AuthorId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
