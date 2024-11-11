using Microsoft.EntityFrameworkCore;

using Ninfa.Entities;
using Ninfa.Interface;

namespace Ninfa.DataAccess
{
    public class UserRepo : IUserRepo
    {
        protected readonly NinfaDbContext _dbContext;

        public UserRepo(NinfaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        async Task<int> IUserRepo.SaveUser(Usuario toSave)
        {
            await _dbContext.Usuarios.AddAsync(toSave);
            await _dbContext.SaveChangesAsync();
            return toSave.Id;
        }

        async Task<Usuario?> IUserRepo.GetUserById(int id)
        {
            return await _dbContext.Usuarios.FindAsync(id);
        }

        async Task<IEnumerable<Usuario>> IUserRepo.GetAllUsers()
        {
            return await _dbContext.Usuarios.ToListAsync();
        }

        async Task<bool> IUserRepo.UpdateUser(Usuario toUpdate)
        {
            var existingUser = await _dbContext.Usuarios.FindAsync(toUpdate.Id);
            if (existingUser == null) return false;

            existingUser.Nombre = toUpdate.Nombre;
            existingUser.UltimoDigitoDoc = toUpdate.UltimoDigitoDoc;
            existingUser.Telefono = toUpdate.Telefono;
            existingUser.FechaCreacion = toUpdate.FechaCreacion;

            await _dbContext.SaveChangesAsync();
            return true;
        }

        async Task<bool> IUserRepo.UserExistsByPhone(string phone)
        {
            return await _dbContext.Usuarios.AnyAsync(u => u.Telefono.Equals(phone));
        }

        async Task<bool> IUserRepo.DeleteUser(int id)
        {
            var toDelete = await _dbContext.Usuarios.FindAsync(id);
            if (toDelete == null) return false;

            _dbContext.Usuarios.Remove(toDelete);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }

}
