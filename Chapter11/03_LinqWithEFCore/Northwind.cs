using Microsoft.EntityFrameworkCore; // DbContext, DbSet<T>

namespace Packt.Shared;

// управление соединением с базой данных
public class Northwind : DbContext
{
    // эти свойства сопоставляются с таблицами в базе данных
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Product>? Products { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //string path = Path.Combine(
        //Environment.CurrentDirectory, "Northwind.db");
        //optionsBuilder.UseSqlite($"Filename={path}");

        string connection = @"Data Source =.; 
                            Initial Catalog = Northwind; 
                            Integrated Security = true; 
                            Encrypt = true; 
                            TrustServerCertificate = true;
                            MultipleActiveResultSets=true";
        optionsBuilder.UseSqlServer(connection);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
        .Property(product => product.UnitPrice)
        .HasConversion<double>();
    }
}