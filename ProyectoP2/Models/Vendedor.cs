using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoP2.Models
{
    public class Vendedor
    {
        [Required]
        [Key]
        public int IdVendedor { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(50)]
        public string Nombre { get; set; }
        [Required]
        [EmailAddress]
        public string correo { get; set; }
        [DataType(DataType.Date)]
        public DateOnly fechanacimiento { get; set; }
    }
}
