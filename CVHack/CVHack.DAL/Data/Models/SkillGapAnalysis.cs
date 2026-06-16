namespace CVHack.DAL
{
    public class SkillGapAnalysis
    {
        public int Id { get; set; }
        public string UserId { get; set; } = null!;
        public int JobId { get; set; }
        public ApplicationUser User { get; set; } = null!;
        public Job Job { get; set; } = null!;
        public ICollection<SkillGapItem> SkillGapItems { get; set; } = new HashSet<SkillGapItem>();
    }
}
