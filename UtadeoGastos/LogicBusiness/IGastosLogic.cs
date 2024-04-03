using UtadeoGastos.Dtos;

namespace UtadeoGastos.LogicBusiness
{
    public interface IGastosLogic
    {
        Task Add(GastosContract contract);
        Task Delete(int id);
        Task Update(ReadGastosContract contract);
        Task<ReadGastosContract> GetById(int id);
        Task<PaginatedResult<ReadGastosContract>> GetByName(string nombre, int index, int size);
    }
}