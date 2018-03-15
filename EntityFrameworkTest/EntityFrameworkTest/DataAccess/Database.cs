
using EntityFrameworkTest.Helpers;
using EntityFrameworkTest.Models;
using Microsoft.EntityFrameworkCore;
using Xamarin.Forms;

namespace EntityFrameworkTest.DataAccess
{
    public class Database : DbContext
    {
        public DbSet<Item> Items { get; set; }

        public DbSet<SubItem> SubItems { get; set; }

        public Database()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = DependencyService.Get<IDbPathDevice>().GetPath();

            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }
    }
}
