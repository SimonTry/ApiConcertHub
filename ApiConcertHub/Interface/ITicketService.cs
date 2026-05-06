using ApiConcertHub.Models;

namespace ApiConcertHub.Interface
{
    public interface ITicketService
    {
        Task<Tickets> Create(Tickets ticket);
        Task<List<Tickets>> GetByClientId(Guid id, string identifier);
    }
}
