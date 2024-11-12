using Ninfa.Entities;

namespace Ninfa.Interface
{
    /// <summary>Crud for User Entity.</summary>
    public interface IUserRepo
    {
        /// <summary>Saves a new user.</summary>
        /// <param name="toSave">Dto to save on database.</param>
        /// <returns>User identifier.</returns>
        Task<int> SaveUser(Usuario toSave);

        /// <summary>Gets a user by ID.</summary>
        /// <param name="id">User identifier.</param>
        /// <returns>The user found, or null if not found.</returns>
        Task<Usuario?> GetUserById(int id);

        /// <summary>Gets all users.</summary>
        /// <returns>List of users.</returns>
        Task<IEnumerable<Usuario>> GetAllUsers();

        /// <summary>Updates an existing user.</summary>
        /// <param name="toUpdate">User data to update.</param>
        /// <returns>Boolean indicating success or failure.</returns>
        Task<bool> UpdateUser(Usuario toUpdate);

        /// <summary>Deletes a user by ID.</summary>
        /// <param name="id">User identifier to delete.</param>
        /// <returns>Boolean indicating success or failure.</returns>
        Task<bool> DeleteUser(int id);

        /// <summary>Checks if a user exists by phone number.</summary>
        /// <param name="phone">User's phone number.</param>
        /// <returns>Boolean indicating existence of the user.</returns>
        Task<bool> UserExistsByPhone(string phone);
        Task<Usuario?> GetUserByPhone(string phone);
    }

}
