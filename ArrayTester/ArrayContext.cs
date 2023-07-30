
using Microsoft.EntityFrameworkCore;


namespace ArrayTester
{
    internal class ArrayContext : DbContext
    {

        public DbSet<WholeArray> Array { get; set; }
        public DbSet<PartialData> PortionData { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=TestArray;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
