using LabManagement_api.Data;
using LabManagement_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace LabManagement_api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class Employee_ManagementController : ControllerBase
{
    private readonly LabManagementDBContext _context;

    public Employee_ManagementController(LabManagementDBContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetEmployee()
    {
        var employees = await _context.Employees
            .Select(e => new
            {
                e.EmployeeId,
                e.EmployeeCode,
                e.Name,
                e.Email,
                e.Department,
                e.IsActive,
                e.CreatedAt
            })
            .ToListAsync();

        return Ok(employees);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetEmployee(int id)
    {
        
        
        var employees = await _context.Employees
            .FirstOrDefaultAsync(e=>e.EmployeeId == id);
        
        
        return Ok(employees);
    }

    [HttpPost]
    public async Task<IActionResult> PostEmployee(Employee employee)
    {
        _context.Employees.Add(employee);

        await _context.SaveChangesAsync();

        return Ok(new
        {
            message = "Employee added successfully",
            employeeId = employee.EmployeeId
        });
    }

    
}