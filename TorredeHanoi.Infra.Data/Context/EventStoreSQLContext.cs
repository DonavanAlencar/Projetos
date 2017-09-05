using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using TorredeHanoi.Infra.Data.Mappings;
using TorredeHanoi.Models;
using Microsoft.EntityFrameworkCore;
using TorredeHanoi.Infra.Data.Extensions;

namespace TorredeHanoi.Infra.Data.Context
{
    public class EventStoreSQLContext : DbContext
    {
        public DbSet<Log> Log { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new LogMap());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}
