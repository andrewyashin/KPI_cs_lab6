using System.Data.Entity;
using Lab6;

namespace SheduleContext
{
    public class PositionContext : DbContext
    {
        public PositionContext(): base("SheduleContext")
        {
        }

        public DbSet<Position> Position { get; set; }

    }
}