using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CVHack.AI;

public static class DependencyInjection
{
    public static IServiceCollection AddAiIntegrations(this IServiceCollection services, IConfiguration config)
    {
        services.AddGroqChatClient(config);     // LLM (reasoning agents)

        services.AddHttpClient<IWebSearchClient, TavilySearchClient>();   // web search

        return services;
    }
}
