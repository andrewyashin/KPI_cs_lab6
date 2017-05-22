using System.Data.Entity;
using Lab6;

namespace SheduleContext
{
    public class EmployeeContext: DbContext
    {
        public EmployeeContext(): base("SheduleContext")
        {
        }

        public DbSet<Employee> Employee { get; set; }

    }
}