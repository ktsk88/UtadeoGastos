using System.ComponentModel.DataAnnotations;

namespace Ninfa.Common
{
    public record UserSave
    {
        [MaxLength(255)]
        public string Nombre { get; set; } = string.Empty;
        [MaxLength(255)]
        public string UltimoDigitoDoc { get; set; } = string.Empty;
        [MaxLength(255)]
        public string Telefono { get; set; } = string.Empty;
    }

    public record UserRead : UserSave
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
