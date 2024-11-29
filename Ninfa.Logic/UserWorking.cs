using Ninfa.Common;
using Ninfa.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninfa.Logic
{
    public class UserWorking : IUserWorkingLogic
    {
        //private const 
        private readonly IGptCommunication _gptCommunication;

        public UserWorking(IGptCommunication gptCommunication)
        {
            this._gptCommunication = gptCommunication;
        }

        async Task<string> IUserWorkingLogic.SetConversation(string message)
        {
            string intention = await GetIntention(message);
            return string.Empty;
        }

        private async Task<string> GetIntention(string message)
        {
            string intention = await _gptCommunication.GetBotResponse(String.Format(Promps.FindIntention,message));
            //TODO - continuar aqui, validar las intenciones propuestas
            return string.Empty;
        }
    }
}
