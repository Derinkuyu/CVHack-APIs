using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YourApp.DAL.Models;

namespace YourApp.DAL.Configurations;

public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder)
    {

        builder.HasOne(u => u.Profile)
               .WithOne(p => p.User)
               .HasForeignKey<UserProfile>(p => p.UserId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
