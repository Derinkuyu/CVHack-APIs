namespace CVHack.DAL
{
    public class JobRepository : GenericRepository<Job>, IJobRepository
    {
        public JobRepository(AppDbContext context) : base(context)
        {
        }
    }
}
