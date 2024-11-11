using Ninfa.Entities;
using Ninfa.Interface;

namespace Ninfa.DataAccess
{
    public class RegisterDataUser : IRegisterDataUser
    {
        protected readonly NinfaDbContext _dbContext;

        public RegisterDataUser(NinfaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        async Task<int> IRegisterDataUser.SaveDataUserAsync(decimal value, int conceptId)
        {
            RegistroDatoUsuario toSave = new() { ConceptoId = conceptId, Valor = value };
            await _dbContext.RegistrosDatosUsuarios.AddAsync(toSave);
            await _dbContext.SaveChangesAsync();

            return toSave.Id;
        }
    }
}
