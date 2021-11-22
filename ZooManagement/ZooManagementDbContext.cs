using Microsoft.EntityFrameworkCore;


namespace ZooManagement
{
    public class ZooManagementDbContext : DbContext
    {
        public ZooManagementDbContext(DbContextOptions<ZooManagementDbContext> options) : base(options) {}
        
    }
}