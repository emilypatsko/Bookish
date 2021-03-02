using Microsoft.EntityFrameworkCore;
using Bookish.Models;

namespace Bookish.Data
{
    public class BookishContext : DbContext
    {
        public DbSet<BookModel> BookViews { get; set; }
        public DbSet<MemberModel> MemberViews { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;");
        }
    }
}