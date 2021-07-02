using Microsoft.EntityFrameworkCore;
using RareBookApp.Domain;
using System;

namespace RareBookApp.Data
{
    public class RareBookAppContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<ConditionCodes> ConditionCodes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Volume> Inventory { get; set; }
        public DbSet<Work> Works { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=RareBookApp");
            }
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Volume>()
                            .HasMany(i => i.SaleTicket)
                            .WithOne();
        }
    }
}
