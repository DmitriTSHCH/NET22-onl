using LibraryDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryDb.Configurations
{
    public class MemberContactConfigurations : IEntityTypeConfiguration<MemberContact>
    {
        public void Configure(EntityTypeBuilder<MemberContact> builder)
        {
            builder.HasKey(t => t.Id);

            builder
                .HasOne<Member>()
                .WithOne()
                .HasForeignKey<MemberContact>(c => c.MemberId);
        }
    }
}
