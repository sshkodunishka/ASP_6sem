using Microsoft.EntityFrameworkCore;

namespace Lab8.Context
{
    public class UserContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("data source=DESKTOP-UC30CLB\\SQLEXPRESS;initial catalog=ADO_8B;integrated security=True;MultipleActiveResultSets=True;");
            }
        }

        public UserContext()
        {
        }

        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }


    }
}
