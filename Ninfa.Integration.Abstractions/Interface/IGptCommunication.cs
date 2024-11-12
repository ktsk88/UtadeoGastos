namespace Ninfa.Interface
{
    public interface IGptCommunication
    {
        /// <summary>Find the message intention of any user.</summary>
        /// <param name="userMessage">Message of the user.</param>
        /// <returns>Code of intention.</returns>
        Task<String> GetBotResponse(String userMessage);
    }
}
