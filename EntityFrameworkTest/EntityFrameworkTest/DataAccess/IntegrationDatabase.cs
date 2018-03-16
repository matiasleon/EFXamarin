
using EntityFrameworkTest.Helpers;
using EntityFrameworkTest.Models;
using Microsoft.EntityFrameworkCore;
using Xamarin.Forms;

namespace EntityFrameworkTest.DataAccess
{
    public class IntegrationDatabase : DbContext
    {
        public DbSet<Item> Items { get; set; }

        public DbSet<SubItem> SubItems { get; set; }

        public IntegrationDatabase()
        {
            this.Database.MigrateAsync();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = DependencyService.Get<IDbPathDevice>().GetPath();

            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }
    }
}
