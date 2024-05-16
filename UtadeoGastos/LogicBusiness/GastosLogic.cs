using AutoMapper;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using UtadeoGastos.Data;
using UtadeoGastos.Dtos;
using UtadeoGastos.Utilities;

namespace UtadeoGastos.LogicBusiness
{
    public class GastosLogic: IGastosLogic
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly GastosDbContext _dbContext;
        private readonly IMapper _mapper;
        public GastosLogic(GastosDbContext dbContext, IMapper mapper, UserManager<IdentityUser> userManager)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _userManager = userManager;
        }

        async Task IGastosLogic.Add(GastosContract contract)
        {
            var tosave = _mapper.Map<Gastos>(contract);
            await _dbContext.Gastos.AddAsync(tosave);
            await _dbContext.SaveChangesAsync();
        }

        async Task IGastosLogic.Delete(int id)
        {
            if (await _dbContext.Gastos.FindAsync(id) is Gastos db)
            {
                _dbContext.Gastos.Remove(db);
                await _dbContext.SaveChangesAsync();
            }
        }

        async Task<ReadGastosContract> IGastosLogic.GetById(int id)
        {
            if (await _dbContext.Gastos.FindAsync(id) is Gastos db)
            {
                return _mapper.Map<ReadGastosContract>(db);
            }
            throw new NotImplementedException();
        }

        async Task<PaginatedResult<ReadGastosContract>> IGastosLogic.GetByName(string nombre, int index, int size)
        {
            using var transaction = _dbContext.Database.BeginTransaction(System.Data.IsolationLevel.ReadUncommitted);

            var result = await _dbContext.Gastos
                .Where(t => t.Descripcion.Contains(nombre))
                .OrderByDescending(t => t.FechaCreacion)
                .Select(t => _mapper.Map<ReadGastosContract>(t))
                .ToPaginatedListAsync(index, size);

            await transaction.CommitAsync();

            return result;

        }

        async Task IGastosLogic.Update(ReadGastosContract contract)
        {
            var toFind = _mapper.Map<Gastos>(contract);
            if (await _dbContext.Gastos.FindAsync(toFind.Id) is Gastos db)
            {
                db.Valor = toFind.Valor;
                db.Descripcion = toFind.Descripcion;
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
