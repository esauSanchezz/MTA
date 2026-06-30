using MTA.Domain.Common;
using MTA.Domain.Enums;

namespace MTA.Domain.Entities;

public class Sale : BaseEntity
{
    public Guid TenantId { get; set; }
    public Tenant Tenant { get; set; } = null!;

    public Guid EmployeeId { get; set; }
    public Employee Employee { get; set; } = null!;

    public DateTime SaleDate { get; set; } = DateTime.UtcNow;
    public decimal Subtotal { get; set; }
    public decimal Discount { get; set; } = 0;
    public decimal Total { get; set; }

    public PaymentMethod PaymentMethod { get; set; }
    public SaleStatus Status { get; set; } = SaleStatus.Pending;

    public string? StripePaymentIntentId { get; set; }
    public string? ClientName { get; set; }
    public string? Notes { get; set; }

    public ICollection<SaleItem> Items { get; set; } = [];
    public Receipt? Receipt { get; set; }
}
