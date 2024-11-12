using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Ninfa.Entities;

namespace Ninfa.DataAccess
{
    public class NinfaDbContext : IdentityDbContext
    {
        public NinfaDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios => Set<Usuario>();
        public DbSet<ConceptoUsuario> ConceptosUsuarios => Set<ConceptoUsuario>();
        public DbSet<RegistroDatoUsuario> RegistrosDatosUsuarios => Set<RegistroDatoUsuario>();
        public DbSet<Conversation> Conversations => Set<Conversation>();

    }
}
