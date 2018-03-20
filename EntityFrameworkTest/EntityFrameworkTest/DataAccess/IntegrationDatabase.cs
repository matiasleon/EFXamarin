using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EntityFrameworkTest.Helpers;
using EntityFrameworkTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Xamarin.Forms;

namespace EntityFrameworkTest.DataAccess
{
    public class IntegrationDatabase : DbContext
    {
        public DbSet<Item> Items { get; set; }

        public DbSet<SubItem> SubItems { get; set; }

        public IntegrationDatabase()
        {
            this.Database.EnsureCreated();
            this.Database.MigrateAsync();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = DependencyService.Get<IDbPathDevice>().GetPath();

            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }
    }
}
