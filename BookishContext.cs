using Microsoft.EntityFrameworkCore;
using Bookish.Models;

namespace Bookish.Data
{
    public class BookishContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Checkout> Checkouts { get; set; }
        public DbSet<Copy> Copies { get; set; }
        public DbSet<Member> Members { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=BookishDB;Trusted_Connection=True;");
        }
    }
}