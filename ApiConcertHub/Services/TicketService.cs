using ApiConcertHub.DAO;
using ApiConcertHub.Interface;
using ApiConcertHub.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace ApiConcertHub.Services
{
    public class TicketService : ITicketService
    {
        private readonly ApplicationDbContext _context;

        public TicketService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Tickets> Create(Tickets objTk)
        {
            int eventExist = _context.Events.Where(
                e => e.id_evento == objTk.EventoId).Count();
            if (eventExist == 0) throw new Exception("Event Not Found");

            _context.Tickets.Add(objTk);
            await _context.SaveChangesAsync();
            return objTk;
        }

        public async Task<List<Tickets>> GetByClientId(Guid Id, string UserId)
        {
            if (!await validateIdentity(Id, UserId)) return null;

            return await _context.Tickets.Include(t => t.Evento).Where(
                c => c.ClientId == Id).ToListAsync();
        }

        private async Task<bool> validateIdentity(Guid idCliente, string UserId)
        {
            var clienteExiste = await _context.Clients.FindAsync(idCliente);

            return UserId == clienteExiste?.IdentityUserId;
        }
    }
}
