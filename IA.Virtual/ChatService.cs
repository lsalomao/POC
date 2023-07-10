using OpenAI.API;
using OpenAI.API.Completions;
using OpenAI.API.Models;

namespace IA.Virtual
{
    public class ChatService
    {
        public static async Task<string> GetChat(string prompt)
        {
            await Task.CompletedTask;

            var openAiClient = new OpenAIAPI("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");
            var completionRequest = new CompletionRequest
            {                
                Prompt = prompt,
                MaxTokens = 2000,
                Temperature = 0.5,
                TopP = 0.9,
                PresencePenalty = 0.6,
                FrequencyPenalty = 0.1
            };
                       

            var completions = await openAiClient.Completions.CreateCompletionAsync(completionRequest);
            var response = completions.Completions[0].Text;

            return response;
        }

    }
}
