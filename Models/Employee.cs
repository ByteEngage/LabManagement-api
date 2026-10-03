namespace LabManagement_api.Models;

public class Employee
{
    public int EmployeeId { get; set; }

    public string EmployeeCode { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string? Department { get; set; }

    public bool IsActive { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public int CreatedBy { get; set; }
    public string PasswordHash { get; set; }=string.Empty;
}