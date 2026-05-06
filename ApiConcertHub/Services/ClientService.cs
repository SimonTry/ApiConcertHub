using ApiConcertHub.DAO;
using ApiConcertHub.Interface;
using ApiConcertHub.Models;

namespace ApiConcertHub.Services
{
    public class ClientService : IClientService
    {

        private readonly ApplicationDbContext _context;

        public ClientService(ApplicationDbContext context) {
            _context = context;
        }

        public async Task<Clients> Create(Clients client)
        {
            _context.Clients.Add(client);
            await _context.SaveChangesAsync();
            return client;
        }
    }
}
