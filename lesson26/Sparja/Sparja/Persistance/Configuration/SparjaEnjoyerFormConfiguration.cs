using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sparja.Models;

namespace Sparja.Persistance.Configuration
{
    public class SparjaEnjoyerFormConfiguration : IEntityTypeConfiguration<SparjaEnjoyerForm>
    {
        public void Configure(EntityTypeBuilder<SparjaEnjoyerForm> builder)
        {
            builder.HasKey(f => f.Id);

            builder.HasIndex(f => f.Email)
                .IsUnique();
        }
    }
}
