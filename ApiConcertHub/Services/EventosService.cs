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

        public async Task<Eventos> GetById(Guid id)
        {
            return await _context.Events.FindAsync(id);
        }


        public async Task<Eventos> Create(Eventos newEvent) 
        {
            _context.Events.Add(newEvent);
            await _context.SaveChangesAsync();
            return newEvent;
        }

        public async Task<bool> Edit(Guid id, Eventos editEvent)
        {
            var objExist = await _context.Events.FindAsync(id);
            if (objExist == null) return false;

            objExist.nombre_evento = editEvent.nombre_evento;
            objExist.nombre_artista = editEvent.nombre_artista;

            await _context.SaveChangesAsync();
            return true;
        }
    }
}
