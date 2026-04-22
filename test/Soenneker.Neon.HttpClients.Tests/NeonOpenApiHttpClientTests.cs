using Soenneker.Neon.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Neon.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class NeonOpenApiHttpClientTests : HostedUnitTest
{
    private readonly INeonOpenApiHttpClient _httpclient;

    public NeonOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<INeonOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
