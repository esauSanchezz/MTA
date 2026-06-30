using MTA.Domain.Common;

namespace MTA.Domain.Entities;

public class Receipt : BaseEntity
{
    public Guid SaleId { get; set; }
    public Sale Sale { get; set; } = null!;

    public string ReceiptNumber { get; set; } = string.Empty;
    public string? PdfUrl { get; set; }
    public DateTime GeneratedAt { get; set; } = DateTime.UtcNow;
    public string? SentToEmail { get; set; }
    public bool EmailSent { get; set; } = false;
}
