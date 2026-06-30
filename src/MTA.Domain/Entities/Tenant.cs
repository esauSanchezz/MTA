using MTA.Domain.Common;
using MTA.Domain.Enums;

namespace MTA.Domain.Entities;

public class Tenant : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Slug { get; set; } = string.Empty;
    public BusinessType BusinessType { get; set; }
    public string? LogoUrl { get; set; }
    public string? Phone { get; set; }
    public string? Address { get; set; }
    public string? Email { get; set; }
    public bool IsActive { get; set; } = true;

    public TimeOnly OpenTime { get; set; } = new TimeOnly(9, 0);
    public TimeOnly CloseTime { get; set; } = new TimeOnly(19, 0);

    public ICollection<Employee> Employees { get; set; } = [];
    public ICollection<Service> Services { get; set; } = [];
    public ICollection<Product> Products { get; set; } = [];
    public ICollection<Sale> Sales { get; set; } = [];
}
