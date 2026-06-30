using MTA.Domain.Common;

namespace MTA.Domain.Entities;

public class CashRegisterCut : BaseEntity
{
    public Guid TenantId { get; set; }
    public Tenant Tenant { get; set; } = null!;

    public DateOnly CutDate { get; set; }
    public decimal OpeningAmount { get; set; }
    public decimal TotalSalesCash { get; set; }
    public decimal TotalSalesCard { get; set; }
    public decimal TotalSalesTransfer { get; set; }
    public decimal TotalSales => TotalSalesCash + TotalSalesCard + TotalSalesTransfer;
    public decimal TotalExpenses { get; set; }
    public decimal ClosingAmount { get; set; }
    public string? Notes { get; set; }
    public string? PdfReportUrl { get; set; }

    public bool IsClosed { get; set; } = false;
    public DateTime? ClosedAt { get; set; }
    public Guid? ClosedByEmployeeId { get; set; }
}
