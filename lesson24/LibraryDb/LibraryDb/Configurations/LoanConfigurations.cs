using LibraryDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryDb.Configurations
{
    public class LoanConfigurations : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            builder.HasKey(t => t.Id);

            builder
                .HasOne<Book>()
                .WithMany()
                .HasForeignKey(l => l.BookId)
                .IsRequired(true);

            builder
                .HasOne<Member>()
                .WithMany()
                .HasForeignKey(l => l.MemberId)
                .IsRequired(true);

            builder
                .ToTable(t => t.HasCheckConstraint("CK_Member_LoanDate_DueDate", "[LoanDate] <= [DueDate]"));

            builder
                .ToTable(t => t.HasCheckConstraint("CK_Member_LoanDate_ReturnDate", "[LoanDate] <= [ReturnDate] OR [ReturnDate] IS NULL"));
        }
    }
}
