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
        // LLM — Groq
        var groqKey = config["Groq:ApiKey"]!;
        var openAiClient = new OpenAIClient(
            new ApiKeyCredential(groqKey),
            new OpenAIClientOptions { Endpoint = new Uri("https://api.groq.com/openai/v1") });

        services.AddChatClient(openAiClient.GetChatClient("llama-3.3-70b-versatile").AsIChatClient());

        // Web search — Tavily
        services.AddHttpClient<IWebSearchClient, TavilySearchClient>();

        // RAG
        services.AddHttpClient<IEmbeddingService, GeminiEmbeddingService>();
        services.AddSingleton<IDocumentLoader, DocumentLoader>();
        services.AddSingleton<TextChunker>();
        services.AddSingleton<IVectorStore, InMemoryVectorStore>();
        services.AddSingleton<IRagIngestionService, RagIngestionService>();
        services.AddHostedService<RagIngestionHostedService>();
        services.AddSingleton<IRagService, RagService>();

        return services;
    }
}