using LibraryDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryDb.Configurations
{
    public class BookConfigurations : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(t => t.Id);

            builder
                .HasOne<Author>()
                .WithMany()
                .HasForeignKey(b => b.AuthorId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne<Publisher>()
                .WithMany()
                .HasForeignKey(b => b.PublisherId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany<Category>()
                .WithMany()
                .UsingEntity(b => b.ToTable("BookCategory"));

            builder
                .HasOne<BookDetail>()
                .WithOne()
                .HasForeignKey<BookDetail>(d => d.BookId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany<Loan>()
                .WithOne()
                .HasForeignKey(l => l.BookId);

            builder
                .HasIndex(b => b.ISBN)
                .IsUnique();

            builder
                .ToTable(t => t.HasCheckConstraint("CK_Book_Price", "[Price] > 0"));

            builder
                .ToTable(t => t.HasCheckConstraint("CK_Book_PublicationYear", "[PublicationYear] > 1900 [PublicationYear] < GETDATE()"));
        }
    }
}
