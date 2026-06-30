namespace MTA.Infrastructure.Services;

public interface ITenantProvider
{
    Guid TenantId { get; }
}
