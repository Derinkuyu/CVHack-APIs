namespace CVHack.DAL
{
    public interface ISupportTicketRepository : IGenericRepository<SupportTicket>
    {
        Task<IEnumerable<SupportTicket>> GetUserTicketsAsync(string userId);
    }
}