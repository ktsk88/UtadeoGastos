using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ninfa.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Nombre { get; set; } = string.Empty;
        [MaxLength(255)]
        public string UltimoDigitoDoc { get; set; } = string.Empty;
        [MaxLength(255)]
        public string Telefono { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

    }

    public class ConceptoUsuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        #region Relations
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } = new();
        #endregion
    }

    public class RegistroDatoUsuario
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Valor { get; set; }

        #region Relations
        public int ConceptoId { get; set; }
        public ConceptoUsuario Concepto { get; set; } = new();
        #endregion
    }
}
