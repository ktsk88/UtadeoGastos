using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UtadeoGastos.Data
{
    public class GastosDbContext : IdentityDbContext
    {
        public GastosDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Gastos> Gastos { get; set; }
    }
}
