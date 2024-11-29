using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninfa.DataAccess.Abstractions.Entities
{
    public class KtskHook
    {
        public int Id { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public string CuerpoPeticion { get; set; } = default!;
    }
}
