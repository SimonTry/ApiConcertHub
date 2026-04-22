using ApiConcertHub.DAO;
using ApiConcertHub.Interface;
using ApiConcertHub.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiConcertHub.Services
{
    public class EventosService: IEventosService
    {
        private readonly ApplicationDbContext _context;

        public EventosService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Eventos>> GetAll()
        {
            return await _context.Events.Where(e => e.isActive == 1).ToListAsync();
        }
    }
}
