namespace UtadeoGastos.Dtos
{
    public class GastosContract
    {
        public decimal Value { get; set; }
        public required string Description { get; set; }
    }
    public class ReadGastosContract : GastosContract
    {
        public int Id { get; set; }
    }
}
