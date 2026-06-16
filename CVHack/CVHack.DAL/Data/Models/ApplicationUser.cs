using Microsoft.AspNetCore.Identity;

namespace CVHack.DAL
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public UserProfile? Profile { get; set; }
        public ICollection<Application> Applications { get; set; } = new HashSet<Application>();
        public ICollection<SavedJob> SavedJobs { get; set; } = new HashSet<SavedJob>();
        public ICollection<SkillGapAnalysis> SkillGapAnalyses { get; set; } = new HashSet<SkillGapAnalysis>();
        public ICollection<SupportTicket> SupportTickets { get; set; } = new HashSet<SupportTicket>();
    }
}
