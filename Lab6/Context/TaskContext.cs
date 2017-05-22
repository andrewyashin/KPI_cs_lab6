using System.Data.Entity;
using Lab6;

namespace SheduleContext
{
    public class TaskContext: DbContext
    {
        public TaskContext(): base("SheduleContext")
        {
        }

        public DbSet<Task> Task { get; set; }
    }
}