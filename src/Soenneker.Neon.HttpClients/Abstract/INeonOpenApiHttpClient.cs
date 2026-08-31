using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace Soenneker.Neon.HttpClients.Abstract;

/// <summary>
/// Provides a cached, authenticated HTTP client for the Neon management API.
/// </summary>
public interface INeonOpenApiHttpClient : IDisposable, IAsyncDisposable
{
    /// <summary>
    /// Gets the configured Neon HTTP client.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The cached client.</returns>
    ValueTask<HttpClient> Get(CancellationToken cancellationToken = default);
}
