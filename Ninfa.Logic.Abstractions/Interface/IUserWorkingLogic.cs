namespace Ninfa.Interface
{
    public interface IUserWorkingLogic
    {
        Task<string> SetConversation(string message);
        
    }
}
