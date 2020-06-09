using EKnjiznica.Models;
using Microsoft.EntityFrameworkCore;

namespace EKnjiznica.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}