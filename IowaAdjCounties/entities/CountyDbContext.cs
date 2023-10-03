using Microsoft.EntityFrameworkCore;


namespace IowaAdjCounties.entities
{
    public class CountyDbContext : DbContext
    {
        public CountyDbContext(DbContextOptions<CountyDbContext> options)
           : base(options)
        {
        }

        public DbSet<County> Counties { get; set; }
        public DbSet<CountyAdjacency> CountyAdjacency { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure the database connection here
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
