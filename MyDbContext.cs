using Microsoft.EntityFrameworkCore;

namespace QLSinhVienEF_New
{
    public class MyDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=.;Database=QLSinhVienDB;Trusted_Connection=True;TrustServerCertificate=True"
            );
        }
    }
}