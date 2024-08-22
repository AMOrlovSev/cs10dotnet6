using Microsoft.EntityFrameworkCore; // DbContext, DbContextOptionsBuilder
using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Packt.Shared;
// позволяет управлять подключением к базе данных
public class Northwind : DbContext
{
    // эти свойства сопоставляются с таблицами в базе данных
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Product>? Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLazyLoadingProxies();

        if (ProjectConstants.DatabaseProvider == "SQLite")
        {
            string path = Path.Combine(Environment.CurrentDirectory, "Northwind.db");
            WriteLine($"Using {path} database file.");
            optionsBuilder.UseSqlite($"Filename={path}");
        }
        else
        {
            //пример из книги для C#10 .NET6, у меня не работает
            //string connection = "Data Source=.;" + 
            //"Initial Catalog=Northwind;" +
            //"Integrated Security=true;" +
            //"MultipleActiveResultSets=true;";
            //optionsBuilder.UseSqlServer(connection);

            string connection = "Data Source =.; Initial Catalog = Northwind; Integrated Security = true; Encrypt = true; TrustServerCertificate = true";
            optionsBuilder.UseSqlServer(connection);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // пример использования Fluent API вместо атрибутов,
        // чтобы ограничить длину имени категории 15 символами
        modelBuilder.Entity<Category>()
        .Property(category => category.CategoryName)
        .IsRequired() // NOT NULL
        .HasMaxLength(15);

        // глобальный фильтр для удаления снятых с производства товаров
        modelBuilder.Entity<Product>()
        .HasQueryFilter(p => !p.Discontinued);

        if (ProjectConstants.DatabaseProvider == "SQLite")
        {
            // добавлен патч для десятичной поддержки в SQLite
            modelBuilder.Entity<Product>()
            .Property(product => product.Cost)
            .HasConversion<double>();
        }
    }
}