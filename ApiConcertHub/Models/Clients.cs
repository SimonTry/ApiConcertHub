using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiConcertHub.Models
{
    public class Clients
    {
        [Key]
        public Guid id_Cliente { get; set; } = Guid.NewGuid();
        public string nombreCliente { get; set; }
        public int isActive { get; set; } = 1;

        [Required]
        public string IdentityUserId { get; set; } = string.Empty;

        [ForeignKey("IdentityUserId")]
        public IdentityUser? IdentityUser { get; set; }
    }
}
