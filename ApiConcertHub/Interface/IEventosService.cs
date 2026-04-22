using ApiConcertHub.Models;

namespace ApiConcertHub.Interface
{
    public interface IEventosService
    {

        Task<List<Eventos>> GetAll();
    }
}
