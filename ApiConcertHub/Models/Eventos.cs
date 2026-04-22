using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiConcertHub.Models
{
    public class Eventos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid id_evento { get; set; }

        public string nombre_evento { get; set; }

        public int isActive { get; set; }
    }
}
