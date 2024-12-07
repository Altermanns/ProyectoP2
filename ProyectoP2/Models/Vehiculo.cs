using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoP2.Models
{
    public class Vehiculo
    {
        [Required]
        [Key]
        public int IdVehiculo { get; set; }
        [Required]
        [MaxLength(50)]
        public string Marca { get; set; }
        [Required]
        [MaxLength(50)]
        public string Modelo { get; set; }
        [Required]
        [Range(1970, 2030, ErrorMessage = "Año no válido")]
        public int Año { get; set; }
        [Required]
        public double precio { get; set; }
        [Required]
        public float kilometraje { get; set; }
        [Required]
        public string TipoCombustible { get; set; }
        [Required]
        public string Ubicacion { get; set; }
    }
}
