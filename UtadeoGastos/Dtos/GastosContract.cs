namespace UtadeoGastos.Dtos
{
    public class GastosContract
    {
        public string Owner { get; set; }
        public decimal Valor { get; set; }
        public required string Descripcion { get; set; }
    }
    public class ReadGastosContract : GastosContract
    {
        public int Id { get; set; }
    }

    public class Inform
    {
        public decimal Ingresos { get; set; }
        public decimal Egresos { get; set; }
    }
}
