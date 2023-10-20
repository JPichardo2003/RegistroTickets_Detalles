using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroTickets_Detalles.Shared.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Este campo no acepta digitos")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string? Nombre { get; set; }
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Ingrese el telefono correctamente, Ejemplo: 8094587412")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string? Teléfono { get; set; }
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Ingrese el Celular correctamente, Ejemplo: 8294587412")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string? Celular { get; set; }
        [StringLength(9, ErrorMessage = "No Puede Exceder los 9 Caracteres")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string? Rnc { get; set; }
        [StringLength(30, ErrorMessage = "No Puede Exceder los 30 Caracteres")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string? Email { get; set; }
        [StringLength(50, ErrorMessage = "No Puede Exceder los 50 Caracteres")]
        [Required(ErrorMessage = "Campo Obligatorio")]
        public string? Dirección { get; set; }

        [ForeignKey("ClienteId")]
        public ICollection<Tickets> Tickets { get; set; } = new List<Tickets>();
    }
}
