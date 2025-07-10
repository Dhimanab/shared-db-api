using Microsoft.EntityFrameworkCore;

namespace SharedDbApi // ✅ matches your project name
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<DeploymentLog> DeploymentLogs { get; set; }
    }

    public class DeploymentLog
    {
        public int Id { get; set; }
        public string? Message { get; set; }  // 👈 Notice the ?
        public DateTime DeployedAt { get; set; }
    }
}