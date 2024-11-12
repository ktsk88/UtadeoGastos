using Ninfa.Common;
using Ninfa.Common.TransferObjects;
using Ninfa.Entities;

namespace Ninfa.Interface
{
    /// <summary>Crud for concep entity</summary>
    public interface IConcepUserRepo
    {
        /// <summary>Saves a new Concep.</summary>
        /// <param name="toSave">Dto to save on database.</param>
        /// <returns>Concep identifier.</returns>
        Task<int> SaveConcep(ConceptoUsuario toSave);

        /// <summary>Gets a Concep by ID.</summary>
        /// <param name="id">Concep identifier.</param>
        /// <returns>The Concep found, or null if not found.</returns>
        Task<ConceptoUsuario?> GetConcepById(int id);

        /// <summary>Gets all conceps.</summary>
        /// <returns>List of conceps.</returns>
        Task<IEnumerable<ConceptoUsuario>> GetAllConceps();

        /// <summary>Updates an existing Concep.</summary>
        /// <param name="toUpdate">Concep data to update.</param>
        /// <returns>Boolean indicating success or failure.</returns>
        Task<bool> UpdateConcep(ConceptoUsuario toUpdate);

        /// <summary>Deletes a Concep by ID.</summary>
        /// <param name="id">Concep identifier to delete.</param>
        /// <returns>Boolean indicating success or failure.</returns>
        Task<bool> DeleteConcep(int id);

        /// <summary>Checks if a Concep exists by name.</summary>
        /// <param name="name">Concep's name.</param>
        /// <param name="userId">Concep's user.</param>
        /// <returns>Boolean indicating existence of the Concep.</returns>
        Task<bool> ConcepExistsByName(string name, int userId);

        /// <summary>Get concepts of an user.</summary>
        /// <param name="id">User Id</param>
        /// <param name="page">Page</param>
        /// <returns></returns>
        Task<PaginatedResult<ConceptRead>> GetAllConcepsByUserId(int id, int page);
    }
}
