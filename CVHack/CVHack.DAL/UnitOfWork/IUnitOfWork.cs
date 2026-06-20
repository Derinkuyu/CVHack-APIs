namespace CVHack.DAL
{
    public interface IUnitOfWork
    {
        ISupportTicketRepository SupportTicketRepository { get; }
        IApplicationRepository ApplicationRepository { get; }
        ISavedJobRepository SavedJobRepository { get; }
        Task<int> SaveChangesAsync();
    }
}
