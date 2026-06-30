using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace MTA.Infrastructure.Services;

public class HttpTenantProvider : ITenantProvider
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public HttpTenantProvider(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public Guid TenantId
    {
        get
        {
            var tenantClaim = _httpContextAccessor.HttpContext?.User
                .FindFirstValue("tenantId");

            if (Guid.TryParse(tenantClaim, out var tenantId))
                return tenantId;

            return Guid.Empty;
        }
    }
}
