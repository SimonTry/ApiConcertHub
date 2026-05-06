using ApiConcertHub.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApiConcertHub.DAO
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Eventos> Events { get; set; }
        public DbSet<Clients> Clients { get; set; }
        public DbSet<Tickets> Tickets { get; set; }

    }
}
