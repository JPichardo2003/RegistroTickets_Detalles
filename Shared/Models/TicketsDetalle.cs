using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroTickets_Detalles.Shared.Models
{
    public class TicketsDetalle
    {
        [Key]
        public int DetalleId { get; set; }
        public int TicketId { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Este campo no acepta digitos")]
        public string? Emisor { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        public string? Mensaje { get; set; }


    }
}
