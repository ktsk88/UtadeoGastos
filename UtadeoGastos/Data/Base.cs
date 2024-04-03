using System.ComponentModel.DataAnnotations;

namespace UtadeoGastos.Data
{
    public class Base
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        [MaxLength(500)]
        public string? Descripcion { get; set; }
    }
}