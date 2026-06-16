namespace CVHack.DAL
{
    public class SkillGapItem
    {
        public int Id { get; set; }
        public int AnalysisId { get; set; }
        public string MissingSkill { get; set; } = null!;
        public SkillGapAnalysis Analysis { get; set; } = null!;
    }
}
