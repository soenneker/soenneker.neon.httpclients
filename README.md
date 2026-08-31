[![](https://img.shields.io/nuget/v/soenneker.neon.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.neon.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.neon.httpclients/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.neon.httpclients/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.neon.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.neon.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.neon.httpclients/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.neon.httpclients/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Neon.HttpClients

Provides a cached, authenticated `HttpClient` for the Neon management API.

## Installation

```bash
dotnet add package Soenneker.Neon.HttpClients
```

## Configuration

```json
{
  "Neon": {
    "ApiKey": "your-api-key"
  }
}
```

`Neon:ClientBaseUrl` can override the default `https://console.neon.tech/api/v2` endpoint. `Neon:AuthHeaderName` and `Neon:AuthHeaderValueTemplate` can override the default `Authorization: Bearer {token}` header.

## Usage

```csharp
using Soenneker.Neon.HttpClients.Abstract;
using Soenneker.Neon.HttpClients.Registrars;

services.AddNeonOpenApiHttpClientAsSingleton();

INeonOpenApiHttpClient neon = serviceProvider
    .GetRequiredService<INeonOpenApiHttpClient>();

HttpClient client = await neon.Get(cancellationToken);
```

Do not dispose the returned `HttpClient`; the registered provider owns it and removes it from the cache when disposed.
