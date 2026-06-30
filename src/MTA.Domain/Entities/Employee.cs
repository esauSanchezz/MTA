using MTA.Domain.Common;

namespace MTA.Domain.Entities;

public class Employee : BaseEntity
{
    public Guid TenantId { get; set; }
    public Tenant Tenant { get; set; } = null!;

    public Guid? UserId { get; set; }
    public AppUser? User { get; set; }

    public string FullName { get; set; } = string.Empty;
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public string Position { get; set; } = string.Empty;
    public decimal? CommissionRate { get; set; }
    public DateOnly HireDate { get; set; }
    public bool IsActive { get; set; } = true;

    public ICollection<WorkSchedule> WorkSchedules { get; set; } = [];
    public ICollection<ScheduleTask> Tasks { get; set; } = [];
}
