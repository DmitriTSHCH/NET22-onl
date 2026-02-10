using LibraryDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryDb.Configurations
{
    public class BookDetailConfigurations : IEntityTypeConfiguration<BookDetail>
    {
        public void Configure(EntityTypeBuilder<BookDetail> builder)
        {
            builder.HasKey(t => t.Id);

            builder
                .HasOne<Book>()
                .WithOne()
                .HasForeignKey<BookDetail>(d => d.BookId);
        }
    }
}
