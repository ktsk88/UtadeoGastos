using Ninfa.Entities;

namespace Ninfa.Interface
{
    public interface IConversationRepo
    {
        Task Save(Conversation toSave);
    }
}
