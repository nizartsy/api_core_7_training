using api_core_7_training.Model;
using Microsoft.EntityFrameworkCore;

namespace api_core_7_training.Data
{
    public class DataContext : DbContext
    {
        private const string connectionString = "Data Source=RAYANS-PC;Initial Catalog=SuperHeroEF;Integrated Security=True;TrustServerCertificate=True";
        public DataContext(DbContextOptions<DataContext> dbContextOptions):base(dbContextOptions)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<SuperHeros> SuperHeros { get; set; }
    }
}
