using ApiConcertHub.Models;

namespace ApiConcertHub.Interface
{
    public interface IClientService
    {
        Task<Clients> Create(Clients newClient);
    }
}
