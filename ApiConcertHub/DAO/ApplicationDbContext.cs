using ApiConcertHub.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiConcertHub.DAO
{
    public class ApplicationDbContext : DbContext
    {
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Eventos> Events { get; set; }
    }
}
