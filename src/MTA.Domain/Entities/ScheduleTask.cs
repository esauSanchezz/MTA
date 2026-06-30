using MTA.Domain.Common;
using MTA.Domain.Enums;

namespace MTA.Domain.Entities;

public class ScheduleTask : BaseEntity
{
    public Guid TenantId { get; set; }
    public Tenant Tenant { get; set; } = null!;

    public Guid EmployeeId { get; set; }
    public Employee Employee { get; set; } = null!;

    public TaskType Type { get; set; }
    public Enums.TaskStatus Status { get; set; } = Enums.TaskStatus.Scheduled;

    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string? Notes { get; set; }

    public string? ClientName { get; set; }
    public string? ClientPhone { get; set; }
    public string? ClientEmail { get; set; }
    public Guid? ServiceId { get; set; }
    public Service? Service { get; set; }

    public string? ActivityTitle { get; set; }
    public string? ActivityDescription { get; set; }

    public int DurationMinutes => (int)(EndTime - StartTime).TotalMinutes;

    public Guid? SaleId { get; set; }
    public Sale? Sale { get; set; }
}
