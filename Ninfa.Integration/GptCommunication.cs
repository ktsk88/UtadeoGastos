using Ninfa.Interface;

using OpenAI.Chat;

namespace Ninfa.Integration
{
    public class GptCommunication : IGptCommunication
    {
        async Task<string> IGptCommunication.GetBotResponse(string userMessage)
        {
            ChatClient client = new(model: "ft:gpt-4o-mini", apiKey: "sk");

            ChatCompletion chatCompletion = await client.CompleteChatAsync(userMessage);

            return chatCompletion.Content.ToString();
        }
    }
}
