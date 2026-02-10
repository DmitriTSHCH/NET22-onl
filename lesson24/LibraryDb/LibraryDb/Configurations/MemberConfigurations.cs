using LibraryDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryDb.Configurations
{
    public class MemberConfigurations : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.HasKey(t => t.Id);

            builder
                .HasMany<Loan>()
                .WithOne()
                .HasForeignKey(l => l.MemberId);

            builder
                .HasOne<MemberContact>()
                .WithOne()
                .HasForeignKey<MemberContact>(c => c.MemberId)
                .IsRequired(true)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasIndex(m => m.Email)
                .IsUnique();

            builder
                .Property(m => m.FirstName)
                .IsRequired();

            builder
                .Property(m => m.LastName)
                .IsRequired();

            builder
                .ToTable(t => t.HasCheckConstraint("CK_Member_FirstName", "[FirstName] < 100"));

            builder
                .ToTable(t => t.HasCheckConstraint("CK_Member_LastName", "[LastName] < 100"));
        }
    }
}
