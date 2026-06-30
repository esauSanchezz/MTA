using MTA.Domain.Common;

namespace MTA.Domain.Entities;

public class Product : BaseEntity
{
    public Guid TenantId { get; set; }
    public Tenant Tenant { get; set; } = null!;

    public string Name { get; set; } = string.Empty;
    public string? SKU { get; set; }
    public string? Description { get; set; }
    public string? Category { get; set; }
    public decimal CostPrice { get; set; }
    public decimal SalePrice { get; set; }
    public int Stock { get; set; } = 0;
    public int MinStock { get; set; } = 0;
    public string? Unit { get; set; }
    public bool IsActive { get; set; } = true;

    public bool IsBelowMinStock => Stock <= MinStock;
}
