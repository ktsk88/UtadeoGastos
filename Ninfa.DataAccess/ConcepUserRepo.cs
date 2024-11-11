using Microsoft.EntityFrameworkCore;

using Ninfa.Entities;
using Ninfa.Interface;

namespace Ninfa.DataAccess
{
    public class ConcepUserRepo : IConcepUserRepo
    {
        protected readonly NinfaDbContext _dbContext;

        public ConcepUserRepo(NinfaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        async Task<int> IConcepUserRepo.SaveConcep(ConceptoUsuario toSave)
        {
            await _dbContext.ConceptosUsuarios.AddAsync(toSave);
            await _dbContext.SaveChangesAsync();
            return toSave.Id;
        }

        async Task<ConceptoUsuario?> IConcepUserRepo.GetConcepById(int id)
        {
            return await _dbContext.ConceptosUsuarios.FindAsync(id);
        }

        async Task<IEnumerable<ConceptoUsuario>> IConcepUserRepo.GetAllConceps()
        {
            return await _dbContext.ConceptosUsuarios.ToListAsync();
        }

        async Task<bool> IConcepUserRepo.UpdateConcep(ConceptoUsuario toUpdate)
        {
            var existingConcep = await _dbContext.ConceptosUsuarios.FindAsync(toUpdate.Id);
            if (existingConcep == null) return false;

            existingConcep.Nombre = toUpdate.Nombre;
            existingConcep.UsuarioId = toUpdate.UsuarioId;

            await _dbContext.SaveChangesAsync();
            return true;
        }

        async Task<bool> IConcepUserRepo.DeleteConcep(int id)
        {
            var toDelete = await _dbContext.ConceptosUsuarios.FindAsync(id);
            if (toDelete == null) return false;

            _dbContext.ConceptosUsuarios.Remove(toDelete);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        async Task<bool> IConcepUserRepo.ConcepExistsByName(string name, int userId)
        {
            return await _dbContext.ConceptosUsuarios.AnyAsync(u => u.Nombre.Equals(name) && u.UsuarioId.Equals(userId));
        }
    }

}