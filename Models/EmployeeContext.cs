using System;
using Microsoft.EntityFrameworkCore;

namespace Asp.netCoreMvcCrud.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options):base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
