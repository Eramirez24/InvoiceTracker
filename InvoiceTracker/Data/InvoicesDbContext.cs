using InvoiceTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace InvoiceTracker.Data
{
    public class InvoicesDbContext : DbContext
    {

        public InvoicesDbContext(DbContextOptions options): base (options)
        {
        }

        public DbSet<Invoices> Invoices { get; set; } = null!;
        public DbSet<Employee> Employee { get; set; } = null!;
    }
}
