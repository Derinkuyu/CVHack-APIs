using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CVHack.AI;

public class RagIngestionHostedService : IHostedService
{
    private readonly IRagIngestionService _ingestion;
    private readonly ILogger<RagIngestionHostedService> _logger;

    public RagIngestionHostedService(
        IRagIngestionService ingestion,
        ILogger<RagIngestionHostedService> logger)
    {
        _ingestion = ingestion;
        _logger = logger;
    }

    public async Task StartAsync(CancellationToken ct)
    {
        try
        {
            await _ingestion.IngestAsync(ct);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "RAG ingestion failed at startup.");
            // don't crash the app — API still works, RAG just won't have data
        }
    }

    public Task StopAsync(CancellationToken ct) => Task.CompletedTask;
}