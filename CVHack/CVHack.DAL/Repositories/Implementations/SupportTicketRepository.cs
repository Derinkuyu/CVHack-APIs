using Microsoft.EntityFrameworkCore;
namespace CVHack.DAL
{
    public class SupportTicketRepository : GenericRepository<SupportTicket>, ISupportTicketRepository
    {
        public SupportTicketRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<SupportTicket>> GetUserTicketsAsync(string userId)
        {
            return await _context.SupportTickets
                .Where(t => t.UserId == userId)
                .OrderByDescending(t => t.CreatedAt)
                .AsNoTracking()
                .ToListAsync();
        }

    }
}