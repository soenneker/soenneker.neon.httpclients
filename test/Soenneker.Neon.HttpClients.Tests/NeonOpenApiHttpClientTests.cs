using Soenneker.Neon.HttpClients.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Neon.HttpClients.Tests;

[Collection("Collection")]
public sealed class NeonOpenApiHttpClientTests : FixturedUnitTest
{
    private readonly INeonOpenApiHttpClient _httpclient;

    public NeonOpenApiHttpClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _httpclient = Resolve<INeonOpenApiHttpClient>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
