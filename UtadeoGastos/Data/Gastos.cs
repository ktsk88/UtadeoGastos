using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.AspNetCore.Identity;

namespace UtadeoGastos.Data
{
    public class Gastos : Base
    {

        public string Owner { get; set; }
        [Required, Column(TypeName = "decimal(18, 2)")]
        public decimal Valor { get; set; }
        [Required]
        public  required bool EsIngreso { get; set; }
        public Gastos()
        {
            EsIngreso = Valor <= 0  ? false : true;
        }
    }
}
