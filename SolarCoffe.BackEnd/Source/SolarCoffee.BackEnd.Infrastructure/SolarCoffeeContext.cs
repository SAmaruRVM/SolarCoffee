namespace SolarCoffee.BackEnd.Infrastructure;

public class SolarCoffeeContext : IdentityDbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder
           .UseSqlite(@"Data Source=C:\Users\joaop\OneDrive\Ambiente de Trabalho\SolarCoffee.db")
           .LogTo(Console.WriteLine, new[] { DbLoggerCategory.Database.Command.Name }, LogLevel.Information)
           .EnableDetailedErrors()
           .EnableSensitiveDataLogging()
           .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Address> Addresses => Set<Address>();
}
