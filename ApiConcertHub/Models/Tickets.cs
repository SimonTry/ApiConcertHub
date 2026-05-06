using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiConcertHub.Models
{
    public class Tickets
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid id_ticket { get; set; }

        [Required]
        public Guid EventoId { get; set; }
        [ForeignKey("EventoId")]
        public Eventos? Evento {  get; set; }
        [Required]
        public Guid ClientId { get; set; }
        [ForeignKey("ClientId")]
        public Clients? Cliente { get; set; }

        public double valorUnitario { get; set; }
        public DateTime fechaCompra { get; set; } = DateTime.UtcNow;

        public string ticketStatus { get; set; } = "Reserved";

    }
}
