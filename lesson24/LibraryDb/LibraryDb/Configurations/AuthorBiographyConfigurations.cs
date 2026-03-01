using LibraryDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryDb.Configurations
{
    public class AuthorBiographyConfigurations : IEntityTypeConfiguration<AuthorBiography>
    {
         public void Configure(EntityTypeBuilder<AuthorBiography> builder)
         {
             builder.HasKey(t => t.Id);

            builder
               .HasOne<Author>()
               .WithOne()
               .HasForeignKey<AuthorBiography>(b => b.AuthorId);
         }
    }
}
