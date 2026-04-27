using ApiConcertHub.Models;

namespace ApiConcertHub.Interface
{
    public interface IEventosService
    {

        Task<List<Eventos>> GetAll();
        Task<Eventos> GetById(Guid Id);

        Task<Eventos> Create(Eventos eventos);

        Task<bool> Edit(Guid id, Eventos editEvent);
    }
}
