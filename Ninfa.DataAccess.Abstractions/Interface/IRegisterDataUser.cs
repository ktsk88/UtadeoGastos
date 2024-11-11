namespace Ninfa.Interface
{
    public interface IRegisterDataUser
    {
        Task<int> SaveDataUserAsync(decimal value, int conceptId);

    }
}
