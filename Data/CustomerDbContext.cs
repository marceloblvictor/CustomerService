using CustomerService.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerService.Data;

public class CustomerDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Database=CustomersDB;Username=postgres;Password=581Marce!");
}

