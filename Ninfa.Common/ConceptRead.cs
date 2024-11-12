namespace Ninfa.Common
{
    public record ConceptRead
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}
