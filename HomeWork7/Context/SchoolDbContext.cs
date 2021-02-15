using System;
using System.Collections.Generic;
using System.Text;
using HomeWork7.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HomeWork7.Context
{
    public sealed class SchoolDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true);
            var connection = builder.Build().GetConnectionString("SchoolDbConnection");

            optionsBuilder.UseSqlServer(connection);
        }
    }
}
