namespace CVHack.BLL
{
    public class JobReadDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string WorkType { get; set; } = string.Empty;
        public string WorkTime { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string? BriefDescription { get; set; }
        public decimal SalaryMin { get; set; }
        public decimal SalaryMax { get; set; }
        public DateTime PostedAt { get; set; }
        public string JobUrl { get; set; } = string.Empty;
        public string SourcePlatform { get; set; } = string.Empty;
    }
}