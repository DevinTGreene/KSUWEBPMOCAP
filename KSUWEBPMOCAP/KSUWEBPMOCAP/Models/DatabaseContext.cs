using Microsoft.EntityFrameworkCore;

namespace KSUWEBPMOCAP.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<AdminAccount> AdminAccounts { get; set; }

        public DbSet<UserAccount> UserAccounts { get; set; }

        public DbSet<ViewerAccount> ViewerAccounts { get; set; }
        public DbSet<PMOAdminAccount> PMOAdminAccounts { get; set; }
    }
}
