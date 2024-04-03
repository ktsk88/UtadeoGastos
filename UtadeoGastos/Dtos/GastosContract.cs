namespace UtadeoGastos.Dtos
{
    public class GastosContract
    {
        public decimal Valor { get; set; }
        public required string Descripcion { get; set; }
    }
    public class ReadGastosContract : GastosContract
    {
        public int Id { get; set; }
    }
}
