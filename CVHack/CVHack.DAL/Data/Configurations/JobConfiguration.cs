using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CVHack.DAL
{
    public class JobConfiguration : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.HasKey(j => j.Id);

            builder.Property(j => j.SalaryMin)
                   .HasPrecision(18, 2);

            builder.Property(j => j.SalaryMax)
                   .HasPrecision(18, 2);
        }
    }
}
