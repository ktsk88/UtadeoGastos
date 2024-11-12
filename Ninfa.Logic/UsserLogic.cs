using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ninfa.Common;
using Ninfa.Entities;
using Ninfa.Interface;
using Ninfa.Logic.Abstractions.Interface;

namespace Ninfa.Logic
{
    public class UsserLogic : IUsserLogic
    {
        private readonly IUserRepo _userRepo;
        private readonly IConcepUserRepo _concepUserRepo;

        public UsserLogic(IUserRepo userRepo, IConcepUserRepo concepUserRepo)
        {
            _userRepo = userRepo;
            _concepUserRepo = concepUserRepo;
        }

        async Task<bool> IUsserLogic.Delete(string phone)
        {
            if (await _userRepo.UserExistsByPhone(phone))
            {
                var u = await _userRepo.GetUserByPhone(phone);
                await _userRepo.DeleteUser(u.Id);
            }
            
            return true;
        }

        async Task<UserRead> IUsserLogic.Get(string phone)
        {
            if (await _userRepo.UserExistsByPhone(phone))
            {
                var u = await _userRepo.GetUserByPhone(phone);

                return new UserRead { 
                    Id = u.Id,
                    Nombre = u.Nombre,
                    FechaCreacion = u.FechaCreacion,
                    UltimoDigitoDoc = u.UltimoDigitoDoc,
                    Telefono = u.Telefono,
                };

            }

            return default!;
        }

        async Task<IEnumerable<ConceptRead>> IUsserLogic.GetConcepts(string phone)
        {
            if (!await _userRepo.UserExistsByPhone(phone))
                return Enumerable.Empty<ConceptRead>();

            var u = await _userRepo.GetUserByPhone(phone);
            return await _concepUserRepo.GetAllConcepsByUserId(u.Id);
        }

        async Task<int> IUsserLogic.Save(UserSave dto)
        {
            return await _userRepo.SaveUser(new Usuario { 
                Nombre = dto.Nombre,
                UltimoDigitoDoc = dto.UltimoDigitoDoc,
                Telefono = dto.Telefono,
            });
        }
    }
}
