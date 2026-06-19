using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CVHack.DAL;

public class AppDbContext : IdentityDbContext<ApplicationUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    public DbSet<UserProfile> UserProfiles => Set<UserProfile>();
    public DbSet<Skill> Skills { get; set; }
    public DbSet<ProfileSkill> ProfileSkills { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Certification> Certifications { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<Education> Educations { get; set; }
    public DbSet<Job> Jobs { get; set; }
    public DbSet<Application> Applications { get; set; }
    public DbSet<SavedJob> SavedJobs { get; set; }
    public DbSet<SkillGapAnalysis> SkillGapAnalyses { get; set; }
    public DbSet<SkillGapItem> SkillGapItems { get; set; }
    public DbSet<SupportTicket> SupportTickets { get; set; }
}
