using Ninfa.Entities;
using Ninfa.Interface;

namespace Ninfa.DataAccess
{
    public class ConversationRepo : IConversationRepo
    {
        protected readonly NinfaDbContext _dbContext;

        public ConversationRepo(NinfaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        async Task IConversationRepo.Save(Conversation toSave)
        {
            await _dbContext.Conversations.AddAsync(toSave);
            await _dbContext.SaveChangesAsync();
        }
    }
}
