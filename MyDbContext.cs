namespace DoctorWhoEFCore;
using Microsoft.EntityFrameworkCore;

public class MyDbContext : DbContext
{
    public DbSet<MyEntity>MyEntities { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyDatabase;Trusted_Connection=True;");
        
    }
}