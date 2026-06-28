using Microsoft.Extensions.AI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OpenAI;
using System.ClientModel;

namespace CVHack.AI;

public static class DependencyInjection
{
    public static IServiceCollection AddAiIntegrations(this IServiceCollection services, IConfiguration config)
    {
        var groqKey = config["Groq:ApiKey"]!;
        var openAiClient = new OpenAIClient(
            new ApiKeyCredential(groqKey),
            new OpenAIClientOptions { Endpoint = new Uri("https://api.groq.com/openai/v1") });

        services.AddChatClient(openAiClient.GetChatClient("llama-3.3-70b-versatile").AsIChatClient());
        services.AddHttpClient<IWebSearchClient, TavilySearchClient>();

        return services;
    }
}