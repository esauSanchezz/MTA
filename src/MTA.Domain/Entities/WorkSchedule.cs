using MTA.Domain.Common;

namespace MTA.Domain.Entities;

public class WorkSchedule : BaseEntity
{
    public Guid EmployeeId { get; set; }
    public Employee Employee { get; set; } = null!;

    public DayOfWeek DayOfWeek { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public bool IsWorkDay { get; set; } = true;
}
