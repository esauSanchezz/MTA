using MTA.Domain.Common;

namespace MTA.Domain.Entities;

public class SaleItem : BaseEntity
{
    public Guid SaleId { get; set; }
    public Sale Sale { get; set; } = null!;

    public Guid? ProductId { get; set; }
    public Product? Product { get; set; }

    public Guid? ServiceId { get; set; }
    public Service? Service { get; set; }

    public string Description { get; set; } = string.Empty;
    public int Quantity { get; set; } = 1;
    public decimal UnitPrice { get; set; }
    public decimal Discount { get; set; } = 0;
    public decimal Total => (UnitPrice * Quantity) - Discount;
}
