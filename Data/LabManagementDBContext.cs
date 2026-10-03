using Microsoft.EntityFrameworkCore;
using LabManagement_api.Models;

namespace LabManagement_api.Data;

public class LabManagementDBContext : DbContext
{
    public LabManagementDBContext(DbContextOptions<LabManagementDBContext> options)
        : base(options)
    {
    }

    public DbSet<Employee> Employees { get; set; }
}