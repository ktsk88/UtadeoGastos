using Ninfa.Common;
using Ninfa.Common.TransferObjects;

namespace Ninfa.Logic.Abstractions.Interface
{
    public interface IUsserLogic
    {
        Task<int> Save(UserSave dto);
        Task<bool> Delete(string phone);
        Task<UserRead> Get(string phone);
        Task<PaginatedResult<ConceptRead>> GetConcepts(string phone, int page);
    }
}
