using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Messageinfo> Messageinfo { get; set; }
        public DbSet<Smsgatewayinfo> Smsgatewayinfo { get; set; }
        public DbSet<Systeminfo> Systeminfo { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Event> Event { get; set; }
    }
}
